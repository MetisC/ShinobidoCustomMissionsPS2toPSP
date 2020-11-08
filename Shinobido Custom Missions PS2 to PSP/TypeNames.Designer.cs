namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    partial class TypeNames
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.142858F);
            this.label.Location = new System.Drawing.Point(3, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 20);
            this.label.TabIndex = 14;
            this.label.Text = "Assassination";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.142858F);
            this.textBox.Location = new System.Drawing.Point(151, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(197, 26);
            this.textBox.TabIndex = 13;
            this.textBox.Tag = "TypeAssasination";
            // 
            // TypeNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Name = "TypeNames";
            this.Size = new System.Drawing.Size(352, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
    }
}
