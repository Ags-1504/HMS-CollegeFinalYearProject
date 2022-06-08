
namespace WindowsFormsApp1
{
    partial class ViewEditMeds
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditMeds));
            this.MedsEditBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Medslbl = new System.Windows.Forms.Label();
            this.Medsdgv = new System.Windows.Forms.DataGridView();
            this.MedPricelbl = new System.Windows.Forms.Label();
            this.MedPriceTb = new System.Windows.Forms.TextBox();
            this.MedNameLbl = new System.Windows.Forms.Label();
            this.MedNameTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MedsEditBtn
            // 
            this.MedsEditBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MedsEditBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedsEditBtn.Location = new System.Drawing.Point(270, 131);
            this.MedsEditBtn.Name = "MedsEditBtn";
            this.MedsEditBtn.Size = new System.Drawing.Size(167, 51);
            this.MedsEditBtn.TabIndex = 36;
            this.MedsEditBtn.Text = "UPDATE";
            this.MedsEditBtn.UseVisualStyleBackColor = false;
            this.MedsEditBtn.Click += new System.EventHandler(this.MedsEditBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Medslbl);
            this.panel1.Controls.Add(this.Medsdgv);
            this.panel1.Location = new System.Drawing.Point(18, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 401);
            this.panel1.TabIndex = 35;
            // 
            // Medslbl
            // 
            this.Medslbl.AutoSize = true;
            this.Medslbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medslbl.ForeColor = System.Drawing.Color.Navy;
            this.Medslbl.Location = new System.Drawing.Point(277, 0);
            this.Medslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Medslbl.Name = "Medslbl";
            this.Medslbl.Size = new System.Drawing.Size(126, 27);
            this.Medslbl.TabIndex = 34;
            this.Medslbl.Text = "Medicines";
            // 
            // Medsdgv
            // 
            this.Medsdgv.AllowUserToAddRows = false;
            this.Medsdgv.AllowUserToDeleteRows = false;
            this.Medsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Medsdgv.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.Medsdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Medsdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Medsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Medsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Medsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Medsdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Medsdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Medsdgv.Location = new System.Drawing.Point(27, 32);
            this.Medsdgv.Margin = new System.Windows.Forms.Padding(0);
            this.Medsdgv.Name = "Medsdgv";
            this.Medsdgv.ReadOnly = true;
            this.Medsdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Medsdgv.RowHeadersVisible = false;
            this.Medsdgv.RowHeadersWidth = 51;
            this.Medsdgv.RowTemplate.Height = 24;
            this.Medsdgv.Size = new System.Drawing.Size(637, 357);
            this.Medsdgv.TabIndex = 33;
            this.Medsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Medsdgv_CellContentClick);
            // 
            // MedPricelbl
            // 
            this.MedPricelbl.AutoSize = true;
            this.MedPricelbl.BackColor = System.Drawing.Color.Transparent;
            this.MedPricelbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedPricelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedPricelbl.Location = new System.Drawing.Point(24, 82);
            this.MedPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedPricelbl.Name = "MedPricelbl";
            this.MedPricelbl.Size = new System.Drawing.Size(217, 27);
            this.MedPricelbl.TabIndex = 34;
            this.MedPricelbl.Text = "Medicine Price/tab";
            // 
            // MedPriceTb
            // 
            this.MedPriceTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedPriceTb.Location = new System.Drawing.Point(270, 78);
            this.MedPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedPriceTb.Name = "MedPriceTb";
            this.MedPriceTb.Size = new System.Drawing.Size(352, 32);
            this.MedPriceTb.TabIndex = 33;
            // 
            // MedNameLbl
            // 
            this.MedNameLbl.AutoSize = true;
            this.MedNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.MedNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedNameLbl.Location = new System.Drawing.Point(24, 26);
            this.MedNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedNameLbl.Name = "MedNameLbl";
            this.MedNameLbl.Size = new System.Drawing.Size(181, 27);
            this.MedNameLbl.TabIndex = 32;
            this.MedNameLbl.Text = "Medicine Name";
            // 
            // MedNameTb
            // 
            this.MedNameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameTb.Location = new System.Drawing.Point(270, 22);
            this.MedNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedNameTb.Name = "MedNameTb";
            this.MedNameTb.Size = new System.Drawing.Size(352, 32);
            this.MedNameTb.TabIndex = 31;
            // 
            // ViewEditMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 620);
            this.Controls.Add(this.MedsEditBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MedPricelbl);
            this.Controls.Add(this.MedPriceTb);
            this.Controls.Add(this.MedNameLbl);
            this.Controls.Add(this.MedNameTb);
            this.DoubleBuffered = true;
            this.Name = "ViewEditMeds";
            this.Text = "ViewEditMeds";
            this.Load += new System.EventHandler(this.ViewEditMeds_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MedsEditBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Medslbl;
        private System.Windows.Forms.DataGridView Medsdgv;
        private System.Windows.Forms.Label MedPricelbl;
        private System.Windows.Forms.TextBox MedPriceTb;
        private System.Windows.Forms.Label MedNameLbl;
        private System.Windows.Forms.TextBox MedNameTb;
    }
}