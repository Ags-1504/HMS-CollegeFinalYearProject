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
    public partial class AddTest : Form
    {
        
        public AddTest()
        {
            InitializeComponent();
        }

        private void TestAddBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "";

            if(TestNameTb.Text == "" || TestPriceTb.Text == "")
            {
                MessageBox.Show("Please enter all field values.");
            }
            else
            {
                query = "insert into diagnostics values(@ID, @name, @price);";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", (TestNameTb.Text.Substring(1, 3)+DateTime.Now.ToString()));
                cmd.Parameters.AddWithValue("@name", TestNameTb.Text);
                cmd.Parameters.AddWithValue("@price", Double.Parse(TestPriceTb.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added successfully in Diagnostics.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }
    }
}
