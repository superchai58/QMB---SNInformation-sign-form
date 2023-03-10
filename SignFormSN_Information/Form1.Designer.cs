namespace SignFormSN_Information
{
    partial class frmSnInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvSN_Trace = new System.Windows.Forms.DataGridView();
            this.dgvSMT_SP = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtscan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnCrytalReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.bgwExcel = new System.ComponentModel.BackgroundWorker();
            this.bgwCreateSign = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSN_Trace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMT_SP)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 751);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SN_Information";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvSN_Trace);
            this.panel8.Controls.Add(this.dgvSMT_SP);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(3, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(978, 528);
            this.panel8.TabIndex = 4;
            // 
            // dgvSN_Trace
            // 
            this.dgvSN_Trace.AllowUserToAddRows = false;
            this.dgvSN_Trace.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSN_Trace.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSN_Trace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSN_Trace.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvSN_Trace.Location = new System.Drawing.Point(501, 0);
            this.dgvSN_Trace.Name = "dgvSN_Trace";
            this.dgvSN_Trace.Size = new System.Drawing.Size(477, 528);
            this.dgvSN_Trace.TabIndex = 0;
            // 
            // dgvSMT_SP
            // 
            this.dgvSMT_SP.AllowUserToAddRows = false;
            this.dgvSMT_SP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSMT_SP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSMT_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSMT_SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSMT_SP.Location = new System.Drawing.Point(0, 0);
            this.dgvSMT_SP.Name = "dgvSMT_SP";
            this.dgvSMT_SP.Size = new System.Drawing.Size(978, 528);
            this.dgvSMT_SP.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 633);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 115);
            this.panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How to use";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(781, 78);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(781, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "     (L) Scan serial number\r\n     (R, BTN1) Export excel file\r\n     (R, BTN2) Cre" +
    "ate Sign form ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pcbLoad);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(784, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 78);
            this.panel5.TabIndex = 0;
            // 
            // pcbLoad
            // 
            this.pcbLoad.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLoad.Image = global::SignFormSN_Information.Properties.Resources.Loading;
            this.pcbLoad.Location = new System.Drawing.Point(0, 0);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(191, 78);
            this.pcbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLoad.TabIndex = 3;
            this.pcbLoad.TabStop = false;
            this.pcbLoad.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtscan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 71);
            this.panel2.TabIndex = 0;
            // 
            // txtscan
            // 
            this.txtscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscan.Location = new System.Drawing.Point(201, 13);
            this.txtscan.Name = "txtscan";
            this.txtscan.Size = new System.Drawing.Size(300, 31);
            this.txtscan.TabIndex = 2;
            this.txtscan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtscan_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial number :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportExcel);
            this.panel3.Controls.Add(this.btnCrytalReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(657, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 71);
            this.panel3.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(9, 13);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(147, 45);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCrytalReport
            // 
            this.btnCrytalReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCrytalReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrytalReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrytalReport.Location = new System.Drawing.Point(162, 13);
            this.btnCrytalReport.Name = "btnCrytalReport";
            this.btnCrytalReport.Size = new System.Drawing.Size(147, 45);
            this.btnCrytalReport.TabIndex = 1;
            this.btnCrytalReport.Text = "Create Sign";
            this.btnCrytalReport.UseVisualStyleBackColor = false;
            this.btnCrytalReport.Click += new System.EventHandler(this.btnCrytalReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 751);
            this.panel1.TabIndex = 0;
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // bgwScan
            // 
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            this.bgwScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScan_RunWorkerCompleted);
            // 
            // bgwExcel
            // 
            this.bgwExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExcel_DoWork);
            this.bgwExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExcel_RunWorkerCompleted);
            // 
            // bgwCreateSign
            // 
            this.bgwCreateSign.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateSign_DoWork);
            this.bgwCreateSign.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateSign_RunWorkerCompleted);
            // 
            // frmSnInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 751);
            this.Controls.Add(this.panel1);
            this.Name = "frmSnInformation";
            this.Text = "frmSign SN_Information";
            this.Load += new System.EventHandler(this.frmSnInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSN_Trace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMT_SP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSMT_SP;
        private System.Windows.Forms.DataGridView dgvSN_Trace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtscan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnCrytalReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbLoad;
        private System.ComponentModel.BackgroundWorker bgwLoad;
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker bgwExcel;
        private System.ComponentModel.BackgroundWorker bgwCreateSign;
    }
}

