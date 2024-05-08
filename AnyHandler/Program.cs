
using System;
using System.Linq;
using System.Windows.Forms;

namespace AnyHandler
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Check for space
            if (Application.StartupPath.Contains(" "))
            {
                // Set "s" in spaces
                string s = Application.StartupPath.Count(c => c == ' ') > 1 ? "s" : string.Empty;

                // Advise user
                MessageBox.Show($"The current directory path contains space{s}.{Environment.NewLine}{Environment.NewLine}Please use a path without space{s}.{Environment.NewLine}Example: C:\\AnyHandler", $"Path with space{s}", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // Halt flow  / exit the application
                return;
            }

            // Start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
