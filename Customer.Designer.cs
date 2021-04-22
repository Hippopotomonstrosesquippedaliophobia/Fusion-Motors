
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 62);
            this.panel1.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.BackColor = System.Drawing.Color.Gold;
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(30, 17);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLbl.Size = new System.Drawing.Size(660, 29);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "James Bond";
            this.nameLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.nameLbl, "Customer\'s name ");
            this.nameLbl.Leave += new System.EventHandler(this.nameLbl_Leave);
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLbl.BackColor = System.Drawing.Color.White;
            this.addressLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(72, 143);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLbl.Size = new System.Drawing.Size(643, 26);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Lot # 555 Test Hill, St. James, Barbados";
            this.toolTip.SetToolTip(this.addressLbl, "Address");
            this.addressLbl.ForeColorChanged += new System.EventHandler(this.addressLbl_ForeColorChanged);
            this.addressLbl.Leave += new System.EventHandler(this.addressLbl_Leave);
            // 
            // num1Lbl
            // 
            this.num1Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num1Lbl.BackColor = System.Drawing.Color.White;
            this.num1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1Lbl.Location = new System.Drawing.Point(72, 225);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num1Lbl.Size = new System.Drawing.Size(306, 26);
            this.num1Lbl.TabIndex = 1;
            this.num1Lbl.Text = "555-5555";
            this.toolTip.SetToolTip(this.num1Lbl, "Primary number");
            this.num1Lbl.ForeColorChanged += new System.EventHandler(this.num1Lbl_ForeColorChanged);
            this.num1Lbl.Leave += new System.EventHandler(this.num1Lbl_Leave);
            // 
            // num2Lbl
            // 
            this.num2Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num2Lbl.BackColor = System.Drawing.Color.White;
            this.num2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2Lbl.Location = new System.Drawing.Point(409, 225);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num2Lbl.Size = new System.Drawing.Size(306, 26);
            this.num2Lbl.TabIndex = 1;
            this.num2Lbl.Text = "555-5555";
            this.toolTip.SetToolTip(this.num2Lbl, "Secondary number");
            this.num2Lbl.ForeColorChanged += new System.EventHandler(this.num2Lbl_ForeColorChanged);
            this.num2Lbl.Leave += new System.EventHandler(this.num2Lbl_Leave);
            // 
            // email2Lbl
            // 
            this.email2Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.email2Lbl.BackColor = System.Drawing.Color.White;
            this.email2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email2Lbl.Location = new System.Drawing.Point(409, 307);
            this.email2Lbl.Name = "email2Lbl";
            this.email2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email2Lbl.Size = new System.Drawing.Size(306, 26);
            this.email2Lbl.TabIndex = 1;
            this.email2Lbl.Text = "testeremail@outlook.com";
            this.toolTip.SetToolTip(this.email2Lbl, "Secondary email");
            this.email2Lbl.ForeColorChanged += new System.EventHandler(this.email2Lbl_ForeColorChanged);
            this.email2Lbl.Leave += new System.EventHandler(this.email2Lbl_Leave);
            // 
            // email1Lbl
            // 
            this.email1Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.email1Lbl.BackColor = System.Drawing.Color.White;
            this.email1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email1Lbl.Location = new System.Drawing.Point(72, 307);
            this.email1Lbl.Name = "email1Lbl";
            this.email1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email1Lbl.Size = new System.Drawing.Size(306, 26);
            this.email1Lbl.TabIndex = 1;
            this.email1Lbl.Text = "testeremail@outlook.com";
            this.toolTip.SetToolTip(this.email1Lbl, "Primary email");
            this.email1Lbl.ForeColorChanged += new System.EventHandler(this.email1Lbl_ForeColorChanged);
            this.email1Lbl.Leave += new System.EventHandler(this.email1Lbl_Leave);
            // 
            // interestedVehiclesListBox
            // 
            this.interestedVehiclesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interestedVehiclesListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interestedVehiclesListBox.FormattingEnabled = true;
            this.interestedVehiclesListBox.ItemHeight = 21;
            this.interestedVehiclesListBox.Location = new System.Drawing.Point(756, 143);
            this.interestedVehiclesListBox.Name = "interestedVehiclesListBox";
            this.interestedVehiclesListBox.Size = new System.Drawing.Size(277, 382);
            this.interestedVehiclesListBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.interestedVehiclesListBox, "List of vehicle\'s this customer is interested in");
            this.interestedVehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.interestedVehiclesListBox_SelectedIndexChanged);
            this.interestedVehiclesListBox.DoubleClick += new System.EventHandler(this.interestedVehiclesListBox_DoubleClick);
            // 
            // inProgressCheckbox
            // 
            this.inProgressCheckbox.AutoSize = true;
            this.inProgressCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inProgressCheckbox.Location = new System.Drawing.Point(860, 24);
            this.inProgressCheckbox.Name = "inProgressCheckbox";
            this.inProgressCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inProgressCheckbox.Size = new System.Drawing.Size(173, 25);
            this.inProgressCheckbox.TabIndex = 4;
            this.inProgressCheckbox.Text = "Currently Seeking";
            this.toolTip.SetToolTip(this.inProgressCheckbox, "Indicate if the customer is currently doing business");
            this.inProgressCheckbox.UseVisualStyleBackColor = true;
            this.inProgressCheckbox.CheckedChanged += new System.EventHandler(this.inProgressCheckbox_CheckedChanged);
            // 
            // callBackCheckbox
            // 
            this.callBackCheckbox.AutoSize = true;
            this.callBackCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callBackCheckbox.Location = new System.Drawing.Point(920, 54);
            this.callBackCheckbox.Name = "callBackCheckbox";
            this.callBackCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.callBackCheckbox.Size = new System.Drawing.Size(113, 25);
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
            this.updateCustomerBtn.Location = new System.Drawing.Point(235, 542);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(148, 44);
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
            this.deleteCustomerBtn.Location = new System.Drawing.Point(72, 542);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(148, 44);
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
            this.addVehicleBtn.Location = new System.Drawing.Point(756, 542);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(217, 44);
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
            this.addThisCustomer.Location = new System.Drawing.Point(72, 542);
            this.addThisCustomer.Name = "addThisCustomer";
            this.addThisCustomer.Size = new System.Drawing.Size(311, 44);
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
            this.removeVehicleBtn.Location = new System.Drawing.Point(979, 542);
            this.removeVehicleBtn.Name = "removeVehicleBtn";
            this.removeVehicleBtn.Size = new System.Drawing.Size(54, 44);
            this.removeVehicleBtn.TabIndex = 5;
            this.toolTip.SetToolTip(this.removeVehicleBtn, "Delete a vehicle from the interested list");
            this.removeVehicleBtn.UseVisualStyleBackColor = false;
            this.removeVehicleBtn.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primary Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secondary Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primary Email Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Secondary Email Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(72, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Additional Comments:";
            // 
            // additionalCommentsLbl
            // 
            this.additionalCommentsLbl.Location = new System.Drawing.Point(72, 389);
            this.additionalCommentsLbl.Multiline = true;
            this.additionalCommentsLbl.Name = "additionalCommentsLbl";
            this.additionalCommentsLbl.Size = new System.Drawing.Size(643, 127);
            this.additionalCommentsLbl.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(756, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interested in:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.num1Lbl);
            this.Controls.Add(this.num2Lbl);
            this.Controls.Add(this.email1Lbl);
            this.Controls.Add(this.email2Lbl);
            this.Controls.Add(this.additionalCommentsLbl);
            this.Controls.Add(this.inProgressCheckbox);
            this.Controls.Add(this.callBackCheckbox);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.removeVehicleBtn);
            this.Controls.Add(this.addThisCustomer);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestedVehiclesListBox);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1059, 623);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameLbl;
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
    }
}
