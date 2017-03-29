namespace TransactionRecording
{
    partial class ReportForm
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
            this.reportListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // reportListView
            // 
            this.reportListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportListView.Location = new System.Drawing.Point(0, 0);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(661, 376);
            this.reportListView.TabIndex = 0;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            this.reportListView.View = System.Windows.Forms.View.List;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 376);
            this.Controls.Add(this.reportListView);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView reportListView;
    }
}