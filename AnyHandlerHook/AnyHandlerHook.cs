/**
 * C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe AnyHandlerHook.dll /codebase /regfile:AnyHandlerHook.reg
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ParadisusIs;

namespace AnyHandlerHook
{
    [Guid("5f7bfea1-b869-48dc-90a9-23ef4015857c"), ComVisible(true)]
    public class AnyHandlerHook : ICopyHook
    {
        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "AnyHandler-SettingsData.txt");

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AnyHandlerHook.AnyHandlerHook"/> class.
        /// </summary>
        public AnyHandlerHook() { }

        /// <summary>
        /// Copies the callback.
        /// </summary>
        /// <returns>The callback.</returns>
        /// <param name="hwnd">Hwnd.</param>
        /// <param name="wFunc">W func.</param>
        /// <param name="wFlags">W flags.</param>
        /// <param name="pszSrcFile">Psz source file.</param>
        /// <param name="dwSrcAttribs">Dw source attribs.</param>
        /// <param name="pszDestFile">Psz destination file.</param>
        /// <param name="dwDestAttribs">Dw destination attribs.</param>
        public uint CopyCallback(IntPtr hwnd,
        uint wFunc,
        uint wFlags,
        [MarshalAs(UnmanagedType.LPWStr)] string pszSrcFile,
        uint dwSrcAttribs,
        [MarshalAs(UnmanagedType.LPWStr)] string pszDestFile,
        uint dwDestAttribs)
        {
            // TODO Declare variables [Can streamline]
            string operation = string.Empty;
            string message = string.Empty;
            string programPath = string.Empty;
            string programArguments = string.Empty;
            bool programHide = false;
            bool writeErrorLog = true; // Toggle if must skip

            try
            {
                // Check for settings data
                if (!File.Exists(this.settingsDataPath))
                {
                    // Advise & halt flow
                    throw new Exception($"{this.settingsDataPath} does not exist.");
                }

                // Set settings data
                var settingsData = new SettingsData(this.settingsDataPath, false);

                // Switch by operation
                switch (wFunc)
                {
                    // Copy
                    case (uint)CopyHookOperation.FO_COPY:

                        operation = "Copy";
                        message = $"Source: {pszSrcFile}{Environment.NewLine}Destination: {pszDestFile}";
                        programPath = settingsData.CopyProgramPath;
                        programArguments = settingsData.CopyProgramArguments;
                        programHide = settingsData.CopyProgramHide;

                        break;

                    // Delete
                    case (uint)CopyHookOperation.FO_DELETE:

                        operation = "Delete";
                        message = $"Source: {pszSrcFile}";
                        programPath = settingsData.DeleteProgramPath;
                        programArguments = settingsData.DeleteProgramArguments;
                        programHide = settingsData.DeleteProgramHide;

                        break;

                    // Move
                    case (uint)CopyHookOperation.FO_MOVE:

                        operation = "Move";
                        message = $"Source: {pszSrcFile}{Environment.NewLine}Destination: {pszDestFile}";
                        programPath = settingsData.MoveProgramPath;
                        programArguments = settingsData.MoveProgramArguments;
                        programHide = settingsData.MoveProgramHide;

                        break;

                    // Rename
                    case (uint)CopyHookOperation.FO_RENAME:

                        operation = "Rename";
                        message = $"Source: {pszSrcFile}{Environment.NewLine}Destination: {pszDestFile}";
                        programPath = settingsData.RenameProgramPath;
                        programArguments = settingsData.RenameProgramArguments;
                        programHide = settingsData.RenameProgramHide;

                        break;
                }

                // Check for a program in path
                if (programPath.Length == 0)
                {
                    // Not handled, skip logging the error
                    writeErrorLog = false;

                    // Halt flow & advise
                    throw new Exception("No program path.");
                }

                // Check for a valid program in path
                if (!File.Exists(programPath))
                {
                    // Halt flow & advise
                    throw new Exception("Invalid program path.");
                }

                // Run the program with arguments
                using (var process = new Process())
                {
                    // Set file name to program path
                    process.StartInfo.FileName = programPath;

                    // Check for arguments
                    if (programArguments.Length > 0)
                    {
                        // Replace source
                        programArguments = programArguments.Replace("{src}", pszSrcFile);

                        // Replace destination
                        programArguments = programArguments.Replace("{dst}", pszDestFile);

                        // Set arguments
                        process.StartInfo.Arguments = programArguments;
                    }

                    // Check hide flag
                    if (programHide)
                    {
                        // Hide the program window
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    }


                    // Start the process
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                // Check if must write error to file
                if (writeErrorLog)
                {
                    // TODO Log error to file [Use variable for DLL location, consider  expanding wFunc to operation]
                    File.AppendAllText(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "AnyHandler-ErrorLog.txt"), $"{Environment.NewLine}{Environment.NewLine}{DateTime.Now.ToString()}: {ex.Message}{Environment.NewLine}Operation: {(operation.Length > 0 ? operation : wFunc.ToString())}{Environment.NewLine}Source: {pszSrcFile}{Environment.NewLine}Destination: {pszDestFile}");
                }
            }

            // Return positive on no program path OR negative to suppress Windows Explorer's dialog
            return programPath.Length > 0 ? (uint)CopyHookResult.IDNO : (uint)CopyHookResult.IDYES;
        }

        /// <summary>
        /// Copy hook result.
        /// </summary>
        private enum CopyHookResult : uint
        {
            IDCANCEL = 2,
            IDYES = 6,
            IDNO = 7
        }

        /// <summary>
        /// Copy hook operation.
        /// </summary>
        private enum CopyHookOperation : uint
        {
            FO_MOVE = 1,
            FO_COPY = 2,
            FO_DELETE = 3,
            FO_RENAME = 4
        }
    }
}