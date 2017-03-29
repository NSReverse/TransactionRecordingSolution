namespace TransactionRecording
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entriesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewEntriesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewDepartmentsButton = new System.Windows.Forms.Button();
            this.departmentsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateReportsButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entriesTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.viewEntriesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entries";
            // 
            // entriesTextBox
            // 
            this.entriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesTextBox.Enabled = false;
            this.entriesTextBox.Location = new System.Drawing.Point(160, 13);
            this.entriesTextBox.Name = "entriesTextBox";
            this.entriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.entriesTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Entries";
            // 
            // viewEntriesButton
            // 
            this.viewEntriesButton.Location = new System.Drawing.Point(185, 39);
            this.viewEntriesButton.Name = "viewEntriesButton";
            this.viewEntriesButton.Size = new System.Drawing.Size(75, 23);
            this.viewEntriesButton.TabIndex = 0;
            this.viewEntriesButton.Text = "View Entries";
            this.viewEntriesButton.UseVisualStyleBackColor = true;
            this.viewEntriesButton.Click += new System.EventHandler(this.viewEntriesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewDepartmentsButton);
            this.groupBox2.Controls.Add(this.departmentsTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departments";
            // 
            // viewDepartmentsButton
            // 
            this.viewDepartmentsButton.Location = new System.Drawing.Point(155, 49);
            this.viewDepartmentsButton.Name = "viewDepartmentsButton";
            this.viewDepartmentsButton.Size = new System.Drawing.Size(105, 23);
            this.viewDepartmentsButton.TabIndex = 7;
            this.viewDepartmentsButton.Text = "View Departments";
            this.viewDepartmentsButton.UseVisualStyleBackColor = true;
            this.viewDepartmentsButton.Click += new System.EventHandler(this.viewDepartmentsButton_Click);
            // 
            // departmentsTextBox
            // 
            this.departmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentsTextBox.Enabled = false;
            this.departmentsTextBox.Location = new System.Drawing.Point(160, 19);
            this.departmentsTextBox.Name = "departmentsTextBox";
            this.departmentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentsTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Departments";
            // 
            // generateReportsButton
            // 
            this.generateReportsButton.Location = new System.Drawing.Point(157, 172);
            this.generateReportsButton.Name = "generateReportsButton";
            this.generateReportsButton.Size = new System.Drawing.Size(121, 33);
            this.generateReportsButton.TabIndex = 2;
            this.generateReportsButton.Text = "Generate Reports";
            this.generateReportsButton.UseVisualStyleBackColor = true;
            this.generateReportsButton.Click += new System.EventHandler(this.generateReportsButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(12, 172);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(121, 33);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload Data";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 211);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.generateReportsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(306, 249);
            this.MinimumSize = new System.Drawing.Size(306, 249);
            this.Name = "Form1";
            this.Text = "DBMS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewEntriesButton;
        private System.Windows.Forms.TextBox entriesTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewDepartmentsButton;
        private System.Windows.Forms.TextBox departmentsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateReportsButton;
        private System.Windows.Forms.Button reloadButton;
    }
}

