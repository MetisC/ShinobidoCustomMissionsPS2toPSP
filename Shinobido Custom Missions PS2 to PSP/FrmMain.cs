using Shinobido_Custom_Missions_PS2_to_PSP.UserControls;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // PS2MCPath
            SaveSettingsPath("PS2MCPath", "Select the Memory Card PCSX2 Folder (Folder type only)");
            if (Properties.Settings.Default["PS2MCPath"].ToString() == "") Application.Exit();

            // PSPMSPath 
            SaveSettingsPath("PSPMSPath", "Select the Memory Stick PPSSPP Folder (EncryptSave = False settings only)");
            if (Properties.Settings.Default["PSPMSPath"].ToString() == "") Application.Exit();

            LoadPanelPSPMissions();

        }

        private void SaveSettingsPath(string settingName, string description)
        {
            if (Properties.Settings.Default[settingName].ToString() == "")
            {
                folderBrowserDialog.Title = description;
                if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

            if (folderBrowserDialog.SelectedPath != "") Properties.Settings.Default[settingName] = folderBrowserDialog.SelectedPath;

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

        public void LoadPanelPSPMissions()
        {

            flowPanMissions.Controls.Clear();

            List<Mission> missionList = new List<Mission>();

            Mission missionsPsp = new Mission();
            missionList = missionsPsp.LoadPSPMissions();

            foreach (Mission mission in missionList)
            {
                AddPSPMission(mission);
            }
        }
        
        public void AddPSPMission(Mission mission)
        {
            MissionControl missionControl = new MissionControl();

            missionControl.Order(mission.MissionOrder.ToString());
            missionControl.LoadImage(mission.MissionIcon);
            missionControl.Title(mission.MissionTitle);
            missionControl.Type(mission.MissionType);
            missionControl.Description(mission.MissionDescription);

            flowPanMissions.Controls.Add(missionControl);

        }

        private void toolStripButtonAdd_Click(object sender, System.EventArgs e)
        {
            FrmMCMissions frmMCMissions = new FrmMCMissions(this);
            frmMCMissions.ShowDialog();
        }

        private void toolStripButtonPSP_Click(object sender, System.EventArgs e)
        {
            OpenFolder(Properties.Settings.Default.PSPMSPath);
        }

        private void toolStripButtonPS2_Click(object sender, System.EventArgs e)
        {
            OpenFolder(Properties.Settings.Default.PS2MCPath);
        }

        private void OpenFolder(string folderPath)
            {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
