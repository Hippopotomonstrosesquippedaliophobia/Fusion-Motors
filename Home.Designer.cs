
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
            this.components = new System.ComponentModel.Container();
            this.homeClockTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // homeClockTxt
            // 
            this.homeClockTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.homeClockTxt.AutoSize = true;
            this.homeClockTxt.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeClockTxt.Location = new System.Drawing.Point(328, 201);
            this.homeClockTxt.Name = "homeClockTxt";
            this.homeClockTxt.Size = new System.Drawing.Size(383, 70);
            this.homeClockTxt.TabIndex = 0;
            this.homeClockTxt.Text = "00:00:00 AM";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(221, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 99);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fusion Motors";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeClockTxt);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1017, 631);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeClockTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer clock;
    }
}
