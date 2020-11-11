namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.folderBrowserDialog = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.flowPanMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPS2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Multiselect = false;
            this.folderBrowserDialog.RootFolder = "C:\\Users\\Casa\\Desktop";
            this.folderBrowserDialog.Title = "Please select a folder...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSettings,
            this.toolStripButtonExit,
            this.toolStripSeparator1,
            this.toolStripButtonAdd,
            this.toolStripSeparator2,
            this.toolStripButtonPSP,
            this.toolStripButtonPS2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1251, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(40, 32);
            this.toolStripButtonSettings.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolStripButtonSettings.ToolTipText = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(40, 38);
            this.toolStripButtonExit.ToolTipText = "Exit Application";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(40, 38);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.ToolTipText = "Add Mission from Memory Card";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // flowPanMissions
            // 
            this.flowPanMissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowPanMissions.AutoScroll = true;
            this.flowPanMissions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanMissions.Location = new System.Drawing.Point(12, 41);
            this.flowPanMissions.Name = "flowPanMissions";
            this.flowPanMissions.Size = new System.Drawing.Size(1223, 587);
            this.flowPanMissions.TabIndex = 2;
            this.flowPanMissions.WrapContents = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButtonPSP
            // 
            this.toolStripButtonPSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPSP.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPSP.Image")));
            this.toolStripButtonPSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPSP.Name = "toolStripButtonPSP";
            this.toolStripButtonPSP.Size = new System.Drawing.Size(40, 38);
            this.toolStripButtonPSP.ToolTipText = "Open PSP Saves Folder";
            this.toolStripButtonPSP.Click += new System.EventHandler(this.toolStripButtonPSP_Click);
            // 
            // toolStripButtonPS2
            // 
            this.toolStripButtonPS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPS2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPS2.Image")));
            this.toolStripButtonPS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPS2.Name = "toolStripButtonPS2";
            this.toolStripButtonPS2.Size = new System.Drawing.Size(40, 38);
            this.toolStripButtonPS2.ToolTipText = "Open PS2 Saves Folder";
            this.toolStripButtonPS2.Click += new System.EventHandler(this.toolStripButtonPS2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 640);
            this.Controls.Add(this.flowPanMissions);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Shinobido Custom Missions PS2 to PSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser folderBrowserDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.FlowLayoutPanel flowPanMissions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPSP;
        private System.Windows.Forms.ToolStripButton toolStripButtonPS2;
    }
}

