using Properties;
using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            
            AddTypeName("Assassination");
            AddTypeName("Total Destruction");
            AddTypeName("Duel");
            AddTypeName("Guard");
            AddTypeName("Assault");
            AddTypeName("Escort");
            AddTypeName("Transport");
            AddTypeName("Robbery");
            AddTypeName("Theft");
            AddTypeName("Kidnapping");
            AddTypeName("Rescue");
            AddTypeName("Collection");
            AddTypeName("Travel");

            foreach (Control c in this.Controls)
            {
                if (!(c is null))
                {
                    if (!(c.Tag is null) && (string)c.Tag != "")
                    {

                        c.Text = (string)Properties.Settings.Default[(string)c.Tag];
                    }
                }
            }

            foreach (TypeNames c in flowPanTypes.Controls)
            {
                if (!(c is null))
                {
                    if (!(c.Tag is null) && (string)c.Tag != "")
                    {
                        c.Text = (string)Properties.Settings.Default[(string)c.Tag];
                    }
                }
            }

        }

        private void FrmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (!(c is null))
                {
                    if (!(c.Tag is null) && (string)c.Tag != "")
                    {
                        Properties.Settings.Default[(string)c.Tag] = c.Text;
                    }
                }
            }

            foreach (TypeNames c in flowPanTypes.Controls)
            {
                if (!(c is null))
                {
                    if (!(c.Tag is null) && (string)c.Tag != "")
                    {
                        Properties.Settings.Default[(string)c.Tag] = c.Text;
                    }
                }
            }
            Properties.Settings.Default.Save();
        }

        private void AddTypeName(string name)
        {
            TypeNames typeNames = new TypeNames();
            typeNames.LoadTypeName(name);
            flowPanTypes.Controls.Add(typeNames);
        }

        private void btnPathPS2_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.RootFolder = PS2MCPath.Text;
            folderBrowserDialog.Title = "Select the Memory Card PCSX2 Folder (Folder type only)";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PS2MCPath.Text = folderBrowserDialog.SelectedFolder;
            }
        }

        private void btnPathPSP_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.RootFolder = PSPMSPath.Text;
            folderBrowserDialog.Title = "Select the Memory Stick PPSSPP Folder (EncryptSave = False settings only)";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PSPMSPath.Text = folderBrowserDialog.SelectedFolder;
            }
        }
    }
}
