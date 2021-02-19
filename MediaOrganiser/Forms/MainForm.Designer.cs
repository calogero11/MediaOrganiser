namespace MediaOrganiser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlAddButtonIndicator = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlExitButtonIndicator = new System.Windows.Forms.Panel();
            this.PnlHomeButtonIndicator = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.TtMainMenu = new System.Windows.Forms.ToolTip(this.components);
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.PnlAddButtonIndicator);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.PnlExitButtonIndicator);
            this.panel1.Controls.Add(this.PnlHomeButtonIndicator);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 684);
            this.panel1.TabIndex = 0;
            // 
            // PnlAddButtonIndicator
            // 
            this.PnlAddButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PnlAddButtonIndicator.Location = new System.Drawing.Point(0, 250);
            this.PnlAddButtonIndicator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlAddButtonIndicator.Name = "PnlAddButtonIndicator";
            this.PnlAddButtonIndicator.Size = new System.Drawing.Size(9, 110);
            this.PnlAddButtonIndicator.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 250);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(255, 110);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            // 
            // PnlExitButtonIndicator
            // 
            this.PnlExitButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PnlExitButtonIndicator.Location = new System.Drawing.Point(0, 575);
            this.PnlExitButtonIndicator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlExitButtonIndicator.Name = "PnlExitButtonIndicator";
            this.PnlExitButtonIndicator.Size = new System.Drawing.Size(9, 110);
            this.PnlExitButtonIndicator.TabIndex = 2;
            // 
            // PnlHomeButtonIndicator
            // 
            this.PnlHomeButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.PnlHomeButtonIndicator.Location = new System.Drawing.Point(0, 140);
            this.PnlHomeButtonIndicator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlHomeButtonIndicator.Name = "PnlHomeButtonIndicator";
            this.PnlHomeButtonIndicator.Size = new System.Drawing.Size(9, 110);
            this.PnlHomeButtonIndicator.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(0, 574);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(255, 110);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(0, 140);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(255, 110);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 140);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(255, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 91);
            this.panel3.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(359, 21);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTitle.Size = new System.Drawing.Size(81, 44);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormLoader.Location = new System.Drawing.Point(255, 91);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(846, 593);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(26, 32);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(206, 74);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 3;
            this.PicLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 684);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1117, 721);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnlAddButtonIndicator;
        private System.Windows.Forms.Panel PnlExitButtonIndicator;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel PnlHomeButtonIndicator;
        private System.Windows.Forms.ToolTip TtMainMenu;

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
    }
}