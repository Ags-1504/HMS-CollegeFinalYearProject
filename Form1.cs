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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            string query = "";
            
            if(UserRoleCmb.SelectedItem == null)
            {
                MessageBox.Show("Please select/fill all fields!");
            }
            else if (UserRoleCmb.SelectedItem.ToString() == "admin")
            {
                query = "Select * from admins where admin_phoneno=@id and admin_password=@pass";
            }else if(UserRoleCmb.SelectedItem.ToString() == "doctor")
            {
                query = "Select * from doctor where doctor_phoneno=@id and doctor_password=@pass";
            }
            else if (UserRoleCmb.SelectedItem.ToString() == "staff")
            {
                query = "Select * from staff where staff_phoneno=@id and staff_password=@pass";
            }
            

            try
            {
                
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IDTxt.Text);
                cmd.Parameters.AddWithValue("@pass", PasswordTxt.Text.GetHashCode());

                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                if(ds.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("Login Successful.");
                    this.Hide();
                    Dashboard dsboard = new Dashboard();
                    dsboard.LoggedInAsLabel = "Logged in As - " + ds.Tables[0].Rows[0][2].ToString();
                    dsboard.UserID = ds.Tables[0].Rows[0][0].ToString();
                    dsboard.UserLevel = UserRoleCmb.SelectedItem.ToString();
                    dsboard.Show();

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
