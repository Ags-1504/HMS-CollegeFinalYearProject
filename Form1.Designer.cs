
namespace WindowsFormsApp1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserRoleCmb = new System.Windows.Forms.ComboBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.IDlbl = new System.Windows.Forms.Label();
            this.UserRolelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.UserRoleCmb);
            this.panel2.Controls.Add(this.LogInBtn);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.Passwordlbl);
            this.panel2.Controls.Add(this.IDTxt);
            this.panel2.Controls.Add(this.IDlbl);
            this.panel2.Controls.Add(this.UserRolelbl);
            this.panel2.Location = new System.Drawing.Point(1030, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 553);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserRoleCmb
            // 
            this.UserRoleCmb.DropDownHeight = 150;
            this.UserRoleCmb.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleCmb.FormattingEnabled = true;
            this.UserRoleCmb.IntegralHeight = false;
            this.UserRoleCmb.ItemHeight = 27;
            this.UserRoleCmb.Items.AddRange(new object[] {
            "admin",
            "doctor",
            "staff"});
            this.UserRoleCmb.Location = new System.Drawing.Point(43, 225);
            this.UserRoleCmb.Name = "UserRoleCmb";
            this.UserRoleCmb.Size = new System.Drawing.Size(180, 35);
            this.UserRoleCmb.TabIndex = 7;
            this.UserRoleCmb.Text = "-- Select --";
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Yellow;
            this.LogInBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogInBtn.Location = new System.Drawing.Point(43, 450);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(149, 51);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(43, 390);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(270, 34);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(38, 359);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(116, 28);
            this.Passwordlbl.TabIndex = 4;
            this.Passwordlbl.Text = "Password";
            // 
            // IDTxt
            // 
            this.IDTxt.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxt.Location = new System.Drawing.Point(41, 308);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(270, 34);
            this.IDTxt.TabIndex = 3;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(38, 277);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(38, 28);
            this.IDlbl.TabIndex = 2;
            this.IDlbl.Text = "ID";
            // 
            // UserRolelbl
            // 
            this.UserRolelbl.AutoSize = true;
            this.UserRolelbl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRolelbl.Location = new System.Drawing.Point(38, 194);
            this.UserRolelbl.Name = "UserRolelbl";
            this.UserRolelbl.Size = new System.Drawing.Size(129, 28);
            this.UserRolelbl.TabIndex = 0;
            this.UserRolelbl.Text = "User Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Broadway", 32F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(52, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(890, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(53, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Our ";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1491, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 52);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LogInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1784, 701);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to HMS";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label UserRolelbl;
        private System.Windows.Forms.ComboBox UserRoleCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exit;
    }
}

