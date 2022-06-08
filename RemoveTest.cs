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
    public partial class RemoveTest : Form
    {
        public RemoveTest()
        {
            InitializeComponent();
        }

        private void TestDelBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            
            string delquery = "";

            if(TestNameTb.Text != null && MessageBox.Show("Are You certain you want to remove " + TestNameTb.Text + " permenantly!", "Remove",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delquery = "delete from diagnostics where test_id = @ID;";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(delquery, con);
                    cmd.Parameters.AddWithValue("@ID", TestIdTb.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Diagnostic deleted Successfully.");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide a test name to delete!");
            }

        }

        private void TestNameTb_Leave(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            string query1 = "";
            if (TestNameTb.Text != null)
            {
                query1 = "Select * from diagnostics where test_name = @name;";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@name", TestNameTb.Text);
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    con.Close();
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        TestIdTb.Text = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input. Try to check the spelling of the diagnostic test.");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide a test name to delete!");
            }
        }
    }
}
