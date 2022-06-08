
namespace WindowsFormsApp1
{
    partial class RemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUser));
            this.IDlbl = new System.Windows.Forms.Label();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.UserTypelbl = new System.Windows.Forms.Label();
            this.UserTypeCb = new System.Windows.Forms.ComboBox();
            this.UserDelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.BackColor = System.Drawing.Color.Transparent;
            this.IDlbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(13, 115);
            this.IDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(92, 27);
            this.IDlbl.TabIndex = 31;
            this.IDlbl.Text = "User ID";
            // 
            // IDTb
            // 
            this.IDTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IDTb.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTb.Location = new System.Drawing.Point(191, 108);
            this.IDTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(259, 35);
            this.IDTb.TabIndex = 30;
            // 
            // UserTypelbl
            // 
            this.UserTypelbl.AutoSize = true;
            this.UserTypelbl.BackColor = System.Drawing.Color.Transparent;
            this.UserTypelbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypelbl.Location = new System.Drawing.Point(13, 49);
            this.UserTypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserTypelbl.Name = "UserTypelbl";
            this.UserTypelbl.Size = new System.Drawing.Size(121, 27);
            this.UserTypelbl.TabIndex = 29;
            this.UserTypelbl.Text = "User Type";
            // 
            // UserTypeCb
            // 
            this.UserTypeCb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserTypeCb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeCb.FormattingEnabled = true;
            this.UserTypeCb.Items.AddRange(new object[] {
            "admin",
            "doctor",
            "staff"});
            this.UserTypeCb.Location = new System.Drawing.Point(191, 39);
            this.UserTypeCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTypeCb.Name = "UserTypeCb";
            this.UserTypeCb.Size = new System.Drawing.Size(180, 33);
            this.UserTypeCb.TabIndex = 28;
            // 
            // UserDelBtn
            // 
            this.UserDelBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UserDelBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDelBtn.Location = new System.Drawing.Point(191, 182);
            this.UserDelBtn.Name = "UserDelBtn";
            this.UserDelBtn.Size = new System.Drawing.Size(167, 51);
            this.UserDelBtn.TabIndex = 32;
            this.UserDelBtn.Text = "REMOVE";
            this.UserDelBtn.UseVisualStyleBackColor = false;
            this.UserDelBtn.Click += new System.EventHandler(this.UserDelBtn_Click);
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.UserDelBtn);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.IDTb);
            this.Controls.Add(this.UserTypelbl);
            this.Controls.Add(this.UserTypeCb);
            this.Name = "RemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.Label UserTypelbl;
        private System.Windows.Forms.ComboBox UserTypeCb;
        private System.Windows.Forms.Button UserDelBtn;
    }
}