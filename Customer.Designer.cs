
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
            this.addVehicle = new System.Windows.Forms.TextBox();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.addThisCustomer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeVehicleBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Location = new System.Drawing.Point(424, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 62);
            this.panel1.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.Gold;
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(30, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLbl.Size = new System.Drawing.Size(536, 34);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "James Bond";
            this.nameLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.nameLbl, "Customer\'s name ");
            this.nameLbl.Leave += new System.EventHandler(this.nameLbl_Leave);
            // 
            // addressLbl
            // 
            this.addressLbl.BackColor = System.Drawing.Color.LightGray;
            this.addressLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(454, 85);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLbl.Size = new System.Drawing.Size(536, 23);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Lot # 555 Test Hill, St. James, Barbados";
            this.addressLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.addressLbl, "Address");
            this.addressLbl.Leave += new System.EventHandler(this.addressLbl_Leave);
            // 
            // num1Lbl
            // 
            this.num1Lbl.BackColor = System.Drawing.Color.LightGray;
            this.num1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num1Lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num1Lbl.Location = new System.Drawing.Point(713, 114);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num1Lbl.Size = new System.Drawing.Size(277, 23);
            this.num1Lbl.TabIndex = 1;
            this.num1Lbl.Text = "555-5555";
            this.num1Lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.num1Lbl, "Primary number");
            this.num1Lbl.Leave += new System.EventHandler(this.num1Lbl_Leave);
            // 
            // num2Lbl
            // 
            this.num2Lbl.BackColor = System.Drawing.Color.LightGray;
            this.num2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num2Lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num2Lbl.Location = new System.Drawing.Point(713, 143);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num2Lbl.Size = new System.Drawing.Size(277, 23);
            this.num2Lbl.TabIndex = 1;
            this.num2Lbl.Text = "555-5555";
            this.num2Lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.num2Lbl, "Secondary number");
            this.num2Lbl.Leave += new System.EventHandler(this.num2Lbl_Leave);
            // 
            // email2Lbl
            // 
            this.email2Lbl.BackColor = System.Drawing.Color.LightGray;
            this.email2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email2Lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email2Lbl.Location = new System.Drawing.Point(713, 201);
            this.email2Lbl.Name = "email2Lbl";
            this.email2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email2Lbl.Size = new System.Drawing.Size(277, 23);
            this.email2Lbl.TabIndex = 1;
            this.email2Lbl.Text = "testeremail@outlook.com";
            this.email2Lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.email2Lbl, "Secondary email");
            this.email2Lbl.Leave += new System.EventHandler(this.email2Lbl_Leave);
            // 
            // email1Lbl
            // 
            this.email1Lbl.BackColor = System.Drawing.Color.LightGray;
            this.email1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email1Lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email1Lbl.Location = new System.Drawing.Point(713, 172);
            this.email1Lbl.Name = "email1Lbl";
            this.email1Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email1Lbl.Size = new System.Drawing.Size(277, 23);
            this.email1Lbl.TabIndex = 1;
            this.email1Lbl.Text = "testeremail@outlook.com";
            this.email1Lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.email1Lbl, "Primary email");
            this.email1Lbl.Leave += new System.EventHandler(this.email1Lbl_Leave);
            // 
            // interestedVehiclesListBox
            // 
            this.interestedVehiclesListBox.FormattingEnabled = true;
            this.interestedVehiclesListBox.ItemHeight = 20;
            this.interestedVehiclesListBox.Location = new System.Drawing.Point(713, 230);
            this.interestedVehiclesListBox.Name = "interestedVehiclesListBox";
            this.interestedVehiclesListBox.Size = new System.Drawing.Size(277, 244);
            this.interestedVehiclesListBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.interestedVehiclesListBox, "List of vehicle\'s this customer is interested in");
            this.interestedVehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.interestedVehiclesListBox_SelectedIndexChanged);
            // 
            // inProgressCheckbox
            // 
            this.inProgressCheckbox.AutoSize = true;
            this.inProgressCheckbox.Location = new System.Drawing.Point(72, 86);
            this.inProgressCheckbox.Name = "inProgressCheckbox";
            this.inProgressCheckbox.Size = new System.Drawing.Size(146, 24);
            this.inProgressCheckbox.TabIndex = 4;
            this.inProgressCheckbox.Text = "Currently Seeking";
            this.toolTip.SetToolTip(this.inProgressCheckbox, "Indicate if the customer is currently doing business");
            this.inProgressCheckbox.UseVisualStyleBackColor = true;
            this.inProgressCheckbox.CheckedChanged += new System.EventHandler(this.inProgressCheckbox_CheckedChanged);
            // 
            // callBackCheckbox
            // 
            this.callBackCheckbox.AutoSize = true;
            this.callBackCheckbox.Location = new System.Drawing.Point(72, 116);
            this.callBackCheckbox.Name = "callBackCheckbox";
            this.callBackCheckbox.Size = new System.Drawing.Size(91, 24);
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
            this.deleteCustomerBtn.UseVisualStyleBackColor = false;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // addVehicle
            // 
            this.addVehicle.BackColor = System.Drawing.Color.LightGray;
            this.addVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addVehicle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVehicle.Location = new System.Drawing.Point(713, 497);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addVehicle.Size = new System.Drawing.Size(277, 23);
            this.addVehicle.TabIndex = 1;
            this.addVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.addVehicle, "Vehicle\'s engine number");
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.addVehicleBtn.FlatAppearance.BorderSize = 0;
            this.addVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addVehicleBtn.Location = new System.Drawing.Point(713, 542);
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
            this.removeVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.removeVehicleBtn.FlatAppearance.BorderSize = 0;
            this.removeVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeVehicleBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeVehicleBtn.Location = new System.Drawing.Point(936, 542);
            this.removeVehicleBtn.Name = "removeVehicleBtn";
            this.removeVehicleBtn.Size = new System.Drawing.Size(54, 44);
            this.removeVehicleBtn.TabIndex = 5;
            this.removeVehicleBtn.Text = "🗑️";
            this.toolTip.SetToolTip(this.removeVehicleBtn, "Delete a vehicle from the interested list");
            this.removeVehicleBtn.UseVisualStyleBackColor = false;
            this.removeVehicleBtn.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.addThisCustomer);
            this.Controls.Add(this.removeVehicleBtn);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.callBackCheckbox);
            this.Controls.Add(this.inProgressCheckbox);
            this.Controls.Add(this.interestedVehiclesListBox);
            this.Controls.Add(this.num2Lbl);
            this.Controls.Add(this.email1Lbl);
            this.Controls.Add(this.addVehicle);
            this.Controls.Add(this.email2Lbl);
            this.Controls.Add(this.num1Lbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1016, 631);
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
        private System.Windows.Forms.TextBox addVehicle;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Button addThisCustomer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button removeVehicleBtn;
    }
}
