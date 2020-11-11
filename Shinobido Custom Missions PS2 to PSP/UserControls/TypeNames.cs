using System.Windows.Forms;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public partial class TypeNames : UserControl
    {
        public TypeNames()
        {
            InitializeComponent();
        }

        public void LoadTypeName(string name)
        {
            label.Text = name;
            this.Tag = "Type" + name.Replace(" ", "");
        }

        /// <summary>
        /// Text Control
        /// </summary>
        public new string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }

    }
}
