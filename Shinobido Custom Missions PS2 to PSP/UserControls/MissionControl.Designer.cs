namespace Shinobido_Custom_Missions_PS2_to_PSP.UserControls
{
    partial class MissionControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgSaveIcon = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaveIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSaveIcon
            // 
            this.imgSaveIcon.Location = new System.Drawing.Point(68, 3);
            this.imgSaveIcon.Name = "imgSaveIcon";
            this.imgSaveIcon.Size = new System.Drawing.Size(275, 153);
            this.imgSaveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSaveIcon.TabIndex = 0;
            this.imgSaveIcon.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(349, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(822, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(4, 60);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(58, 37);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "00";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(348, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(822, 23);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Mission Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(350, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(821, 88);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Mission Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MissionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgSaveIcon);
            this.Name = "MissionControl";
            this.Size = new System.Drawing.Size(1182, 162);
            ((System.ComponentModel.ISupportInitialize)(this.imgSaveIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSaveIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
    }
}
