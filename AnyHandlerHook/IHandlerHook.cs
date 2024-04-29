using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace AnyHandlerHook
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("000214FC-0000-0000-C000-000000000046")]
    public interface ICopyHook
    {
        [PreserveSig()]
        uint CopyCallback(IntPtr hwnd,
        uint wFunc,
        uint wFlags,
        [MarshalAs(UnmanagedType.LPWStr)] string pszSrcFile,
        uint dwSrcAttribs,
        [MarshalAs(UnmanagedType.LPWStr)] string pszDestFile,
        uint dwDestAttribs);
    }
}

