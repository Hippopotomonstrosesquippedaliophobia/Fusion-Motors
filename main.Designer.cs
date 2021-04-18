
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.mongoStatusLbl = new System.Windows.Forms.Label();
            this.mongoDBLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.mongoReconnect = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.DatabaseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.UC = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mongoStatusLbl);
            this.panel3.Controls.Add(this.mongoDBLbl);
            this.panel3.Controls.Add(this.versionLbl);
            this.panel3.Controls.Add(this.mongoReconnect);
            this.panel3.Location = new System.Drawing.Point(2, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 88);
            this.panel3.TabIndex = 6;
            // 
            // mongoStatusLbl
            // 
            this.mongoStatusLbl.AutoSize = true;
            this.mongoStatusLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoStatusLbl.ForeColor = System.Drawing.Color.LightGray;
            this.mongoStatusLbl.Location = new System.Drawing.Point(27, 16);
            this.mongoStatusLbl.Name = "mongoStatusLbl";
            this.mongoStatusLbl.Size = new System.Drawing.Size(182, 18);
            this.mongoStatusLbl.TabIndex = 3;
            this.mongoStatusLbl.Text = "Mongo: Not Connected";
            // 
            // mongoDBLbl
            // 
            this.mongoDBLbl.AutoSize = true;
            this.mongoDBLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoDBLbl.ForeColor = System.Drawing.Color.LightGray;
            this.mongoDBLbl.Location = new System.Drawing.Point(27, 36);
            this.mongoDBLbl.Name = "mongoDBLbl";
            this.mongoDBLbl.Size = new System.Drawing.Size(102, 18);
            this.mongoDBLbl.TabIndex = 3;
            this.mongoDBLbl.Text = "FusionMotors";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLbl.ForeColor = System.Drawing.Color.White;
            this.versionLbl.Location = new System.Drawing.Point(27, 63);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(10, 15);
            this.versionLbl.TabIndex = 5;
            this.versionLbl.Text = "-";
            // 
            // mongoReconnect
            // 
            this.mongoReconnect.FlatAppearance.BorderSize = 0;
            this.mongoReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mongoReconnect.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mongoReconnect.ForeColor = System.Drawing.Color.White;
            this.mongoReconnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mongoReconnect.Location = new System.Drawing.Point(238, 23);
            this.mongoReconnect.Name = "mongoReconnect";
            this.mongoReconnect.Size = new System.Drawing.Size(48, 38);
            this.mongoReconnect.TabIndex = 4;
            this.mongoReconnect.Text = "↻";
            this.mongoReconnect.UseVisualStyleBackColor = true;
            this.mongoReconnect.Click += new System.EventHandler(this.mongoReconnect_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(3, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(288, 68);
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
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(3, 77);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(288, 68);
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
            this.DatabaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseBtn.Image")));
            this.DatabaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseBtn.Location = new System.Drawing.Point(3, 151);
            this.DatabaseBtn.Name = "DatabaseBtn";
            this.DatabaseBtn.Size = new System.Drawing.Size(288, 68);
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
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(3, 225);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(288, 68);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "     Add";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Gold;
            this.sidePanel.Location = new System.Drawing.Point(2, 3);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(18, 68);
            this.sidePanel.TabIndex = 2;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gold;
            this.titleBar.Controls.Add(this.minimize);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1379, 30);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Gold;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimize.Location = new System.Drawing.Point(1309, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 30);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "−";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(1344, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 30);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(574, 71);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(182, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "Homepage";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.logo);
            this.panel5.Location = new System.Drawing.Point(369, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 142);
            this.panel5.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(27, 1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(139, 118);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // UC
            // 
            this.UC.BackColor = System.Drawing.SystemColors.Window;
            this.UC.Location = new System.Drawing.Point(320, 177);
            this.UC.Name = "UC";
            this.UC.Size = new System.Drawing.Size(1059, 623);
            this.UC.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.homeBtn);
            this.flowLayoutPanel1.Controls.Add(this.searchBtn);
            this.flowLayoutPanel1.Controls.Add(this.DatabaseBtn);
            this.flowLayoutPanel1.Controls.Add(this.AddBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 608);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 681);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 119);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 606);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 78);
            this.panel4.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(1293, 65);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(51, 51);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.FlatAppearance.BorderSize = 0;
            this.notificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationBtn.Image = ((System.Drawing.Image)(resources.GetObject("notificationBtn.Image")));
            this.notificationBtn.Location = new System.Drawing.Point(1236, 65);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(51, 51);
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
            // notify
            // 
            this.notify.Location = new System.Drawing.Point(1165, 83);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(65, 25);
            this.notify.TabIndex = 9;
            this.notify.Text = "No New";
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 800);
            this.Controls.Add(this.notify);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UC);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fusion Motors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.Shown += new System.EventHandler(this.main_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button DatabaseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel UC;
        private System.Windows.Forms.Button homeBtn;
        public System.Windows.Forms.Label mongoStatusLbl;
        public System.Windows.Forms.Label mongoDBLbl;
        private System.Windows.Forms.Button mongoReconnect;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button notificationBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Label notify;
    }
}