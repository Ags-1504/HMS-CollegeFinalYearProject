﻿
namespace WindowsFormsApp1
{
    partial class AddBedCats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBedCats));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Catslbl = new System.Windows.Forms.Label();
            this.Catsdgv = new System.Windows.Forms.DataGridView();
            this.CatPricelbl = new System.Windows.Forms.Label();
            this.CatPriceTb = new System.Windows.Forms.TextBox();
            this.CatNameLbl = new System.Windows.Forms.Label();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.BedtoAddlbl = new System.Windows.Forms.Label();
            this.BedtoAddTb = new System.Windows.Forms.TextBox();
            this.AddCatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Catslbl);
            this.panel1.Controls.Add(this.Catsdgv);
            this.panel1.Location = new System.Drawing.Point(57, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 401);
            this.panel1.TabIndex = 41;
            // 
            // Catslbl
            // 
            this.Catslbl.AutoSize = true;
            this.Catslbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catslbl.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.Catsdgv.BackgroundColor = System.Drawing.Color.LightGray;
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
            this.CatPricelbl.Location = new System.Drawing.Point(52, 84);
            this.CatPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatPricelbl.Name = "CatPricelbl";
            this.CatPricelbl.Size = new System.Drawing.Size(218, 27);
            this.CatPricelbl.TabIndex = 40;
            this.CatPricelbl.Text = "Category Price/day";
            // 
            // CatPriceTb
            // 
            this.CatPriceTb.BackColor = System.Drawing.Color.Silver;
            this.CatPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatPriceTb.Location = new System.Drawing.Point(359, 82);
            this.CatPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatPriceTb.Name = "CatPriceTb";
            this.CatPriceTb.Size = new System.Drawing.Size(352, 32);
            this.CatPriceTb.TabIndex = 39;
            // 
            // CatNameLbl
            // 
            this.CatNameLbl.AutoSize = true;
            this.CatNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.CatNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatNameLbl.Location = new System.Drawing.Point(52, 31);
            this.CatNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatNameLbl.Name = "CatNameLbl";
            this.CatNameLbl.Size = new System.Drawing.Size(179, 27);
            this.CatNameLbl.TabIndex = 38;
            this.CatNameLbl.Text = "Category Name";
            // 
            // CatNameTb
            // 
            this.CatNameTb.BackColor = System.Drawing.Color.Silver;
            this.CatNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.Location = new System.Drawing.Point(359, 29);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(352, 32);
            this.CatNameTb.TabIndex = 37;
            // 
            // BedtoAddlbl
            // 
            this.BedtoAddlbl.AutoSize = true;
            this.BedtoAddlbl.BackColor = System.Drawing.Color.Transparent;
            this.BedtoAddlbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedtoAddlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BedtoAddlbl.Location = new System.Drawing.Point(52, 144);
            this.BedtoAddlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BedtoAddlbl.Name = "BedtoAddlbl";
            this.BedtoAddlbl.Size = new System.Drawing.Size(218, 27);
            this.BedtoAddlbl.TabIndex = 45;
            this.BedtoAddlbl.Text = "No. of Beds to Add";
            // 
            // BedtoAddTb
            // 
            this.BedtoAddTb.BackColor = System.Drawing.Color.Silver;
            this.BedtoAddTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedtoAddTb.Location = new System.Drawing.Point(359, 142);
            this.BedtoAddTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BedtoAddTb.Name = "BedtoAddTb";
            this.BedtoAddTb.Size = new System.Drawing.Size(352, 32);
            this.BedtoAddTb.TabIndex = 44;
            // 
            // AddCatBtn
            // 
            this.AddCatBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddCatBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatBtn.Location = new System.Drawing.Point(370, 211);
            this.AddCatBtn.Name = "AddCatBtn";
            this.AddCatBtn.Size = new System.Drawing.Size(167, 51);
            this.AddCatBtn.TabIndex = 46;
            this.AddCatBtn.Text = "ADD ";
            this.AddCatBtn.UseVisualStyleBackColor = false;
            this.AddCatBtn.Click += new System.EventHandler(this.AddCatBtn_Click);
            // 
            // AddBedCats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 715);
            this.Controls.Add(this.AddCatBtn);
            this.Controls.Add(this.BedtoAddlbl);
            this.Controls.Add(this.BedtoAddTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CatPricelbl);
            this.Controls.Add(this.CatPriceTb);
            this.Controls.Add(this.CatNameLbl);
            this.Controls.Add(this.CatNameTb);
            this.Name = "AddBedCats";
            this.Text = "AddBedCategories";
            this.Load += new System.EventHandler(this.AddBedCats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Catslbl;
        private System.Windows.Forms.DataGridView Catsdgv;
        private System.Windows.Forms.Label CatPricelbl;
        private System.Windows.Forms.TextBox CatPriceTb;
        private System.Windows.Forms.Label CatNameLbl;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.Label BedtoAddlbl;
        private System.Windows.Forms.TextBox BedtoAddTb;
        private System.Windows.Forms.Button AddCatBtn;
    }
}