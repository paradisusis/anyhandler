using System;
using Microsoft.Win32;

namespace AnyHandler
{
    public class RegistryModifier
    {
        /// <summary>
        /// Any handler dll path.
        /// </summary>
        string anyHandlerDllPath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AnyHandler.RegistryModifier"/> class.
        /// </summary>
        public RegistryModifier()
        {
            // Parameterless constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AnyHandler.RegistryModifier"/> class.
        /// </summary>
        /// <param name="anyHandlerDllPath">Any handler dll path.</param>
        public RegistryModifier(string anyHandlerDllPath)
        {
            // Set AnyHandler's DLL path
            this.anyHandlerDllPath = anyHandlerDllPath;
        }

        /// <summary>
        /// Adds any handler.
        /// </summary>
        public void AddAnyHandler()
        {
            // Check there's a DLL path to work with
            if (this.anyHandlerDllPath == string.Empty)
            {
                // Halt flow
                return;
            }

            // HKEY_CLASSES_ROOT\Directory\shellex\CopyHookHandlers\AnyHandlerHook
            RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"Directory\shellex\CopyHookHandlers\AnyHandlerHook");
            key.SetValue("", "{5F7BFEA1-B869-48DC-90A9-23EF4015857C}");
            key.Close();

            // HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Approved
            key = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Approved");
            key.SetValue("{5F7BFEA1-B869-48DC-90A9-23EF4015857C}", "AnyHandlerHook");
            key.Close();

            // HKEY_CLASSES_ROOT\AnyHandlerHook.AnyHandlerHook
            key = Registry.ClassesRoot.CreateSubKey(@"AnyHandlerHook.AnyHandlerHook");
            key.SetValue("", "AnyHandlerHook.AnyHandlerHook");
            key.Close();

            // HKEY_CLASSES_ROOT\AnyHandlerHook.AnyHandlerHook\CLSID
            key = Registry.ClassesRoot.CreateSubKey(@"AnyHandlerHook.AnyHandlerHook\CLSID");
            key.SetValue("", "{5F7BFEA1-B869-48DC-90A9-23EF4015857C}");
            key.Close();

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}
            key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}");
            key.SetValue("", "AnyHandlerHook.AnyHandlerHook");
            key.Close();

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\InprocServer32
            key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\InprocServer32");
            key.SetValue("", "mscoree.dll");
            key.SetValue("ThreadingModel", "Both");
            key.SetValue("Class", "AnyHandlerHook.AnyHandlerHook");
            key.SetValue("Assembly", "AnyHandlerHook, Version=0.1.0.24773, Culture=neutral, PublicKeyToken=null");
            key.SetValue("RuntimeVersion", "v4.0.30319");
            key.SetValue("CodeBase", $"file:///{this.anyHandlerDllPath}");
            key.Close();

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\InprocServer32\0.1.0.24773
            key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\InprocServer32\0.1.0.24773");
            key.SetValue("Class", "AnyHandlerHook.AnyHandlerHook");
            key.SetValue("Assembly", "AnyHandlerHook, Version=0.1.0.24773, Culture=neutral, PublicKeyToken=null");
            key.SetValue("RuntimeVersion", "v4.0.30319");
            key.SetValue("CodeBase", $"file:///{this.anyHandlerDllPath}");
            key.Close();

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\ProgId
            key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\ProgId");
            key.SetValue("", "AnyHandlerHook.AnyHandlerHook");
            key.Close();

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\Implemented Categories\{62C8FE65-4EBB-45E7-B440-6E39B2CDBF29}
            key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}\Implemented Categories\{62C8FE65-4EBB-45E7-B440-6E39B2CDBF29}");
            key.Close();
        }

        /// <summary>
        /// Removes any handler.
        /// </summary>
        public void RemoveAnyHandler()
        {
            // HKEY_CLASSES_ROOT\Directory\shellex\CopyHookHandlers\AnyHandlerHook
            Registry.ClassesRoot.DeleteSubKeyTree(@"Directory\shellex\CopyHookHandlers\AnyHandlerHook", false);

            // HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Approved\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}
            Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Approved", true).DeleteValue("{5F7BFEA1-B869-48DC-90A9-23EF4015857C}", false);

            // HKEY_CLASSES_ROOT\AnyHandlerHook.AnyHandlerHook
            Registry.ClassesRoot.DeleteSubKeyTree(@"AnyHandlerHook.AnyHandlerHook", false);

            // HKEY_CLASSES_ROOT\CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}
            Registry.ClassesRoot.DeleteSubKeyTree(@"CLSID\{5F7BFEA1-B869-48DC-90A9-23EF4015857C}", false);
        }
    }
}
