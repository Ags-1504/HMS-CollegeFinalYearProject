
namespace WindowsFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedicineLabel = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.BedLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.MedicineBtn = new System.Windows.Forms.Button();
            this.BedBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.DiagnosticBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveTestBtn = new System.Windows.Forms.Button();
            this.RemoveMedBtn = new System.Windows.Forms.Button();
            this.ViewEditTestBtn = new System.Windows.Forms.Button();
            this.AddTestBtn = new System.Windows.Forms.Button();
            this.AddMedicineBtn = new System.Windows.Forms.Button();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.ViewEditStockBtn = new System.Windows.Forms.Button();
            this.ViewEditUserBtn = new System.Windows.Forms.Button();
            this.ManageBedCatBtn = new System.Windows.Forms.Button();
            this.ViewEditBedBtn = new System.Windows.Forms.Button();
            this.AddBedBtn = new System.Windows.Forms.Button();
            this.PatientVisitBtn = new System.Windows.Forms.Button();
            this.DischargePatientBtn = new System.Windows.Forms.Button();
            this.ViewEditPatientBtn = new System.Windows.Forms.Button();
            this.PatientredgBtn = new System.Windows.Forms.Button();
            this.LoggedInAs = new System.Windows.Forms.LinkLabel();
            this.GoBackBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1485, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(49, 48);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MedicineLabel);
            this.panel1.Controls.Add(this.DiagnosisLabel);
            this.panel1.Controls.Add(this.PatientLabel);
            this.panel1.Controls.Add(this.BedLabel);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.PatientBtn);
            this.panel1.Controls.Add(this.MedicineBtn);
            this.panel1.Controls.Add(this.BedBtn);
            this.panel1.Controls.Add(this.UserBtn);
            this.panel1.Controls.Add(this.DiagnosticBtn);
            this.panel1.Location = new System.Drawing.Point(377, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 649);
            this.panel1.TabIndex = 7;
            // 
            // MedicineLabel
            // 
            this.MedicineLabel.BackColor = System.Drawing.Color.LightGray;
            this.MedicineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MedicineLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicineLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineLabel.Location = new System.Drawing.Point(788, 434);
            this.MedicineLabel.Name = "MedicineLabel";
            this.MedicineLabel.Size = new System.Drawing.Size(167, 38);
            this.MedicineLabel.TabIndex = 14;
            this.MedicineLabel.Text = "MEDICINE";
            this.MedicineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MedicineLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.BackColor = System.Drawing.Color.Tan;
            this.DiagnosisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiagnosisLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisLabel.Location = new System.Drawing.Point(93, 434);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(167, 38);
            this.DiagnosisLabel.TabIndex = 13;
            this.DiagnosisLabel.Text = "DIAGNOSIS";
            this.DiagnosisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiagnosisLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // PatientLabel
            // 
            this.PatientLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.PatientLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLabel.Location = new System.Drawing.Point(453, 401);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(167, 38);
            this.PatientLabel.TabIndex = 12;
            this.PatientLabel.Text = "PATIENT";
            this.PatientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // BedLabel
            // 
            this.BedLabel.BackColor = System.Drawing.Color.Khaki;
            this.BedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BedLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedLabel.Location = new System.Drawing.Point(788, 167);
            this.BedLabel.Name = "BedLabel";
            this.BedLabel.Size = new System.Drawing.Size(167, 38);
            this.BedLabel.TabIndex = 11;
            this.BedLabel.Text = "BED";
            this.BedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BedLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.MistyRose;
            this.UserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(93, 167);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(167, 38);
            this.UserLabel.TabIndex = 10;
            this.UserLabel.Text = "USER";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.PatientBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PatientBtn.BackgroundImage")));
            this.PatientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PatientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PatientBtn.Location = new System.Drawing.Point(453, 247);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(167, 151);
            this.PatientBtn.TabIndex = 9;
            this.PatientBtn.UseVisualStyleBackColor = false;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            this.PatientBtn.MouseLeave += new System.EventHandler(this.PatientBtn_MouseLeave);
            this.PatientBtn.MouseHover += new System.EventHandler(this.PatientBtn_MouseHover);
            // 
            // MedicineBtn
            // 
            this.MedicineBtn.BackColor = System.Drawing.Color.LightGray;
            this.MedicineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MedicineBtn.BackgroundImage")));
            this.MedicineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MedicineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MedicineBtn.Location = new System.Drawing.Point(788, 475);
            this.MedicineBtn.Name = "MedicineBtn";
            this.MedicineBtn.Size = new System.Drawing.Size(167, 151);
            this.MedicineBtn.TabIndex = 8;
            this.MedicineBtn.UseVisualStyleBackColor = false;
            this.MedicineBtn.Click += new System.EventHandler(this.MedicineBtn_Click);
            this.MedicineBtn.MouseLeave += new System.EventHandler(this.MedicineBtn_MouseLeave);
            this.MedicineBtn.MouseHover += new System.EventHandler(this.MedicineBtn_MouseHover);
            // 
            // BedBtn
            // 
            this.BedBtn.BackColor = System.Drawing.Color.Khaki;
            this.BedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BedBtn.BackgroundImage")));
            this.BedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BedBtn.Location = new System.Drawing.Point(788, 32);
            this.BedBtn.Name = "BedBtn";
            this.BedBtn.Size = new System.Drawing.Size(167, 132);
            this.BedBtn.TabIndex = 7;
            this.BedBtn.UseVisualStyleBackColor = false;
            this.BedBtn.Click += new System.EventHandler(this.BedBtn_Click);
            this.BedBtn.MouseLeave += new System.EventHandler(this.BedBtn_MouseLeave);
            this.BedBtn.MouseHover += new System.EventHandler(this.BedBtn_MouseHover);
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.MistyRose;
            this.UserBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserBtn.BackgroundImage")));
            this.UserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserBtn.Location = new System.Drawing.Point(93, 32);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(167, 132);
            this.UserBtn.TabIndex = 6;
            this.UserBtn.UseVisualStyleBackColor = false;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            this.UserBtn.MouseLeave += new System.EventHandler(this.UserBtn_MouseLeave);
            this.UserBtn.MouseHover += new System.EventHandler(this.UserBtn_MouseHover);
            // 
            // DiagnosticBtn
            // 
            this.DiagnosticBtn.BackColor = System.Drawing.Color.Tan;
            this.DiagnosticBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiagnosticBtn.BackgroundImage")));
            this.DiagnosticBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiagnosticBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DiagnosticBtn.Location = new System.Drawing.Point(93, 475);
            this.DiagnosticBtn.Name = "DiagnosticBtn";
            this.DiagnosticBtn.Size = new System.Drawing.Size(167, 151);
            this.DiagnosticBtn.TabIndex = 5;
            this.DiagnosticBtn.UseVisualStyleBackColor = false;
            this.DiagnosticBtn.Click += new System.EventHandler(this.DiagnosticBtn_Click);
            this.DiagnosticBtn.MouseLeave += new System.EventHandler(this.DiagnosticsBtn_MouseLeave);
            this.DiagnosticBtn.MouseHover += new System.EventHandler(this.DiagnosticsBtn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.RemoveUserBtn);
            this.panel2.Controls.Add(this.RemoveMedBtn);
            this.panel2.Controls.Add(this.RemoveTestBtn);
            this.panel2.Controls.Add(this.ViewEditTestBtn);
            this.panel2.Controls.Add(this.AddTestBtn);
            this.panel2.Controls.Add(this.ViewEditStockBtn);
            this.panel2.Controls.Add(this.ViewEditUserBtn);
            this.panel2.Controls.Add(this.AddMedicineBtn);
            this.panel2.Controls.Add(this.AddUserBtn);
            this.panel2.Controls.Add(this.ManageBedCatBtn);
            this.panel2.Controls.Add(this.ViewEditBedBtn);
            this.panel2.Controls.Add(this.PatientVisitBtn);
            this.panel2.Controls.Add(this.DischargePatientBtn);
            this.panel2.Controls.Add(this.ViewEditPatientBtn);
            this.panel2.Controls.Add(this.PatientredgBtn);
            this.panel2.Controls.Add(this.AddBedBtn);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 684);
            this.panel2.TabIndex = 8;
            // 
            // RemoveTestBtn
            // 
            this.RemoveTestBtn.BackColor = System.Drawing.Color.Tan;
            this.RemoveTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveTestBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveTestBtn.Location = new System.Drawing.Point(63, 464);
            this.RemoveTestBtn.Name = "RemoveTestBtn";
            this.RemoveTestBtn.Size = new System.Drawing.Size(217, 72);
            this.RemoveTestBtn.TabIndex = 15;
            this.RemoveTestBtn.Text = "REMOVE DIAGNOSTIC";
            this.RemoveTestBtn.UseVisualStyleBackColor = false;
            this.RemoveTestBtn.Visible = false;
            this.RemoveTestBtn.Click += new System.EventHandler(this.RemoveTestBtn_Click);
            // 
            // RemoveMedBtn
            // 
            this.RemoveMedBtn.BackColor = System.Drawing.Color.LightGray;
            this.RemoveMedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveMedBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveMedBtn.Location = new System.Drawing.Point(63, 461);
            this.RemoveMedBtn.Name = "RemoveMedBtn";
            this.RemoveMedBtn.Size = new System.Drawing.Size(217, 73);
            this.RemoveMedBtn.TabIndex = 12;
            this.RemoveMedBtn.Text = "REMOVE MEDICINE";
            this.RemoveMedBtn.UseVisualStyleBackColor = false;
            this.RemoveMedBtn.Visible = false;
            this.RemoveMedBtn.Click += new System.EventHandler(this.RemoveMedBtn_Click);
            // 
            // ViewEditTestBtn
            // 
            this.ViewEditTestBtn.BackColor = System.Drawing.Color.Tan;
            this.ViewEditTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEditTestBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditTestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewEditTestBtn.Location = new System.Drawing.Point(63, 289);
            this.ViewEditTestBtn.Name = "ViewEditTestBtn";
            this.ViewEditTestBtn.Size = new System.Drawing.Size(217, 74);
            this.ViewEditTestBtn.TabIndex = 14;
            this.ViewEditTestBtn.Text = "VIEW/EDIT DIAGNOSTIC";
            this.ViewEditTestBtn.UseVisualStyleBackColor = false;
            this.ViewEditTestBtn.Visible = false;
            this.ViewEditTestBtn.Click += new System.EventHandler(this.ViewEditTestBtn_Click);
            // 
            // AddTestBtn
            // 
            this.AddTestBtn.BackColor = System.Drawing.Color.Tan;
            this.AddTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTestBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTestBtn.Location = new System.Drawing.Point(64, 110);
            this.AddTestBtn.Name = "AddTestBtn";
            this.AddTestBtn.Size = new System.Drawing.Size(217, 75);
            this.AddTestBtn.TabIndex = 13;
            this.AddTestBtn.Text = "ADD DIAGNOSTICS";
            this.AddTestBtn.UseVisualStyleBackColor = false;
            this.AddTestBtn.Visible = false;
            this.AddTestBtn.Click += new System.EventHandler(this.AddTestBtn_Click);
            // 
            // AddMedicineBtn
            // 
            this.AddMedicineBtn.BackColor = System.Drawing.Color.LightGray;
            this.AddMedicineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMedicineBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedicineBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMedicineBtn.Location = new System.Drawing.Point(64, 116);
            this.AddMedicineBtn.Name = "AddMedicineBtn";
            this.AddMedicineBtn.Size = new System.Drawing.Size(217, 63);
            this.AddMedicineBtn.TabIndex = 10;
            this.AddMedicineBtn.Text = "ADD MEDICINE";
            this.AddMedicineBtn.UseVisualStyleBackColor = false;
            this.AddMedicineBtn.Visible = false;
            this.AddMedicineBtn.Click += new System.EventHandler(this.AddMedicineBtn_Click);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.BackColor = System.Drawing.Color.MistyRose;
            this.RemoveUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveUserBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveUserBtn.Location = new System.Drawing.Point(64, 463);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(217, 74);
            this.RemoveUserBtn.TabIndex = 9;
            this.RemoveUserBtn.Text = "REMOVE USER";
            this.RemoveUserBtn.UseVisualStyleBackColor = false;
            this.RemoveUserBtn.Visible = false;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.MistyRose;
            this.AddUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddUserBtn.Location = new System.Drawing.Point(64, 116);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(217, 63);
            this.AddUserBtn.TabIndex = 7;
            this.AddUserBtn.Text = "ADD USER";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Visible = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // ViewEditStockBtn
            // 
            this.ViewEditStockBtn.BackColor = System.Drawing.Color.LightGray;
            this.ViewEditStockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEditStockBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditStockBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewEditStockBtn.Location = new System.Drawing.Point(63, 294);
            this.ViewEditStockBtn.Name = "ViewEditStockBtn";
            this.ViewEditStockBtn.Size = new System.Drawing.Size(217, 67);
            this.ViewEditStockBtn.TabIndex = 11;
            this.ViewEditStockBtn.Text = "VIEW/EDIT STOCK";
            this.ViewEditStockBtn.UseVisualStyleBackColor = false;
            this.ViewEditStockBtn.Visible = false;
            this.ViewEditStockBtn.Click += new System.EventHandler(this.ViewEditStockBtn_Click);
            // 
            // ViewEditUserBtn
            // 
            this.ViewEditUserBtn.BackColor = System.Drawing.Color.MistyRose;
            this.ViewEditUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEditUserBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewEditUserBtn.Location = new System.Drawing.Point(64, 289);
            this.ViewEditUserBtn.Name = "ViewEditUserBtn";
            this.ViewEditUserBtn.Size = new System.Drawing.Size(217, 74);
            this.ViewEditUserBtn.TabIndex = 8;
            this.ViewEditUserBtn.Text = "VIEW/EDIT";
            this.ViewEditUserBtn.UseVisualStyleBackColor = false;
            this.ViewEditUserBtn.Visible = false;
            this.ViewEditUserBtn.Click += new System.EventHandler(this.ViewEditUserBtn_Click);
            // 
            // ManageBedCatBtn
            // 
            this.ManageBedCatBtn.BackColor = System.Drawing.Color.Khaki;
            this.ManageBedCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageBedCatBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBedCatBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageBedCatBtn.Location = new System.Drawing.Point(63, 461);
            this.ManageBedCatBtn.Name = "ManageBedCatBtn";
            this.ManageBedCatBtn.Size = new System.Drawing.Size(217, 79);
            this.ManageBedCatBtn.TabIndex = 6;
            this.ManageBedCatBtn.Text = "UPDATE BED CATEGORIES";
            this.ManageBedCatBtn.UseVisualStyleBackColor = false;
            this.ManageBedCatBtn.Visible = false;
            this.ManageBedCatBtn.Click += new System.EventHandler(this.ManageBedCatBtn_Click);
            // 
            // ViewEditBedBtn
            // 
            this.ViewEditBedBtn.BackColor = System.Drawing.Color.Khaki;
            this.ViewEditBedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEditBedBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditBedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewEditBedBtn.Location = new System.Drawing.Point(63, 291);
            this.ViewEditBedBtn.Name = "ViewEditBedBtn";
            this.ViewEditBedBtn.Size = new System.Drawing.Size(217, 72);
            this.ViewEditBedBtn.TabIndex = 5;
            this.ViewEditBedBtn.Text = "VIEW BED Status";
            this.ViewEditBedBtn.UseVisualStyleBackColor = false;
            this.ViewEditBedBtn.Visible = false;
            this.ViewEditBedBtn.Click += new System.EventHandler(this.ViewEditBedBtn_Click);
            // 
            // AddBedBtn
            // 
            this.AddBedBtn.BackColor = System.Drawing.Color.Khaki;
            this.AddBedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBedBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBedBtn.Location = new System.Drawing.Point(64, 113);
            this.AddBedBtn.Name = "AddBedBtn";
            this.AddBedBtn.Size = new System.Drawing.Size(217, 72);
            this.AddBedBtn.TabIndex = 4;
            this.AddBedBtn.Text = "ADD BED CATEGORIES";
            this.AddBedBtn.UseVisualStyleBackColor = false;
            this.AddBedBtn.Visible = false;
            this.AddBedBtn.Click += new System.EventHandler(this.AddBedBtn_Click);
            // 
            // PatientVisitBtn
            // 
            this.PatientVisitBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.PatientVisitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientVisitBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientVisitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientVisitBtn.Location = new System.Drawing.Point(63, 383);
            this.PatientVisitBtn.Name = "PatientVisitBtn";
            this.PatientVisitBtn.Size = new System.Drawing.Size(217, 63);
            this.PatientVisitBtn.TabIndex = 3;
            this.PatientVisitBtn.Text = "VISIT";
            this.PatientVisitBtn.UseVisualStyleBackColor = false;
            this.PatientVisitBtn.Visible = false;
            // 
            // DischargePatientBtn
            // 
            this.DischargePatientBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.DischargePatientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DischargePatientBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DischargePatientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DischargePatientBtn.Location = new System.Drawing.Point(63, 554);
            this.DischargePatientBtn.Name = "DischargePatientBtn";
            this.DischargePatientBtn.Size = new System.Drawing.Size(217, 63);
            this.DischargePatientBtn.TabIndex = 2;
            this.DischargePatientBtn.Text = "DISCHARGE";
            this.DischargePatientBtn.UseVisualStyleBackColor = false;
            this.DischargePatientBtn.Visible = false;
            // 
            // ViewEditPatientBtn
            // 
            this.ViewEditPatientBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ViewEditPatientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEditPatientBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditPatientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewEditPatientBtn.Location = new System.Drawing.Point(64, 202);
            this.ViewEditPatientBtn.Name = "ViewEditPatientBtn";
            this.ViewEditPatientBtn.Size = new System.Drawing.Size(217, 63);
            this.ViewEditPatientBtn.TabIndex = 1;
            this.ViewEditPatientBtn.Text = "VIEW/EDIT";
            this.ViewEditPatientBtn.UseVisualStyleBackColor = false;
            this.ViewEditPatientBtn.Visible = false;
            // 
            // PatientredgBtn
            // 
            this.PatientredgBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.PatientredgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientredgBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientredgBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientredgBtn.Location = new System.Drawing.Point(63, 35);
            this.PatientredgBtn.Name = "PatientredgBtn";
            this.PatientredgBtn.Size = new System.Drawing.Size(217, 63);
            this.PatientredgBtn.TabIndex = 0;
            this.PatientredgBtn.Text = "ADMIT PATIENT";
            this.PatientredgBtn.UseVisualStyleBackColor = false;
            this.PatientredgBtn.Visible = false;
            // 
            // LoggedInAs
            // 
            this.LoggedInAs.ActiveLinkColor = System.Drawing.Color.Brown;
            this.LoggedInAs.AutoSize = true;
            this.LoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.LoggedInAs.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoggedInAs.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.LoggedInAs.Location = new System.Drawing.Point(664, 17);
            this.LoggedInAs.Name = "LoggedInAs";
            this.LoggedInAs.Size = new System.Drawing.Size(163, 29);
            this.LoggedInAs.TabIndex = 9;
            this.LoggedInAs.TabStop = true;
            this.LoggedInAs.Text = "Logged in as";
            // 
            // GoBackBut
            // 
            this.GoBackBut.BackColor = System.Drawing.Color.Wheat;
            this.GoBackBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackBut.BackgroundImage")));
            this.GoBackBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBackBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackBut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoBackBut.Location = new System.Drawing.Point(125, 17);
            this.GoBackBut.Name = "GoBackBut";
            this.GoBackBut.Size = new System.Drawing.Size(92, 49);
            this.GoBackBut.TabIndex = 10;
            this.GoBackBut.UseVisualStyleBackColor = false;
            this.GoBackBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1788, 798);
            this.Controls.Add(this.GoBackBut);
            this.Controls.Add(this.LoggedInAs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button MedicineBtn;
        private System.Windows.Forms.Button BedBtn;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button DiagnosticBtn;
        private System.Windows.Forms.Button PatientVisitBtn;
        private System.Windows.Forms.Button DischargePatientBtn;
        private System.Windows.Forms.Button ViewEditPatientBtn;
        private System.Windows.Forms.Button PatientredgBtn;
        private System.Windows.Forms.Button ManageBedCatBtn;
        private System.Windows.Forms.Button ViewEditBedBtn;
        private System.Windows.Forms.Button AddBedBtn;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button ViewEditUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button RemoveMedBtn;
        private System.Windows.Forms.Button ViewEditStockBtn;
        private System.Windows.Forms.Button AddMedicineBtn;
        private System.Windows.Forms.Button RemoveTestBtn;
        private System.Windows.Forms.Button ViewEditTestBtn;
        private System.Windows.Forms.Button AddTestBtn;
        private System.Windows.Forms.LinkLabel LoggedInAs;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label MedicineLabel;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.Label BedLabel;
        private System.Windows.Forms.Button GoBackBut;
    }
}