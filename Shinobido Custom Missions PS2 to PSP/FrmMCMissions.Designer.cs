
namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    partial class FrmMCMissions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridMC = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMC
            // 
            this.dataGridMC.AllowUserToAddRows = false;
            this.dataGridMC.AllowUserToDeleteRows = false;
            this.dataGridMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Order,
            this.Name2,
            this.Type,
            this.Description});
            this.dataGridMC.Location = new System.Drawing.Point(11, 0);
            this.dataGridMC.Name = "dataGridMC";
            this.dataGridMC.RowHeadersVisible = false;
            this.dataGridMC.RowHeadersWidth = 72;
            this.dataGridMC.RowTemplate.Height = 31;
            this.dataGridMC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMC.Size = new System.Drawing.Size(1039, 553);
            this.dataGridMC.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(833, 559);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 58);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(945, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Selected
            // 
            this.Selected.FillWeight = 50F;
            this.Selected.Frozen = true;
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 9;
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 33;
            // 
            // Order
            // 
            this.Order.Frozen = true;
            this.Order.HeaderText = "Order";
            this.Order.MinimumWidth = 9;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 103;
            // 
            // Name2
            // 
            this.Name2.Frozen = true;
            this.Name2.HeaderText = "Name";
            this.Name2.MinimumWidth = 9;
            this.Name2.Name = "Name2";
            this.Name2.ReadOnly = true;
            this.Name2.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 9;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Description
            // 
            this.Description.FillWeight = 500F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 500;
            // 
            // FrmMCMissions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1059, 629);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridMC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMCMissions";
            this.Text = "Select MC Mission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}