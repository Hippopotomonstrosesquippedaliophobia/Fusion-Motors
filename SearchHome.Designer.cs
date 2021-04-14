
namespace Database_Application_Chris
{
    partial class SearchHomeControl
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
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.SearchPageLabel = new System.Windows.Forms.Label();
            this.customersRadio = new System.Windows.Forms.RadioButton();
            this.vehiclesRadio = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.searchTxt.Location = new System.Drawing.Point(151, 321);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(723, 28);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.Text = "Search by first and last name (Eg. James Bond)...";
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTxt.Enter += new System.EventHandler(this.searchTxt_Enter);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // SearchPageLabel
            // 
            this.SearchPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchPageLabel.AutoSize = true;
            this.SearchPageLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPageLabel.Location = new System.Drawing.Point(428, 224);
            this.SearchPageLabel.Name = "SearchPageLabel";
            this.SearchPageLabel.Size = new System.Drawing.Size(228, 49);
            this.SearchPageLabel.TabIndex = 1;
            this.SearchPageLabel.Text = "Customers";
            this.SearchPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersRadio
            // 
            this.customersRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customersRadio.AutoSize = true;
            this.customersRadio.Location = new System.Drawing.Point(404, 378);
            this.customersRadio.Name = "customersRadio";
            this.customersRadio.Size = new System.Drawing.Size(99, 24);
            this.customersRadio.TabIndex = 3;
            this.customersRadio.TabStop = true;
            this.customersRadio.Text = "Customers";
            this.customersRadio.UseVisualStyleBackColor = true;
            this.customersRadio.Click += new System.EventHandler(this.customersRadio_Click);
            // 
            // vehiclesRadio
            // 
            this.vehiclesRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehiclesRadio.AutoSize = true;
            this.vehiclesRadio.Location = new System.Drawing.Point(563, 378);
            this.vehiclesRadio.Name = "vehiclesRadio";
            this.vehiclesRadio.Size = new System.Drawing.Size(83, 24);
            this.vehiclesRadio.TabIndex = 3;
            this.vehiclesRadio.TabStop = true;
            this.vehiclesRadio.Text = "Vehicles";
            this.vehiclesRadio.UseVisualStyleBackColor = true;
            this.vehiclesRadio.Click += new System.EventHandler(this.vehiclesRadio_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.Gold;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(880, 321);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(28, 28);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "🔍";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.vehiclesRadio);
            this.Controls.Add(this.customersRadio);
            this.Controls.Add(this.SearchPageLabel);
            this.Controls.Add(this.searchTxt);
            this.Name = "SearchHomeControl";
            this.Size = new System.Drawing.Size(1059, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton customerRadio;
        private System.Windows.Forms.RadioButton vehiclesRadio;
        private System.Windows.Forms.RadioButton customersRadio;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label SearchPageLabel;
    }
}
