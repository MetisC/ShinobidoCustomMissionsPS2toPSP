using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public partial class FrmMCMissions : Form
    {
        private readonly FrmMain frmMain;
        public FrmMCMissions(FrmMain parentForm)
        {
            InitializeComponent();

            frmMain = parentForm;

            List<Mission> missionList = new List<Mission>();

            Mission missionsPS2 = new Mission();
            missionList = missionsPS2.LoadPS2Missions();

            dataGridMC.Rows.Clear();

            foreach (Mission mission in missionList)
            {
                dataGridMC.Rows.Add(0, mission.MissionOrder, mission.MissionTitle, mission.MissionType, mission.MissionDescription);
            }

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            List<Mission> missionList = new List<Mission>();

            Mission missionsPSP = new Mission();
            missionList = missionsPSP.LoadPSPMissions();

            int lastOrder = -1;
            foreach (Mission mission in missionList)
            {
                if (mission.MissionOrder > lastOrder)
                {
                    lastOrder = mission.MissionOrder;
                }
            }

            int missionsCreated = 0;

            foreach (DataGridViewRow row in dataGridMC.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    lastOrder += 1;

                    string orderSave = lastOrder.ToString();
                    if (orderSave.Length < 2)
                    {
                        orderSave = "0" + orderSave;
                    }

                    DirectoryCopy(".\\PSPSAVEBASE\\UCES00421MissionSave00", Properties.Settings.Default.PSPMSPath + "\\UCES00421MissionSave" + orderSave);

                    string savePs2 = row.Cells[1].Value.ToString();
                    if (savePs2.Length < 2) savePs2 = "0" + savePs2;
                    if (savePs2.Length < 3) savePs2 = "0" + savePs2;

                    File.Copy(Properties.Settings.Default.PS2MCPath + "\\BESCES-53931CT" + savePs2 + "\\BESCES-53931CT" + savePs2, Properties.Settings.Default.PSPMSPath + "\\UCES00421MissionSave" + orderSave + "\\HOMURA.BIN",true);

                    missionsCreated += 1;

                }
            }

            if (missionsCreated > 0)
            {
                MessageBox.Show(this, "Done. Enter the game and copy or save the mission to update the save info file", "Mission Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "No missions selected", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmMain.LoadPanelPSPMissions();
            this.Close();

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = false)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }

        }
    }
}
