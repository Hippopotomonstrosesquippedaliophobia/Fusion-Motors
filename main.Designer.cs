
namespace Database_Application_Chris
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.titleBar = new System.Windows.Forms.Panel();
            this.maximize = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.UC = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mongoReconnect = new System.Windows.Forms.Button();
            this.mongoStatusLbl = new System.Windows.Forms.Label();
            this.mongoDBLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.DatabaseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.UserControlArea = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.UserControlArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gold;
            this.titleBar.Controls.Add(this.maximize);
            this.titleBar.Controls.Add(this.minimize);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1303, 22);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Gold;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maximize.Location = new System.Drawing.Point(1233, 0);
            this.maximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(35, 22);
            this.maximize.TabIndex = 10;
            this.maximize.Text = "1";
            this.maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Gold;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimize.Location = new System.Drawing.Point(1198, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 22);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "−";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Gold;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(1268, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 22);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(226, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 28);
            this.Title.TabIndex = 2;
            this.Title.Text = "Homepage";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.logo);
            this.panel5.Location = new System.Drawing.Point(41, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 106);
            this.panel5.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.Image = global::Database_Application_Chris.Properties.Resources.fusion_Motors_blk_png;
            this.logo.Location = new System.Drawing.Point(24, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 88);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // UC
            // 
            this.UC.AutoSize = true;
            this.UC.BackColor = System.Drawing.SystemColors.Window;
            this.UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC.Location = new System.Drawing.Point(0, 0);
            this.UC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC.Name = "UC";
            this.UC.Size = new System.Drawing.Size(1018, 594);
            this.UC.TabIndex = 4;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Image = global::Database_Application_Chris.Properties.Resources.settings_small;
            this.settingsBtn.Location = new System.Drawing.Point(932, 33);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(38, 32);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationBtn.FlatAppearance.BorderSize = 0;
            this.notificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationBtn.Image = global::Database_Application_Chris.Properties.Resources.notification_bell;
            this.notificationBtn.Location = new System.Drawing.Point(889, 33);
            this.notificationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(38, 32);
            this.notificationBtn.TabIndex = 6;
            this.notificationBtn.UseVisualStyleBackColor = true;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 89);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.mongoReconnect);
            this.panel3.Controls.Add(this.mongoStatusLbl);
            this.panel3.Controls.Add(this.mongoDBLbl);
            this.panel3.Controls.Add(this.versionLbl);
            this.panel3.Location = new System.Drawing.Point(2, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 66);
            this.panel3.TabIndex = 6;
            // 
            // mongoReconnect
            // 
            this.mongoReconnect.FlatAppearance.BorderSize = 0;
            this.mongoReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mongoReconnect.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoReconnect.ForeColor = System.Drawing.Color.White;
            this.mongoReconnect.Image = global::Database_Application_Chris.Properties.Resources.refresh_small;
            this.mongoReconnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mongoReconnect.Location = new System.Drawing.Point(207, 12);
            this.mongoReconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mongoReconnect.Name = "mongoReconnect";
            this.mongoReconnect.Size = new System.Drawing.Size(38, 32);
            this.mongoReconnect.TabIndex = 4;
            this.mongoReconnect.UseVisualStyleBackColor = true;
            this.mongoReconnect.Click += new System.EventHandler(this.mongoReconnect_Click);
            // 
            // mongoStatusLbl
            // 
            this.mongoStatusLbl.AutoSize = true;
            this.mongoStatusLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoStatusLbl.ForeColor = System.Drawing.Color.LightGray;
            this.mongoStatusLbl.Location = new System.Drawing.Point(24, 12);
            this.mongoStatusLbl.Name = "mongoStatusLbl";
            this.mongoStatusLbl.Size = new System.Drawing.Size(144, 16);
            this.mongoStatusLbl.TabIndex = 3;
            this.mongoStatusLbl.Text = "Mongo: Not Connected";
            // 
            // mongoDBLbl
            // 
            this.mongoDBLbl.AutoSize = true;
            this.mongoDBLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoDBLbl.ForeColor = System.Drawing.Color.LightGray;
            this.mongoDBLbl.Location = new System.Drawing.Point(24, 27);
            this.mongoDBLbl.Name = "mongoDBLbl";
            this.mongoDBLbl.Size = new System.Drawing.Size(82, 16);
            this.mongoDBLbl.TabIndex = 3;
            this.mongoDBLbl.Text = "FusionMotors";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLbl.ForeColor = System.Drawing.Color.White;
            this.versionLbl.Location = new System.Drawing.Point(24, 47);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(8, 12);
            this.versionLbl.TabIndex = 5;
            this.versionLbl.Text = "-";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.flowLayoutPanel1);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Location = new System.Drawing.Point(0, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 610);
            this.panel7.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.homeBtn);
            this.flowLayoutPanel1.Controls.Add(this.searchBtn);
            this.flowLayoutPanel1.Controls.Add(this.DatabaseBtn);
            this.flowLayoutPanel1.Controls.Add(this.AddBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 610);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homeBtn.Image = global::Database_Application_Chris.Properties.Resources.home;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(3, 2);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(252, 51);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "     Home ";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Image = global::Database_Application_Chris.Properties.Resources.search;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(3, 57);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(252, 51);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "     Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // DatabaseBtn
            // 
            this.DatabaseBtn.FlatAppearance.BorderSize = 0;
            this.DatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatabaseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DatabaseBtn.Image = global::Database_Application_Chris.Properties.Resources.db;
            this.DatabaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseBtn.Location = new System.Drawing.Point(3, 112);
            this.DatabaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseBtn.Name = "DatabaseBtn";
            this.DatabaseBtn.Size = new System.Drawing.Size(252, 51);
            this.DatabaseBtn.TabIndex = 2;
            this.DatabaseBtn.Text = "     Database ";
            this.DatabaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DatabaseBtn.UseVisualStyleBackColor = true;
            this.DatabaseBtn.Click += new System.EventHandler(this.DatabaseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Image = global::Database_Application_Chris.Properties.Resources.add_small;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(3, 167);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(252, 51);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "     Add";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 610);
            this.panel2.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Gold;
            this.sidePanel.Location = new System.Drawing.Point(2, 2);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(16, 51);
            this.sidePanel.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 732);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 732);
            this.panel4.TabIndex = 8;
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Controls.Add(this.panel5);
            this.TopBar.Controls.Add(this.settingsBtn);
            this.TopBar.Controls.Add(this.notificationBtn);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(285, 22);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1018, 138);
            this.TopBar.TabIndex = 9;
            // 
            // UserControlArea
            // 
            this.UserControlArea.Controls.Add(this.UC);
            this.UserControlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlArea.Location = new System.Drawing.Point(285, 160);
            this.UserControlArea.Name = "UserControlArea";
            this.UserControlArea.Size = new System.Drawing.Size(1018, 594);
            this.UserControlArea.TabIndex = 10;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1303, 754);
            this.Controls.Add(this.UserControlArea);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1050, 525);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fusion Motors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.Shown += new System.EventHandler(this.main_Shown);
            this.titleBar.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.UserControlArea.ResumeLayout(false);
            this.UserControlArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button minimize;
        public System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel UC;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button notificationBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mongoReconnect;
        public System.Windows.Forms.Label mongoStatusLbl;
        public System.Windows.Forms.Label mongoDBLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button DatabaseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel UserControlArea;
    }
}