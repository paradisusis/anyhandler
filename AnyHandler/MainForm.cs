

namespace AnyHandler
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Microsoft.Win32;

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
        /// Initializes a new instance of the <see cref="T:AnyHandler.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
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

        }

        /// <summary>
        /// Handles the delete browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeleteBrowseButtonClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the move browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoveBrowseButtonClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the rename browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRenameBrowseButtonClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the more releases paradisusis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoreReleasesParadisusisToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Update the status
            this.UpdateStatus(true);

            // Check for space
            if (this.anyHandlerHookDllPath.Contains(" "))
            {
                // Advise user
                MessageBox.Show($"The current directory path contains spaces.{Environment.NewLine}{Environment.NewLine}Please use a path without spaces.{Environment.NewLine}Example: C:\\AnyHandler", "Path with spaces", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {

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