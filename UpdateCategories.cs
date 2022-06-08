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
    public partial class UpdateCategories : Form
    {
        public UpdateCategories()
        {
            InitializeComponent();
        }

        string name = "", id = "", price = "";

        private void populate()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);

            string query1 = "Select * from bed_category;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            con.Close();
            dt1.Columns["category_id"].ColumnName = "Category ID";
            dt1.Columns["category_name"].ColumnName = "Category Name";
            dt1.Columns["category_priceperday"].ColumnName = "Bed Price/Day";
            dt1.Columns["beds_total"].ColumnName = "Total Beds";
            dt1.Columns["beds_left"].ColumnName = "Beds Available";
            Catsdgv.DataSource = dt1;
        }

        private void UpdateCategories_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void UpCatBtn_Click_1(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;

            if (!name.Equals(CatNameTb.Text) || !price.Equals(CatPriceTb.Text))
            {
                string query = "update bed_category set category_name = @name, category_priceperday = @price where category_id = @ID";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", CatNameTb.Text);
                cmd.Parameters.AddWithValue("@price", CatPriceTb.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bed Category details updated successfully.");
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

        private void Catsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Catsdgv.Rows[e.RowIndex];
            CatNameTb.Text = row.Cells[1].Value.ToString();
            name = CatNameTb.Text;
            CatPriceTb.Text = row.Cells[2].Value.ToString();
            price = CatPriceTb.Text;
            id = row.Cells[0].Value.ToString();
        }
    }
}
