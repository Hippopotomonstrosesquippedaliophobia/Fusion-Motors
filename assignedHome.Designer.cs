namespace Database_Application_Chris
{
    partial class assignedHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customersLbl = new System.Windows.Forms.Label();
            vehiclesLbl = new System.Windows.Forms.Label();
            listViewVehicles = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            listView = new System.Windows.Forms.ListView();
            ID = new System.Windows.Forms.ColumnHeader();
            FNameCol = new System.Windows.Forms.ColumnHeader();
            LNameCol = new System.Windows.Forms.ColumnHeader();
            NumberCol = new System.Windows.Forms.ColumnHeader();
            AddressCol = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // customersLbl
            // 
            customersLbl.AutoSize = true;
            customersLbl.Location = new System.Drawing.Point(13, 195);
            customersLbl.Name = "customersLbl";
            customersLbl.Size = new System.Drawing.Size(64, 15);
            customersLbl.TabIndex = 0;
            customersLbl.Text = "Customers";
            // 
            // vehiclesLbl
            // 
            vehiclesLbl.AutoSize = true;
            vehiclesLbl.Location = new System.Drawing.Point(13, 17);
            vehiclesLbl.Name = "vehiclesLbl";
            vehiclesLbl.Size = new System.Drawing.Size(49, 15);
            vehiclesLbl.TabIndex = 1;
            vehiclesLbl.Text = "Vehicles";
            // 
            // listViewVehicles
            // 
            listViewVehicles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader4 });
            listViewVehicles.FullRowSelect = true;
            listViewVehicles.GridLines = true;
            listViewVehicles.Location = new System.Drawing.Point(13, 35);
            listViewVehicles.Name = "listViewVehicles";
            listViewVehicles.Size = new System.Drawing.Size(899, 141);
            listViewVehicles.TabIndex = 2;
            listViewVehicles.UseCompatibleStateImageBehavior = false;
            listViewVehicles.View = System.Windows.Forms.View.Details;
            listViewVehicles.SelectedIndexChanged += listViewVehicles_SelectedIndexChanged;
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
            // listView
            // 
            listView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, FNameCol, LNameCol, NumberCol, AddressCol });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new System.Drawing.Point(13, 213);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(899, 241);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
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
            // assignedHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(listView);
            Controls.Add(listViewVehicles);
            Controls.Add(vehiclesLbl);
            Controls.Add(customersLbl);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "assignedHome";
            Size = new System.Drawing.Size(927, 467);
            Load += assignedHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label customersLbl;
        private System.Windows.Forms.Label vehiclesLbl;
        private System.Windows.Forms.ListView listViewVehicles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FNameCol;
        private System.Windows.Forms.ColumnHeader LNameCol;
        private System.Windows.Forms.ColumnHeader NumberCol;
        private System.Windows.Forms.ColumnHeader AddressCol;
    }
}
