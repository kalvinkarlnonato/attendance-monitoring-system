namespace Biometric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.shutdownButton = new FontAwesome.Sharp.IconButton();
            this.manageButton = new FontAwesome.Sharp.IconButton();
            this.biometricButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.maximizeButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.currentChildLabel = new System.Windows.Forms.Label();
            this.currentChildIcon = new FontAwesome.Sharp.IconPictureBox();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildIcon)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(240)))));
            this.leftPanel.Controls.Add(this.shutdownButton);
            this.leftPanel.Controls.Add(this.manageButton);
            this.leftPanel.Controls.Add(this.biometricButton);
            this.leftPanel.Controls.Add(this.dashboardButton);
            this.leftPanel.Controls.Add(this.titlePanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(220, 624);
            this.leftPanel.TabIndex = 1;
            // 
            // shutdownButton
            // 
            this.shutdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.shutdownButton.FlatAppearance.BorderSize = 0;
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.shutdownButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.shutdownButton.IconColor = System.Drawing.Color.White;
            this.shutdownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.shutdownButton.IconSize = 45;
            this.shutdownButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdownButton.Location = new System.Drawing.Point(0, 250);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.shutdownButton.Size = new System.Drawing.Size(220, 50);
            this.shutdownButton.TabIndex = 4;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shutdownButton.UseVisualStyleBackColor = true;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageButton.FlatAppearance.BorderSize = 0;
            this.manageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageButton.IconChar = FontAwesome.Sharp.IconChar.HandPointUp;
            this.manageButton.IconColor = System.Drawing.Color.White;
            this.manageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageButton.IconSize = 45;
            this.manageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton.Location = new System.Drawing.Point(0, 200);
            this.manageButton.Name = "manageButton";
            this.manageButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.manageButton.Size = new System.Drawing.Size(220, 50);
            this.manageButton.TabIndex = 3;
            this.manageButton.Text = "Manage";
            this.manageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // biometricButton
            // 
            this.biometricButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.biometricButton.FlatAppearance.BorderSize = 0;
            this.biometricButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biometricButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.biometricButton.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.biometricButton.IconColor = System.Drawing.Color.White;
            this.biometricButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biometricButton.IconSize = 45;
            this.biometricButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biometricButton.Location = new System.Drawing.Point(0, 150);
            this.biometricButton.Name = "biometricButton";
            this.biometricButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.biometricButton.Size = new System.Drawing.Size(220, 50);
            this.biometricButton.TabIndex = 2;
            this.biometricButton.Text = "Biometric";
            this.biometricButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biometricButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.biometricButton.UseVisualStyleBackColor = true;
            this.biometricButton.Click += new System.EventHandler(this.biometricButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.dashboardButton.IconColor = System.Drawing.Color.White;
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 45;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 100);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dashboardButton.Size = new System.Drawing.Size(220, 50);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(240)))));
            this.titleBarPanel.Controls.Add(this.closeButton);
            this.titleBarPanel.Controls.Add(this.maximizeButton);
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.currentChildLabel);
            this.titleBarPanel.Controls.Add(this.currentChildIcon);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(220, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(992, 50);
            this.titleBarPanel.TabIndex = 2;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 25;
            this.closeButton.Location = new System.Drawing.Point(965, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.maximizeButton.IconColor = System.Drawing.Color.Black;
            this.maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeButton.IconSize = 25;
            this.maximizeButton.Location = new System.Drawing.Point(934, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 25;
            this.minimizeButton.Location = new System.Drawing.Point(903, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // currentChildLabel
            // 
            this.currentChildLabel.AutoSize = true;
            this.currentChildLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentChildLabel.Location = new System.Drawing.Point(45, 21);
            this.currentChildLabel.Name = "currentChildLabel";
            this.currentChildLabel.Size = new System.Drawing.Size(35, 13);
            this.currentChildLabel.TabIndex = 1;
            this.currentChildLabel.Text = "Home";
            // 
            // currentChildIcon
            // 
            this.currentChildIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(240)))));
            this.currentChildIcon.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.currentChildIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.currentChildIcon.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.currentChildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildIcon.IconSize = 28;
            this.currentChildIcon.Location = new System.Drawing.Point(10, 12);
            this.currentChildIcon.Name = "currentChildIcon";
            this.currentChildIcon.Size = new System.Drawing.Size(28, 28);
            this.currentChildIcon.TabIndex = 0;
            this.currentChildIcon.TabStop = false;
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowPanel.Location = new System.Drawing.Point(220, 50);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(992, 9);
            this.shadowPanel.TabIndex = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1212, 624);
            this.mainPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.homePictureBox);
            this.panel1.Location = new System.Drawing.Point(531, 207);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(405, 217);
            this.panel1.TabIndex = 1;
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.homePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homePictureBox.Image = global::Biometric.Properties.Resources.csu;
            this.homePictureBox.Location = new System.Drawing.Point(-30, 0);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(206, 217);
            this.homePictureBox.TabIndex = 0;
            this.homePictureBox.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(42, 21);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(129, 62);
            this.homeButton.TabIndex = 0;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.Controls.Add(this.homeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(220, 100);
            this.titlePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 624);
            this.Controls.Add(this.shadowPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "MainForm";
            this.Text = "Attendance Monitoring System";
            this.leftPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildIcon)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private FontAwesome.Sharp.IconButton shutdownButton;
        private FontAwesome.Sharp.IconButton manageButton;
        private FontAwesome.Sharp.IconButton biometricButton;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private FontAwesome.Sharp.IconPictureBox currentChildIcon;
        private System.Windows.Forms.Label currentChildLabel;
        private System.Windows.Forms.Panel shadowPanel;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton maximizeButton;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox homeButton;
    }
}