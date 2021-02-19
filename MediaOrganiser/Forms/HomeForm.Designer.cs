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
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtbxFileManager = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblCurrentDirectory = new System.Windows.Forms.Label();
            this.FileManager = new System.Windows.Forms.ListView();
            this.TtHome = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "file.png");
            this.iconList.Images.SetKeyName(1, "folder.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtbxFileManager);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnRemove);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 31);
            this.panel1.TabIndex = 1;
            // 
            // TxtbxFileManager
            // 
            this.TxtbxFileManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxFileManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtbxFileManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxFileManager.Location = new System.Drawing.Point(0, 0);
            this.TxtbxFileManager.Name = "TxtbxFileManager";
            this.TxtbxFileManager.Size = new System.Drawing.Size(526, 30);
            this.TxtbxFileManager.TabIndex = 6;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(526, 0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(31, 31);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "...";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(557, 0);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(31, 31);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "-";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(588, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(31, 31);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblCurrentDirectory);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 410);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(619, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LblCurrentDirectory
            // 
            this.LblCurrentDirectory.AutoSize = true;
            this.LblCurrentDirectory.Location = new System.Drawing.Point(3, 0);
            this.LblCurrentDirectory.Name = "LblCurrentDirectory";
            this.LblCurrentDirectory.Size = new System.Drawing.Size(92, 13);
            this.LblCurrentDirectory.TabIndex = 0;
            this.LblCurrentDirectory.Text = "Current Directory: ";
            // 
            // FileManager
            // 
            this.FileManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileManager.HideSelection = false;
            this.FileManager.LargeImageList = this.iconList;
            this.FileManager.Location = new System.Drawing.Point(0, 31);
            this.FileManager.Name = "FileManager";
            this.FileManager.ShowItemToolTips = true;
            this.FileManager.Size = new System.Drawing.Size(619, 379);
            this.FileManager.SmallImageList = this.iconList;
            this.FileManager.TabIndex = 0;
            this.FileManager.UseCompatibleStateImageBehavior = false;
            this.FileManager.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FileManager_ItemSelectionChanged);
            this.FileManager.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileManager_MouseDoubleClick);
            this.FileManager.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FileManager_PreviewKeyDown);
            // 
            // HomeForm
            // 
            this.AcceptButton = this.BtnAdd;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.FileManager);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ListView FileManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label LblCurrentDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtbxFileManager;

        #endregion
        private System.Windows.Forms.Label LblNoFiles;
        private System.Windows.Forms.PictureBox ImgFile;
        private System.Windows.Forms.ToolTip TtHome;
    }
}