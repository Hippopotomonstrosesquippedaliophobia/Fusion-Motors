
namespace Database_Application_Chris
{
    partial class AddVehicleImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleImg));
            this.vehicleImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addImgBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImg)).BeginInit();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleImg
            // 
            this.vehicleImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleImg.Location = new System.Drawing.Point(32, 68);
            this.vehicleImg.Name = "vehicleImg";
            this.vehicleImg.Size = new System.Drawing.Size(523, 328);
            this.vehicleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleImg.TabIndex = 0;
            this.vehicleImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add an image to represent the vehicle";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gold;
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(581, 30);
            this.titleBar.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Gold;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(541, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "✖";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addImgBtn
            // 
            this.addImgBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addImgBtn.BackColor = System.Drawing.Color.Gold;
            this.addImgBtn.FlatAppearance.BorderSize = 0;
            this.addImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImgBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addImgBtn.ForeColor = System.Drawing.Color.Black;
            this.addImgBtn.Location = new System.Drawing.Point(91, 424);
            this.addImgBtn.Name = "addImgBtn";
            this.addImgBtn.Size = new System.Drawing.Size(464, 27);
            this.addImgBtn.TabIndex = 6;
            this.addImgBtn.Text = "Add Image";
            this.addImgBtn.UseVisualStyleBackColor = false;
            this.addImgBtn.Click += new System.EventHandler(this.addImgBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(32, 402);
            this.locationLbl.MaximumSize = new System.Drawing.Size(523, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(11, 16);
            this.locationLbl.TabIndex = 7;
            this.locationLbl.Text = "-";
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearbtn.BackColor = System.Drawing.Color.Red;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.clearbtn.Location = new System.Drawing.Point(32, 424);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(53, 27);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // AddVehicleImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 463);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.addImgBtn);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.vehicleImg);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddVehicleImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle Image";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImg)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vehicleImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addImgBtn;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Button clearbtn;
    }
}