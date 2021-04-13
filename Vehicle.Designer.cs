﻿
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
            this.addCustomer = new System.Windows.Forms.TextBox();
            this.chassisNumLbl = new System.Windows.Forms.TextBox();
            this.colourLbl = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.engineNumLbl);
            this.panel1.Location = new System.Drawing.Point(424, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 62);
            this.panel1.TabIndex = 6;
            // 
            // engineNumLbl
            // 
            this.engineNumLbl.BackColor = System.Drawing.Color.Gold;
            this.engineNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engineNumLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.engineNumLbl.Location = new System.Drawing.Point(30, 13);
            this.engineNumLbl.Name = "engineNumLbl";
            this.engineNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.engineNumLbl.Size = new System.Drawing.Size(536, 34);
            this.engineNumLbl.TabIndex = 1;
            this.engineNumLbl.Text = "Engine Number";
            this.engineNumLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.engineNumLbl, "Engine Number");
            this.engineNumLbl.Leave += new System.EventHandler(this.engineNumLbl_Leave);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.addCustomerBtn.FlatAppearance.BorderSize = 0;
            this.addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBtn.Location = new System.Drawing.Point(713, 542);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(277, 44);
            this.addCustomerBtn.TabIndex = 17;
            this.addCustomerBtn.Text = "+ Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // deleteVehicleBtn
            // 
            this.deleteVehicleBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteVehicleBtn.FlatAppearance.BorderSize = 0;
            this.deleteVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVehicleBtn.Location = new System.Drawing.Point(72, 542);
            this.deleteVehicleBtn.Name = "deleteVehicleBtn";
            this.deleteVehicleBtn.Size = new System.Drawing.Size(148, 44);
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
            this.updateVehicleBtn.Location = new System.Drawing.Point(235, 542);
            this.updateVehicleBtn.Name = "updateVehicleBtn";
            this.updateVehicleBtn.Size = new System.Drawing.Size(148, 44);
            this.updateVehicleBtn.TabIndex = 19;
            this.updateVehicleBtn.Text = "↻ Update";
            this.updateVehicleBtn.UseVisualStyleBackColor = false;
            this.updateVehicleBtn.Visible = false;
            this.updateVehicleBtn.Click += new System.EventHandler(this.updateVehicleBtn_Click);
            // 
            // interestedCustomersListBox
            // 
            this.interestedCustomersListBox.FormattingEnabled = true;
            this.interestedCustomersListBox.ItemHeight = 20;
            this.interestedCustomersListBox.Location = new System.Drawing.Point(713, 153);
            this.interestedCustomersListBox.Name = "interestedCustomersListBox";
            this.interestedCustomersListBox.Size = new System.Drawing.Size(277, 344);
            this.interestedCustomersListBox.TabIndex = 13;
            this.toolTip.SetToolTip(this.interestedCustomersListBox, "List of interested customers");
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.LightGray;
            this.addCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addCustomer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCustomer.Location = new System.Drawing.Point(713, 513);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCustomer.Size = new System.Drawing.Size(277, 23);
            this.addCustomer.TabIndex = 9;
            this.addCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chassisNumLbl
            // 
            this.chassisNumLbl.BackColor = System.Drawing.Color.LightGray;
            this.chassisNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chassisNumLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chassisNumLbl.Location = new System.Drawing.Point(454, 85);
            this.chassisNumLbl.Name = "chassisNumLbl";
            this.chassisNumLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chassisNumLbl.Size = new System.Drawing.Size(536, 23);
            this.chassisNumLbl.TabIndex = 12;
            this.chassisNumLbl.Text = "Chassis Number";
            this.chassisNumLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.chassisNumLbl, "Chassis Number");
            this.chassisNumLbl.Leave += new System.EventHandler(this.chassisNumLbl_Leave);
            // 
            // colourLbl
            // 
            this.colourLbl.BackColor = System.Drawing.Color.LightGray;
            this.colourLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colourLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colourLbl.Location = new System.Drawing.Point(454, 114);
            this.colourLbl.Name = "colourLbl";
            this.colourLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colourLbl.Size = new System.Drawing.Size(536, 23);
            this.colourLbl.TabIndex = 12;
            this.colourLbl.Text = "Colour";
            this.colourLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.colourLbl, "Colour of car");
            this.colourLbl.Leave += new System.EventHandler(this.colourLbl_Leave);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.deleteVehicleBtn);
            this.Controls.Add(this.updateVehicleBtn);
            this.Controls.Add(this.interestedCustomersListBox);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.colourLbl);
            this.Controls.Add(this.chassisNumLbl);
            this.Name = "Vehicle";
            this.Size = new System.Drawing.Size(1016, 631);
            this.Click += new System.EventHandler(this.Vehicle_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox addCustomer;
        private System.Windows.Forms.TextBox chassisNumLbl;
        private System.Windows.Forms.TextBox colourLbl;
        private System.Windows.Forms.ToolTip toolTip;
    }
}