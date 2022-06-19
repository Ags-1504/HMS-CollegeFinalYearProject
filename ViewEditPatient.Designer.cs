
namespace WindowsFormsApp1
{
    partial class ViewEditPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditPatient));
            this.PatCntlbl = new System.Windows.Forms.Label();
            this.PatCntTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatIDTb = new System.Windows.Forms.TextBox();
            this.PatIDlbl = new System.Windows.Forms.Label();
            this.PatNamCb = new System.Windows.Forms.ComboBox();
            this.PatNamelbl = new System.Windows.Forms.Label();
            this.SelPatlbl = new System.Windows.Forms.Label();
            this.Medicinesdgv = new System.Windows.Forms.DataGridView();
            this.Medlbl = new System.Windows.Forms.Label();
            this.Testslbl = new System.Windows.Forms.Label();
            this.Testsdgv = new System.Windows.Forms.DataGridView();
            this.TestReportTb = new System.Windows.Forms.RichTextBox();
            this.ReportTblbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medicinesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PatCntlbl
            // 
            this.PatCntlbl.AutoSize = true;
            this.PatCntlbl.BackColor = System.Drawing.Color.Transparent;
            this.PatCntlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatCntlbl.Location = new System.Drawing.Point(996, 20);
            this.PatCntlbl.Name = "PatCntlbl";
            this.PatCntlbl.Size = new System.Drawing.Size(217, 24);
            this.PatCntlbl.TabIndex = 9;
            this.PatCntlbl.Text = "Current Patient Count";
            // 
            // PatCntTb
            // 
            this.PatCntTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatCntTb.Location = new System.Drawing.Point(1230, 12);
            this.PatCntTb.Name = "PatCntTb";
            this.PatCntTb.Size = new System.Drawing.Size(119, 32);
            this.PatCntTb.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PatIDTb);
            this.panel1.Controls.Add(this.PatIDlbl);
            this.panel1.Controls.Add(this.PatNamCb);
            this.panel1.Controls.Add(this.PatNamelbl);
            this.panel1.Location = new System.Drawing.Point(19, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 150);
            this.panel1.TabIndex = 10;
            // 
            // PatIDTb
            // 
            this.PatIDTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatIDTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatIDTb.Location = new System.Drawing.Point(193, 94);
            this.PatIDTb.Name = "PatIDTb";
            this.PatIDTb.ReadOnly = true;
            this.PatIDTb.Size = new System.Drawing.Size(255, 32);
            this.PatIDTb.TabIndex = 6;
            // 
            // PatIDlbl
            // 
            this.PatIDlbl.AutoSize = true;
            this.PatIDlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatIDlbl.Location = new System.Drawing.Point(14, 94);
            this.PatIDlbl.Name = "PatIDlbl";
            this.PatIDlbl.Size = new System.Drawing.Size(101, 24);
            this.PatIDlbl.TabIndex = 5;
            this.PatIDlbl.Text = "Patient ID";
            // 
            // PatNamCb
            // 
            this.PatNamCb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNamCb.FormattingEnabled = true;
            this.PatNamCb.Location = new System.Drawing.Point(193, 20);
            this.PatNamCb.Name = "PatNamCb";
            this.PatNamCb.Size = new System.Drawing.Size(272, 33);
            this.PatNamCb.TabIndex = 4;
            this.PatNamCb.SelectedIndexChanged += new System.EventHandler(this.PatNamCb_SelectedIndexChanged);
            // 
            // PatNamelbl
            // 
            this.PatNamelbl.AutoSize = true;
            this.PatNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNamelbl.Location = new System.Drawing.Point(14, 20);
            this.PatNamelbl.Name = "PatNamelbl";
            this.PatNamelbl.Size = new System.Drawing.Size(135, 24);
            this.PatNamelbl.TabIndex = 3;
            this.PatNamelbl.Text = "Patient Name";
            // 
            // SelPatlbl
            // 
            this.SelPatlbl.AutoSize = true;
            this.SelPatlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelPatlbl.Location = new System.Drawing.Point(42, 35);
            this.SelPatlbl.Name = "SelPatlbl";
            this.SelPatlbl.Size = new System.Drawing.Size(140, 24);
            this.SelPatlbl.TabIndex = 11;
            this.SelPatlbl.Text = "Select Patient";
            // 
            // Medicinesdgv
            // 
            this.Medicinesdgv.AllowUserToAddRows = false;
            this.Medicinesdgv.AllowUserToDeleteRows = false;
            this.Medicinesdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Medicinesdgv.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Medicinesdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Medicinesdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Medicinesdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Medicinesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Medicinesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Medicinesdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Medicinesdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Medicinesdgv.Location = new System.Drawing.Point(19, 252);
            this.Medicinesdgv.Name = "Medicinesdgv";
            this.Medicinesdgv.ReadOnly = true;
            this.Medicinesdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Medicinesdgv.RowHeadersVisible = false;
            this.Medicinesdgv.RowHeadersWidth = 51;
            this.Medicinesdgv.RowTemplate.Height = 24;
            this.Medicinesdgv.Size = new System.Drawing.Size(657, 313);
            this.Medicinesdgv.TabIndex = 12;
            // 
            // Medlbl
            // 
            this.Medlbl.AutoSize = true;
            this.Medlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medlbl.Location = new System.Drawing.Point(15, 217);
            this.Medlbl.Name = "Medlbl";
            this.Medlbl.Size = new System.Drawing.Size(220, 24);
            this.Medlbl.TabIndex = 15;
            this.Medlbl.Text = "Medicines Prescribed:";
            // 
            // Testslbl
            // 
            this.Testslbl.AutoSize = true;
            this.Testslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testslbl.Location = new System.Drawing.Point(692, 61);
            this.Testslbl.Name = "Testslbl";
            this.Testslbl.Size = new System.Drawing.Size(177, 24);
            this.Testslbl.TabIndex = 16;
            this.Testslbl.Text = "Tests Prescribed:";
            // 
            // Testsdgv
            // 
            this.Testsdgv.AllowUserToAddRows = false;
            this.Testsdgv.AllowUserToDeleteRows = false;
            this.Testsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Testsdgv.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Testsdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Testsdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Testsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Testsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Testsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Testsdgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Testsdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Testsdgv.Location = new System.Drawing.Point(690, 94);
            this.Testsdgv.Name = "Testsdgv";
            this.Testsdgv.ReadOnly = true;
            this.Testsdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Testsdgv.RowHeadersVisible = false;
            this.Testsdgv.RowHeadersWidth = 51;
            this.Testsdgv.RowTemplate.Height = 24;
            this.Testsdgv.Size = new System.Drawing.Size(659, 327);
            this.Testsdgv.TabIndex = 17;
            this.Testsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Testsdgv_CellContentClick);
            // 
            // TestReportTb
            // 
            this.TestReportTb.Location = new System.Drawing.Point(690, 468);
            this.TestReportTb.Name = "TestReportTb";
            this.TestReportTb.Size = new System.Drawing.Size(659, 87);
            this.TestReportTb.TabIndex = 18;
            this.TestReportTb.Text = "";
            // 
            // ReportTblbl
            // 
            this.ReportTblbl.AutoSize = true;
            this.ReportTblbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTblbl.Location = new System.Drawing.Point(692, 441);
            this.ReportTblbl.Name = "ReportTblbl";
            this.ReportTblbl.Size = new System.Drawing.Size(564, 20);
            this.ReportTblbl.TabIndex = 19;
            this.ReportTblbl.Text = "Add a Test Comment here and Click on the Test Row to Add a report";
            // 
            // ViewEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 577);
            this.Controls.Add(this.ReportTblbl);
            this.Controls.Add(this.TestReportTb);
            this.Controls.Add(this.Testsdgv);
            this.Controls.Add(this.Testslbl);
            this.Controls.Add(this.Medlbl);
            this.Controls.Add(this.Medicinesdgv);
            this.Controls.Add(this.SelPatlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatCntlbl);
            this.Controls.Add(this.PatCntTb);
            this.Name = "ViewEditPatient";
            this.Text = "ViewEditPatient";
            this.Load += new System.EventHandler(this.ViewEditPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medicinesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatCntlbl;
        private System.Windows.Forms.TextBox PatCntTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PatIDTb;
        private System.Windows.Forms.Label PatIDlbl;
        private System.Windows.Forms.ComboBox PatNamCb;
        private System.Windows.Forms.Label PatNamelbl;
        private System.Windows.Forms.Label SelPatlbl;
        private System.Windows.Forms.DataGridView Medicinesdgv;
        private System.Windows.Forms.Label Medlbl;
        private System.Windows.Forms.Label Testslbl;
        private System.Windows.Forms.DataGridView Testsdgv;
        private System.Windows.Forms.RichTextBox TestReportTb;
        private System.Windows.Forms.Label ReportTblbl;
    }
}