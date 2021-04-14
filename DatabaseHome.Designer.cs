
namespace Database_Application_Chris
{
    partial class DatabaseHome
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
            this.viewVehicles = new System.Windows.Forms.Button();
            this.viewCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewVehicles
            // 
            this.viewVehicles.BackColor = System.Drawing.Color.Gold;
            this.viewVehicles.FlatAppearance.BorderSize = 0;
            this.viewVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVehicles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewVehicles.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.viewVehicles.Location = new System.Drawing.Point(553, 250);
            this.viewVehicles.Name = "viewVehicles";
            this.viewVehicles.Size = new System.Drawing.Size(326, 131);
            this.viewVehicles.TabIndex = 1;
            this.viewVehicles.Text = "View Vehicles";
            this.viewVehicles.UseVisualStyleBackColor = false;
            this.viewVehicles.Click += new System.EventHandler(this.viewVehicles_Click);
            // 
            // viewCustomers
            // 
            this.viewCustomers.BackColor = System.Drawing.Color.Gold;
            this.viewCustomers.FlatAppearance.BorderSize = 0;
            this.viewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewCustomers.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.viewCustomers.Location = new System.Drawing.Point(138, 250);
            this.viewCustomers.Name = "viewCustomers";
            this.viewCustomers.Size = new System.Drawing.Size(326, 131);
            this.viewCustomers.TabIndex = 2;
            this.viewCustomers.Text = "View Customers";
            this.viewCustomers.UseVisualStyleBackColor = false;
            this.viewCustomers.Click += new System.EventHandler(this.viewCustomers_Click);
            // 
            // DatabaseHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewVehicles);
            this.Controls.Add(this.viewCustomers);
            this.Name = "DatabaseHome";
            this.Size = new System.Drawing.Size(1017, 631);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewVehicles;
        private System.Windows.Forms.Button viewCustomers;
    }
}
