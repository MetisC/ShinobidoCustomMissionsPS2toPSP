using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //Properties.Settings.Default.Reload();
            // PS2MCPath
            SaveSettingsPath("PS2MCPath", "Select the Memory Card PCSX2 Folder (Folder type only)");
            if (Properties.Settings.Default["PS2MCPath"].ToString() == "") Application.Exit();

            // PSPMSPath
            SaveSettingsPath("PSPMSPath", "Select the Memory Stick PPSSPP Folder (EncryptSave = False settings only)");
            if (Properties.Settings.Default["PSPMSPath"].ToString() == "") Application.Exit();

        }

        private void SaveSettingsPath(string settingName, string description)
        {
            if (Properties.Settings.Default[settingName].ToString() == "")
            {
                folderBrowserDialog.Title = description;
                //folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

            if (folderBrowserDialog.SelectedPath != "") Properties.Settings.Default[settingName] = folderBrowserDialog.SelectedPath;

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void toolStripButtonSettings_Click(object sender, System.EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }

        private void toolStripButtonExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
