using System.Drawing;
using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP.UserControls
{
    public partial class MissionControl : UserControl
    {
        public MissionControl()
        {
            InitializeComponent();
            Encrypted = false;
        }

        public bool Encrypted { get; set; }

        public void LoadImage(Image image)
        {
            imgSaveIcon.Image = image;
        }

        public void Title(string title)
        {
            if (title.Contains("³") || title.Contains("¬") || title.Contains("·") || title.Contains("¤") 
                || title.Contains("§") || title.Contains("«") || title.Contains("~") || title.Contains("½")
                || title.Contains("¼") || title.Contains("ß") || title.Contains("Æ") || title.Contains("Ø")
                || title.Contains("©") || title.Contains("±") || title.Contains("¢") || title.Contains("²")
                || title.Contains("°")
            )
            {
                lblTitle.Text = "MISSION ENCRYPTED";
                lblTitle.ForeColor = Color.Red;
                Encrypted = true;
            }
            else
            {
                lblTitle.Text = title;
            }
        }

        public void Type(string type)
        {
            if (Encrypted)
            {
                lblType.Text = "";
            }
            else
            {
                lblType.Text = type;
            }
        }

        public void Order(string order)
        {
            lblOrder.Text = order;
        }

        public void Description (string description)
        {
            if (Encrypted)
            {
                lblDescription.Text = "Disable EncryptSaves and save the mission again";
                lblDescription.ForeColor = Color.Red;
            }
            else
            {
                lblDescription.Text = description;
            }
        }

    }
}
