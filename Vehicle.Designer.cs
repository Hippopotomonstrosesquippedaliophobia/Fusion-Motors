
namespace Database_Application_Chris
{
    partial class Vehicle
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.engineNumLbl = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.deleteVehicleBtn = new System.Windows.Forms.Button();
            this.updateVehicleBtn = new System.Windows.Forms.Button();
            this.interestedCustomersListBox = new System.Windows.Forms.ListBox();
            this.chassisNumLbl = new System.Windows.Forms.TextBox();
            this.colourLbl = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addThisVehicle = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.L8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.makeLbl = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.TextBox();
            this.L4 = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.DateTimePicker();
            this.L5 = new System.Windows.Forms.Label();
            this.valuationLbl = new System.Windows.Forms.TextBox();
            this.L6 = new System.Windows.Forms.Label();
            this.askingPriceLbl = new System.Windows.Forms.TextBox();
            this.L7 = new System.Windows.Forms.Label();
            this.ownerLbl = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FormButtonsSection = new System.Windows.Forms.Panel();
            this.InterestedCustomersPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.FormButtonsSection.SuspendLayout();
            this.InterestedCustomersPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.engineNumLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 47);
            this.panel1.TabIndex = 6;
            // 
            // engineNumLbl
            // 
            this.engineNumLbl.BackColor = System.Drawing.Color.Gold;
            this.engineNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engineNumLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.engineNumLbl.Location = new System.Drawing.Point(55, 12);
            this.engineNumLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.engineNumLbl.Name = "engineNumLbl";
            this.engineNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.engineNumLbl.Size = new System.Drawing.Size(558, 23);
            this.engineNumLbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.engineNumLbl, "Engine Number");
            this.engineNumLbl.Leave += new System.EventHandler(this.engineNumLbl_Leave);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.addCustomerBtn.Enabled = false;
            this.addCustomerBtn.FlatAppearance.BorderSize = 0;
            this.addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCustomerBtn.Location = new System.Drawing.Point(739, 26);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(190, 33);
            this.addCustomerBtn.TabIndex = 17;
            this.addCustomerBtn.Text = "+";
            this.toolTip.SetToolTip(this.addCustomerBtn, "Add an interested customer");
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Visible = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // deleteVehicleBtn
            // 
            this.deleteVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteVehicleBtn.FlatAppearance.BorderSize = 0;
            this.deleteVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteVehicleBtn.Location = new System.Drawing.Point(57, 26);
            this.deleteVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteVehicleBtn.Name = "deleteVehicleBtn";
            this.deleteVehicleBtn.Size = new System.Drawing.Size(130, 33);
            this.deleteVehicleBtn.TabIndex = 18;
            this.deleteVehicleBtn.Text = "🗑️ Delete";
            this.deleteVehicleBtn.UseVisualStyleBackColor = false;
            this.deleteVehicleBtn.Click += new System.EventHandler(this.deleteVehicleBtn_Click);
            // 
            // updateVehicleBtn
            // 
            this.updateVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.updateVehicleBtn.Enabled = false;
            this.updateVehicleBtn.FlatAppearance.BorderSize = 0;
            this.updateVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateVehicleBtn.Location = new System.Drawing.Point(197, 26);
            this.updateVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateVehicleBtn.Name = "updateVehicleBtn";
            this.updateVehicleBtn.Size = new System.Drawing.Size(130, 33);
            this.updateVehicleBtn.TabIndex = 19;
            this.updateVehicleBtn.Text = "↻ Update";
            this.updateVehicleBtn.UseVisualStyleBackColor = false;
            this.updateVehicleBtn.Visible = false;
            this.updateVehicleBtn.Click += new System.EventHandler(this.updateVehicleBtn_Click);
            // 
            // interestedCustomersListBox
            // 
            this.interestedCustomersListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.interestedCustomersListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interestedCustomersListBox.FormattingEnabled = true;
            this.interestedCustomersListBox.ItemHeight = 19;
            this.interestedCustomersListBox.Location = new System.Drawing.Point(24, 0);
            this.interestedCustomersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interestedCustomersListBox.Name = "interestedCustomersListBox";
            this.interestedCustomersListBox.Size = new System.Drawing.Size(243, 375);
            this.interestedCustomersListBox.TabIndex = 13;
            this.toolTip.SetToolTip(this.interestedCustomersListBox, "List of interested customers");
            this.interestedCustomersListBox.DoubleClick += new System.EventHandler(this.interestedCustomersListBox_DoubleClick);
            // 
            // chassisNumLbl
            // 
            this.chassisNumLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chassisNumLbl.BackColor = System.Drawing.Color.White;
            this.chassisNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chassisNumLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chassisNumLbl.Location = new System.Drawing.Point(16, 27);
            this.chassisNumLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chassisNumLbl.Name = "chassisNumLbl";
            this.chassisNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chassisNumLbl.Size = new System.Drawing.Size(290, 24);
            this.chassisNumLbl.TabIndex = 12;
            this.toolTip.SetToolTip(this.chassisNumLbl, "Chassis Number");
            this.chassisNumLbl.ForeColorChanged += new System.EventHandler(this.engineNumLbl_Leave);
            this.chassisNumLbl.Leave += new System.EventHandler(this.chassisNumLbl_Leave);
            // 
            // colourLbl
            // 
            this.colourLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourLbl.BackColor = System.Drawing.Color.White;
            this.colourLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colourLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colourLbl.Location = new System.Drawing.Point(433, 48);
            this.colourLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colourLbl.Name = "colourLbl";
            this.colourLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colourLbl.Size = new System.Drawing.Size(124, 24);
            this.colourLbl.TabIndex = 12;
            this.toolTip.SetToolTip(this.colourLbl, "Colour of car");
            // 
            // addThisVehicle
            // 
            this.addThisVehicle.BackColor = System.Drawing.Color.Gold;
            this.addThisVehicle.FlatAppearance.BorderSize = 0;
            this.addThisVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addThisVehicle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addThisVehicle.Location = new System.Drawing.Point(57, 26);
            this.addThisVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addThisVehicle.Name = "addThisVehicle";
            this.addThisVehicle.Size = new System.Drawing.Size(272, 33);
            this.addThisVehicle.TabIndex = 17;
            this.addThisVehicle.Text = "+ Add Vehicle";
            this.toolTip.SetToolTip(this.addThisVehicle, "Add this vehicle to the database");
            this.addThisVehicle.UseVisualStyleBackColor = false;
            this.addThisVehicle.Click += new System.EventHandler(this.addThisVehicle_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteCustomerBtn.Enabled = false;
            this.deleteCustomerBtn.FlatAppearance.BorderSize = 0;
            this.deleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCustomerBtn.Image = global::Database_Application_Chris.Properties.Resources.bin_small;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(935, 26);
            this.deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(47, 33);
            this.deleteCustomerBtn.TabIndex = 17;
            this.toolTip.SetToolTip(this.deleteCustomerBtn, "Remove a customer from the vehicle\'s interested patrons list");
            this.deleteCustomerBtn.UseVisualStyleBackColor = false;
            this.deleteCustomerBtn.Visible = false;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L1.Location = new System.Drawing.Point(16, 9);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(103, 16);
            this.L1.TabIndex = 20;
            this.L1.Text = "Chassis Number: *";
            // 
            // L8
            // 
            this.L8.AutoSize = true;
            this.L8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L8.Location = new System.Drawing.Point(433, 30);
            this.L8.Name = "L8";
            this.L8.Size = new System.Drawing.Size(54, 16);
            this.L8.TabIndex = 20;
            this.L8.Text = "Colour: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customers Interested in this vehicle:";
            // 
            // makeLbl
            // 
            this.makeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeLbl.BackColor = System.Drawing.Color.White;
            this.makeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeLbl.Location = new System.Drawing.Point(16, 31);
            this.makeLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeLbl.Name = "makeLbl";
            this.makeLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.makeLbl.Size = new System.Drawing.Size(190, 24);
            this.makeLbl.TabIndex = 12;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L3.Location = new System.Drawing.Point(16, 13);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(50, 16);
            this.L3.TabIndex = 20;
            this.L3.Text = "Make: *";
            // 
            // modelLbl
            // 
            this.modelLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelLbl.BackColor = System.Drawing.Color.White;
            this.modelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelLbl.Location = new System.Drawing.Point(222, 31);
            this.modelLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modelLbl.Size = new System.Drawing.Size(190, 24);
            this.modelLbl.TabIndex = 12;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L4.Location = new System.Drawing.Point(222, 13);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(54, 16);
            this.L4.TabIndex = 20;
            this.L4.Text = "Model: *";
            // 
            // yearLbl
            // 
            this.yearLbl.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLbl.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.yearLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLbl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearLbl.Location = new System.Drawing.Point(433, 31);
            this.yearLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(124, 24);
            this.yearLbl.TabIndex = 21;
            this.yearLbl.Value = new System.DateTime(2021, 4, 18, 16, 42, 42, 0);
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L5.Location = new System.Drawing.Point(433, 13);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(44, 16);
            this.L5.TabIndex = 20;
            this.L5.Text = "Year: *";
            // 
            // valuationLbl
            // 
            this.valuationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valuationLbl.BackColor = System.Drawing.Color.White;
            this.valuationLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuationLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuationLbl.Location = new System.Drawing.Point(16, 48);
            this.valuationLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valuationLbl.Name = "valuationLbl";
            this.valuationLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valuationLbl.Size = new System.Drawing.Size(190, 24);
            this.valuationLbl.TabIndex = 12;
            this.valuationLbl.Leave += new System.EventHandler(this.valuationLbl_Leave);
            // 
            // L6
            // 
            this.L6.AutoSize = true;
            this.L6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L6.Location = new System.Drawing.Point(16, 30);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(114, 16);
            this.L6.TabIndex = 20;
            this.L6.Text = "Current Valuation: *";
            // 
            // askingPriceLbl
            // 
            this.askingPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.askingPriceLbl.BackColor = System.Drawing.Color.White;
            this.askingPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.askingPriceLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.askingPriceLbl.Location = new System.Drawing.Point(222, 48);
            this.askingPriceLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.askingPriceLbl.Name = "askingPriceLbl";
            this.askingPriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.askingPriceLbl.Size = new System.Drawing.Size(190, 24);
            this.askingPriceLbl.TabIndex = 12;
            this.askingPriceLbl.Leave += new System.EventHandler(this.askingPriceLbl_Leave);
            // 
            // L7
            // 
            this.L7.AutoSize = true;
            this.L7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L7.Location = new System.Drawing.Point(222, 30);
            this.L7.Name = "L7";
            this.L7.Size = new System.Drawing.Size(80, 16);
            this.L7.TabIndex = 20;
            this.L7.Text = "Asking Price: *";
            // 
            // ownerLbl
            // 
            this.ownerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerLbl.BackColor = System.Drawing.Color.White;
            this.ownerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ownerLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ownerLbl.Location = new System.Drawing.Point(7, 27);
            this.ownerLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerLbl.Name = "ownerLbl";
            this.ownerLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ownerLbl.Size = new System.Drawing.Size(224, 24);
            this.ownerLbl.TabIndex = 12;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L2.Location = new System.Drawing.Point(7, 9);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(47, 16);
            this.L2.TabIndex = 20;
            this.L2.Text = "Owner:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chassisNumLbl);
            this.panel2.Controls.Add(this.L1);
            this.panel2.Location = new System.Drawing.Point(39, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 68);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ownerLbl);
            this.panel3.Controls.Add(this.L2);
            this.panel3.Location = new System.Drawing.Point(365, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 68);
            this.panel3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-46, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current Valuation: *";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(160, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(190, 24);
            this.textBox1.TabIndex = 12;
            this.textBox1.Leave += new System.EventHandler(this.askingPriceLbl_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(-46, 290);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(190, 24);
            this.textBox2.TabIndex = 12;
            this.textBox2.Leave += new System.EventHandler(this.valuationLbl_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.askingPriceLbl);
            this.panel4.Controls.Add(this.L8);
            this.panel4.Controls.Add(this.L6);
            this.panel4.Controls.Add(this.L7);
            this.panel4.Controls.Add(this.colourLbl);
            this.panel4.Controls.Add(this.valuationLbl);
            this.panel4.Location = new System.Drawing.Point(39, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 84);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.yearLbl);
            this.panel5.Controls.Add(this.L3);
            this.panel5.Controls.Add(this.L4);
            this.panel5.Controls.Add(this.L5);
            this.panel5.Controls.Add(this.modelLbl);
            this.panel5.Controls.Add(this.makeLbl);
            this.panel5.Location = new System.Drawing.Point(39, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 73);
            this.panel5.TabIndex = 25;
            // 
            // FormButtonsSection
            // 
            this.FormButtonsSection.Controls.Add(this.addThisVehicle);
            this.FormButtonsSection.Controls.Add(this.updateVehicleBtn);
            this.FormButtonsSection.Controls.Add(this.deleteVehicleBtn);
            this.FormButtonsSection.Controls.Add(this.deleteCustomerBtn);
            this.FormButtonsSection.Controls.Add(this.addCustomerBtn);
            this.FormButtonsSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FormButtonsSection.Location = new System.Drawing.Point(0, 484);
            this.FormButtonsSection.Name = "FormButtonsSection";
            this.FormButtonsSection.Size = new System.Drawing.Size(1018, 110);
            this.FormButtonsSection.TabIndex = 26;
            // 
            // InterestedCustomersPanel
            // 
            this.InterestedCustomersPanel.Controls.Add(this.panel6);
            this.InterestedCustomersPanel.Controls.Add(this.label3);
            this.InterestedCustomersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InterestedCustomersPanel.Location = new System.Drawing.Point(718, 47);
            this.InterestedCustomersPanel.Name = "InterestedCustomersPanel";
            this.InterestedCustomersPanel.Size = new System.Drawing.Size(300, 437);
            this.InterestedCustomersPanel.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.interestedCustomersListBox);
            this.panel6.Location = new System.Drawing.Point(2, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 375);
            this.panel6.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(718, 437);
            this.panel7.TabIndex = 28;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.InterestedCustomersPanel);
            this.Controls.Add(this.FormButtonsSection);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vehicle";
            this.Size = new System.Drawing.Size(1018, 594);
            this.Click += new System.EventHandler(this.Vehicle_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.FormButtonsSection.ResumeLayout(false);
            this.InterestedCustomersPanel.ResumeLayout(false);
            this.InterestedCustomersPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox engineNumLbl;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button deleteVehicleBtn;
        private System.Windows.Forms.Button updateVehicleBtn;
        private System.Windows.Forms.ListBox interestedCustomersListBox;
        private System.Windows.Forms.TextBox chassisNumLbl;
        private System.Windows.Forms.TextBox colourLbl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button addThisVehicle;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox makeLbl;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.TextBox modelLbl;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.DateTimePicker yearLbl;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.TextBox valuationLbl;
        private System.Windows.Forms.Label L6;
        private System.Windows.Forms.TextBox askingPriceLbl;
        private System.Windows.Forms.Label L7;
        private System.Windows.Forms.TextBox ownerLbl;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel FormButtonsSection;
        private System.Windows.Forms.Panel InterestedCustomersPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}
