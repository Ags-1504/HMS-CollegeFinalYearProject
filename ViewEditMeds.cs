using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewEditMeds : Form
    {
        public ViewEditMeds()
        {
            InitializeComponent();
        }

        static string name = "";
        static string price = "";
        static string id = " ";

        void populate()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);

            string query1 = "Select * from medicines;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            dt1.Columns["medicine_id"].ColumnName = "Med ID";
            dt1.Columns["medicine_name"].ColumnName = "Med Name";
            dt1.Columns["medicine_pricepertab"].ColumnName = "Med Price/Tab";
            Medsdgv.DataSource = dt1;
        }

        private void ViewEditMeds_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Medsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Medsdgv.Rows[e.RowIndex];
            MedNameTb.Text = row.Cells[1].Value.ToString();
            name = MedNameTb.Text;
            MedPriceTb.Text = row.Cells[2].Value.ToString();
            price = MedPriceTb.Text;
            id = row.Cells[0].Value.ToString();
        }

        private void MedsEditBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;

            if (!name.Equals(MedNameTb.Text) || !price.Equals(MedPriceTb.Text))
            {
                string query = "update medicines set medicine_name = @name, medicine_pricepertab = @price where medicine_id = @ID";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", MedNameTb.Text);
                cmd.Parameters.AddWithValue("@price", MedPriceTb.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine details updated successfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No updates were made...");
            }
        }
    }
}
