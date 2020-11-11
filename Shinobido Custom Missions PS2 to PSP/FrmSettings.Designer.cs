namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.PS2MCPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PSPMSPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.btnPathPS2 = new System.Windows.Forms.Button();
            this.btnPathPSP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flowPanTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PS2MCPath
            // 
            this.PS2MCPath.Location = new System.Drawing.Point(214, 284);
            this.PS2MCPath.Name = "PS2MCPath";
            this.PS2MCPath.Size = new System.Drawing.Size(412, 29);
            this.PS2MCPath.TabIndex = 5;
            this.PS2MCPath.Tag = "PS2MCPath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path MC PCSX2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(21, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path MS PPSSPP";
            // 
            // PSPMSPath
            // 
            this.PSPMSPath.Location = new System.Drawing.Point(214, 319);
            this.PSPMSPath.Name = "PSPMSPath";
            this.PSPMSPath.Size = new System.Drawing.Size(412, 29);
            this.PSPMSPath.TabIndex = 7;
            this.PSPMSPath.Tag = "PSPMSPath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game Title";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 355);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(454, 29);
            this.textBox3.TabIndex = 0;
            this.textBox3.Tag = "GameTitle";
            this.textBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Save Detail";
            this.label4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 390);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(454, 29);
            this.textBox4.TabIndex = 1;
            this.textBox4.Tag = "Detail";
            this.textBox4.Visible = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Multiselect = false;
            this.folderBrowserDialog.RootFolder = "C:\\Users\\Casa\\Desktop";
            this.folderBrowserDialog.Title = "Please select a folder...";
            // 
            // btnPathPS2
            // 
            this.btnPathPS2.Location = new System.Drawing.Point(632, 283);
            this.btnPathPS2.Name = "btnPathPS2";
            this.btnPathPS2.Size = new System.Drawing.Size(36, 29);
            this.btnPathPS2.TabIndex = 6;
            this.btnPathPS2.Text = "...";
            this.btnPathPS2.UseVisualStyleBackColor = true;
            this.btnPathPS2.Click += new System.EventHandler(this.btnPathPS2_Click);
            // 
            // btnPathPSP
            // 
            this.btnPathPSP.Location = new System.Drawing.Point(632, 320);
            this.btnPathPSP.Name = "btnPathPSP";
            this.btnPathPSP.Size = new System.Drawing.Size(36, 29);
            this.btnPathPSP.TabIndex = 8;
            this.btnPathPSP.Text = "...";
            this.btnPathPSP.UseVisualStyleBackColor = true;
            this.btnPathPSP.Click += new System.EventHandler(this.btnPathPSP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type mission names";
            // 
            // flowPanTypes
            // 
            this.flowPanTypes.AutoScroll = true;
            this.flowPanTypes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanTypes.Location = new System.Drawing.Point(26, 43);
            this.flowPanTypes.Name = "flowPanTypes";
            this.flowPanTypes.Size = new System.Drawing.Size(642, 216);
            this.flowPanTypes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Save Created by";
            this.label6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 425);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(454, 29);
            this.textBox5.TabIndex = 2;
            this.textBox5.Tag = "CreatedBy";
            this.textBox5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Save Title";
            this.label7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "Title";
            this.textBox1.Visible = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPathPSP);
            this.Controls.Add(this.btnPathPS2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PSPMSPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PS2MCPath);
            this.Controls.Add(this.flowPanTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSettings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PS2MCPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PSPMSPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser folderBrowserDialog;
        private System.Windows.Forms.Button btnPathPS2;
        private System.Windows.Forms.Button btnPathPSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowPanTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}