
namespace WindowsFormsApp1
{
    partial class ViewEditTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditTest));
            this.TestPricelbl = new System.Windows.Forms.Label();
            this.TestPriceTb = new System.Windows.Forms.TextBox();
            this.TestNameLbl = new System.Windows.Forms.Label();
            this.TestNameTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Diagnosticslbl = new System.Windows.Forms.Label();
            this.Diagnosticsdgv = new System.Windows.Forms.DataGridView();
            this.UserEditBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diagnosticsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TestPricelbl
            // 
            this.TestPricelbl.AutoSize = true;
            this.TestPricelbl.BackColor = System.Drawing.Color.Transparent;
            this.TestPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPricelbl.Location = new System.Drawing.Point(20, 83);
            this.TestPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestPricelbl.Name = "TestPricelbl";
            this.TestPricelbl.Size = new System.Drawing.Size(110, 25);
            this.TestPricelbl.TabIndex = 19;
            this.TestPricelbl.Text = "Test Price";
            // 
            // TestPriceTb
            // 
            this.TestPriceTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestPriceTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPriceTb.Location = new System.Drawing.Point(198, 83);
            this.TestPriceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestPriceTb.Name = "TestPriceTb";
            this.TestPriceTb.Size = new System.Drawing.Size(352, 32);
            this.TestPriceTb.TabIndex = 18;
            // 
            // TestNameLbl
            // 
            this.TestNameLbl.AutoSize = true;
            this.TestNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.TestNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameLbl.Location = new System.Drawing.Point(20, 30);
            this.TestNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestNameLbl.Name = "TestNameLbl";
            this.TestNameLbl.Size = new System.Drawing.Size(117, 25);
            this.TestNameLbl.TabIndex = 17;
            this.TestNameLbl.Text = "Test Name";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TestNameTb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameTb.Location = new System.Drawing.Point(198, 23);
            this.TestNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.Size = new System.Drawing.Size(352, 32);
            this.TestNameTb.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.Diagnosticslbl);
            this.panel1.Controls.Add(this.Diagnosticsdgv);
            this.panel1.Location = new System.Drawing.Point(25, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 401);
            this.panel1.TabIndex = 20;
            // 
            // Diagnosticslbl
            // 
            this.Diagnosticslbl.AutoSize = true;
            this.Diagnosticslbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosticslbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Diagnosticslbl.Location = new System.Drawing.Point(277, 0);
            this.Diagnosticslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Diagnosticslbl.Name = "Diagnosticslbl";
            this.Diagnosticslbl.Size = new System.Drawing.Size(146, 27);
            this.Diagnosticslbl.TabIndex = 34;
            this.Diagnosticslbl.Text = "Diagnostics";
            // 
            // Diagnosticsdgv
            // 
            this.Diagnosticsdgv.AllowUserToAddRows = false;
            this.Diagnosticsdgv.AllowUserToDeleteRows = false;
            this.Diagnosticsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Diagnosticsdgv.BackgroundColor = System.Drawing.Color.Azure;
            this.Diagnosticsdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Diagnosticsdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Diagnosticsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Diagnosticsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Diagnosticsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Diagnosticsdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Diagnosticsdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Diagnosticsdgv.Location = new System.Drawing.Point(27, 32);
            this.Diagnosticsdgv.Margin = new System.Windows.Forms.Padding(0);
            this.Diagnosticsdgv.Name = "Diagnosticsdgv";
            this.Diagnosticsdgv.ReadOnly = true;
            this.Diagnosticsdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Diagnosticsdgv.RowHeadersVisible = false;
            this.Diagnosticsdgv.RowHeadersWidth = 51;
            this.Diagnosticsdgv.RowTemplate.Height = 24;
            this.Diagnosticsdgv.Size = new System.Drawing.Size(637, 357);
            this.Diagnosticsdgv.TabIndex = 33;
            this.Diagnosticsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Diagnosticsdgv_CellContentClick);
            // 
            // UserEditBtn
            // 
            this.UserEditBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserEditBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEditBtn.Location = new System.Drawing.Point(266, 133);
            this.UserEditBtn.Name = "UserEditBtn";
            this.UserEditBtn.Size = new System.Drawing.Size(167, 51);
            this.UserEditBtn.TabIndex = 30;
            this.UserEditBtn.Text = "UPDATE";
            this.UserEditBtn.UseVisualStyleBackColor = false;
            this.UserEditBtn.Click += new System.EventHandler(this.UserEditBtn_Click);
            // 
            // ViewEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 620);
            this.Controls.Add(this.UserEditBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestPricelbl);
            this.Controls.Add(this.TestPriceTb);
            this.Controls.Add(this.TestNameLbl);
            this.Controls.Add(this.TestNameTb);
            this.Name = "ViewEditTest";
            this.Text = "ViewEditTest";
            this.Load += new System.EventHandler(this.ViewEditTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diagnosticsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestPricelbl;
        private System.Windows.Forms.TextBox TestPriceTb;
        private System.Windows.Forms.Label TestNameLbl;
        private System.Windows.Forms.TextBox TestNameTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Diagnosticslbl;
        private System.Windows.Forms.DataGridView Diagnosticsdgv;
        private System.Windows.Forms.Button UserEditBtn;
    }
}