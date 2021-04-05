
namespace Database_Application_Chris
{
    partial class customerPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.parish = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 35);
            this.panel1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(13, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Test Namerino";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num.Location = new System.Drawing.Point(23, 40);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(62, 20);
            this.num.TabIndex = 1;
            this.num.Text = "555-555";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(23, 60);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(183, 20);
            this.address.TabIndex = 1;
            this.address.Text = "Lot # 456, Adams Bridge";
            // 
            // parish
            // 
            this.parish.AutoSize = true;
            this.parish.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parish.Location = new System.Drawing.Point(23, 80);
            this.parish.Name = "parish";
            this.parish.Size = new System.Drawing.Size(75, 20);
            this.parish.TabIndex = 1;
            this.parish.Text = "St. James";
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.Gold;
            this.selectBtn.FlatAppearance.BorderSize = 0;
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectBtn.Location = new System.Drawing.Point(131, 84);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(104, 31);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // customerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.parish);
            this.Controls.Add(this.address);
            this.Controls.Add(this.num);
            this.Controls.Add(this.panel1);
            this.Name = "customerPanel";
            this.Size = new System.Drawing.Size(244, 122);
            this.Load += new System.EventHandler(this.customerPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label parish;
        private System.Windows.Forms.Button selectBtn;
    }
}
