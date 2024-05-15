// <copyright file="MainForm.cs" company="Paradisus.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace AnyHandler
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using Microsoft.Win32;
    using ParadisusIs;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Any handler hook dll path.
        /// </summary>
        private string anyHandlerHookDllPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AnyHandlerHook.dll");

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = "AnyHandler-SettingsData.txt";

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AnyHandler.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon 
            this.associatedIcon = this.Icon;

            /* Settings data */

            // Set settings data
            this.settingsData = new SettingsData(this.settingsDataPath, !File.Exists(this.settingsDataPath));
        }

        /// <summary>
        /// Handles the add button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddButtonClick(object sender, EventArgs e)
        {
            // Check if AnyHandlerHook.dll exists 
            if (!this.IsDllPresent())
            {
                // Advise user
                MessageBox.Show($"AnyHandlerHook.dll is not present.{Environment.NewLine}{Environment.NewLine}Please copy it and try again.", "Missing dll", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Halt flow and update status
                goto ExitFunction;
            }

            /* Add to registry */

            try
            {
                // Set new registry modifier
                RegistryModifier registryModifier = new RegistryModifier(this.anyHandlerHookDllPath);

                // Add it
                registryModifier.AddAnyHandler();

                // Advise user
                MessageBox.Show($"AnyHandler has been added to Windows Explorer!{Environment.NewLine}{Environment.NewLine}Changes will be picked on next restart.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        ExitFunction:

            // Update the status
            this.UpdateStatus(false);
        }

        /// <summary>
        /// Handles the remove button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            // Check if CLSID exists 
            if (!this.IsActive())
            {
                // Advise user
                MessageBox.Show($"AnyHandler is not active hence no need to remove it.", "Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow and update status
                goto ExitFunction;
            }

            /* Remove from registry */

            try
            {
                // Set new registry modifier
                RegistryModifier registryModifier = new RegistryModifier();

                // Remove it
                registryModifier.RemoveAnyHandler();

                // Advise user
                MessageBox.Show($"AnyHandler has been removed from Windows Explorer!{Environment.NewLine}{Environment.NewLine}Changes will be picked on next restart.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        ExitFunction:

            // Update the status
            this.UpdateStatus(false);
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="checkDll">If set to <c>true</c> check dll.</param>
        private void UpdateStatus(bool checkDll)
        {
            // Registry
            this.statusValueToolStripStatusLabel.Text = this.IsActive() ? "Active" : "Inactive";

            // Dll
            if (checkDll)
            {
                this.dllValueToolStripStatusLabel.Text = this.IsDllPresent() ? "Present" : "Missing";
            }
        }

        /// <summary>
        /// Checks if AnyHandlerHook.dll exists within current folder.
        /// </summary>
        /// <returns><c>true</c> 
        /// if AnyHandlerHook.dll exists, <c>false</c> otherwise.</returns>
        private bool IsDllPresent()
        {
            // Check if AnyHandlerHook.dll exists and return 
            return File.Exists(this.anyHandlerHookDllPath);
        }

        /// <summary>
        /// Checks if the registry key exists.
        /// </summary>
        /// <returns><c>true</c>, if the registry key exists, <c>false</c> otherwise.</returns>
        /// <param name="baseKey">Base key.</param>
        /// <param name="subKeyName">Sub key name.</param>
        private bool KeyExists(RegistryKey baseKey, string subKeyName)
        {
            // St the registry key
            RegistryKey registryKey = baseKey.OpenSubKey(subKeyName);

            // Return true if not null
            return registryKey != null;
        }

        /// <summary>
        /// Check if AnyHandler is active.
        /// </summary>
        /// <returns><c>true</c>, if AnyHandler is active, <c>false</c> otherwise.</returns>
        private bool IsActive()
        {
            // The variable to return
            bool keyExists = false;

            try
            {
                // Set result
                keyExists = KeyExists(Registry.ClassesRoot, @"Directory\shellex\CopyHookHandlers\AnyHandlerHook");
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the result
            return keyExists;
        }

        /// <summary>
        /// Handles the copy browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.copyProgramTextBox.Text = this.openFileDialog.FileName;

                // Check for no arguments
                if (this.copyArgumentsTextBox.Text.Length == 0)
                {
                    // Add {src} and {dst}
                    this.copyArgumentsTextBox.Text = $"{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}{{src}}{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)} {(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}{{dst}}{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}";
                }
            }
        }

        /// <summary>
        /// Handles the delete browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeleteBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.deleteProgramTextBox.Text = this.openFileDialog.FileName;

                // Check for no arguments
                if (this.deleteArgumentsTextBox.Text.Length == 0)
                {
                    // Add {dir}
                    this.deleteArgumentsTextBox.Text = $"{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}{{src}}{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}";
                }
            }
        }

        /// <summary>
        /// Handles the move browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoveBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.moveProgramTextBox.Text = this.openFileDialog.FileName;

                // Check for no arguments
                if (this.moveArgumentsTextBox.Text.Length == 0)
                {
                    // Add {dir}
                    this.moveArgumentsTextBox.Text = $"{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}{{dir}}{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}";
                }
            }
        }

        /// <summary>
        /// Handles the rename browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRenameBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.renameProgramTextBox.Text = this.openFileDialog.FileName;

                // Check for no arguments
                if (this.renameArgumentsTextBox.Text.Length == 0)
                {
                    // Add {dir}
                    this.renameArgumentsTextBox.Text = $"{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}{{dir}}{(this.addquotesToolStripMenuItem.Checked ? "\"" : string.Empty)}";
                }
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Temp vars
            bool alwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;
            bool addQuotes = this.addquotesToolStripMenuItem.Checked;

            /* Settings */

            // Remove settings data file
            File.Delete(this.settingsDataPath);

            // Set settings data
            this.settingsData = new SettingsData(this.settingsDataPath, true);

            /* GUI */

            // Patch by temp vars
            this.settingsData.AlwaysOnTop = alwaysOnTop;
            this.settingsData.AddQuotes = addQuotes;

            // Set GUI as per the reset settings
            this.SetGuiSettings();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the more releases paradisusis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoreReleasesParadisusisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site's releases portal
            Process.Start("https://paradisus.is/releases/");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=54149.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/paradisusis/anyhandler");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Flat icon set by helloabt_com - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/flat-icon-icon-set-graphics-box-967062/{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}";
            ;

            // Prepend sponsors
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler (mouser){Environment.NewLine}* ibay770{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: {Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #135, Week #20 @ May 14, 2024",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Set the loaded settings onto the GUI
            this.SetGuiSettings();

            // Update the status
            this.UpdateStatus(true);
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Save current settings as per the GUI
            this.SaveGuiSettings();
        }

        /// <summary>
        /// Sets the GUI settings.
        /// </summary>
        private void SetGuiSettings()
        {
            // Always on top
            this.alwaysOnTopToolStripMenuItem.Checked = this.settingsData.AlwaysOnTop;
            this.TopMost = this.settingsData.AlwaysOnTop;

            // Add quotes
            this.addquotesToolStripMenuItem.Checked = this.settingsData.AddQuotes;

            // Operations' path and arguments
            this.copyProgramTextBox.Text = this.settingsData.CopyProgramPath;
            this.copyArgumentsTextBox.Text = this.settingsData.CopyProgramArguments;
            this.moveProgramTextBox.Text = this.settingsData.MoveProgramPath;
            this.moveArgumentsTextBox.Text = this.settingsData.MoveProgramArguments;
            this.deleteProgramTextBox.Text = this.settingsData.DeleteProgramPath;
            this.deleteArgumentsTextBox.Text = this.settingsData.DeleteProgramArguments;
            this.renameProgramTextBox.Text = this.settingsData.RenameProgramPath;
            this.renameArgumentsTextBox.Text = this.settingsData.RenameProgramArguments;
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        private void SaveGuiSettings()
        {
            // Always on top
            this.settingsData.AlwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;

            // Add quotes
            this.settingsData.AddQuotes = this.addquotesToolStripMenuItem.Checked;

            // Operations' path and arguments
            this.settingsData.CopyProgramPath = this.copyProgramTextBox.Text;
            this.settingsData.CopyProgramArguments = this.copyArgumentsTextBox.Text;
            this.settingsData.MoveProgramPath = this.moveProgramTextBox.Text;
            this.settingsData.MoveProgramArguments = this.moveArgumentsTextBox.Text;
            this.settingsData.DeleteProgramPath = this.deleteProgramTextBox.Text;
            this.settingsData.DeleteProgramArguments = this.deleteArgumentsTextBox.Text;
            this.settingsData.RenameProgramPath = this.renameProgramTextBox.Text;
            this.settingsData.RenameProgramArguments = this.renameArgumentsTextBox.Text;


            // Save settings data to disk
            this.settingsData.SaveSettingsFile();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}