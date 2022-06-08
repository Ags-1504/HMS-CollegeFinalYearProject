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
    public partial class AddMeds : Form
    {
        public AddMeds()
        {
            InitializeComponent();
        }

        private void MedAddBtn_Click(object sender, EventArgs e)
        {

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "";

            if (MedNameTb.Text == "" || MedPriceTb.Text == "")
            {
                MessageBox.Show("Please enter all field values.");
            }
            else
            {
                query = "insert into medicines values(@ID, @name, @price);";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", (MedNameTb.Text.Substring(1, 3) + DateTime.Now.ToString()));
                cmd.Parameters.AddWithValue("@name", MedNameTb.Text);
                cmd.Parameters.AddWithValue("@price", Double.Parse(MedPriceTb.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added successfully in Medicines.");
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


            }
        }
    }
}
