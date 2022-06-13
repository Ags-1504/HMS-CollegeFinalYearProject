
namespace WindowsFormsApp1
{
    partial class DischargePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DischargePatient));
            this.SelPatlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatIDTb = new System.Windows.Forms.TextBox();
            this.PatIDlbl = new System.Windows.Forms.Label();
            this.PatNamCb = new System.Windows.Forms.ComboBox();
            this.PatNamelbl = new System.Windows.Forms.Label();
            this.DischargeBtn = new System.Windows.Forms.Button();
            this.Billdgv = new System.Windows.Forms.DataGridView();
            this.DoctorCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosticCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Billdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // SelPatlbl
            // 
            this.SelPatlbl.AutoSize = true;
            this.SelPatlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelPatlbl.Location = new System.Drawing.Point(35, 9);
            this.SelPatlbl.Name = "SelPatlbl";
            this.SelPatlbl.Size = new System.Drawing.Size(140, 24);
            this.SelPatlbl.TabIndex = 13;
            this.SelPatlbl.Text = "Select Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PatIDTb);
            this.panel1.Controls.Add(this.PatIDlbl);
            this.panel1.Controls.Add(this.PatNamCb);
            this.panel1.Controls.Add(this.PatNamelbl);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 150);
            this.panel1.TabIndex = 12;
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
            this.PatIDlbl.Size = new System.Drawing.Size(135, 24);
            this.PatIDlbl.TabIndex = 5;
            this.PatIDlbl.Text = "Patient Name";
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
            // DischargeBtn
            // 
            this.DischargeBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DischargeBtn.Location = new System.Drawing.Point(576, 41);
            this.DischargeBtn.Name = "DischargeBtn";
            this.DischargeBtn.Size = new System.Drawing.Size(220, 47);
            this.DischargeBtn.TabIndex = 14;
            this.DischargeBtn.Text = "Discharge && Show Bill";
            this.DischargeBtn.UseVisualStyleBackColor = true;
            this.DischargeBtn.Click += new System.EventHandler(this.DischargeBtn_Click);
            // 
            // Billdgv
            // 
            this.Billdgv.AllowUserToAddRows = false;
            this.Billdgv.AllowUserToDeleteRows = false;
            this.Billdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Billdgv.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Billdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Billdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Billdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Billdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Billdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Billdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorCharges,
            this.BedCharges,
            this.MedicineCharges,
            this.DiagnosticCharges,
            this.TotalCharges});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Billdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Billdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Billdgv.Location = new System.Drawing.Point(72, 249);
            this.Billdgv.Name = "Billdgv";
            this.Billdgv.ReadOnly = true;
            this.Billdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Billdgv.RowHeadersVisible = false;
            this.Billdgv.RowHeadersWidth = 51;
            this.Billdgv.RowTemplate.Height = 24;
            this.Billdgv.Size = new System.Drawing.Size(671, 146);
            this.Billdgv.TabIndex = 15;
            // 
            // DoctorCharges
            // 
            this.DoctorCharges.HeaderText = "Doctor Charges";
            this.DoctorCharges.MinimumWidth = 6;
            this.DoctorCharges.Name = "DoctorCharges";
            this.DoctorCharges.ReadOnly = true;
            // 
            // BedCharges
            // 
            this.BedCharges.HeaderText = "Bed Charges";
            this.BedCharges.MinimumWidth = 6;
            this.BedCharges.Name = "BedCharges";
            this.BedCharges.ReadOnly = true;
            // 
            // MedicineCharges
            // 
            this.MedicineCharges.HeaderText = "Medicine Charges";
            this.MedicineCharges.MinimumWidth = 6;
            this.MedicineCharges.Name = "MedicineCharges";
            this.MedicineCharges.ReadOnly = true;
            // 
            // DiagnosticCharges
            // 
            this.DiagnosticCharges.HeaderText = "Diagnostic Charges";
            this.DiagnosticCharges.MinimumWidth = 6;
            this.DiagnosticCharges.Name = "DiagnosticCharges";
            this.DiagnosticCharges.ReadOnly = true;
            // 
            // TotalCharges
            // 
            this.TotalCharges.HeaderText = "Total Charges";
            this.TotalCharges.MinimumWidth = 6;
            this.TotalCharges.Name = "TotalCharges";
            this.TotalCharges.ReadOnly = true;
            // 
            // DischargePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 407);
            this.Controls.Add(this.Billdgv);
            this.Controls.Add(this.DischargeBtn);
            this.Controls.Add(this.SelPatlbl);
            this.Controls.Add(this.panel1);
            this.Name = "DischargePatient";
            this.Text = "DischargePatient";
            this.Load += new System.EventHandler(this.DischargePatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Billdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelPatlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PatIDTb;
        private System.Windows.Forms.Label PatIDlbl;
        private System.Windows.Forms.ComboBox PatNamCb;
        private System.Windows.Forms.Label PatNamelbl;
        private System.Windows.Forms.Button DischargeBtn;
        private System.Windows.Forms.DataGridView Billdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosticCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCharges;
    }
}