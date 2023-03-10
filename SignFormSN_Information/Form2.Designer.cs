namespace SignFormSN_Information
{
    partial class Form2
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
            this.vwReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // vwReport
            // 
            this.vwReport.ActiveViewIndex = -1;
            this.vwReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vwReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.vwReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vwReport.Location = new System.Drawing.Point(0, 0);
            this.vwReport.Name = "vwReport";
            this.vwReport.Size = new System.Drawing.Size(709, 800);
            this.vwReport.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 800);
            this.Controls.Add(this.vwReport);
            this.Name = "Form2";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vwReport;
    }
}