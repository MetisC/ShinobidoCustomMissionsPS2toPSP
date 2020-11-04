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
            this.folderBrowserDialog = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Multiselect = false;
            this.folderBrowserDialog.RootFolder = "C:\\Users\\Casa\\Desktop";
            this.folderBrowserDialog.Title = "Please select a folder...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 521);
            this.Name = "FrmMain";
            this.Text = "Shinobido Custom Missions PS2 to PSP";
            this.ResumeLayout(false);

        }

        #endregion

        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser folderBrowserDialog;
    }
}

