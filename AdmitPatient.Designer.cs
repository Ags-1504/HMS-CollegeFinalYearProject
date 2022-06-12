
namespace WindowsFormsApp1
{
    partial class AdmitPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmitPatient));
            this.PatientPersonalInfo = new System.Windows.Forms.Panel();
            this.PatAddTb = new System.Windows.Forms.RichTextBox();
            this.Patphnlbl = new System.Windows.Forms.Label();
            this.PatphnnoTb = new System.Windows.Forms.TextBox();
            this.PatAddlbl = new System.Windows.Forms.Label();
            this.PatNamelbl = new System.Windows.Forms.Label();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.PersonalInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoctorAssCb = new System.Windows.Forms.ComboBox();
            this.DoctorAsslbl = new System.Windows.Forms.Label();
            this.AdmDeptCb = new System.Windows.Forms.ComboBox();
            this.AdmDeptlbl = new System.Windows.Forms.Label();
            this.AllotBedCb = new System.Windows.Forms.ComboBox();
            this.AllotBedlbl = new System.Windows.Forms.Label();
            this.AdmitBtn = new System.Windows.Forms.Button();
            this.MedicalDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatCntTb = new System.Windows.Forms.TextBox();
            this.QRcodepic = new System.Windows.Forms.PictureBox();
            this.PatientPersonalInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodepic)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientPersonalInfo
            // 
            this.PatientPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.PatientPersonalInfo.Controls.Add(this.PatAddTb);
            this.PatientPersonalInfo.Controls.Add(this.Patphnlbl);
            this.PatientPersonalInfo.Controls.Add(this.PatphnnoTb);
            this.PatientPersonalInfo.Controls.Add(this.PatAddlbl);
            this.PatientPersonalInfo.Controls.Add(this.PatNamelbl);
            this.PatientPersonalInfo.Controls.Add(this.PatNameTb);
            this.PatientPersonalInfo.Location = new System.Drawing.Point(31, 65);
            this.PatientPersonalInfo.Name = "PatientPersonalInfo";
            this.PatientPersonalInfo.Size = new System.Drawing.Size(508, 272);
            this.PatientPersonalInfo.TabIndex = 0;
            // 
            // PatAddTb
            // 
            this.PatAddTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatAddTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddTb.Location = new System.Drawing.Point(224, 157);
            this.PatAddTb.Name = "PatAddTb";
            this.PatAddTb.Size = new System.Drawing.Size(255, 96);
            this.PatAddTb.TabIndex = 6;
            this.PatAddTb.Text = "";
            // 
            // Patphnlbl
            // 
            this.Patphnlbl.AutoSize = true;
            this.Patphnlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patphnlbl.Location = new System.Drawing.Point(30, 105);
            this.Patphnlbl.Name = "Patphnlbl";
            this.Patphnlbl.Size = new System.Drawing.Size(178, 24);
            this.Patphnlbl.TabIndex = 5;
            this.Patphnlbl.Text = "Patient Phone no.";
            // 
            // PatphnnoTb
            // 
            this.PatphnnoTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatphnnoTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatphnnoTb.Location = new System.Drawing.Point(224, 97);
            this.PatphnnoTb.Name = "PatphnnoTb";
            this.PatphnnoTb.Size = new System.Drawing.Size(255, 32);
            this.PatphnnoTb.TabIndex = 4;
            // 
            // PatAddlbl
            // 
            this.PatAddlbl.AutoSize = true;
            this.PatAddlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddlbl.Location = new System.Drawing.Point(30, 180);
            this.PatAddlbl.Name = "PatAddlbl";
            this.PatAddlbl.Size = new System.Drawing.Size(159, 24);
            this.PatAddlbl.TabIndex = 3;
            this.PatAddlbl.Text = "Patient Address";
            // 
            // PatNamelbl
            // 
            this.PatNamelbl.AutoSize = true;
            this.PatNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNamelbl.Location = new System.Drawing.Point(31, 40);
            this.PatNamelbl.Name = "PatNamelbl";
            this.PatNamelbl.Size = new System.Drawing.Size(135, 24);
            this.PatNamelbl.TabIndex = 1;
            this.PatNamelbl.Text = "Patient Name";
            // 
            // PatNameTb
            // 
            this.PatNameTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.Location = new System.Drawing.Point(225, 32);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(255, 32);
            this.PatNameTb.TabIndex = 0;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.AutoSize = true;
            this.PersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PersonalInfo.Location = new System.Drawing.Point(111, 42);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(139, 25);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.Text = "Personal Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DoctorAssCb);
            this.panel1.Controls.Add(this.DoctorAsslbl);
            this.panel1.Controls.Add(this.AdmDeptCb);
            this.panel1.Controls.Add(this.AdmDeptlbl);
            this.panel1.Controls.Add(this.AllotBedCb);
            this.panel1.Controls.Add(this.AllotBedlbl);
            this.panel1.Location = new System.Drawing.Point(545, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 253);
            this.panel1.TabIndex = 2;
            // 
            // DoctorAssCb
            // 
            this.DoctorAssCb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DoctorAssCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorAssCb.FormattingEnabled = true;
            this.DoctorAssCb.Location = new System.Drawing.Point(222, 200);
            this.DoctorAssCb.Name = "DoctorAssCb";
            this.DoctorAssCb.Size = new System.Drawing.Size(245, 33);
            this.DoctorAssCb.TabIndex = 7;
            this.DoctorAssCb.SelectedIndexChanged += new System.EventHandler(this.DoctorAssCb_SelectedIndexChanged);
            // 
            // DoctorAsslbl
            // 
            this.DoctorAsslbl.AutoSize = true;
            this.DoctorAsslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorAsslbl.Location = new System.Drawing.Point(12, 209);
            this.DoctorAsslbl.Name = "DoctorAsslbl";
            this.DoctorAsslbl.Size = new System.Drawing.Size(156, 25);
            this.DoctorAsslbl.TabIndex = 6;
            this.DoctorAsslbl.Text = "Assigned Doctor";
            // 
            // AdmDeptCb
            // 
            this.AdmDeptCb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AdmDeptCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmDeptCb.FormattingEnabled = true;
            this.AdmDeptCb.Location = new System.Drawing.Point(265, 118);
            this.AdmDeptCb.Name = "AdmDeptCb";
            this.AdmDeptCb.Size = new System.Drawing.Size(202, 33);
            this.AdmDeptCb.TabIndex = 5;
            this.AdmDeptCb.SelectedIndexChanged += new System.EventHandler(this.AdmDeptCb_SelectedIndexChanged);
            // 
            // AdmDeptlbl
            // 
            this.AdmDeptlbl.AutoSize = true;
            this.AdmDeptlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmDeptlbl.Location = new System.Drawing.Point(12, 127);
            this.AdmDeptlbl.Name = "AdmDeptlbl";
            this.AdmDeptlbl.Size = new System.Drawing.Size(209, 25);
            this.AdmDeptlbl.TabIndex = 4;
            this.AdmDeptlbl.Text = "Admission Department";
            // 
            // AllotBedCb
            // 
            this.AllotBedCb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AllotBedCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotBedCb.FormattingEnabled = true;
            this.AllotBedCb.Location = new System.Drawing.Point(162, 46);
            this.AllotBedCb.Name = "AllotBedCb";
            this.AllotBedCb.Size = new System.Drawing.Size(305, 33);
            this.AllotBedCb.TabIndex = 3;
            this.AllotBedCb.SelectedIndexChanged += new System.EventHandler(this.AllotBedCb_SelectedIndexChanged);
            // 
            // AllotBedlbl
            // 
            this.AllotBedlbl.AutoSize = true;
            this.AllotBedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotBedlbl.Location = new System.Drawing.Point(12, 50);
            this.AllotBedlbl.Name = "AllotBedlbl";
            this.AllotBedlbl.Size = new System.Drawing.Size(90, 25);
            this.AllotBedlbl.TabIndex = 2;
            this.AllotBedlbl.Text = "Allot Bed";
            // 
            // AdmitBtn
            // 
            this.AdmitBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AdmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmitBtn.Location = new System.Drawing.Point(31, 437);
            this.AdmitBtn.Name = "AdmitBtn";
            this.AdmitBtn.Size = new System.Drawing.Size(475, 49);
            this.AdmitBtn.TabIndex = 3;
            this.AdmitBtn.Text = "ADMIT &&  Generate BarCode";
            this.AdmitBtn.UseVisualStyleBackColor = false;
            this.AdmitBtn.Click += new System.EventHandler(this.AdmitBtn_Click);
            // 
            // MedicalDetails
            // 
            this.MedicalDetails.AutoSize = true;
            this.MedicalDetails.BackColor = System.Drawing.Color.Transparent;
            this.MedicalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MedicalDetails.Location = new System.Drawing.Point(621, 41);
            this.MedicalDetails.Name = "MedicalDetails";
            this.MedicalDetails.Size = new System.Drawing.Size(159, 25);
            this.MedicalDetails.TabIndex = 5;
            this.MedicalDetails.Text = "Medical Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Patient Count";
            // 
            // PatCntTb
            // 
            this.PatCntTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatCntTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatCntTb.Location = new System.Drawing.Point(287, 352);
            this.PatCntTb.Name = "PatCntTb";
            this.PatCntTb.Size = new System.Drawing.Size(119, 32);
            this.PatCntTb.TabIndex = 6;
            // 
            // QRcodepic
            // 
            this.QRcodepic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QRcodepic.Location = new System.Drawing.Point(670, 333);
            this.QRcodepic.Name = "QRcodepic";
            this.QRcodepic.Size = new System.Drawing.Size(264, 191);
            this.QRcodepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRcodepic.TabIndex = 8;
            this.QRcodepic.TabStop = false;
            // 
            // AdmitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1124, 546);
            this.Controls.Add(this.QRcodepic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatCntTb);
            this.Controls.Add(this.MedicalDetails);
            this.Controls.Add(this.AdmitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PersonalInfo);
            this.Controls.Add(this.PatientPersonalInfo);
            this.Name = "AdmitPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmitPatient";
            this.Load += new System.EventHandler(this.AdmitPatient_Load);
            this.PatientPersonalInfo.ResumeLayout(false);
            this.PatientPersonalInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PatientPersonalInfo;
        private System.Windows.Forms.Label PatNamelbl;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.RichTextBox PatAddTb;
        private System.Windows.Forms.Label Patphnlbl;
        private System.Windows.Forms.TextBox PatphnnoTb;
        private System.Windows.Forms.Label PatAddlbl;
        private System.Windows.Forms.Label PersonalInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox DoctorAssCb;
        private System.Windows.Forms.Label DoctorAsslbl;
        private System.Windows.Forms.ComboBox AdmDeptCb;
        private System.Windows.Forms.Label AdmDeptlbl;
        private System.Windows.Forms.ComboBox AllotBedCb;
        private System.Windows.Forms.Label AllotBedlbl;
        private System.Windows.Forms.Button AdmitBtn;
        private System.Windows.Forms.Label MedicalDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatCntTb;
        private System.Windows.Forms.PictureBox QRcodepic;
    }
}