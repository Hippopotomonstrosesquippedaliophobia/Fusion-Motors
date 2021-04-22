
namespace Database_Application_Chris
{
    partial class addHome
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
            this.addCustomer = new System.Windows.Forms.Button();
            this.addVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCustomer
            // 
            this.addCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCustomer.BackColor = System.Drawing.Color.Gold;
            this.addCustomer.FlatAppearance.BorderSize = 0;
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addCustomer.Location = new System.Drawing.Point(156, 250);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(326, 131);
            this.addCustomer.TabIndex = 0;
            this.addCustomer.Text = "+ Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // addVehicle
            // 
            this.addVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVehicle.BackColor = System.Drawing.Color.Gold;
            this.addVehicle.FlatAppearance.BorderSize = 0;
            this.addVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addVehicle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addVehicle.Location = new System.Drawing.Point(571, 250);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.Size = new System.Drawing.Size(326, 131);
            this.addVehicle.TabIndex = 0;
            this.addVehicle.Text = "+ Add Vehicle";
            this.addVehicle.UseVisualStyleBackColor = false;
            this.addVehicle.Click += new System.EventHandler(this.addVehicle_Click);
            // 
            // addHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addVehicle);
            this.Name = "addHome";
            this.Size = new System.Drawing.Size(1059, 623);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button addVehicle;
    }
}
