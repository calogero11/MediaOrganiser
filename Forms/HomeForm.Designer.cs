namespace MediaOrganiser
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.FileManger = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FileManger
            // 
            this.FileManger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileManger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileManger.HideSelection = false;
            this.FileManger.LargeImageList = this.iconList;
            this.FileManger.Location = new System.Drawing.Point(0, 0);
            this.FileManger.Name = "FileManger";
            this.FileManger.Size = new System.Drawing.Size(619, 443);
            this.FileManger.SmallImageList = this.iconList;
            this.FileManger.TabIndex = 0;
            this.FileManger.UseCompatibleStateImageBehavior = false;
            this.FileManger.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FileManger_ItemSelectionChanged);
            this.FileManger.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileManger_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "file.png");
            this.iconList.Images.SetKeyName(1, "folder.png");
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.FileManger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblNoFiles;
        private System.Windows.Forms.PictureBox ImgFile;
        private System.Windows.Forms.ListView FileManger;
        private System.Windows.Forms.ImageList iconList;
    }
}