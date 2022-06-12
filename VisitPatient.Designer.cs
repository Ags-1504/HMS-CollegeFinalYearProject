
namespace WindowsFormsApp1
{
    partial class VisitPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatIDTb = new System.Windows.Forms.TextBox();
            this.PatIDlbl = new System.Windows.Forms.Label();
            this.PatNamCb = new System.Windows.Forms.ComboBox();
            this.PatNamelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DocCommTb = new System.Windows.Forms.RichTextBox();
            this.SelPatlbl = new System.Windows.Forms.Label();
            this.DocCommlbl = new System.Windows.Forms.Label();
            this.DocIDTb = new System.Windows.Forms.TextBox();
            this.DOCIDlbl = new System.Windows.Forms.Label();
            this.PresMedsPanel = new System.Windows.Forms.Panel();
            this.PreMedsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ForDayslbl = new System.Windows.Forms.Label();
            this.Doseperdaylbl = new System.Windows.Forms.Label();
            this.DoseperdayTb = new System.Windows.Forms.TextBox();
            this.ForDaysTb = new System.Windows.Forms.TextBox();
            this.MedDosagelbl = new System.Windows.Forms.Label();
            this.MedNameCb = new System.Windows.Forms.ComboBox();
            this.MedName = new System.Windows.Forms.Label();
            this.VisitBtn = new System.Windows.Forms.Button();
            this.PresTestspanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TestNameCb = new System.Windows.Forms.ComboBox();
            this.TestNamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PresMedsPanel.SuspendLayout();
            this.PresTestspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PatIDTb);
            this.panel1.Controls.Add(this.PatIDlbl);
            this.panel1.Controls.Add(this.PatNamCb);
            this.panel1.Controls.Add(this.PatNamelbl);
            this.panel1.Location = new System.Drawing.Point(21, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 150);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DocCommTb);
            this.panel2.Location = new System.Drawing.Point(21, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 265);
            this.panel2.TabIndex = 1;
            // 
            // DocCommTb
            // 
            this.DocCommTb.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocCommTb.Location = new System.Drawing.Point(27, 33);
            this.DocCommTb.Name = "DocCommTb";
            this.DocCommTb.Size = new System.Drawing.Size(406, 187);
            this.DocCommTb.TabIndex = 0;
            this.DocCommTb.Text = "";
            // 
            // SelPatlbl
            // 
            this.SelPatlbl.AutoSize = true;
            this.SelPatlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelPatlbl.Location = new System.Drawing.Point(44, 9);
            this.SelPatlbl.Name = "SelPatlbl";
            this.SelPatlbl.Size = new System.Drawing.Size(140, 24);
            this.SelPatlbl.TabIndex = 4;
            this.SelPatlbl.Text = "Select Patient";
            // 
            // DocCommlbl
            // 
            this.DocCommlbl.AutoSize = true;
            this.DocCommlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocCommlbl.Location = new System.Drawing.Point(44, 196);
            this.DocCommlbl.Name = "DocCommlbl";
            this.DocCommlbl.Size = new System.Drawing.Size(154, 24);
            this.DocCommlbl.TabIndex = 5;
            this.DocCommlbl.Text = "Add Comments";
            // 
            // DocIDTb
            // 
            this.DocIDTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocIDTb.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocIDTb.Location = new System.Drawing.Point(1048, 36);
            this.DocIDTb.Name = "DocIDTb";
            this.DocIDTb.ReadOnly = true;
            this.DocIDTb.Size = new System.Drawing.Size(213, 29);
            this.DocIDTb.TabIndex = 6;
            // 
            // DOCIDlbl
            // 
            this.DOCIDlbl.AutoSize = true;
            this.DOCIDlbl.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOCIDlbl.Location = new System.Drawing.Point(1044, 9);
            this.DOCIDlbl.Name = "DOCIDlbl";
            this.DOCIDlbl.Size = new System.Drawing.Size(99, 24);
            this.DOCIDlbl.TabIndex = 7;
            this.DOCIDlbl.Text = "Doctor ID";
            // 
            // PresMedsPanel
            // 
            this.PresMedsPanel.Controls.Add(this.PreMedsBtn);
            this.PresMedsPanel.Controls.Add(this.label1);
            this.PresMedsPanel.Controls.Add(this.label4);
            this.PresMedsPanel.Controls.Add(this.ForDayslbl);
            this.PresMedsPanel.Controls.Add(this.Doseperdaylbl);
            this.PresMedsPanel.Controls.Add(this.DoseperdayTb);
            this.PresMedsPanel.Controls.Add(this.ForDaysTb);
            this.PresMedsPanel.Controls.Add(this.MedDosagelbl);
            this.PresMedsPanel.Controls.Add(this.MedNameCb);
            this.PresMedsPanel.Controls.Add(this.MedName);
            this.PresMedsPanel.Location = new System.Drawing.Point(516, 71);
            this.PresMedsPanel.Name = "PresMedsPanel";
            this.PresMedsPanel.Size = new System.Drawing.Size(740, 199);
            this.PresMedsPanel.TabIndex = 8;
            this.PresMedsPanel.Visible = false;
            // 
            // PreMedsBtn
            // 
            this.PreMedsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreMedsBtn.Location = new System.Drawing.Point(513, 44);
            this.PreMedsBtn.Name = "PreMedsBtn";
            this.PreMedsBtn.Size = new System.Drawing.Size(189, 74);
            this.PreMedsBtn.TabIndex = 12;
            this.PreMedsBtn.Text = "Prescribe Medicine";
            this.PreMedsBtn.UseVisualStyleBackColor = true;
            this.PreMedsBtn.Click += new System.EventHandler(this.PreMedsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prescribe Medicines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dose/day:";
            // 
            // ForDayslbl
            // 
            this.ForDayslbl.AutoSize = true;
            this.ForDayslbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForDayslbl.Location = new System.Drawing.Point(15, 132);
            this.ForDayslbl.Name = "ForDayslbl";
            this.ForDayslbl.Size = new System.Drawing.Size(83, 23);
            this.ForDayslbl.TabIndex = 11;
            this.ForDayslbl.Text = "For Days:";
            // 
            // Doseperdaylbl
            // 
            this.Doseperdaylbl.AutoSize = true;
            this.Doseperdaylbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doseperdaylbl.Location = new System.Drawing.Point(314, 132);
            this.Doseperdaylbl.Name = "Doseperdaylbl";
            this.Doseperdaylbl.Size = new System.Drawing.Size(86, 23);
            this.Doseperdaylbl.TabIndex = 10;
            this.Doseperdaylbl.Text = "Dose/day:";
            // 
            // DoseperdayTb
            // 
            this.DoseperdayTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DoseperdayTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoseperdayTb.Location = new System.Drawing.Point(318, 159);
            this.DoseperdayTb.Name = "DoseperdayTb";
            this.DoseperdayTb.Size = new System.Drawing.Size(255, 32);
            this.DoseperdayTb.TabIndex = 9;
            // 
            // ForDaysTb
            // 
            this.ForDaysTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ForDaysTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForDaysTb.Location = new System.Drawing.Point(19, 159);
            this.ForDaysTb.Name = "ForDaysTb";
            this.ForDaysTb.Size = new System.Drawing.Size(255, 32);
            this.ForDaysTb.TabIndex = 8;
            // 
            // MedDosagelbl
            // 
            this.MedDosagelbl.AutoSize = true;
            this.MedDosagelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDosagelbl.Location = new System.Drawing.Point(3, 94);
            this.MedDosagelbl.Name = "MedDosagelbl";
            this.MedDosagelbl.Size = new System.Drawing.Size(171, 24);
            this.MedDosagelbl.TabIndex = 7;
            this.MedDosagelbl.Text = "Medicine Dosage";
            // 
            // MedNameCb
            // 
            this.MedNameCb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameCb.FormattingEnabled = true;
            this.MedNameCb.Location = new System.Drawing.Point(180, 36);
            this.MedNameCb.Name = "MedNameCb";
            this.MedNameCb.Size = new System.Drawing.Size(272, 33);
            this.MedNameCb.TabIndex = 6;
            // 
            // MedName
            // 
            this.MedName.AutoSize = true;
            this.MedName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedName.Location = new System.Drawing.Point(3, 44);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(153, 24);
            this.MedName.TabIndex = 5;
            this.MedName.Text = "Medicine Name";
            // 
            // VisitBtn
            // 
            this.VisitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitBtn.Location = new System.Drawing.Point(39, 500);
            this.VisitBtn.Name = "VisitBtn";
            this.VisitBtn.Size = new System.Drawing.Size(189, 34);
            this.VisitBtn.TabIndex = 13;
            this.VisitBtn.Text = "Visit";
            this.VisitBtn.UseVisualStyleBackColor = true;
            this.VisitBtn.Click += new System.EventHandler(this.VisitBtn_Click);
            // 
            // PresTestspanel
            // 
            this.PresTestspanel.Controls.Add(this.button1);
            this.PresTestspanel.Controls.Add(this.label2);
            this.PresTestspanel.Controls.Add(this.TestNameCb);
            this.PresTestspanel.Controls.Add(this.TestNamelbl);
            this.PresTestspanel.Location = new System.Drawing.Point(516, 294);
            this.PresTestspanel.Name = "PresTestspanel";
            this.PresTestspanel.Size = new System.Drawing.Size(740, 199);
            this.PresTestspanel.TabIndex = 14;
            this.PresTestspanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prescribe Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prescribe Tests";
            // 
            // TestNameCb
            // 
            this.TestNameCb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameCb.FormattingEnabled = true;
            this.TestNameCb.Location = new System.Drawing.Point(180, 36);
            this.TestNameCb.Name = "TestNameCb";
            this.TestNameCb.Size = new System.Drawing.Size(272, 33);
            this.TestNameCb.TabIndex = 6;
            // 
            // TestNamelbl
            // 
            this.TestNamelbl.AutoSize = true;
            this.TestNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNamelbl.Location = new System.Drawing.Point(3, 44);
            this.TestNamelbl.Name = "TestNamelbl";
            this.TestNamelbl.Size = new System.Drawing.Size(110, 24);
            this.TestNamelbl.TabIndex = 5;
            this.TestNamelbl.Text = "Test Name";
            // 
            // VisitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 546);
            this.Controls.Add(this.PresTestspanel);
            this.Controls.Add(this.VisitBtn);
            this.Controls.Add(this.PresMedsPanel);
            this.Controls.Add(this.DOCIDlbl);
            this.Controls.Add(this.DocIDTb);
            this.Controls.Add(this.DocCommlbl);
            this.Controls.Add(this.SelPatlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisitPatient";
            this.Text = "VisitPatient";
            this.Load += new System.EventHandler(this.VisitPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PresMedsPanel.ResumeLayout(false);
            this.PresMedsPanel.PerformLayout();
            this.PresTestspanel.ResumeLayout(false);
            this.PresTestspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatIDlbl;
        private System.Windows.Forms.ComboBox PatNamCb;
        private System.Windows.Forms.Label PatNamelbl;
        private System.Windows.Forms.TextBox PatIDTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox DocCommTb;
        private System.Windows.Forms.Label SelPatlbl;
        private System.Windows.Forms.Label DocCommlbl;
        private System.Windows.Forms.TextBox DocIDTb;
        private System.Windows.Forms.Label DOCIDlbl;
        private System.Windows.Forms.Panel PresMedsPanel;
        private System.Windows.Forms.Label ForDayslbl;
        private System.Windows.Forms.Label Doseperdaylbl;
        private System.Windows.Forms.TextBox DoseperdayTb;
        private System.Windows.Forms.TextBox ForDaysTb;
        private System.Windows.Forms.Label MedDosagelbl;
        private System.Windows.Forms.ComboBox MedNameCb;
        private System.Windows.Forms.Label MedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PreMedsBtn;
        private System.Windows.Forms.Button VisitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PresTestspanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TestNameCb;
        private System.Windows.Forms.Label TestNamelbl;
    }
}