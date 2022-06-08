
namespace WindowsFormsApp1
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.UserTypeCb = new System.Windows.Forms.ComboBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.PhonenoTb = new System.Windows.Forms.TextBox();
            this.DocFeesTb = new System.Windows.Forms.TextBox();
            this.DocSpecTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocSpeclbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.DocFeeslbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserTypeCb
            // 
            this.UserTypeCb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserTypeCb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeCb.FormattingEnabled = true;
            this.UserTypeCb.Items.AddRange(new object[] {
            "admin",
            "doctor",
            "staff"});
            this.UserTypeCb.Location = new System.Drawing.Point(178, 26);
            this.UserTypeCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTypeCb.Name = "UserTypeCb";
            this.UserTypeCb.Size = new System.Drawing.Size(180, 33);
            this.UserTypeCb.TabIndex = 0;
            this.UserTypeCb.SelectedValueChanged += new System.EventHandler(this.UserTypeCb_SelectedValueChanged);
            // 
            // NameTb
            // 
            this.NameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(178, 121);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(386, 32);
            this.NameTb.TabIndex = 1;
            // 
            // IDTb
            // 
            this.IDTb.BackColor = System.Drawing.Color.MistyRose;
            this.IDTb.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDTb.Location = new System.Drawing.Point(926, 47);
            this.IDTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTb.Name = "IDTb";
            this.IDTb.ReadOnly = true;
            this.IDTb.Size = new System.Drawing.Size(211, 35);
            this.IDTb.TabIndex = 2;
            this.IDTb.TextChanged += new System.EventHandler(this.IDTb_TextChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(178, 282);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(386, 32);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.UseSystemPasswordChar = true;
            // 
            // PhonenoTb
            // 
            this.PhonenoTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhonenoTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonenoTb.Location = new System.Drawing.Point(175, 196);
            this.PhonenoTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhonenoTb.Name = "PhonenoTb";
            this.PhonenoTb.Size = new System.Drawing.Size(389, 32);
            this.PhonenoTb.TabIndex = 4;
            // 
            // DocFeesTb
            // 
            this.DocFeesTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DocFeesTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocFeesTb.Location = new System.Drawing.Point(277, 375);
            this.DocFeesTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocFeesTb.Name = "DocFeesTb";
            this.DocFeesTb.Size = new System.Drawing.Size(287, 32);
            this.DocFeesTb.TabIndex = 5;
            this.DocFeesTb.Visible = false;
            // 
            // DocSpecTb
            // 
            this.DocSpecTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DocSpecTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSpecTb.Location = new System.Drawing.Point(277, 449);
            this.DocSpecTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocSpecTb.Name = "DocSpecTb";
            this.DocSpecTb.Size = new System.Drawing.Size(287, 32);
            this.DocSpecTb.TabIndex = 6;
            this.DocSpecTb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(805, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phoneno";
            // 
            // DocSpeclbl
            // 
            this.DocSpeclbl.AutoSize = true;
            this.DocSpeclbl.BackColor = System.Drawing.Color.Transparent;
            this.DocSpeclbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSpeclbl.Location = new System.Drawing.Point(24, 449);
            this.DocSpeclbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocSpeclbl.Name = "DocSpeclbl";
            this.DocSpeclbl.Size = new System.Drawing.Size(209, 24);
            this.DocSpeclbl.TabIndex = 9;
            this.DocSpeclbl.Text = "Doctor Specialized in";
            this.DocSpeclbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(23, 121);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(63, 24);
            this.NameLbl.TabIndex = 11;
            this.NameLbl.Text = "Name";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // DocFeeslbl
            // 
            this.DocFeeslbl.AutoSize = true;
            this.DocFeeslbl.BackColor = System.Drawing.Color.Transparent;
            this.DocFeeslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocFeeslbl.Location = new System.Drawing.Point(24, 375);
            this.DocFeeslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocFeeslbl.Name = "DocFeeslbl";
            this.DocFeeslbl.Size = new System.Drawing.Size(170, 24);
            this.DocFeeslbl.TabIndex = 12;
            this.DocFeeslbl.Text = "Doctor Fees/visit";
            this.DocFeeslbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Type";
            // 
            // UserAddBtn
            // 
            this.UserAddBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserAddBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAddBtn.Location = new System.Drawing.Point(784, 422);
            this.UserAddBtn.Name = "UserAddBtn";
            this.UserAddBtn.Size = new System.Drawing.Size(167, 51);
            this.UserAddBtn.TabIndex = 14;
            this.UserAddBtn.Text = "ADD";
            this.UserAddBtn.UseVisualStyleBackColor = false;
            this.UserAddBtn.Click += new System.EventHandler(this.UserAddBtn_Click);
            // 
            // AddUser
            // 
            this.AcceptButton = this.UserAddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 650);
            this.Controls.Add(this.UserAddBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DocFeeslbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocSpeclbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocSpecTb);
            this.Controls.Add(this.DocFeesTb);
            this.Controls.Add(this.PhonenoTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.IDTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.UserTypeCb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserTypeCb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox PhonenoTb;
        private System.Windows.Forms.TextBox DocFeesTb;
        private System.Windows.Forms.TextBox DocSpecTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DocSpeclbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label DocFeeslbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UserAddBtn;
    }
}