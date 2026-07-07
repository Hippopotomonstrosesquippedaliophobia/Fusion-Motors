
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            titleBar = new System.Windows.Forms.Panel();
            maximize = new System.Windows.Forms.Button();
            minimize = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            Title = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            logo = new System.Windows.Forms.PictureBox();
            UC = new System.Windows.Forms.Panel();
            settingsBtn = new System.Windows.Forms.Button();
            notificationBtn = new System.Windows.Forms.Button();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            userNameLbl = new System.Windows.Forms.Label();
            mongoReconnect = new System.Windows.Forms.Button();
            mongoDBLbl = new System.Windows.Forms.Label();
            versionLbl = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            homeBtn = new System.Windows.Forms.Button();
            searchBtn = new System.Windows.Forms.Button();
            DatabaseBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            assignedBtn = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            sidePanel = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            TopBar = new System.Windows.Forms.Panel();
            UserControlArea = new System.Windows.Forms.Panel();
            titleBar.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            TopBar.SuspendLayout();
            UserControlArea.SuspendLayout();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.BackColor = System.Drawing.Color.Gold;
            titleBar.Controls.Add(maximize);
            titleBar.Controls.Add(minimize);
            titleBar.Controls.Add(closeBtn);
            titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            titleBar.Location = new System.Drawing.Point(0, 0);
            titleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            titleBar.Name = "titleBar";
            titleBar.Size = new System.Drawing.Size(1303, 22);
            titleBar.TabIndex = 1;
            titleBar.MouseDown += titleBar_MouseDown;
            // 
            // maximize
            // 
            maximize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maximize.BackColor = System.Drawing.Color.Gold;
            maximize.FlatAppearance.BorderSize = 0;
            maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maximize.Font = new System.Drawing.Font("Webdings", 9F);
            maximize.Location = new System.Drawing.Point(1233, 0);
            maximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            maximize.Name = "maximize";
            maximize.Size = new System.Drawing.Size(35, 22);
            maximize.TabIndex = 10;
            maximize.Text = "1";
            maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            maximize.UseVisualStyleBackColor = false;
            maximize.Click += maximize_Click;
            // 
            // minimize
            // 
            minimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            minimize.BackColor = System.Drawing.Color.Gold;
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            minimize.Location = new System.Drawing.Point(1198, 0);
            minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            minimize.Name = "minimize";
            minimize.Size = new System.Drawing.Size(35, 22);
            minimize.TabIndex = 10;
            minimize.Text = "−";
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += minimize_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeBtn.BackColor = System.Drawing.Color.Gold;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            closeBtn.Location = new System.Drawing.Point(1268, 0);
            closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(35, 22);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "✖";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            Title.Location = new System.Drawing.Point(226, 31);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(144, 28);
            Title.TabIndex = 2;
            Title.Text = "Homepage";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Gold;
            panel5.Controls.Add(logo);
            panel5.Location = new System.Drawing.Point(41, 0);
            panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(158, 106);
            panel5.TabIndex = 3;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.fusion_Motors_blk_png;
            logo.Location = new System.Drawing.Point(24, 1);
            logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(122, 88);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // UC
            // 
            UC.AutoSize = true;
            UC.BackColor = System.Drawing.SystemColors.Window;
            UC.Dock = System.Windows.Forms.DockStyle.Fill;
            UC.Location = new System.Drawing.Point(0, 0);
            UC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UC.Name = "UC";
            UC.Size = new System.Drawing.Size(1018, 594);
            UC.TabIndex = 4;
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingsBtn.Image = Properties.Resources.settings_small;
            settingsBtn.Location = new System.Drawing.Point(932, 33);
            settingsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new System.Drawing.Size(38, 32);
            settingsBtn.TabIndex = 6;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // notificationBtn
            // 
            notificationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            notificationBtn.FlatAppearance.BorderSize = 0;
            notificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            notificationBtn.Image = Properties.Resources.notification_bell;
            notificationBtn.Location = new System.Drawing.Point(889, 33);
            notificationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            notificationBtn.Name = "notificationBtn";
            notificationBtn.Size = new System.Drawing.Size(38, 32);
            notificationBtn.TabIndex = 6;
            notificationBtn.UseVisualStyleBackColor = true;
            notificationBtn.Click += notificationBtn_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            contextMenuStrip.ItemClicked += contextMenuStrip_ItemClicked;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 643);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(285, 89);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel3.Controls.Add(userNameLbl);
            panel3.Controls.Add(mongoReconnect);
            panel3.Controls.Add(mongoDBLbl);
            panel3.Controls.Add(versionLbl);
            panel3.Location = new System.Drawing.Point(2, 12);
            panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(278, 66);
            panel3.TabIndex = 6;
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            userNameLbl.ForeColor = System.Drawing.Color.LightGray;
            userNameLbl.Location = new System.Drawing.Point(24, 11);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new System.Drawing.Size(91, 16);
            userNameLbl.TabIndex = 6;
            userNameLbl.Text = "No User Found";
            // 
            // mongoReconnect
            // 
            mongoReconnect.FlatAppearance.BorderSize = 0;
            mongoReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mongoReconnect.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            mongoReconnect.ForeColor = System.Drawing.Color.White;
            mongoReconnect.Image = Properties.Resources.refresh_small;
            mongoReconnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            mongoReconnect.Location = new System.Drawing.Point(207, 12);
            mongoReconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mongoReconnect.Name = "mongoReconnect";
            mongoReconnect.Size = new System.Drawing.Size(38, 32);
            mongoReconnect.TabIndex = 4;
            mongoReconnect.UseVisualStyleBackColor = true;
            // 
            // mongoDBLbl
            // 
            mongoDBLbl.AutoSize = true;
            mongoDBLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            mongoDBLbl.ForeColor = System.Drawing.Color.LightGray;
            mongoDBLbl.Location = new System.Drawing.Point(24, 27);
            mongoDBLbl.Name = "mongoDBLbl";
            mongoDBLbl.Size = new System.Drawing.Size(82, 16);
            mongoDBLbl.TabIndex = 3;
            mongoDBLbl.Text = "FusionMotors";
            // 
            // versionLbl
            // 
            versionLbl.AutoSize = true;
            versionLbl.Font = new System.Drawing.Font("Century Gothic", 6F);
            versionLbl.ForeColor = System.Drawing.Color.White;
            versionLbl.Location = new System.Drawing.Point(24, 47);
            versionLbl.Name = "versionLbl";
            versionLbl.Size = new System.Drawing.Size(8, 12);
            versionLbl.TabIndex = 5;
            versionLbl.Text = "-";
            // 
            // panel7
            // 
            panel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel7.AutoSize = true;
            panel7.Controls.Add(flowLayoutPanel1);
            panel7.Controls.Add(panel2);
            panel7.Location = new System.Drawing.Point(0, 18);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(285, 610);
            panel7.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
            flowLayoutPanel1.Controls.Add(homeBtn);
            flowLayoutPanel1.Controls.Add(searchBtn);
            flowLayoutPanel1.Controls.Add(DatabaseBtn);
            flowLayoutPanel1.Controls.Add(AddBtn);
            flowLayoutPanel1.Controls.Add(assignedBtn);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(14, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(271, 610);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            homeBtn.ForeColor = System.Drawing.SystemColors.Control;
            homeBtn.Image = Properties.Resources.home;
            homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            homeBtn.Location = new System.Drawing.Point(3, 2);
            homeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new System.Drawing.Size(268, 51);
            homeBtn.TabIndex = 2;
            homeBtn.Text = "     Home ";
            homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            searchBtn.Image = Properties.Resources.search;
            searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            searchBtn.Location = new System.Drawing.Point(3, 57);
            searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(266, 51);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "     Search";
            searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // DatabaseBtn
            // 
            DatabaseBtn.FlatAppearance.BorderSize = 0;
            DatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DatabaseBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            DatabaseBtn.ForeColor = System.Drawing.SystemColors.Control;
            DatabaseBtn.Image = Properties.Resources.db;
            DatabaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DatabaseBtn.Location = new System.Drawing.Point(3, 112);
            DatabaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DatabaseBtn.Name = "DatabaseBtn";
            DatabaseBtn.Size = new System.Drawing.Size(268, 51);
            DatabaseBtn.TabIndex = 2;
            DatabaseBtn.Text = "     Database ";
            DatabaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DatabaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            DatabaseBtn.UseVisualStyleBackColor = true;
            DatabaseBtn.Click += DatabaseBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            AddBtn.ForeColor = System.Drawing.SystemColors.Control;
            AddBtn.Image = Properties.Resources.add_small;
            AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AddBtn.Location = new System.Drawing.Point(3, 167);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(268, 51);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "     Add";
            AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // assignedBtn
            // 
            assignedBtn.FlatAppearance.BorderSize = 0;
            assignedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            assignedBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            assignedBtn.ForeColor = System.Drawing.SystemColors.Control;
            assignedBtn.Image = Properties.Resources.checklistFixed;
            assignedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            assignedBtn.Location = new System.Drawing.Point(3, 222);
            assignedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            assignedBtn.Name = "assignedBtn";
            assignedBtn.Size = new System.Drawing.Size(259, 51);
            assignedBtn.TabIndex = 3;
            assignedBtn.Text = "    Assigned";
            assignedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            assignedBtn.UseVisualStyleBackColor = true;
            assignedBtn.Click += assignedBtn_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
            panel2.Controls.Add(sidePanel);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(14, 610);
            panel2.TabIndex = 0;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = System.Drawing.Color.Gold;
            sidePanel.Location = new System.Drawing.Point(1, 2);
            sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new System.Drawing.Size(10, 51);
            sidePanel.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel6.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel1);
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(285, 732);
            panel6.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(285, 732);
            panel4.TabIndex = 8;
            // 
            // TopBar
            // 
            TopBar.Controls.Add(Title);
            TopBar.Controls.Add(panel5);
            TopBar.Controls.Add(settingsBtn);
            TopBar.Controls.Add(notificationBtn);
            TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            TopBar.Location = new System.Drawing.Point(285, 22);
            TopBar.Name = "TopBar";
            TopBar.Size = new System.Drawing.Size(1018, 138);
            TopBar.TabIndex = 9;
            // 
            // UserControlArea
            // 
            UserControlArea.Controls.Add(UC);
            UserControlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            UserControlArea.Location = new System.Drawing.Point(285, 160);
            UserControlArea.Name = "UserControlArea";
            UserControlArea.Size = new System.Drawing.Size(1018, 594);
            UserControlArea.TabIndex = 10;
            // 
            // main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(1303, 754);
            Controls.Add(UserControlArea);
            Controls.Add(TopBar);
            Controls.Add(panel4);
            Controls.Add(titleBar);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(1050, 525);
            Name = "main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fusion Motors";
            FormClosing += main_FormClosing;
            Load += main_Load;
            Shown += main_Shown;
            titleBar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            UserControlArea.ResumeLayout(false);
            UserControlArea.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button assignedBtn;
        public System.Windows.Forms.Label userNameLbl;
    }
}