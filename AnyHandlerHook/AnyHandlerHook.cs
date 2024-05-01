/**
 * C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe AnyHandlerHook.dll /codebase /regfile:AnyHandlerHook.reg
 */

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnyHandlerHook
{
    [Guid("5f7bfea1-b869-48dc-90a9-23ef4015857c"), ComVisible(true)]
    public class AnyHandlerHook : ICopyHook
    {
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
            //#
            MessageBox.Show($"This: {pszSrcFile}{Environment.NewLine}To: {pszDestFile}", $"{ wFunc }");

            return (uint)CopyHookResult.IDNO;
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