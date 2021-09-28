
namespace Database_Application_Chris
{
    partial class ViewVehicle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVehicle));
            this.vehicleImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImg)).BeginInit();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleImg
            // 
            this.vehicleImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleImg.Location = new System.Drawing.Point(7, 36);
            this.vehicleImg.Name = "vehicleImg";
            this.vehicleImg.Size = new System.Drawing.Size(862, 499);
            this.vehicleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleImg.TabIndex = 0;
            this.vehicleImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Image";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gold;
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(878, 30);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Gold;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(838, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "✖";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ViewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.vehicleImg);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle Image";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImg)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vehicleImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button closeBtn;
    }
}