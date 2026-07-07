
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            nameLbl = new System.Windows.Forms.TextBox();
            addressLbl = new System.Windows.Forms.TextBox();
            num1Lbl = new System.Windows.Forms.TextBox();
            num2Lbl = new System.Windows.Forms.TextBox();
            email2Lbl = new System.Windows.Forms.TextBox();
            email1Lbl = new System.Windows.Forms.TextBox();
            interestedVehiclesListBox = new System.Windows.Forms.ListBox();
            inProgressCheckbox = new System.Windows.Forms.CheckBox();
            callBackCheckbox = new System.Windows.Forms.CheckBox();
            updateCustomerBtn = new System.Windows.Forms.Button();
            deleteCustomerBtn = new System.Windows.Forms.Button();
            addVehicleBtn = new System.Windows.Forms.Button();
            addThisCustomer = new System.Windows.Forms.Button();
            toolTip = new System.Windows.Forms.ToolTip(components);
            removeVehicleBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            additionalCommentsLbl = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            viewErrors = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            agentCombo = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.Gold;
            panel1.Controls.Add(nameLbl);
            panel1.Location = new System.Drawing.Point(0, 14);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(711, 46);
            panel1.TabIndex = 0;
            // 
            // nameLbl
            // 
            nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nameLbl.BackColor = System.Drawing.Color.Gold;
            nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            nameLbl.Location = new System.Drawing.Point(62, 11);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new System.Drawing.Size(578, 24);
            nameLbl.TabIndex = 2;
            nameLbl.Leave += nameLbl_Leave;
            // 
            // addressLbl
            // 
            addressLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            addressLbl.BackColor = System.Drawing.Color.White;
            addressLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            addressLbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            addressLbl.Location = new System.Drawing.Point(63, 107);
            addressLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addressLbl.Name = "addressLbl";
            addressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            addressLbl.Size = new System.Drawing.Size(645, 22);
            addressLbl.TabIndex = 1;
            toolTip.SetToolTip(addressLbl, "Address");
            addressLbl.ForeColorChanged += addressLbl_ForeColorChanged;
            addressLbl.Leave += addressLbl_Leave;
            // 
            // num1Lbl
            // 
            num1Lbl.BackColor = System.Drawing.Color.White;
            num1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            num1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            num1Lbl.Location = new System.Drawing.Point(63, 169);
            num1Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            num1Lbl.Name = "num1Lbl";
            num1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            num1Lbl.Size = new System.Drawing.Size(268, 22);
            num1Lbl.TabIndex = 1;
            toolTip.SetToolTip(num1Lbl, "Primary number");
            num1Lbl.ForeColorChanged += num1Lbl_ForeColorChanged;
            num1Lbl.Leave += num1Lbl_Leave;
            // 
            // num2Lbl
            // 
            num2Lbl.BackColor = System.Drawing.Color.White;
            num2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            num2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            num2Lbl.Location = new System.Drawing.Point(358, 169);
            num2Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            num2Lbl.Name = "num2Lbl";
            num2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            num2Lbl.Size = new System.Drawing.Size(268, 22);
            num2Lbl.TabIndex = 1;
            toolTip.SetToolTip(num2Lbl, "Secondary number");
            num2Lbl.ForeColorChanged += num2Lbl_ForeColorChanged;
            num2Lbl.Leave += num2Lbl_Leave;
            // 
            // email2Lbl
            // 
            email2Lbl.BackColor = System.Drawing.Color.White;
            email2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            email2Lbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            email2Lbl.Location = new System.Drawing.Point(358, 230);
            email2Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            email2Lbl.Name = "email2Lbl";
            email2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            email2Lbl.Size = new System.Drawing.Size(268, 22);
            email2Lbl.TabIndex = 1;
            toolTip.SetToolTip(email2Lbl, "Secondary email");
            email2Lbl.ForeColorChanged += email2Lbl_ForeColorChanged;
            email2Lbl.Leave += email2Lbl_Leave;
            // 
            // email1Lbl
            // 
            email1Lbl.BackColor = System.Drawing.Color.White;
            email1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            email1Lbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            email1Lbl.Location = new System.Drawing.Point(63, 230);
            email1Lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            email1Lbl.Name = "email1Lbl";
            email1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            email1Lbl.Size = new System.Drawing.Size(268, 22);
            email1Lbl.TabIndex = 1;
            toolTip.SetToolTip(email1Lbl, "Primary email");
            email1Lbl.ForeColorChanged += email1Lbl_ForeColorChanged;
            email1Lbl.Leave += email1Lbl_Leave;
            // 
            // interestedVehiclesListBox
            // 
            interestedVehiclesListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            interestedVehiclesListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            interestedVehiclesListBox.FormattingEnabled = true;
            interestedVehiclesListBox.ItemHeight = 19;
            interestedVehiclesListBox.Location = new System.Drawing.Point(24, 0);
            interestedVehiclesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            interestedVehiclesListBox.Name = "interestedVehiclesListBox";
            interestedVehiclesListBox.Size = new System.Drawing.Size(237, 403);
            interestedVehiclesListBox.TabIndex = 2;
            toolTip.SetToolTip(interestedVehiclesListBox, "List of vehicle's this customer is interested in");
            interestedVehiclesListBox.SelectedIndexChanged += interestedVehiclesListBox_SelectedIndexChanged;
            interestedVehiclesListBox.DoubleClick += interestedVehiclesListBox_DoubleClick;
            // 
            // inProgressCheckbox
            // 
            inProgressCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            inProgressCheckbox.AutoSize = true;
            inProgressCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            inProgressCheckbox.Location = new System.Drawing.Point(119, 18);
            inProgressCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inProgressCheckbox.Name = "inProgressCheckbox";
            inProgressCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            inProgressCheckbox.Size = new System.Drawing.Size(147, 23);
            inProgressCheckbox.TabIndex = 4;
            inProgressCheckbox.Text = "Currently Seeking";
            toolTip.SetToolTip(inProgressCheckbox, "Indicate if the customer is currently doing business");
            inProgressCheckbox.UseVisualStyleBackColor = true;
            inProgressCheckbox.CheckedChanged += inProgressCheckbox_CheckedChanged;
            // 
            // callBackCheckbox
            // 
            callBackCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            callBackCheckbox.AutoSize = true;
            callBackCheckbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            callBackCheckbox.Location = new System.Drawing.Point(172, 40);
            callBackCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            callBackCheckbox.Name = "callBackCheckbox";
            callBackCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            callBackCheckbox.Size = new System.Drawing.Size(95, 23);
            callBackCheckbox.TabIndex = 4;
            callBackCheckbox.Text = "Call back";
            toolTip.SetToolTip(callBackCheckbox, "Indicate if the customer is to be called back");
            callBackCheckbox.UseVisualStyleBackColor = true;
            callBackCheckbox.CheckedChanged += callBackCheckbox_CheckedChanged;
            // 
            // updateCustomerBtn
            // 
            updateCustomerBtn.BackColor = System.Drawing.Color.Gold;
            updateCustomerBtn.Enabled = false;
            updateCustomerBtn.FlatAppearance.BorderSize = 0;
            updateCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            updateCustomerBtn.Location = new System.Drawing.Point(205, 14);
            updateCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            updateCustomerBtn.Name = "updateCustomerBtn";
            updateCustomerBtn.Size = new System.Drawing.Size(130, 33);
            updateCustomerBtn.TabIndex = 5;
            updateCustomerBtn.Text = "↻ Update";
            updateCustomerBtn.UseVisualStyleBackColor = false;
            updateCustomerBtn.Visible = false;
            updateCustomerBtn.Click += updateCustomerBtn_Click;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.BackColor = System.Drawing.Color.Gold;
            deleteCustomerBtn.FlatAppearance.BorderSize = 0;
            deleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            deleteCustomerBtn.Location = new System.Drawing.Point(62, 14);
            deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new System.Drawing.Size(130, 33);
            deleteCustomerBtn.TabIndex = 5;
            deleteCustomerBtn.Text = "🗑️ Delete";
            deleteCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            deleteCustomerBtn.UseVisualStyleBackColor = false;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // addVehicleBtn
            // 
            addVehicleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addVehicleBtn.BackColor = System.Drawing.Color.Gold;
            addVehicleBtn.FlatAppearance.BorderSize = 0;
            addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            addVehicleBtn.Location = new System.Drawing.Point(739, 14);
            addVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addVehicleBtn.Name = "addVehicleBtn";
            addVehicleBtn.Size = new System.Drawing.Size(190, 33);
            addVehicleBtn.TabIndex = 5;
            addVehicleBtn.Text = "+  ";
            toolTip.SetToolTip(addVehicleBtn, "Add a vehicle which the customer is interested in");
            addVehicleBtn.UseVisualStyleBackColor = false;
            addVehicleBtn.Click += addVehicleInterest_Click;
            // 
            // addThisCustomer
            // 
            addThisCustomer.BackColor = System.Drawing.Color.Gold;
            addThisCustomer.Enabled = false;
            addThisCustomer.FlatAppearance.BorderSize = 0;
            addThisCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addThisCustomer.Font = new System.Drawing.Font("Century Gothic", 9F);
            addThisCustomer.Location = new System.Drawing.Point(62, 14);
            addThisCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addThisCustomer.Name = "addThisCustomer";
            addThisCustomer.Size = new System.Drawing.Size(272, 33);
            addThisCustomer.TabIndex = 5;
            addThisCustomer.Text = "+ Add Customer";
            toolTip.SetToolTip(addThisCustomer, "Add this customer to the database");
            addThisCustomer.UseVisualStyleBackColor = false;
            addThisCustomer.Visible = false;
            addThisCustomer.Click += addThisCustomer_Click;
            // 
            // removeVehicleBtn
            // 
            removeVehicleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            removeVehicleBtn.BackColor = System.Drawing.Color.Gold;
            removeVehicleBtn.FlatAppearance.BorderSize = 0;
            removeVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            removeVehicleBtn.Image = Properties.Resources.bin_small;
            removeVehicleBtn.Location = new System.Drawing.Point(934, 14);
            removeVehicleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            removeVehicleBtn.Name = "removeVehicleBtn";
            removeVehicleBtn.Size = new System.Drawing.Size(47, 33);
            removeVehicleBtn.TabIndex = 5;
            toolTip.SetToolTip(removeVehicleBtn, "Delete a vehicle from the interested list");
            removeVehicleBtn.UseVisualStyleBackColor = false;
            removeVehicleBtn.Click += removeVehicle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label1.Location = new System.Drawing.Point(63, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 6;
            label1.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label2.Location = new System.Drawing.Point(63, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 16);
            label2.TabIndex = 6;
            label2.Text = "Primary Contact Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label3.Location = new System.Drawing.Point(358, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 16);
            label3.TabIndex = 6;
            label3.Text = "Secondary Contact Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label4.Location = new System.Drawing.Point(63, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 16);
            label4.TabIndex = 6;
            label4.Text = "Primary Email Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label5.Location = new System.Drawing.Point(358, 215);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(144, 16);
            label5.TabIndex = 6;
            label5.Text = "Secondary Email Address:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label6.Location = new System.Drawing.Point(63, 277);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 16);
            label6.TabIndex = 6;
            label6.Text = "Additional Comments:";
            // 
            // additionalCommentsLbl
            // 
            additionalCommentsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            additionalCommentsLbl.Location = new System.Drawing.Point(63, 292);
            additionalCommentsLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            additionalCommentsLbl.Multiline = true;
            additionalCommentsLbl.Name = "additionalCommentsLbl";
            additionalCommentsLbl.Size = new System.Drawing.Size(645, 168);
            additionalCommentsLbl.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            label7.Location = new System.Drawing.Point(37, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 16);
            label7.TabIndex = 6;
            label7.Text = "Interested in:";
            // 
            // panel2
            // 
            panel2.Controls.Add(viewErrors);
            panel2.Controls.Add(addVehicleBtn);
            panel2.Controls.Add(removeVehicleBtn);
            panel2.Controls.Add(addThisCustomer);
            panel2.Controls.Add(updateCustomerBtn);
            panel2.Controls.Add(deleteCustomerBtn);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 520);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1018, 74);
            panel2.TabIndex = 8;
            // 
            // viewErrors
            // 
            viewErrors.BackColor = System.Drawing.Color.Red;
            viewErrors.Enabled = false;
            viewErrors.FlatAppearance.BorderSize = 0;
            viewErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            viewErrors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            viewErrors.ForeColor = System.Drawing.Color.White;
            viewErrors.Location = new System.Drawing.Point(358, 14);
            viewErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            viewErrors.Name = "viewErrors";
            viewErrors.Size = new System.Drawing.Size(130, 33);
            viewErrors.TabIndex = 5;
            viewErrors.Text = "View Errors";
            viewErrors.UseVisualStyleBackColor = false;
            viewErrors.Visible = false;
            viewErrors.Click += viewErrors_Click;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(inProgressCheckbox);
            panel3.Controls.Add(callBackCheckbox);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(717, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(301, 520);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            panel4.Controls.Add(interestedVehiclesListBox);
            panel4.Location = new System.Drawing.Point(6, 107);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(264, 408);
            panel4.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(62, 474);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 13);
            label8.TabIndex = 24;
            label8.Text = "Agent";
            // 
            // agentCombo
            // 
            agentCombo.FormattingEnabled = true;
            agentCombo.Location = new System.Drawing.Point(64, 490);
            agentCombo.Name = "agentCombo";
            agentCombo.Size = new System.Drawing.Size(267, 23);
            agentCombo.TabIndex = 23;
            // 
            // Customer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Controls.Add(label8);
            Controls.Add(agentCombo);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(addressLbl);
            Controls.Add(num1Lbl);
            Controls.Add(num2Lbl);
            Controls.Add(email1Lbl);
            Controls.Add(email2Lbl);
            Controls.Add(additionalCommentsLbl);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Customer";
            Size = new System.Drawing.Size(1018, 594);
            Load += Customer_Load;
            MouseClick += Customer_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox agentCombo;
    }
}
