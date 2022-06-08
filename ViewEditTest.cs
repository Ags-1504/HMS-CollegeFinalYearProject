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
    public partial class ViewEditTest : Form
    {
        public ViewEditTest()
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

            string query1 = "Select * from diagnostics;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            dt1.Columns["test_id"].ColumnName = "Test ID";
            dt1.Columns["test_name"].ColumnName = "Test Name";
            dt1.Columns["test_price"].ColumnName = "Test Price";
            Diagnosticsdgv.DataSource = dt1;
        }
        private void ViewEditTest_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Diagnosticsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = Diagnosticsdgv.Rows[e.RowIndex];
            TestNameTb.Text = row.Cells[1].Value.ToString();
            name = TestNameTb.Text;
            TestPriceTb.Text = row.Cells[2].Value.ToString();
            price = TestPriceTb.Text;
            id = row.Cells[0].Value.ToString();
        }

        private void UserEditBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;

            if(!name.Equals(TestNameTb.Text) || !price.Equals(TestPriceTb.Text))
            {
                string query = "update diagnostics set test_name = @name, test_price = @price where test_id = @ID";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", TestNameTb.Text);
                cmd.Parameters.AddWithValue("@price", TestPriceTb.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test details updated successfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No updates were made...");
            }
        }

        /*private void TestNameTb_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }*/
    }
}
