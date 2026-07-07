
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            engineNumLbl = new System.Windows.Forms.TextBox();
            addCustomerBtn = new System.Windows.Forms.Button();
            deleteVehicleBtn = new System.Windows.Forms.Button();
            updateVehicleBtn = new System.Windows.Forms.Button();
            interestedCustomersListBox = new System.Windows.Forms.ListBox();
            chassisNumLbl = new System.Windows.Forms.TextBox();
            colourLbl = new System.Windows.Forms.TextBox();
            toolTip = new System.Windows.Forms.ToolTip(components);
            addThisVehicle = new System.Windows.Forms.Button();
            deleteCustomerBtn = new System.Windows.Forms.Button();
            imageOfCar = new System.Windows.Forms.PictureBox();
            L1 = new System.Windows.Forms.Label();
            L8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            makeLbl = new System.Windows.Forms.TextBox();
            L3 = new System.Windows.Forms.Label();
            modelLbl = new System.Windows.Forms.TextBox();
            L4 = new System.Windows.Forms.Label();
            yearLbl = new System.Windows.Forms.DateTimePicker();
            L5 = new System.Windows.Forms.Label();
            valuationLbl = new System.Windows.Forms.TextBox();
            L6 = new System.Windows.Forms.Label();
            askingPriceLbl = new System.Windows.Forms.TextBox();
            L7 = new System.Windows.Forms.Label();
            ownerLbl = new System.Windows.Forms.TextBox();
            L2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            FormButtonsSection = new System.Windows.Forms.Panel();
            viewErrors = new System.Windows.Forms.Button();
            InterestedCustomersPanel = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            panel12 = new System.Windows.Forms.Panel();
            panel13 = new System.Windows.Forms.Panel();
            panel15 = new System.Windows.Forms.Panel();
            location = new System.Windows.Forms.Label();
            panel14 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            agentCombo = new System.Windows.Forms.ComboBox();
            additionalCommentsLbl = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageOfCar).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            FormButtonsSection.SuspendLayout();
            InterestedCustomersPanel.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gold;
            panel1.Controls.Add(engineNumLbl);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1018, 47);
            panel1.TabIndex = 6;
            // 
            // engineNumLbl
            // 
            engineNumLbl.BackColor = System.Drawing.Color.Gold;
            engineNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            engineNumLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            engineNumLbl.Location = new System.Drawing.Point(55, 12);
            engineNumLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            engineNumLbl.Name = "engineNumLbl";
            engineNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            engineNumLbl.Size = new System.Drawing.Size(558, 23);
            engineNumLbl.TabIndex = 1;
            toolTip.SetToolTip(engineNumLbl, "Engine Number");
            engineNumLbl.Leave += engineNumLbl_Leave;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addCustomerBtn.BackColor = System.Drawing.Color.Gold;
            addCustomerBtn.Enabled = false;
            addCustomerBtn.FlatAppearance.BorderSize = 0;
            addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            addCustomerBtn.Location = new System.Drawing.Point(739, 26);
            addCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new System.Drawing.Size(190, 33);
            addCustomerBtn.TabIndex = 17;
            addCustomerBtn.Text = "+";
            toolTip.SetToolTip(addCustomerBtn, "Add an interested customer");
            addCustomerBtn.UseVisualStyleBackColor = false;
            addCustomerBtn.Visible = false;
            // 
            // deleteVehicleBtn
            // 
            deleteVehicleBtn.BackColor = System.Drawing.Color.Gold;
            deleteVehicleBtn.FlatAppearance.BorderSize = 0;
            deleteVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            deleteVehicleBtn.Location = new System.Drawing.Point(57, 26);
            deleteVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteVehicleBtn.Name = "deleteVehicleBtn";
            deleteVehicleBtn.Size = new System.Drawing.Size(130, 33);
            deleteVehicleBtn.TabIndex = 18;
            deleteVehicleBtn.Text = "🗑️ Delete";
            deleteVehicleBtn.UseVisualStyleBackColor = false;
            deleteVehicleBtn.Click += deleteVehicleBtn_Click;
            // 
            // updateVehicleBtn
            // 
            updateVehicleBtn.BackColor = System.Drawing.Color.Gold;
            updateVehicleBtn.Enabled = false;
            updateVehicleBtn.FlatAppearance.BorderSize = 0;
            updateVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            updateVehicleBtn.Location = new System.Drawing.Point(197, 26);
            updateVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            updateVehicleBtn.Name = "updateVehicleBtn";
            updateVehicleBtn.Size = new System.Drawing.Size(130, 33);
            updateVehicleBtn.TabIndex = 19;
            updateVehicleBtn.Text = "↻ Update";
            updateVehicleBtn.UseVisualStyleBackColor = false;
            updateVehicleBtn.Visible = false;
            updateVehicleBtn.Click += updateVehicleBtn_Click;
            // 
            // interestedCustomersListBox
            // 
            interestedCustomersListBox.Dock = System.Windows.Forms.DockStyle.Right;
            interestedCustomersListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            interestedCustomersListBox.FormattingEnabled = true;
            interestedCustomersListBox.ItemHeight = 19;
            interestedCustomersListBox.Location = new System.Drawing.Point(24, 0);
            interestedCustomersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            interestedCustomersListBox.Name = "interestedCustomersListBox";
            interestedCustomersListBox.Size = new System.Drawing.Size(243, 416);
            interestedCustomersListBox.TabIndex = 13;
            toolTip.SetToolTip(interestedCustomersListBox, "List of interested customers");
            interestedCustomersListBox.DoubleClick += interestedCustomersListBox_DoubleClick;
            // 
            // chassisNumLbl
            // 
            chassisNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chassisNumLbl.BackColor = System.Drawing.Color.White;
            chassisNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            chassisNumLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            chassisNumLbl.Location = new System.Drawing.Point(16, 27);
            chassisNumLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chassisNumLbl.Name = "chassisNumLbl";
            chassisNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chassisNumLbl.Size = new System.Drawing.Size(290, 24);
            chassisNumLbl.TabIndex = 12;
            toolTip.SetToolTip(chassisNumLbl, "Chassis Number");
            chassisNumLbl.ForeColorChanged += engineNumLbl_Leave;
            chassisNumLbl.Leave += chassisNumLbl_Leave;
            // 
            // colourLbl
            // 
            colourLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            colourLbl.BackColor = System.Drawing.Color.White;
            colourLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            colourLbl.Location = new System.Drawing.Point(433, 48);
            colourLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            colourLbl.Name = "colourLbl";
            colourLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            colourLbl.Size = new System.Drawing.Size(124, 24);
            colourLbl.TabIndex = 12;
            toolTip.SetToolTip(colourLbl, "Colour of car");
            colourLbl.Leave += colourLbl_Leave_1;
            // 
            // addThisVehicle
            // 
            addThisVehicle.BackColor = System.Drawing.Color.Gold;
            addThisVehicle.FlatAppearance.BorderSize = 0;
            addThisVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addThisVehicle.Font = new System.Drawing.Font("Century Gothic", 9F);
            addThisVehicle.Location = new System.Drawing.Point(57, 26);
            addThisVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addThisVehicle.Name = "addThisVehicle";
            addThisVehicle.Size = new System.Drawing.Size(272, 33);
            addThisVehicle.TabIndex = 17;
            addThisVehicle.Text = "+ Add Vehicle";
            toolTip.SetToolTip(addThisVehicle, "Add this vehicle to the database");
            addThisVehicle.UseVisualStyleBackColor = false;
            addThisVehicle.Click += addThisVehicle_Click;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            deleteCustomerBtn.BackColor = System.Drawing.Color.Gold;
            deleteCustomerBtn.Enabled = false;
            deleteCustomerBtn.FlatAppearance.BorderSize = 0;
            deleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            deleteCustomerBtn.Image = Properties.Resources.bin_small;
            deleteCustomerBtn.Location = new System.Drawing.Point(935, 26);
            deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new System.Drawing.Size(47, 33);
            deleteCustomerBtn.TabIndex = 17;
            toolTip.SetToolTip(deleteCustomerBtn, "Remove a customer from the vehicle's interested patrons list");
            deleteCustomerBtn.UseVisualStyleBackColor = false;
            deleteCustomerBtn.Visible = false;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // imageOfCar
            // 
            imageOfCar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            imageOfCar.BackColor = System.Drawing.SystemColors.Control;
            imageOfCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            imageOfCar.InitialImage = Properties.Resources.missingcar;
            imageOfCar.Location = new System.Drawing.Point(0, 22);
            imageOfCar.Name = "imageOfCar";
            imageOfCar.Size = new System.Drawing.Size(202, 120);
            imageOfCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imageOfCar.TabIndex = 28;
            imageOfCar.TabStop = false;
            toolTip.SetToolTip(imageOfCar, "Double click to edit, Middle Mouse button to expand, Right click to clear");
            imageOfCar.DoubleClick += imageOfCar_DoubleClick;
            imageOfCar.MouseClick += imageOfCar_MouseClick;
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L1.Location = new System.Drawing.Point(16, 9);
            L1.Name = "L1";
            L1.Size = new System.Drawing.Size(103, 16);
            L1.TabIndex = 20;
            L1.Text = "Chassis Number: *";
            // 
            // L8
            // 
            L8.AutoSize = true;
            L8.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L8.Location = new System.Drawing.Point(433, 30);
            L8.Name = "L8";
            L8.Size = new System.Drawing.Size(54, 16);
            L8.TabIndex = 20;
            L8.Text = "Colour: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label3.Location = new System.Drawing.Point(29, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 16);
            label3.TabIndex = 20;
            label3.Text = "Customers Interested in this vehicle:";
            // 
            // makeLbl
            // 
            makeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            makeLbl.BackColor = System.Drawing.Color.White;
            makeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            makeLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            makeLbl.Location = new System.Drawing.Point(16, 31);
            makeLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            makeLbl.Name = "makeLbl";
            makeLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            makeLbl.Size = new System.Drawing.Size(190, 24);
            makeLbl.TabIndex = 12;
            makeLbl.Leave += makeLbl_Leave;
            // 
            // L3
            // 
            L3.AutoSize = true;
            L3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L3.Location = new System.Drawing.Point(16, 13);
            L3.Name = "L3";
            L3.Size = new System.Drawing.Size(50, 16);
            L3.TabIndex = 20;
            L3.Text = "Make: *";
            // 
            // modelLbl
            // 
            modelLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            modelLbl.BackColor = System.Drawing.Color.White;
            modelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            modelLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            modelLbl.Location = new System.Drawing.Point(222, 31);
            modelLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modelLbl.Name = "modelLbl";
            modelLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            modelLbl.Size = new System.Drawing.Size(190, 24);
            modelLbl.TabIndex = 12;
            modelLbl.Leave += modelLbl_Leave;
            // 
            // L4
            // 
            L4.AutoSize = true;
            L4.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L4.Location = new System.Drawing.Point(222, 13);
            L4.Name = "L4";
            L4.Size = new System.Drawing.Size(54, 16);
            L4.TabIndex = 20;
            L4.Text = "Model: *";
            // 
            // yearLbl
            // 
            yearLbl.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F);
            yearLbl.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            yearLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            yearLbl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            yearLbl.Location = new System.Drawing.Point(433, 31);
            yearLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            yearLbl.Name = "yearLbl";
            yearLbl.Size = new System.Drawing.Size(124, 24);
            yearLbl.TabIndex = 21;
            yearLbl.Value = new System.DateTime(2021, 4, 18, 16, 42, 42, 0);
            // 
            // L5
            // 
            L5.AutoSize = true;
            L5.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L5.Location = new System.Drawing.Point(433, 13);
            L5.Name = "L5";
            L5.Size = new System.Drawing.Size(44, 16);
            L5.TabIndex = 20;
            L5.Text = "Year: *";
            // 
            // valuationLbl
            // 
            valuationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            valuationLbl.BackColor = System.Drawing.Color.White;
            valuationLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            valuationLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            valuationLbl.Location = new System.Drawing.Point(16, 48);
            valuationLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            valuationLbl.Name = "valuationLbl";
            valuationLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            valuationLbl.Size = new System.Drawing.Size(190, 24);
            valuationLbl.TabIndex = 12;
            valuationLbl.Leave += valuationLbl_Leave;
            // 
            // L6
            // 
            L6.AutoSize = true;
            L6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L6.Location = new System.Drawing.Point(16, 30);
            L6.Name = "L6";
            L6.Size = new System.Drawing.Size(114, 16);
            L6.TabIndex = 20;
            L6.Text = "Current Valuation: *";
            // 
            // askingPriceLbl
            // 
            askingPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            askingPriceLbl.BackColor = System.Drawing.Color.White;
            askingPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            askingPriceLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            askingPriceLbl.Location = new System.Drawing.Point(222, 48);
            askingPriceLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            askingPriceLbl.Name = "askingPriceLbl";
            askingPriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            askingPriceLbl.Size = new System.Drawing.Size(190, 24);
            askingPriceLbl.TabIndex = 12;
            askingPriceLbl.Leave += askingPriceLbl_Leave;
            // 
            // L7
            // 
            L7.AutoSize = true;
            L7.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L7.Location = new System.Drawing.Point(222, 30);
            L7.Name = "L7";
            L7.Size = new System.Drawing.Size(80, 16);
            L7.TabIndex = 20;
            L7.Text = "Asking Price: *";
            // 
            // ownerLbl
            // 
            ownerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ownerLbl.BackColor = System.Drawing.Color.White;
            ownerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ownerLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            ownerLbl.Location = new System.Drawing.Point(7, 27);
            ownerLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ownerLbl.Name = "ownerLbl";
            ownerLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ownerLbl.Size = new System.Drawing.Size(224, 24);
            ownerLbl.TabIndex = 12;
            // 
            // L2
            // 
            L2.AutoSize = true;
            L2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            L2.Location = new System.Drawing.Point(7, 9);
            L2.Name = "L2";
            L2.Size = new System.Drawing.Size(47, 16);
            L2.TabIndex = 20;
            L2.Text = "Owner:";
            // 
            // panel2
            // 
            panel2.Controls.Add(chassisNumLbl);
            panel2.Controls.Add(L1);
            panel2.Location = new System.Drawing.Point(39, 31);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(320, 68);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(ownerLbl);
            panel3.Controls.Add(L2);
            panel3.Location = new System.Drawing.Point(365, 31);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(248, 68);
            panel3.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label1.Location = new System.Drawing.Point(-46, 274);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 16);
            label1.TabIndex = 20;
            label1.Text = "Current Valuation: *";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            textBox1.Location = new System.Drawing.Point(160, 290);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(190, 24);
            textBox1.TabIndex = 12;
            textBox1.Leave += askingPriceLbl_Leave;
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBox2.BackColor = System.Drawing.Color.White;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            textBox2.Location = new System.Drawing.Point(-46, 290);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox2.Size = new System.Drawing.Size(190, 24);
            textBox2.TabIndex = 12;
            textBox2.Leave += valuationLbl_Leave;
            // 
            // panel4
            // 
            panel4.Controls.Add(askingPriceLbl);
            panel4.Controls.Add(L8);
            panel4.Controls.Add(L6);
            panel4.Controls.Add(L7);
            panel4.Controls.Add(colourLbl);
            panel4.Controls.Add(valuationLbl);
            panel4.Location = new System.Drawing.Point(39, 204);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(574, 84);
            panel4.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.Controls.Add(yearLbl);
            panel5.Controls.Add(L3);
            panel5.Controls.Add(L4);
            panel5.Controls.Add(L5);
            panel5.Controls.Add(modelLbl);
            panel5.Controls.Add(makeLbl);
            panel5.Location = new System.Drawing.Point(39, 120);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(574, 73);
            panel5.TabIndex = 25;
            // 
            // FormButtonsSection
            // 
            FormButtonsSection.Controls.Add(viewErrors);
            FormButtonsSection.Controls.Add(addThisVehicle);
            FormButtonsSection.Controls.Add(updateVehicleBtn);
            FormButtonsSection.Controls.Add(deleteVehicleBtn);
            FormButtonsSection.Controls.Add(deleteCustomerBtn);
            FormButtonsSection.Controls.Add(addCustomerBtn);
            FormButtonsSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            FormButtonsSection.Location = new System.Drawing.Point(0, 503);
            FormButtonsSection.Name = "FormButtonsSection";
            FormButtonsSection.Size = new System.Drawing.Size(1018, 91);
            FormButtonsSection.TabIndex = 26;
            // 
            // viewErrors
            // 
            viewErrors.BackColor = System.Drawing.Color.Red;
            viewErrors.Enabled = false;
            viewErrors.FlatAppearance.BorderSize = 0;
            viewErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            viewErrors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            viewErrors.ForeColor = System.Drawing.Color.White;
            viewErrors.Location = new System.Drawing.Point(350, 26);
            viewErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewErrors.Name = "viewErrors";
            viewErrors.Size = new System.Drawing.Size(130, 33);
            viewErrors.TabIndex = 20;
            viewErrors.Text = "View Errors";
            viewErrors.UseVisualStyleBackColor = false;
            viewErrors.Visible = false;
            viewErrors.Click += viewErrors_Click;
            // 
            // InterestedCustomersPanel
            // 
            InterestedCustomersPanel.Controls.Add(panel6);
            InterestedCustomersPanel.Controls.Add(label3);
            InterestedCustomersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            InterestedCustomersPanel.Location = new System.Drawing.Point(718, 47);
            InterestedCustomersPanel.Name = "InterestedCustomersPanel";
            InterestedCustomersPanel.Size = new System.Drawing.Size(300, 456);
            InterestedCustomersPanel.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            panel6.AutoSize = true;
            panel6.Controls.Add(interestedCustomersListBox);
            panel6.Location = new System.Drawing.Point(2, 40);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(267, 416);
            panel6.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(panel12);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel2);
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            panel7.Location = new System.Drawing.Point(0, 47);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(718, 456);
            panel7.TabIndex = 28;
            // 
            // panel12
            // 
            panel12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(panel9);
            panel12.Location = new System.Drawing.Point(0, 294);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(718, 162);
            panel12.TabIndex = 32;
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel14);
            panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            panel13.Location = new System.Drawing.Point(469, 0);
            panel13.Name = "panel13";
            panel13.Size = new System.Drawing.Size(249, 162);
            panel13.TabIndex = 32;
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.White;
            panel15.Controls.Add(location);
            panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel15.Location = new System.Drawing.Point(0, 143);
            panel15.Name = "panel15";
            panel15.Size = new System.Drawing.Size(249, 19);
            panel15.TabIndex = 31;
            // 
            // location
            // 
            location.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            location.AutoSize = true;
            location.Location = new System.Drawing.Point(4, 4);
            location.MaximumSize = new System.Drawing.Size(175, 0);
            location.Name = "location";
            location.Size = new System.Drawing.Size(12, 15);
            location.TabIndex = 30;
            location.Text = "-";
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.Color.White;
            panel14.Controls.Add(imageOfCar);
            panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            panel14.Location = new System.Drawing.Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new System.Drawing.Size(249, 162);
            panel14.TabIndex = 29;
            // 
            // panel9
            // 
            panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel9.BackColor = System.Drawing.Color.White;
            panel9.Controls.Add(label2);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(agentCombo);
            panel9.Controls.Add(additionalCommentsLbl);
            panel9.Dock = System.Windows.Forms.DockStyle.Left;
            panel9.Location = new System.Drawing.Point(0, 0);
            panel9.MaximumSize = new System.Drawing.Size(600, 0);
            panel9.MinimumSize = new System.Drawing.Size(469, 155);
            panel9.Name = "panel9";
            panel9.Padding = new System.Windows.Forms.Padding(10);
            panel9.Size = new System.Drawing.Size(469, 162);
            panel9.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(55, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 22;
            label2.Text = "Agent";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label6.Location = new System.Drawing.Point(55, 4);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 16);
            label6.TabIndex = 26;
            label6.Text = "Additional Comments:";
            // 
            // agentCombo
            // 
            agentCombo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            agentCombo.FormattingEnabled = true;
            agentCombo.Location = new System.Drawing.Point(57, 126);
            agentCombo.Name = "agentCombo";
            agentCombo.Size = new System.Drawing.Size(394, 23);
            agentCombo.TabIndex = 21;
            // 
            // additionalCommentsLbl
            // 
            additionalCommentsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            additionalCommentsLbl.Location = new System.Drawing.Point(55, 22);
            additionalCommentsLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            additionalCommentsLbl.MinimumSize = new System.Drawing.Size(396, 4);
            additionalCommentsLbl.Multiline = true;
            additionalCommentsLbl.Name = "additionalCommentsLbl";
            additionalCommentsLbl.Size = new System.Drawing.Size(396, 82);
            additionalCommentsLbl.TabIndex = 27;
            // 
            // Vehicle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(InterestedCustomersPanel);
            Controls.Add(FormButtonsSection);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Vehicle";
            Size = new System.Drawing.Size(1018, 594);
            Click += Vehicle_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageOfCar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            FormButtonsSection.ResumeLayout(false);
            InterestedCustomersPanel.ResumeLayout(false);
            InterestedCustomersPanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button viewErrors;
        private System.Windows.Forms.TextBox additionalCommentsLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imageOfCar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox agentCombo;
    }
}
