
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
            titleBar = new System.Windows.Forms.Panel();
            minimizeBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            titleLbl = new System.Windows.Forms.Label();
            listView = new System.Windows.Forms.ListView();
            ID = new System.Windows.Forms.ColumnHeader();
            FNameCol = new System.Windows.Forms.ColumnHeader();
            LNameCol = new System.Windows.Forms.ColumnHeader();
            NumberCol = new System.Windows.Forms.ColumnHeader();
            AddressCol = new System.Windows.Forms.ColumnHeader();
            countLbl = new System.Windows.Forms.Label();
            searchTxt = new System.Windows.Forms.TextBox();
            searchBtn = new System.Windows.Forms.Button();
            listViewVehicles = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            titleBar.SuspendLayout();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.BackColor = System.Drawing.Color.Gold;
            titleBar.Controls.Add(minimizeBtn);
            titleBar.Controls.Add(closeBtn);
            titleBar.Controls.Add(titleLbl);
            titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            titleBar.Location = new System.Drawing.Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Size = new System.Drawing.Size(923, 30);
            titleBar.TabIndex = 0;
            titleBar.MouseDown += titleBar_MouseDown;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = System.Drawing.Color.Gold;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            minimizeBtn.Location = new System.Drawing.Point(842, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new System.Drawing.Size(40, 30);
            minimizeBtn.TabIndex = 8;
            minimizeBtn.Text = "−";
            minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = System.Drawing.Color.Gold;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            closeBtn.Location = new System.Drawing.Point(883, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(40, 30);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "✖";
            closeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new System.Drawing.Point(10, 5);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new System.Drawing.Size(70, 17);
            titleLbl.TabIndex = 9;
            titleLbl.Text = "Customers";
            // 
            // listView
            // 
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, FNameCol, LNameCol, NumberCol, AddressCol });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new System.Drawing.Point(12, 93);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(899, 476);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChangedAsync;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // FNameCol
            // 
            FNameCol.Text = "First Name";
            FNameCol.Width = 160;
            // 
            // LNameCol
            // 
            LNameCol.Text = "Last Name";
            LNameCol.Width = 160;
            // 
            // NumberCol
            // 
            NumberCol.Text = "Primary Number";
            NumberCol.Width = 160;
            // 
            // AddressCol
            // 
            AddressCol.Text = "Primary Address";
            AddressCol.Width = 385;
            // 
            // countLbl
            // 
            countLbl.Location = new System.Drawing.Point(373, 572);
            countLbl.Name = "countLbl";
            countLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            countLbl.Size = new System.Drawing.Size(538, 20);
            countLbl.TabIndex = 3;
            countLbl.Text = "-";
            countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTxt
            // 
            searchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            searchTxt.Location = new System.Drawing.Point(12, 43);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new System.Drawing.Size(511, 22);
            searchTxt.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            searchBtn.BackColor = System.Drawing.Color.Gold;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            searchBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            searchBtn.ForeColor = System.Drawing.Color.Black;
            searchBtn.Location = new System.Drawing.Point(529, 42);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(381, 27);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Find a Customer";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // listViewVehicles
            // 
            listViewVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader4 });
            listViewVehicles.FullRowSelect = true;
            listViewVehicles.GridLines = true;
            listViewVehicles.Location = new System.Drawing.Point(12, 93);
            listViewVehicles.Name = "listViewVehicles";
            listViewVehicles.Size = new System.Drawing.Size(899, 476);
            listViewVehicles.TabIndex = 1;
            listViewVehicles.UseCompatibleStateImageBehavior = false;
            listViewVehicles.View = System.Windows.Forms.View.Details;
            listViewVehicles.SelectedIndexChanged += listView_SelectedIndexChangedAsync;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Engine Number";
            columnHeader2.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Make";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Model";
            columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Year";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Value";
            columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Asking Price";
            columnHeader9.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Colour";
            columnHeader4.Width = 92;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(923, 601);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(countLbl);
            Controls.Add(listViewVehicles);
            Controls.Add(listView);
            Controls.Add(titleBar);
            Font = new System.Drawing.Font("Century Gothic", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SearchForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fusion Motors: Search Database";
            Shown += SearchForm_Shown;
            titleBar.ResumeLayout(false);
            titleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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