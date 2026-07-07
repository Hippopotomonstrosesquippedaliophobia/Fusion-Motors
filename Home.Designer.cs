
namespace Database_Application_Chris
{
    partial class HomeControl
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
            homeClockTxt = new System.Windows.Forms.Label();
            clock = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // homeClockTxt
            // 
            homeClockTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            homeClockTxt.AutoSize = true;
            homeClockTxt.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            homeClockTxt.Location = new System.Drawing.Point(137, 327);
            homeClockTxt.Name = "homeClockTxt";
            homeClockTxt.Size = new System.Drawing.Size(408, 77);
            homeClockTxt.TabIndex = 0;
            homeClockTxt.Text = "00:00:00 AM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fusion_Motors_1;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(675, 452);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(homeClockTxt);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(112, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(678, 455);
            panel1.TabIndex = 3;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "HomeControl";
            Size = new System.Drawing.Size(890, 473);
            Load += HomeControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label homeClockTxt;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
