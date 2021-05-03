
namespace Database_Application_Chris
{
    partial class Customer
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
            this.nameLbl = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.TextBox();
            this.num1Lbl = new System.Windows.Forms.TextBox();
            this.num2Lbl = new System.Windows.Forms.TextBox();
            this.email2Lbl = new System.Windows.Forms.TextBox();
            this.email1Lbl = new System.Windows.Forms.TextBox();
            this.interestedVehiclesListBox = new System.Windows.Forms.ListBox();
            this.inProgressCheckbox = new System.Windows.Forms.CheckBox();
            this.callBackCheckbox = new System.Windows.Forms.CheckBox();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.addThisCustomer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeVehicleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.additionalCommentsLbl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewErrors = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 46);
            this.panel1.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.BackColor = System.Drawing.Color.Gold;
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(62, 11);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(578, 24);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Leave += new System.EventHandler(this.nameLbl_Leave);
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLbl.BackColor = System.Drawing.Color.White;
            this.addressLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(63, 107);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLbl.Size = new System.Drawing.Size(645, 22);
            this.addressLbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.addressLbl, "Address");
            this.addressLbl.ForeColorChanged += new System.EventHandler(this.addressLbl_ForeColorChanged);
            this.addressLbl.Leave += new System.EventHandler(this.addressLbl_Leave);
            // 
            // num1Lbl
            // 
            this.num1Lbl.BackColor = System.Drawing.Color.White;
            this.num1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1Lbl.Location = new System.Drawing.Point(63, 169);
            this.num1Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num1Lbl.Size = new System.Drawing.Size(268, 22);
            this.num1Lbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.num1Lbl, "Primary number");
            this.num1Lbl.ForeColorChanged += new System.EventHandler(this.num1Lbl_ForeColorChanged);
            this.num1Lbl.Leave += new System.EventHandler(this.num1Lbl_Leave);
            // 
            // num2Lbl
            // 
            this.num2Lbl.BackColor = System.Drawing.Color.White;
            this.num2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2Lbl.Location = new System.Drawing.Point(358, 169);
            this.num2Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num2Lbl.Size = new System.Drawing.Size(268, 22);
            this.num2Lbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.num2Lbl, "Secondary number");
            this.num2Lbl.ForeColorChanged += new System.EventHandler(this.num2Lbl_ForeColorChanged);
            this.num2Lbl.Leave += new System.EventHandler(this.num2Lbl_Leave);
            // 
            // email2Lbl
            // 
            this.email2Lbl.BackColor = System.Drawing.Color.White;
            this.email2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email2Lbl.Location = new System.Drawing.Point(358, 230);
            this.email2Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email2Lbl.Name = "email2Lbl";
            this.email2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email2Lbl.Size = new System.Drawing.Size(268, 22);
            this.email2Lbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.email2Lbl, "Secondary email");
            this.email2Lbl.ForeColorChanged += new System.EventHandler(this.email2Lbl_ForeColorChanged);
            this.email2Lbl.Leave += new System.EventHandler(this.email2Lbl_Leave);
            // 
            // email1Lbl
            // 
            this.email1Lbl.BackColor = System.Drawing.Color.White;
            this.email1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email1Lbl.Location = new System.Drawing.Point(63, 230);
            this.email1Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email1Lbl.Name = "email1Lbl";
            this.email1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email1Lbl.Size = new System.Drawing.Size(268, 22);
            this.email1Lbl.TabIndex = 1;
            this.toolTip.SetToolTip(this.email1Lbl, "Primary email");
            this.email1Lbl.ForeColorChanged += new System.EventHandler(this.email1Lbl_ForeColorChanged);
            this.email1Lbl.Leave += new System.EventHandler(this.email1Lbl_Leave);
            // 
            // interestedVehiclesListBox
            // 
            this.interestedVehiclesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestedVehiclesListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interestedVehiclesListBox.FormattingEnabled = true;
            this.interestedVehiclesListBox.ItemHeight = 19;
            this.interestedVehiclesListBox.Location = new System.Drawing.Point(24, 0);
            this.interestedVehiclesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interestedVehiclesListBox.Name = "interestedVehiclesListBox";
            this.interestedVehiclesListBox.Size = new System.Drawing.Size(237, 403);
            this.interestedVehiclesListBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.interestedVehiclesListBox, "List of vehicle\'s this customer is interested in");
            this.interestedVehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.interestedVehiclesListBox_SelectedIndexChanged);
            this.interestedVehiclesListBox.DoubleClick += new System.EventHandler(this.interestedVehiclesListBox_DoubleClick);
            // 
            // inProgressCheckbox
            // 
            this.inProgressCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inProgressCheckbox.AutoSize = true;
            this.inProgressCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inProgressCheckbox.Location = new System.Drawing.Point(119, 18);
            this.inProgressCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inProgressCheckbox.Name = "inProgressCheckbox";
            this.inProgressCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inProgressCheckbox.Size = new System.Drawing.Size(147, 23);
            this.inProgressCheckbox.TabIndex = 4;
            this.inProgressCheckbox.Text = "Currently Seeking";
            this.toolTip.SetToolTip(this.inProgressCheckbox, "Indicate if the customer is currently doing business");
            this.inProgressCheckbox.UseVisualStyleBackColor = true;
            this.inProgressCheckbox.CheckedChanged += new System.EventHandler(this.inProgressCheckbox_CheckedChanged);
            // 
            // callBackCheckbox
            // 
            this.callBackCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.callBackCheckbox.AutoSize = true;
            this.callBackCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callBackCheckbox.Location = new System.Drawing.Point(172, 40);
            this.callBackCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.callBackCheckbox.Name = "callBackCheckbox";
            this.callBackCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.callBackCheckbox.Size = new System.Drawing.Size(95, 23);
            this.callBackCheckbox.TabIndex = 4;
            this.callBackCheckbox.Text = "Call back";
            this.toolTip.SetToolTip(this.callBackCheckbox, "Indicate if the customer is to be called back");
            this.callBackCheckbox.UseVisualStyleBackColor = true;
            this.callBackCheckbox.CheckedChanged += new System.EventHandler(this.callBackCheckbox_CheckedChanged);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.updateCustomerBtn.Enabled = false;
            this.updateCustomerBtn.FlatAppearance.BorderSize = 0;
            this.updateCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCustomerBtn.Location = new System.Drawing.Point(205, 14);
            this.updateCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(130, 33);
            this.updateCustomerBtn.TabIndex = 5;
            this.updateCustomerBtn.Text = "↻ Update";
            this.updateCustomerBtn.UseVisualStyleBackColor = false;
            this.updateCustomerBtn.Visible = false;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteCustomerBtn.FlatAppearance.BorderSize = 0;
            this.deleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCustomerBtn.Location = new System.Drawing.Point(62, 14);
            this.deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(130, 33);
            this.deleteCustomerBtn.TabIndex = 5;
            this.deleteCustomerBtn.Text = "🗑️ Delete";
            this.deleteCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteCustomerBtn.UseVisualStyleBackColor = false;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.addVehicleBtn.FlatAppearance.BorderSize = 0;
            this.addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addVehicleBtn.Location = new System.Drawing.Point(739, 14);
            this.addVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(190, 33);
            this.addVehicleBtn.TabIndex = 5;
            this.addVehicleBtn.Text = "+  ";
            this.toolTip.SetToolTip(this.addVehicleBtn, "Add a vehicle which the customer is interested in");
            this.addVehicleBtn.UseVisualStyleBackColor = false;
            this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleInterest_Click);
            // 
            // addThisCustomer
            // 
            this.addThisCustomer.BackColor = System.Drawing.Color.Gold;
            this.addThisCustomer.Enabled = false;
            this.addThisCustomer.FlatAppearance.BorderSize = 0;
            this.addThisCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addThisCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addThisCustomer.Location = new System.Drawing.Point(62, 14);
            this.addThisCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addThisCustomer.Name = "addThisCustomer";
            this.addThisCustomer.Size = new System.Drawing.Size(272, 33);
            this.addThisCustomer.TabIndex = 5;
            this.addThisCustomer.Text = "+ Add Customer";
            this.toolTip.SetToolTip(this.addThisCustomer, "Add this customer to the database");
            this.addThisCustomer.UseVisualStyleBackColor = false;
            this.addThisCustomer.Visible = false;
            this.addThisCustomer.Click += new System.EventHandler(this.addThisCustomer_Click);
            // 
            // removeVehicleBtn
            // 
            this.removeVehicleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.removeVehicleBtn.FlatAppearance.BorderSize = 0;
            this.removeVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeVehicleBtn.Image = global::Database_Application_Chris.Properties.Resources.bin_small;
            this.removeVehicleBtn.Location = new System.Drawing.Point(934, 14);
            this.removeVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeVehicleBtn.Name = "removeVehicleBtn";
            this.removeVehicleBtn.Size = new System.Drawing.Size(47, 33);
            this.removeVehicleBtn.TabIndex = 5;
            this.toolTip.SetToolTip(this.removeVehicleBtn, "Delete a vehicle from the interested list");
            this.removeVehicleBtn.UseVisualStyleBackColor = false;
            this.removeVehicleBtn.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primary Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(358, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secondary Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primary Email Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(358, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Secondary Email Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Additional Comments:";
            // 
            // additionalCommentsLbl
            // 
            this.additionalCommentsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalCommentsLbl.Location = new System.Drawing.Point(63, 292);
            this.additionalCommentsLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.additionalCommentsLbl.Multiline = true;
            this.additionalCommentsLbl.Name = "additionalCommentsLbl";
            this.additionalCommentsLbl.Size = new System.Drawing.Size(645, 220);
            this.additionalCommentsLbl.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interested in:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewErrors);
            this.panel2.Controls.Add(this.addVehicleBtn);
            this.panel2.Controls.Add(this.removeVehicleBtn);
            this.panel2.Controls.Add(this.addThisCustomer);
            this.panel2.Controls.Add(this.updateCustomerBtn);
            this.panel2.Controls.Add(this.deleteCustomerBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 74);
            this.panel2.TabIndex = 8;
            // 
            // viewErrors
            // 
            this.viewErrors.BackColor = System.Drawing.Color.Red;
            this.viewErrors.Enabled = false;
            this.viewErrors.FlatAppearance.BorderSize = 0;
            this.viewErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewErrors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewErrors.ForeColor = System.Drawing.Color.White;
            this.viewErrors.Location = new System.Drawing.Point(358, 14);
            this.viewErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewErrors.Name = "viewErrors";
            this.viewErrors.Size = new System.Drawing.Size(130, 33);
            this.viewErrors.TabIndex = 5;
            this.viewErrors.Text = "View Errors";
            this.viewErrors.UseVisualStyleBackColor = false;
            this.viewErrors.Visible = false;
            this.viewErrors.Click += new System.EventHandler(this.viewErrors_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.inProgressCheckbox);
            this.panel3.Controls.Add(this.callBackCheckbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(717, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 520);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.interestedVehiclesListBox);
            this.panel4.Location = new System.Drawing.Point(6, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 408);
            this.panel4.TabIndex = 7;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.num1Lbl);
            this.Controls.Add(this.num2Lbl);
            this.Controls.Add(this.email1Lbl);
            this.Controls.Add(this.email2Lbl);
            this.Controls.Add(this.additionalCommentsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1018, 594);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addressLbl;
        private System.Windows.Forms.TextBox num1Lbl;
        private System.Windows.Forms.TextBox num2Lbl;
        private System.Windows.Forms.TextBox email2Lbl;
        private System.Windows.Forms.TextBox email1Lbl;
        private System.Windows.Forms.ListBox interestedVehiclesListBox;
        private System.Windows.Forms.CheckBox inProgressCheckbox;
        private System.Windows.Forms.CheckBox callBackCheckbox;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Button addThisCustomer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button removeVehicleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox additionalCommentsLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox nameLbl;
        private System.Windows.Forms.Button viewErrors;
    }
}
