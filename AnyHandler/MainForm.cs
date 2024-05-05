

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
            if (!this.AnyHandlerHookDllExists())
            {
                // Advise user
                MessageBox.Show($"AnyHandlerHook.dll is not present.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Halt flow
                return;
            }

            /* Add to registry */

            try
            {
                // Set new registry modifier
                RegistryModifier registryModifier = new RegistryModifier(this.anyHandlerHookDllPath);

                // Add it
                registryModifier.AddAnyHandler();

                // Advise user
                MessageBox.Show($"AnyHandler has been added to Windows Explorer!{Environment.NewLine}Changes will be picked on next restart.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the remove button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            /* Remove from registry */

            try
            {
                // Set new registry modifier
                RegistryModifier registryModifier = new RegistryModifier();

                // Remove it
                registryModifier.RemoveAnyHandler();

                // Advise user
                MessageBox.Show($"AnyHandler has been removed from Windows Explorer!{Environment.NewLine}Changes will be picked on next restart.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if AnyHandlerHook.dll exists within current folder.
        /// </summary>
        /// <returns><c>true</c> if AnyHandlerHook.dll exists, <c>false</c> otherwise.</returns>
        private bool AnyHandlerHookDllExists()
        {
            // Check if AnyHandlerHook.dll exists and return 
            return File.Exists(this.anyHandlerHookDllPath);
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