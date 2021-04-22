
namespace Database_Application_Chris
{
    partial class SettingsPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.ImportPanel = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listTables = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.file2Txt = new System.Windows.Forms.Label();
            this.file1Txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importTablesBtn = new System.Windows.Forms.Button();
            this.selectFile2 = new System.Windows.Forms.Button();
            this.file2TextBox = new System.Windows.Forms.TextBox();
            this.clear1 = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            this.selectFile1 = new System.Windows.Forms.Button();
            this.file1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exportTablesBtn = new System.Windows.Forms.Button();
            this.openLocation = new System.Windows.Forms.Button();
            this.clearExportLocation = new System.Windows.Forms.Button();
            this.exportPanel = new System.Windows.Forms.Panel();
            this.exportLocationTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.ImportPanel.SuspendLayout();
            this.exportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.importBtn);
            this.flowLayoutPanel1.Controls.Add(this.exportBtn);
            this.flowLayoutPanel1.Controls.Add(this.aboutBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 598);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Location = new System.Drawing.Point(77, 3);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(226, 68);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Import Database";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Location = new System.Drawing.Point(77, 77);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(226, 68);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Export Database";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Location = new System.Drawing.Point(77, 151);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(226, 68);
            this.aboutBtn.TabIndex = 0;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // ImportPanel
            // 
            this.ImportPanel.Controls.Add(this.file1TextBox);
            this.ImportPanel.Controls.Add(this.selectFile1);
            this.ImportPanel.Controls.Add(this.file2TextBox);
            this.ImportPanel.Controls.Add(this.selectFile2);
            this.ImportPanel.Controls.Add(this.importTablesBtn);
            this.ImportPanel.Controls.Add(this.clear1);
            this.ImportPanel.Controls.Add(this.clear2);
            this.ImportPanel.Controls.Add(this.pagePanel);
            this.ImportPanel.Controls.Add(this.label8);
            this.ImportPanel.Controls.Add(this.listTables);
            this.ImportPanel.Controls.Add(this.label6);
            this.ImportPanel.Controls.Add(this.file2Txt);
            this.ImportPanel.Controls.Add(this.file1Txt);
            this.ImportPanel.Controls.Add(this.label4);
            this.ImportPanel.Controls.Add(this.label2);
            this.ImportPanel.Controls.Add(this.label1);
            this.ImportPanel.Location = new System.Drawing.Point(306, 25);
            this.ImportPanel.Name = "ImportPanel";
            this.ImportPanel.Size = new System.Drawing.Size(753, 597);
            this.ImportPanel.TabIndex = 1;
            this.ImportPanel.Enter += new System.EventHandler(this.ImportPanel_Enter);
            // 
            // pagePanel
            // 
            this.pagePanel.BackColor = System.Drawing.Color.Gold;
            this.pagePanel.Location = new System.Drawing.Point(3, 27);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(10, 68);
            this.pagePanel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(52, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(591, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Note: Only files by the name \"Customers.json\" and \"Vehicles.json\" will be allowed" +
    "";
            // 
            // listTables
            // 
            this.listTables.AutoSize = true;
            this.listTables.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.listTables.Location = new System.Drawing.Point(249, 88);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(14, 20);
            this.listTables.TabIndex = 5;
            this.listTables.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current database tables:";
            // 
            // file2Txt
            // 
            this.file2Txt.Location = new System.Drawing.Point(94, 260);
            this.file2Txt.Name = "file2Txt";
            this.file2Txt.Size = new System.Drawing.Size(399, 20);
            this.file2Txt.TabIndex = 3;
            this.file2Txt.Text = "No file selected.";
            this.toolTip.SetToolTip(this.file2Txt, "No file selected.");
            // 
            // file1Txt
            // 
            this.file1Txt.Location = new System.Drawing.Point(94, 144);
            this.file1Txt.Name = "file1Txt";
            this.file1Txt.Size = new System.Drawing.Size(399, 20);
            this.file1Txt.TabIndex = 3;
            this.file1Txt.Text = "No file selected.";
            this.toolTip.SetToolTip(this.file1Txt, "No file selected.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "File:";
            // 
            // importTablesBtn
            // 
            this.importTablesBtn.BackColor = System.Drawing.Color.Gold;
            this.importTablesBtn.FlatAppearance.BorderSize = 0;
            this.importTablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importTablesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.importTablesBtn.Location = new System.Drawing.Point(531, 499);
            this.importTablesBtn.Name = "importTablesBtn";
            this.importTablesBtn.Size = new System.Drawing.Size(179, 61);
            this.importTablesBtn.TabIndex = 2;
            this.importTablesBtn.Text = "Import";
            this.toolTip.SetToolTip(this.importTablesBtn, "Import these tables into the database");
            this.importTablesBtn.UseVisualStyleBackColor = false;
            this.importTablesBtn.Click += new System.EventHandler(this.importTablesBtn_Click);
            // 
            // selectFile2
            // 
            this.selectFile2.BackColor = System.Drawing.Color.Gold;
            this.selectFile2.FlatAppearance.BorderSize = 0;
            this.selectFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectFile2.Location = new System.Drawing.Point(499, 288);
            this.selectFile2.Name = "selectFile2";
            this.selectFile2.Size = new System.Drawing.Size(133, 34);
            this.selectFile2.TabIndex = 2;
            this.selectFile2.Text = "Select File";
            this.toolTip.SetToolTip(this.selectFile2, "Select a table to import");
            this.selectFile2.UseVisualStyleBackColor = false;
            this.selectFile2.Click += new System.EventHandler(this.selectFile2Btn_Click);
            // 
            // file2TextBox
            // 
            this.file2TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file2TextBox.Location = new System.Drawing.Point(52, 290);
            this.file2TextBox.Name = "file2TextBox";
            this.file2TextBox.Size = new System.Drawing.Size(441, 32);
            this.file2TextBox.TabIndex = 1;
            // 
            // clear1
            // 
            this.clear1.BackColor = System.Drawing.Color.White;
            this.clear1.Enabled = false;
            this.clear1.FlatAppearance.BorderSize = 0;
            this.clear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear1.ForeColor = System.Drawing.Color.Red;
            this.clear1.Location = new System.Drawing.Point(638, 172);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(62, 34);
            this.clear1.TabIndex = 2;
            this.clear1.Text = "Clear";
            this.toolTip.SetToolTip(this.clear1, "Clear the selected file");
            this.clear1.UseVisualStyleBackColor = false;
            this.clear1.Visible = false;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // clear2
            // 
            this.clear2.BackColor = System.Drawing.Color.White;
            this.clear2.Enabled = false;
            this.clear2.FlatAppearance.BorderSize = 0;
            this.clear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear2.ForeColor = System.Drawing.Color.Red;
            this.clear2.Location = new System.Drawing.Point(638, 288);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(62, 34);
            this.clear2.TabIndex = 2;
            this.clear2.Text = "Clear";
            this.toolTip.SetToolTip(this.clear2, "Clear the selected file");
            this.clear2.UseVisualStyleBackColor = false;
            this.clear2.Visible = false;
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // selectFile1
            // 
            this.selectFile1.BackColor = System.Drawing.Color.Gold;
            this.selectFile1.FlatAppearance.BorderSize = 0;
            this.selectFile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectFile1.Location = new System.Drawing.Point(499, 172);
            this.selectFile1.Name = "selectFile1";
            this.selectFile1.Size = new System.Drawing.Size(133, 34);
            this.selectFile1.TabIndex = 2;
            this.selectFile1.Text = "Select File";
            this.toolTip.SetToolTip(this.selectFile1, "Select a table to import");
            this.selectFile1.UseVisualStyleBackColor = false;
            this.selectFile1.Click += new System.EventHandler(this.selectFile1Btn_Click);
            // 
            // file1TextBox
            // 
            this.file1TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file1TextBox.Location = new System.Drawing.Point(52, 174);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.Size = new System.Drawing.Size(441, 32);
            this.file1TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import a table into the database";
            // 
            // exportTablesBtn
            // 
            this.exportTablesBtn.BackColor = System.Drawing.Color.Gold;
            this.exportTablesBtn.FlatAppearance.BorderSize = 0;
            this.exportTablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportTablesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportTablesBtn.Location = new System.Drawing.Point(512, 499);
            this.exportTablesBtn.Name = "exportTablesBtn";
            this.exportTablesBtn.Size = new System.Drawing.Size(179, 61);
            this.exportTablesBtn.TabIndex = 2;
            this.exportTablesBtn.Text = "Export";
            this.toolTip.SetToolTip(this.exportTablesBtn, "Import these tables into the database");
            this.exportTablesBtn.UseVisualStyleBackColor = false;
            this.exportTablesBtn.Click += new System.EventHandler(this.exportTablesBtn_Click);
            // 
            // openLocation
            // 
            this.openLocation.BackColor = System.Drawing.Color.Gold;
            this.openLocation.FlatAppearance.BorderSize = 0;
            this.openLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLocation.Location = new System.Drawing.Point(512, 239);
            this.openLocation.Name = "openLocation";
            this.openLocation.Size = new System.Drawing.Size(101, 32);
            this.openLocation.TabIndex = 6;
            this.openLocation.Text = "Select ";
            this.toolTip.SetToolTip(this.openLocation, "Select a folder to export to");
            this.openLocation.UseVisualStyleBackColor = false;
            this.openLocation.Click += new System.EventHandler(this.openLocation_Click);
            // 
            // clearExportLocation
            // 
            this.clearExportLocation.BackColor = System.Drawing.Color.White;
            this.clearExportLocation.Enabled = false;
            this.clearExportLocation.FlatAppearance.BorderSize = 0;
            this.clearExportLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearExportLocation.ForeColor = System.Drawing.Color.Red;
            this.clearExportLocation.Location = new System.Drawing.Point(619, 238);
            this.clearExportLocation.Name = "clearExportLocation";
            this.clearExportLocation.Size = new System.Drawing.Size(62, 34);
            this.clearExportLocation.TabIndex = 7;
            this.clearExportLocation.Text = "Clear";
            this.toolTip.SetToolTip(this.clearExportLocation, "Clear the selected file");
            this.clearExportLocation.UseVisualStyleBackColor = false;
            this.clearExportLocation.Visible = false;
            this.clearExportLocation.Click += new System.EventHandler(this.clearExportLocation_Click);
            // 
            // exportPanel
            // 
            this.exportPanel.Controls.Add(this.tableComboBox);
            this.exportPanel.Controls.Add(this.exportLocationTxt);
            this.exportPanel.Controls.Add(this.openLocation);
            this.exportPanel.Controls.Add(this.clearExportLocation);
            this.exportPanel.Controls.Add(this.exportTablesBtn);
            this.exportPanel.Controls.Add(this.label5);
            this.exportPanel.Controls.Add(this.label3);
            this.exportPanel.Controls.Add(this.label13);
            this.exportPanel.Enabled = false;
            this.exportPanel.Location = new System.Drawing.Point(325, 25);
            this.exportPanel.Name = "exportPanel";
            this.exportPanel.Size = new System.Drawing.Size(734, 597);
            this.exportPanel.TabIndex = 8;
            this.exportPanel.Visible = false;
            this.exportPanel.EnabledChanged += new System.EventHandler(this.exportPanel_EnabledChanged);
            // 
            // exportLocationTxt
            // 
            this.exportLocationTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportLocationTxt.Location = new System.Drawing.Point(33, 239);
            this.exportLocationTxt.Name = "exportLocationTxt";
            this.exportLocationTxt.Size = new System.Drawing.Size(473, 32);
            this.exportLocationTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select an export location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select a table:";
            // 
            // tableComboBox
            // 
            this.tableComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(33, 136);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(473, 31);
            this.tableComboBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(33, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(342, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Export a table from the database";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImportPanel);
            this.Controls.Add(this.exportPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(1059, 623);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ImportPanel.ResumeLayout(false);
            this.ImportPanel.PerformLayout();
            this.exportPanel.ResumeLayout(false);
            this.exportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel ImportPanel;
        private System.Windows.Forms.Button selectFile1;
        private System.Windows.Forms.TextBox file1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label file1Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button importTablesBtn;
        private System.Windows.Forms.Label file2Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectVFile;
        private System.Windows.Forms.TextBox vehicleTableTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label listTables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectFile2;
        private System.Windows.Forms.TextBox file2TextBox;
        private System.Windows.Forms.Button clear2;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.Panel exportPanel;
        private System.Windows.Forms.Button exportTablesBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox exportLocationTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Button clearExportLocation;
        private System.Windows.Forms.Button openLocation;
    }
}
