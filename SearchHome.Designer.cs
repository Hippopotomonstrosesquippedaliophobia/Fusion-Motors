
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
            this.searchTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.searchTxt.Location = new System.Drawing.Point(132, 241);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(633, 27);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.Text = "Search by first and last name (Eg. James Bond)...";
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTxt.Enter += new System.EventHandler(this.searchTxt_Enter);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // SearchPageLabel
            // 
            this.SearchPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchPageLabel.AutoSize = true;
            this.SearchPageLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPageLabel.Location = new System.Drawing.Point(374, 168);
            this.SearchPageLabel.Name = "SearchPageLabel";
            this.SearchPageLabel.Size = new System.Drawing.Size(196, 42);
            this.SearchPageLabel.TabIndex = 1;
            this.SearchPageLabel.Text = "Customers";
            this.SearchPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersRadio
            // 
            this.customersRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customersRadio.AutoSize = true;
            this.customersRadio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersRadio.Location = new System.Drawing.Point(354, 284);
            this.customersRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersRadio.Name = "customersRadio";
            this.customersRadio.Size = new System.Drawing.Size(110, 25);
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
            this.vehiclesRadio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehiclesRadio.Location = new System.Drawing.Point(493, 284);
            this.vehiclesRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiclesRadio.Name = "vehiclesRadio";
            this.vehiclesRadio.Size = new System.Drawing.Size(91, 25);
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
            this.searchBtn.Image = global::Database_Application_Chris.Properties.Resources.search_smaller;
            this.searchBtn.Location = new System.Drawing.Point(770, 241);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(27, 27);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.customersRadio);
            this.Controls.Add(this.vehiclesRadio);
            this.Controls.Add(this.SearchPageLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchHomeControl";
            this.Size = new System.Drawing.Size(927, 467);
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
