
namespace WindowsFormsApp1
{
    partial class AddMeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMeds));
            this.MedAddBtn = new System.Windows.Forms.Button();
            this.MedPricelbl = new System.Windows.Forms.Label();
            this.MedPriceTb = new System.Windows.Forms.TextBox();
            this.MedNameLbl = new System.Windows.Forms.Label();
            this.MedNameTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MedAddBtn
            // 
            this.MedAddBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MedAddBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedAddBtn.Location = new System.Drawing.Point(321, 189);
            this.MedAddBtn.Name = "MedAddBtn";
            this.MedAddBtn.Size = new System.Drawing.Size(167, 51);
            this.MedAddBtn.TabIndex = 21;
            this.MedAddBtn.Text = "ADD";
            this.MedAddBtn.UseVisualStyleBackColor = false;
            this.MedAddBtn.Click += new System.EventHandler(this.MedAddBtn_Click);
            // 
            // MedPricelbl
            // 
            this.MedPricelbl.AutoSize = true;
            this.MedPricelbl.BackColor = System.Drawing.Color.Transparent;
            this.MedPricelbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedPricelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedPricelbl.Location = new System.Drawing.Point(18, 123);
            this.MedPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedPricelbl.Name = "MedPricelbl";
            this.MedPricelbl.Size = new System.Drawing.Size(222, 27);
            this.MedPricelbl.TabIndex = 20;
            this.MedPricelbl.Text = "Medicine Price/Tab";
            // 
            // MedPriceTb
            // 
            this.MedPriceTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedPriceTb.Location = new System.Drawing.Point(291, 118);
            this.MedPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedPriceTb.Name = "MedPriceTb";
            this.MedPriceTb.Size = new System.Drawing.Size(352, 32);
            this.MedPriceTb.TabIndex = 19;
            // 
            // MedNameLbl
            // 
            this.MedNameLbl.AutoSize = true;
            this.MedNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.MedNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedNameLbl.Location = new System.Drawing.Point(18, 50);
            this.MedNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedNameLbl.Name = "MedNameLbl";
            this.MedNameLbl.Size = new System.Drawing.Size(181, 27);
            this.MedNameLbl.TabIndex = 18;
            this.MedNameLbl.Text = "Medicine Name";
            // 
            // MedNameTb
            // 
            this.MedNameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameTb.Location = new System.Drawing.Point(291, 50);
            this.MedNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedNameTb.Name = "MedNameTb";
            this.MedNameTb.Size = new System.Drawing.Size(352, 32);
            this.MedNameTb.TabIndex = 17;
            // 
            // AddMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedAddBtn);
            this.Controls.Add(this.MedPricelbl);
            this.Controls.Add(this.MedPriceTb);
            this.Controls.Add(this.MedNameLbl);
            this.Controls.Add(this.MedNameTb);
            this.DoubleBuffered = true;
            this.Name = "AddMeds";
            this.Text = "AddMeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MedAddBtn;
        private System.Windows.Forms.Label MedPricelbl;
        private System.Windows.Forms.TextBox MedPriceTb;
        private System.Windows.Forms.Label MedNameLbl;
        private System.Windows.Forms.TextBox MedNameTb;
    }
}