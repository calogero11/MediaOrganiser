namespace MediaOrganiser
{
    partial class EmptyHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyHomeForm));
            this.ImgFile = new System.Windows.Forms.PictureBox();
            this.LblNoFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFile)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgFile
            // 
            this.ImgFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgFile.Image = ((System.Drawing.Image)(resources.GetObject("ImgFile.Image")));
            this.ImgFile.Location = new System.Drawing.Point(257, 185);
            this.ImgFile.Name = "ImgFile";
            this.ImgFile.Size = new System.Drawing.Size(100, 100);
            this.ImgFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgFile.TabIndex = 0;
            this.ImgFile.TabStop = false;
            // 
            // LblNoFiles
            // 
            this.LblNoFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNoFiles.AutoSize = true;
            this.LblNoFiles.Location = new System.Drawing.Point(189, 292);
            this.LblNoFiles.Name = "LblNoFiles";
            this.LblNoFiles.Size = new System.Drawing.Size(242, 13);
            this.LblNoFiles.TabIndex = 1;
            this.LblNoFiles.Text = "No files to show. Please try Importing some media.";
            // 
            // EmptyHomeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 482);
            this.Controls.Add(this.LblNoFiles);
            this.Controls.Add(this.ImgFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmptyHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImgFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNoFiles;
        private System.Windows.Forms.PictureBox ImgFile;
    }
}