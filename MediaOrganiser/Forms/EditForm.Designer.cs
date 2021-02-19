namespace MediaOrganiser
{
    partial class EditForm
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
            this.TxtbxPlayList = new System.Windows.Forms.TextBox();
            this.TxtbxCategory = new System.Windows.Forms.TextBox();
            this.TxtbxImage = new System.Windows.Forms.TextBox();
            this.TxtbxMediaFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtbxComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSelectMediaFile = new System.Windows.Forms.Button();
            this.BtnSelectImage = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblOutcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtbxPlayList
            // 
            this.TxtbxPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbxPlayList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtbxPlayList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtbxPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPlayList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtbxPlayList.Location = new System.Drawing.Point(151, 91);
            this.TxtbxPlayList.Name = "TxtbxPlayList";
            this.TxtbxPlayList.Size = new System.Drawing.Size(330, 20);
            this.TxtbxPlayList.TabIndex = 0;
            this.TxtbxPlayList.TextChanged += new System.EventHandler(this.TxtbxPlayList_TextChanged);
            // 
            // TxtbxCategory
            // 
            this.TxtbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtbxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtbxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCategory.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtbxCategory.Location = new System.Drawing.Point(150, 146);
            this.TxtbxCategory.Name = "TxtbxCategory";
            this.TxtbxCategory.Size = new System.Drawing.Size(330, 20);
            this.TxtbxCategory.TabIndex = 1;
            this.TxtbxCategory.TextChanged += new System.EventHandler(this.TxtbxCategory_TextChanged);
            // 
            // TxtbxImage
            // 
            this.TxtbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxImage.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtbxImage.Location = new System.Drawing.Point(150, 206);
            this.TxtbxImage.Name = "TxtbxImage";
            this.TxtbxImage.ReadOnly = true;
            this.TxtbxImage.Size = new System.Drawing.Size(330, 20);
            this.TxtbxImage.TabIndex = 2;
            this.TxtbxImage.TextChanged += new System.EventHandler(this.TxtbxImage_TextChanged);
            // 
            // TxtbxMediaFile
            // 
            this.TxtbxMediaFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbxMediaFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxMediaFile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtbxMediaFile.Location = new System.Drawing.Point(150, 274);
            this.TxtbxMediaFile.Name = "TxtbxMediaFile";
            this.TxtbxMediaFile.ReadOnly = true;
            this.TxtbxMediaFile.Size = new System.Drawing.Size(330, 20);
            this.TxtbxMediaFile.TabIndex = 3;
            this.TxtbxMediaFile.TextChanged += new System.EventHandler(this.TxtbxMediaFile_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PlayList:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MediaFile:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtbxComment
            // 
            this.TxtbxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbxComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxComment.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtbxComment.Location = new System.Drawing.Point(150, 333);
            this.TxtbxComment.Name = "TxtbxComment";
            this.TxtbxComment.Size = new System.Drawing.Size(330, 20);
            this.TxtbxComment.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comment:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSelectMediaFile
            // 
            this.BtnSelectMediaFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSelectMediaFile.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectMediaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectMediaFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSelectMediaFile.Location = new System.Drawing.Point(415, 274);
            this.BtnSelectMediaFile.Name = "BtnSelectMediaFile";
            this.BtnSelectMediaFile.Size = new System.Drawing.Size(66, 20);
            this.BtnSelectMediaFile.TabIndex = 10;
            this.BtnSelectMediaFile.Text = "Select";
            this.BtnSelectMediaFile.UseVisualStyleBackColor = false;
            this.BtnSelectMediaFile.Click += new System.EventHandler(this.BtnSelectMediaFile_Click);
            // 
            // BtnSelectImage
            // 
            this.BtnSelectImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSelectImage.Location = new System.Drawing.Point(415, 206);
            this.BtnSelectImage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSelectImage.Name = "BtnSelectImage";
            this.BtnSelectImage.Size = new System.Drawing.Size(65, 20);
            this.BtnSelectImage.TabIndex = 11;
            this.BtnSelectImage.Text = "Select";
            this.BtnSelectImage.UseVisualStyleBackColor = false;
            this.BtnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.Location = new System.Drawing.Point(271, 399);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblOutcome
            // 
            this.LblOutcome.AutoSize = true;
            this.LblOutcome.Location = new System.Drawing.Point(352, 404);
            this.LblOutcome.Name = "LblOutcome";
            this.LblOutcome.Size = new System.Drawing.Size(0, 13);
            this.LblOutcome.TabIndex = 13;
            // 
            // EditForm
            // 
            this.AcceptButton = this.BtnUpdate;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 482);
            this.Controls.Add(this.LblOutcome);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSelectImage);
            this.Controls.Add(this.BtnSelectMediaFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtbxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtbxMediaFile);
            this.Controls.Add(this.TxtbxImage);
            this.Controls.Add(this.TxtbxCategory);
            this.Controls.Add(this.TxtbxPlayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button BtnSelectImage;
        private System.Windows.Forms.Button BtnSelectMediaFile;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblOutcome;
        private System.Windows.Forms.TextBox TxtbxCategory;
        private System.Windows.Forms.TextBox TxtbxComment;
        private System.Windows.Forms.TextBox TxtbxImage;
        private System.Windows.Forms.TextBox TxtbxMediaFile;
        private System.Windows.Forms.TextBox TxtbxPlayList;

        #endregion
    }
}