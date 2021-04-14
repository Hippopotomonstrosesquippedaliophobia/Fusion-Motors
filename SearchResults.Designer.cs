
namespace Database_Application_Chris
{
    partial class SearchResultsControl
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
            this.Result1 = new System.Windows.Forms.Panel();
            this.Result2 = new System.Windows.Forms.Panel();
            this.Result3 = new System.Windows.Forms.Panel();
            this.Result4 = new System.Windows.Forms.Panel();
            this.Result5 = new System.Windows.Forms.Panel();
            this.Result6 = new System.Windows.Forms.Panel();
            this.Result7 = new System.Windows.Forms.Panel();
            this.Result8 = new System.Windows.Forms.Panel();
            this.Result9 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.fwdBtn = new System.Windows.Forms.Button();
            this.numResultsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result1
            // 
            this.Result1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result1.BackColor = System.Drawing.Color.White;
            this.Result1.Location = new System.Drawing.Point(111, 62);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(244, 122);
            this.Result1.TabIndex = 0;
            // 
            // Result2
            // 
            this.Result2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result2.Location = new System.Drawing.Point(408, 62);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(244, 122);
            this.Result2.TabIndex = 1;
            this.Result2.Visible = false;
            // 
            // Result3
            // 
            this.Result3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result3.Location = new System.Drawing.Point(705, 62);
            this.Result3.Name = "Result3";
            this.Result3.Size = new System.Drawing.Size(244, 122);
            this.Result3.TabIndex = 2;
            this.Result3.Visible = false;
            // 
            // Result4
            // 
            this.Result4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result4.Location = new System.Drawing.Point(111, 233);
            this.Result4.Name = "Result4";
            this.Result4.Size = new System.Drawing.Size(244, 122);
            this.Result4.TabIndex = 3;
            this.Result4.Visible = false;
            // 
            // Result5
            // 
            this.Result5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result5.Location = new System.Drawing.Point(408, 233);
            this.Result5.Name = "Result5";
            this.Result5.Size = new System.Drawing.Size(244, 122);
            this.Result5.TabIndex = 2;
            this.Result5.Visible = false;
            // 
            // Result6
            // 
            this.Result6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result6.Location = new System.Drawing.Point(705, 233);
            this.Result6.Name = "Result6";
            this.Result6.Size = new System.Drawing.Size(244, 122);
            this.Result6.TabIndex = 2;
            this.Result6.Visible = false;
            // 
            // Result7
            // 
            this.Result7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result7.Location = new System.Drawing.Point(111, 401);
            this.Result7.Name = "Result7";
            this.Result7.Size = new System.Drawing.Size(244, 122);
            this.Result7.TabIndex = 2;
            this.Result7.Visible = false;
            // 
            // Result8
            // 
            this.Result8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result8.Location = new System.Drawing.Point(408, 401);
            this.Result8.Name = "Result8";
            this.Result8.Size = new System.Drawing.Size(244, 122);
            this.Result8.TabIndex = 2;
            this.Result8.Visible = false;
            // 
            // Result9
            // 
            this.Result9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result9.Location = new System.Drawing.Point(705, 401);
            this.Result9.Name = "Result9";
            this.Result9.Size = new System.Drawing.Size(244, 122);
            this.Result9.TabIndex = 2;
            this.Result9.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Gold;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(408, 550);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 49);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // fwdBtn
            // 
            this.fwdBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fwdBtn.BackColor = System.Drawing.Color.Gold;
            this.fwdBtn.FlatAppearance.BorderSize = 0;
            this.fwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fwdBtn.Location = new System.Drawing.Point(535, 550);
            this.fwdBtn.Name = "fwdBtn";
            this.fwdBtn.Size = new System.Drawing.Size(117, 49);
            this.fwdBtn.TabIndex = 4;
            this.fwdBtn.Text = ">";
            this.fwdBtn.UseVisualStyleBackColor = false;
            this.fwdBtn.Click += new System.EventHandler(this.fwdBtn_Click);
            // 
            // numResultsLbl
            // 
            this.numResultsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numResultsLbl.AutoSize = true;
            this.numResultsLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numResultsLbl.Location = new System.Drawing.Point(696, 566);
            this.numResultsLbl.Name = "numResultsLbl";
            this.numResultsLbl.Size = new System.Drawing.Size(16, 21);
            this.numResultsLbl.TabIndex = 6;
            this.numResultsLbl.Text = "-";
            // 
            // SearchResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numResultsLbl);
            this.Controls.Add(this.fwdBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.Result9);
            this.Controls.Add(this.Result8);
            this.Controls.Add(this.Result7);
            this.Controls.Add(this.Result6);
            this.Controls.Add(this.Result5);
            this.Controls.Add(this.Result4);
            this.Controls.Add(this.Result3);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.Result1);
            this.Name = "SearchResultsControl";
            this.Size = new System.Drawing.Size(1059, 623);
            this.Load += new System.EventHandler(this.SearchResultsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Result1;
        private System.Windows.Forms.Panel Result2;
        private System.Windows.Forms.Panel Result3;
        private System.Windows.Forms.Panel Result4;
        private System.Windows.Forms.Panel Result5;
        private System.Windows.Forms.Panel Result6;
        private System.Windows.Forms.Panel Result7;
        private System.Windows.Forms.Panel Result8;
        private System.Windows.Forms.Panel Result9;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button fwdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numResultsLbl;
    }
}
