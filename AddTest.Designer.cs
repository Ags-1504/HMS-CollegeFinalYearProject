
namespace WindowsFormsApp1
{
    partial class AddTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTest));
            this.TestNameLbl = new System.Windows.Forms.Label();
            this.TestNameTb = new System.Windows.Forms.TextBox();
            this.TestPricelbl = new System.Windows.Forms.Label();
            this.TestPriceTb = new System.Windows.Forms.TextBox();
            this.TestAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestNameLbl
            // 
            this.TestNameLbl.AutoSize = true;
            this.TestNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.TestNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameLbl.Location = new System.Drawing.Point(13, 54);
            this.TestNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestNameLbl.Name = "TestNameLbl";
            this.TestNameLbl.Size = new System.Drawing.Size(110, 24);
            this.TestNameLbl.TabIndex = 13;
            this.TestNameLbl.Text = "Test Name";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameTb.Location = new System.Drawing.Point(161, 50);
            this.TestNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.Size = new System.Drawing.Size(352, 32);
            this.TestNameTb.TabIndex = 12;
            // 
            // TestPricelbl
            // 
            this.TestPricelbl.AutoSize = true;
            this.TestPricelbl.BackColor = System.Drawing.Color.Transparent;
            this.TestPricelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPricelbl.Location = new System.Drawing.Point(13, 119);
            this.TestPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestPricelbl.Name = "TestPricelbl";
            this.TestPricelbl.Size = new System.Drawing.Size(105, 24);
            this.TestPricelbl.TabIndex = 15;
            this.TestPricelbl.Text = "Test Price";
            // 
            // TestPriceTb
            // 
            this.TestPriceTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPriceTb.Location = new System.Drawing.Point(161, 110);
            this.TestPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestPriceTb.Name = "TestPriceTb";
            this.TestPriceTb.Size = new System.Drawing.Size(352, 32);
            this.TestPriceTb.TabIndex = 14;
            // 
            // TestAddBtn
            // 
            this.TestAddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestAddBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestAddBtn.Location = new System.Drawing.Point(161, 187);
            this.TestAddBtn.Name = "TestAddBtn";
            this.TestAddBtn.Size = new System.Drawing.Size(167, 51);
            this.TestAddBtn.TabIndex = 16;
            this.TestAddBtn.Text = "ADD";
            this.TestAddBtn.UseVisualStyleBackColor = false;
            this.TestAddBtn.Click += new System.EventHandler(this.TestAddBtn_Click);
            // 
            // AddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestAddBtn);
            this.Controls.Add(this.TestPricelbl);
            this.Controls.Add(this.TestPriceTb);
            this.Controls.Add(this.TestNameLbl);
            this.Controls.Add(this.TestNameTb);
            this.Name = "AddTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestNameLbl;
        private System.Windows.Forms.TextBox TestNameTb;
        private System.Windows.Forms.Label TestPricelbl;
        private System.Windows.Forms.TextBox TestPriceTb;
        private System.Windows.Forms.Button TestAddBtn;
    }
}