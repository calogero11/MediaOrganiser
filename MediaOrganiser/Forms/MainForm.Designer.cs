﻿namespace MediaOrganiser
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (221)))), ((int) (((byte) (221)))), ((int) (((byte) (221)))));
            this.panel1.Controls.Add(this.PnlAddButtonIndicator);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.PnlExitButtonIndicator);
            this.panel1.Controls.Add(this.PnlHomeButtonIndicator);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 556);
            this.panel1.TabIndex = 0;
            // 
            // PnlAddButtonIndicator
            // 
            this.PnlAddButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))), ((int) (((byte) (196)))));
            this.PnlAddButtonIndicator.Location = new System.Drawing.Point(0, 203);
            this.PnlAddButtonIndicator.Name = "PnlAddButtonIndicator";
            this.PnlAddButtonIndicator.Size = new System.Drawing.Size(7, 89);
            this.PnlAddButtonIndicator.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 203);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(191, 89);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            // 
            // PnlExitButtonIndicator
            // 
            this.PnlExitButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))), ((int) (((byte) (196)))));
            this.PnlExitButtonIndicator.Location = new System.Drawing.Point(0, 467);
            this.PnlExitButtonIndicator.Name = "PnlExitButtonIndicator";
            this.PnlExitButtonIndicator.Size = new System.Drawing.Size(7, 89);
            this.PnlExitButtonIndicator.TabIndex = 2;
            // 
            // PnlHomeButtonIndicator
            // 
            this.PnlHomeButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (211)))), ((int) (((byte) (0)))));
            this.PnlHomeButtonIndicator.Location = new System.Drawing.Point(0, 114);
            this.PnlHomeButtonIndicator.Name = "PnlHomeButtonIndicator";
            this.PnlHomeButtonIndicator.Size = new System.Drawing.Size(7, 89);
            this.PnlHomeButtonIndicator.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnExit.Location = new System.Drawing.Point(0, 467);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(191, 89);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnHome.Location = new System.Drawing.Point(0, 114);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(191, 89);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 114);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 74);
            this.panel3.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblTitle.Location = new System.Drawing.Point(269, 17);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTitle.Size = new System.Drawing.Size(65, 35);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormLoader.Location = new System.Drawing.Point(191, 74);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(635, 482);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 556);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(842, 595);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}