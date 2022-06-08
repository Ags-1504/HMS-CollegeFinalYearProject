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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void UserDelBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            string query1 = "";
            string delquery = "";
            if (UserTypeCb.SelectedItem == null)
            {
                MessageBox.Show("Please select/fill all fields!");
            }
            else if (UserTypeCb.SelectedItem.ToString() == "admin")
            {
                query1 = "Select * from admins where admin_id=@id;";
                delquery = "Delete from admins where admin_id = @id";
            }
            else if (UserTypeCb.SelectedItem.ToString() == "doctor")
            {
                query1 = "Select * from doctor where doctor_id=@id;";
                delquery = "Delete from doctor where doctor_id = @id;";
            }
            else if (UserTypeCb.SelectedItem.ToString() == "staff")
            {
                query1 = "Select * from staff where staff_id=@id;";
                delquery = "Delete from staff where staff_id = @id;";
            }
            try
            {
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@id", IDTb.Text);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                if (MessageBox.Show("Are You certain you want to remove "+ds.Tables[0].Rows[0][2].ToString()+" permenantly!", "Remove", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(delquery, con);
                    cmd2.Parameters.AddWithValue("@id", IDTb.Text);
                    if(cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Removed from System Successfully");
                    }
                    else
                    {
                        MessageBox.Show("User Removal Failed! Please check all fields.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
