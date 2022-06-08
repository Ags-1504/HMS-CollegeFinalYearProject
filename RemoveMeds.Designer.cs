
namespace WindowsFormsApp1
{
    partial class RemoveMeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveMeds));
            this.MedIDlbl = new System.Windows.Forms.Label();
            this.MedIdTb = new System.Windows.Forms.TextBox();
            this.MedNameLbl = new System.Windows.Forms.Label();
            this.MedNameTb = new System.Windows.Forms.TextBox();
            this.MedDelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MedIDlbl
            // 
            this.MedIDlbl.AutoSize = true;
            this.MedIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.MedIDlbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedIDlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedIDlbl.Location = new System.Drawing.Point(42, 111);
            this.MedIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedIDlbl.Name = "MedIDlbl";
            this.MedIDlbl.Size = new System.Drawing.Size(141, 27);
            this.MedIDlbl.TabIndex = 42;
            this.MedIDlbl.Text = "Medicine ID";
            // 
            // MedIdTb
            // 
            this.MedIdTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MedIdTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedIdTb.Location = new System.Drawing.Point(266, 111);
            this.MedIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedIdTb.Name = "MedIdTb";
            this.MedIdTb.ReadOnly = true;
            this.MedIdTb.Size = new System.Drawing.Size(354, 32);
            this.MedIdTb.TabIndex = 41;
            // 
            // MedNameLbl
            // 
            this.MedNameLbl.AutoSize = true;
            this.MedNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.MedNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedNameLbl.Location = new System.Drawing.Point(42, 39);
            this.MedNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedNameLbl.Name = "MedNameLbl";
            this.MedNameLbl.Size = new System.Drawing.Size(181, 27);
            this.MedNameLbl.TabIndex = 40;
            this.MedNameLbl.Text = "Medicine Name";
            // 
            // MedNameTb
            // 
            this.MedNameTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MedNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameTb.Location = new System.Drawing.Point(266, 39);
            this.MedNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedNameTb.Name = "MedNameTb";
            this.MedNameTb.Size = new System.Drawing.Size(354, 32);
            this.MedNameTb.TabIndex = 39;
            this.MedNameTb.Leave += new System.EventHandler(this.MedNameTb_Leave);
            // 
            // MedDelBtn
            // 
            this.MedDelBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MedDelBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDelBtn.Location = new System.Drawing.Point(266, 179);
            this.MedDelBtn.Name = "MedDelBtn";
            this.MedDelBtn.Size = new System.Drawing.Size(167, 51);
            this.MedDelBtn.TabIndex = 38;
            this.MedDelBtn.Text = "REMOVE";
            this.MedDelBtn.UseVisualStyleBackColor = false;
            this.MedDelBtn.Click += new System.EventHandler(this.MedDelBtn_Click);
            // 
            // RemoveMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 380);
            this.Controls.Add(this.MedIDlbl);
            this.Controls.Add(this.MedIdTb);
            this.Controls.Add(this.MedNameLbl);
            this.Controls.Add(this.MedNameTb);
            this.Controls.Add(this.MedDelBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "RemoveMeds";
            this.Text = "RemoveMeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MedIDlbl;
        private System.Windows.Forms.TextBox MedIdTb;
        private System.Windows.Forms.Label MedNameLbl;
        private System.Windows.Forms.TextBox MedNameTb;
        private System.Windows.Forms.Button MedDelBtn;
    }
}