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
    public partial class AddBedCats : Form
    {
        public AddBedCats()
        {
            InitializeComponent();
        }

        

        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "";

            if (CatNameTb.Text == "" || CatPriceTb.Text == "" || BedtoAddTb.Text == "")
            {
                MessageBox.Show("Please enter all field values.");
            }
            else
            {
                query = "insert into bed_category values(@ID, @name, @price, @beds, @beds);";
                cmd = new MySqlCommand(query, con);
                string ID = "HMS-bc-00" + (Catsdgv.Rows.Count + 1).ToString()+DateTime.Now.ToString();
                string name = CatNameTb.Text;
                long n = long.Parse(BedtoAddTb.Text);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", Double.Parse(CatPriceTb.Text));
                cmd.Parameters.AddWithValue("@beds", n);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bed Category Added successfully");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                populateBeds(n, ID, name);
                populate();

            }
        }

        private void populateBeds(long n, string id, string name)
        {
            for (long i = 1; i <= n; i++)
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
                MySqlConnection con = new MySqlConnection(connstr);
                MySqlCommand cmd;
                string query = "insert into beds values(@ID, @cat_ID, false);";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", name.Substring(0,3) + "-0" + i.ToString()+DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@cat_ID", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

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

        private void AddBedCats_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Catsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
