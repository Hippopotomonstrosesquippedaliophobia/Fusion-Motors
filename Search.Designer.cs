
namespace Database_Application_Chris
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.FNameCol = new System.Windows.Forms.ColumnHeader();
            this.LNameCol = new System.Windows.Forms.ColumnHeader();
            this.NumberCol = new System.Windows.Forms.ColumnHeader();
            this.AddressCol = new System.Windows.Forms.ColumnHeader();
            this.countLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gold;
            this.titleBar.Controls.Add(this.minimizeBtn);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.titleLbl);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(923, 30);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Gold;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.Location = new System.Drawing.Point(842, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(40, 30);
            this.minimizeBtn.TabIndex = 8;
            this.minimizeBtn.Text = "−";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Gold;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(883, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "✖";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(10, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(85, 20);
            this.titleLbl.TabIndex = 9;
            this.titleLbl.Text = "Customers";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FNameCol,
            this.LNameCol,
            this.NumberCol,
            this.AddressCol});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 93);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(899, 476);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // FNameCol
            // 
            this.FNameCol.Text = "First Name";
            this.FNameCol.Width = 160;
            // 
            // LNameCol
            // 
            this.LNameCol.Text = "Last Name";
            this.LNameCol.Width = 160;
            // 
            // NumberCol
            // 
            this.NumberCol.Text = "Primary Number";
            this.NumberCol.Width = 160;
            // 
            // AddressCol
            // 
            this.AddressCol.Text = "Primary Address";
            this.AddressCol.Width = 385;
            // 
            // countLbl
            // 
            this.countLbl.Location = new System.Drawing.Point(373, 572);
            this.countLbl.Name = "countLbl";
            this.countLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countLbl.Size = new System.Drawing.Size(538, 20);
            this.countLbl.TabIndex = 3;
            this.countLbl.Text = "-";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTxt.Location = new System.Drawing.Point(12, 43);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(511, 26);
            this.searchTxt.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.Gold;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(529, 42);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(381, 27);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Find a Customer";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader4});
            this.listViewVehicles.FullRowSelect = true;
            this.listViewVehicles.GridLines = true;
            this.listViewVehicles.HideSelection = false;
            this.listViewVehicles.Location = new System.Drawing.Point(12, 93);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(899, 476);
            this.listViewVehicles.TabIndex = 1;
            this.listViewVehicles.UseCompatibleStateImageBehavior = false;
            this.listViewVehicles.View = System.Windows.Forms.View.Details;
            this.listViewVehicles.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Engine Number";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Make";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Asking Price";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Colour";
            this.columnHeader4.Width = 92;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(923, 601);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.listViewVehicles);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fusion Motors: Search Database";
            this.Shown += new System.EventHandler(this.SearchForm_Shown);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ColumnHeader FNameCol;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader NumberCol;
        private System.Windows.Forms.ColumnHeader AddressCol;
        private System.Windows.Forms.ColumnHeader LNameCol;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.ListView listViewVehicles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}