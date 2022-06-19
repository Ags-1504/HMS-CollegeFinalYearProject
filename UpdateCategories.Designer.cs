
namespace WindowsFormsApp1
{
    partial class UpdateCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategories));
            this.UpCatBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Catslbl = new System.Windows.Forms.Label();
            this.Catsdgv = new System.Windows.Forms.DataGridView();
            this.CatPricelbl = new System.Windows.Forms.Label();
            this.CatPriceTb = new System.Windows.Forms.TextBox();
            this.CatNameLbl = new System.Windows.Forms.Label();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UpCatBtn
            // 
            this.UpCatBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpCatBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpCatBtn.Location = new System.Drawing.Point(321, 185);
            this.UpCatBtn.Name = "UpCatBtn";
            this.UpCatBtn.Size = new System.Drawing.Size(167, 51);
            this.UpCatBtn.TabIndex = 54;
            this.UpCatBtn.Text = "UPDATE";
            this.UpCatBtn.UseVisualStyleBackColor = false;
            this.UpCatBtn.Click += new System.EventHandler(this.UpCatBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Catslbl);
            this.panel1.Controls.Add(this.Catsdgv);
            this.panel1.Location = new System.Drawing.Point(19, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 401);
            this.panel1.TabIndex = 51;
            // 
            // Catslbl
            // 
            this.Catslbl.AutoSize = true;
            this.Catslbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catslbl.ForeColor = System.Drawing.Color.Navy;
            this.Catslbl.Location = new System.Drawing.Point(297, 0);
            this.Catslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Catslbl.Name = "Catslbl";
            this.Catslbl.Size = new System.Drawing.Size(183, 27);
            this.Catslbl.TabIndex = 34;
            this.Catslbl.Text = "Bed Categories";
            // 
            // Catsdgv
            // 
            this.Catsdgv.AllowUserToAddRows = false;
            this.Catsdgv.AllowUserToDeleteRows = false;
            this.Catsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Catsdgv.BackgroundColor = System.Drawing.Color.Silver;
            this.Catsdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Catsdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Catsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Catsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Catsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Catsdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Catsdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Catsdgv.Location = new System.Drawing.Point(27, 32);
            this.Catsdgv.Margin = new System.Windows.Forms.Padding(0);
            this.Catsdgv.Name = "Catsdgv";
            this.Catsdgv.ReadOnly = true;
            this.Catsdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Catsdgv.RowHeadersVisible = false;
            this.Catsdgv.RowHeadersWidth = 51;
            this.Catsdgv.RowTemplate.Height = 24;
            this.Catsdgv.Size = new System.Drawing.Size(710, 357);
            this.Catsdgv.TabIndex = 33;
            this.Catsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Catsdgv_CellContentClick);
            // 
            // CatPricelbl
            // 
            this.CatPricelbl.AutoSize = true;
            this.CatPricelbl.BackColor = System.Drawing.Color.Transparent;
            this.CatPricelbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatPricelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatPricelbl.Location = new System.Drawing.Point(41, 75);
            this.CatPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatPricelbl.Name = "CatPricelbl";
            this.CatPricelbl.Size = new System.Drawing.Size(218, 27);
            this.CatPricelbl.TabIndex = 50;
            this.CatPricelbl.Text = "Category Price/day";
            // 
            // CatPriceTb
            // 
            this.CatPriceTb.BackColor = System.Drawing.Color.Silver;
            this.CatPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatPriceTb.Location = new System.Drawing.Point(366, 73);
            this.CatPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatPriceTb.Name = "CatPriceTb";
            this.CatPriceTb.Size = new System.Drawing.Size(352, 32);
            this.CatPriceTb.TabIndex = 49;
            // 
            // CatNameLbl
            // 
            this.CatNameLbl.AutoSize = true;
            this.CatNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.CatNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatNameLbl.Location = new System.Drawing.Point(41, 19);
            this.CatNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatNameLbl.Name = "CatNameLbl";
            this.CatNameLbl.Size = new System.Drawing.Size(179, 27);
            this.CatNameLbl.TabIndex = 48;
            this.CatNameLbl.Text = "Category Name";
            // 
            // CatNameTb
            // 
            this.CatNameTb.BackColor = System.Drawing.Color.Silver;
            this.CatNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.Location = new System.Drawing.Point(366, 19);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(352, 32);
            this.CatNameTb.TabIndex = 47;
            // 
            // UpdateCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.UpCatBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CatPricelbl);
            this.Controls.Add(this.CatPriceTb);
            this.Controls.Add(this.CatNameLbl);
            this.Controls.Add(this.CatNameTb);
            this.Name = "UpdateCategories";
            this.Text = "UpdateCategories";
            this.Load += new System.EventHandler(this.UpdateCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpCatBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Catslbl;
        private System.Windows.Forms.DataGridView Catsdgv;
        private System.Windows.Forms.Label CatPricelbl;
        private System.Windows.Forms.TextBox CatPriceTb;
        private System.Windows.Forms.Label CatNameLbl;
        private System.Windows.Forms.TextBox CatNameTb;
    }
}