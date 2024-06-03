using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ParadisusIs
{
    /// <summary>
    /// Settings data.
    /// </summary>
    public class SettingsData
    {
        /// <summary>
        /// Gets or sets the settings data path.
        /// </summary>
        /// <value>The settings data path.</value>
        public string SettingsDataPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> always on top.
        /// </summary>
        /// <value><c>true</c> if always on top; otherwise, <c>false</c>.</value>
        public bool AlwaysOnTop { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> add quotes.
        /// </summary>
        /// <value><c>true</c> if add quotes; otherwise, <c>false</c>.</value>
        public bool AddQuotes { get; set; } = true;

        /// <summary>
        /// Gets or sets the copy program path.
        /// </summary>
        /// <value>The copy program path.</value>
        public string CopyProgramPath { get; set; }

        /// <summary>
        /// Gets or sets the copy program arguments.
        /// </summary>
        /// <value>The copy program arguments.</value>
        public string CopyProgramArguments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> copy program hide.
        /// </summary>
        /// <value><c>true</c> if copy program hide; otherwise, <c>false</c>.</value>
        public bool CopyProgramHide { get; set; } = false;

        /// <summary>
        /// Gets or sets the move program path.
        /// </summary>
        /// <value>The move program path.</value>
        public string MoveProgramPath { get; set; }

        /// <summary>
        /// Gets or sets the move program arguments.
        /// </summary>
        /// <value>The move program arguments.</value>
        public string MoveProgramArguments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> move program hide.
        /// </summary>
        /// <value><c>true</c> if move program hide; otherwise, <c>false</c>.</value>
        public bool MoveProgramHide { get; set; } = false;

        /// <summary>
        /// Gets or sets the delete program path.
        /// </summary>
        /// <value>The delete program path.</value>
        public string DeleteProgramPath { get; set; }

        /// <summary>
        /// Gets or sets the delete program arguments.
        /// </summary>
        /// <value>The delete program arguments.</value>
        public string DeleteProgramArguments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> delete program hide.
        /// </summary>
        /// <value><c>true</c> if delete program hide; otherwise, <c>false</c>.</value>
        public bool DeleteProgramHide { get; set; } = false;

        /// <summary>
        /// Gets or sets the rename program path.
        /// </summary>
        /// <value>The rename program path.</value>
        public string RenameProgramPath { get; set; }

        /// <summary>
        /// Gets or sets the rename program arguments.
        /// </summary>
        /// <value>The rename program arguments.</value>
        public string RenameProgramArguments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ParadisusIs.SettingsData"/> rename program hide.
        /// </summary>
        /// <value><c>true</c> if rename program hide; otherwise, <c>false</c>.</value>
        public bool RenameProgramHide { get; set; } = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PublicDomain.SettingsData"/> class.
        /// </summary>
        public SettingsData()
        {
            // Parameterless constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PublicDomain.SettingsData"/> class.
        /// </summary>
        /// <param name="settingsDataPath">Settings data path.</param>
        /// <param name="newFile">If set to <c>true</c> new file.</param>
        public SettingsData(string settingsDataPath, bool newFile)
        {
            // Set settings data path
            this.SettingsDataPath = settingsDataPath;

            // New settings file
            if (newFile || !File.Exists(this.SettingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile();
            }

            /* Set all properties */

            // TODO Check new file flag [Constructor flow can be improved]
            if (newFile)
            {
                // Halt flow
                return;
            }

            // Load from file
            SettingsData settingsData = LoadSettingsFile();

            // Iterate writable properties
            foreach (PropertyInfo property in typeof(SettingsData).GetProperties().Where(p => p.CanWrite))
            {
                // Populate
                property.SetValue(this, property.GetValue(settingsData, null), null);
            }
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        public SettingsData LoadSettingsFile()
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(this.SettingsDataPath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        public void SaveSettingsFile()
        {
            try
            {
                // Check there's a settings data path to work with
                if (this.SettingsDataPath == string.Empty)
                {
                    // Halt flow and advise
                    throw new Exception("Empty settings data path.");
                }

                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(this.SettingsDataPath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, this);
                }
            }
            catch (Exception exception)
            {
                // TODO Advise user [Can log to file to keep silent]
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}