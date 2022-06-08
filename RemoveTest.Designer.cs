
namespace WindowsFormsApp1
{
    partial class RemoveTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveTest));
            this.TestDelBtn = new System.Windows.Forms.Button();
            this.TestNameLbl = new System.Windows.Forms.Label();
            this.TestNameTb = new System.Windows.Forms.TextBox();
            this.TestIDlbl = new System.Windows.Forms.Label();
            this.TestIdTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestDelBtn
            // 
            this.TestDelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestDelBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDelBtn.Location = new System.Drawing.Point(183, 190);
            this.TestDelBtn.Name = "TestDelBtn";
            this.TestDelBtn.Size = new System.Drawing.Size(167, 51);
            this.TestDelBtn.TabIndex = 33;
            this.TestDelBtn.Text = "REMOVE";
            this.TestDelBtn.UseVisualStyleBackColor = false;
            this.TestDelBtn.Click += new System.EventHandler(this.TestDelBtn_Click);
            // 
            // TestNameLbl
            // 
            this.TestNameLbl.AutoSize = true;
            this.TestNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.TestNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameLbl.Location = new System.Drawing.Point(35, 49);
            this.TestNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestNameLbl.Name = "TestNameLbl";
            this.TestNameLbl.Size = new System.Drawing.Size(110, 24);
            this.TestNameLbl.TabIndex = 35;
            this.TestNameLbl.Text = "Test Name";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameTb.Location = new System.Drawing.Point(183, 45);
            this.TestNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.Size = new System.Drawing.Size(352, 32);
            this.TestNameTb.TabIndex = 34;
            this.TestNameTb.Leave += new System.EventHandler(this.TestNameTb_Leave);
            // 
            // TestIDlbl
            // 
            this.TestIDlbl.AutoSize = true;
            this.TestIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.TestIDlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIDlbl.Location = new System.Drawing.Point(35, 121);
            this.TestIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestIDlbl.Name = "TestIDlbl";
            this.TestIDlbl.Size = new System.Drawing.Size(76, 24);
            this.TestIDlbl.TabIndex = 37;
            this.TestIDlbl.Text = "Test ID";
            // 
            // TestIdTb
            // 
            this.TestIdTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestIdTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIdTb.Location = new System.Drawing.Point(183, 117);
            this.TestIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestIdTb.Name = "TestIdTb";
            this.TestIdTb.ReadOnly = true;
            this.TestIdTb.Size = new System.Drawing.Size(209, 32);
            this.TestIdTb.TabIndex = 36;
            // 
            // RemoveTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 380);
            this.Controls.Add(this.TestIDlbl);
            this.Controls.Add(this.TestIdTb);
            this.Controls.Add(this.TestNameLbl);
            this.Controls.Add(this.TestNameTb);
            this.Controls.Add(this.TestDelBtn);
            this.Name = "RemoveTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestDelBtn;
        private System.Windows.Forms.Label TestNameLbl;
        private System.Windows.Forms.TextBox TestNameTb;
        private System.Windows.Forms.Label TestIDlbl;
        private System.Windows.Forms.TextBox TestIdTb;
    }
}