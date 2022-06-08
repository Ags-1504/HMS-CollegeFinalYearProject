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
    public partial class RemoveMeds : Form
    {
        public RemoveMeds()
        {
            InitializeComponent();
        }

        private void MedDelBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);

            string delquery = "";

            if (MedNameTb.Text != null && MessageBox.Show("Are You certain you want to remove " + MedNameTb.Text + " permenantly!", "Remove",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delquery = "delete from medicines where medicine_id = @ID;";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(delquery, con);
                    cmd.Parameters.AddWithValue("@ID", MedIdTb.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine deleted Successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide a medicine name to delete!");
            }

        }

        private void MedNameTb_Leave(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            string query1 = "";
            if (MedNameTb.Text != null)
            {
                query1 = "Select * from medicines where medicine_name = @name;";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@name", MedNameTb.Text);
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    con.Close();
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MedIdTb.Text = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input. Try to check the spelling of the medicine.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide a medicine name to delete!");
            }
        }
    }
}
