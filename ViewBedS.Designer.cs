
namespace WindowsFormsApp1
{
    partial class ViewBedS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBedS));
            this.Bedsdgv = new System.Windows.Forms.DataGridView();
            this.Reserved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateCatBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bedsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Bedsdgv
            // 
            this.Bedsdgv.AllowUserToAddRows = false;
            this.Bedsdgv.AllowUserToDeleteRows = false;
            this.Bedsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bedsdgv.BackgroundColor = System.Drawing.Color.Silver;
            this.Bedsdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bedsdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Bedsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bedsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Bedsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bedsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reserved,
            this.BedID,
            this.CategoryID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bedsdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bedsdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bedsdgv.Location = new System.Drawing.Point(9, 26);
            this.Bedsdgv.Margin = new System.Windows.Forms.Padding(0);
            this.Bedsdgv.Name = "Bedsdgv";
            this.Bedsdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Bedsdgv.RowHeadersVisible = false;
            this.Bedsdgv.RowHeadersWidth = 51;
            this.Bedsdgv.RowTemplate.Height = 24;
            this.Bedsdgv.Size = new System.Drawing.Size(782, 642);
            this.Bedsdgv.TabIndex = 34;
            // 
            // Reserved
            // 
            this.Reserved.HeaderText = "Reserved?";
            this.Reserved.MinimumWidth = 6;
            this.Reserved.Name = "Reserved";
            // 
            // BedID
            // 
            this.BedID.HeaderText = "Bed ID";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // UpdateCatBtn
            // 
            this.UpdateCatBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateCatBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCatBtn.Location = new System.Drawing.Point(317, 688);
            this.UpdateCatBtn.Name = "UpdateCatBtn";
            this.UpdateCatBtn.Size = new System.Drawing.Size(167, 51);
            this.UpdateCatBtn.TabIndex = 47;
            this.UpdateCatBtn.Text = "UPDATE ";
            this.UpdateCatBtn.UseVisualStyleBackColor = false;
            this.UpdateCatBtn.Click += new System.EventHandler(this.UpdateCatBtn_Click);
            // 
            // ViewBedS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.UpdateCatBtn);
            this.Controls.Add(this.Bedsdgv);
            this.Name = "ViewBedS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBedStatus";
            this.Load += new System.EventHandler(this.ViewBedS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bedsdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bedsdgv;
        private System.Windows.Forms.Button UpdateCatBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
    }
}