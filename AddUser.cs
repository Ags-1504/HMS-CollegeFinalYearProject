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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        
        private void IDTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserAddBtn_Click(object sender, EventArgs e)
        {
            IDTb.Text = "HMS-"+ (PhonenoTb.Text.ToString()).Substring(2, 2) + "-" + NameTb.Text.ToString().Substring(NameTb.Text.ToString().Length -3);
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "";
            if(UserTypeCb.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please Select a Type of User first!");
            }
            else if(UserTypeCb.SelectedItem.ToString() == "doctor")
            {
                IDTb.Text += "D";
                query = "insert into doctor values(@id, @pass, @name, @phoneno, @fees, @spec);";
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phoneno", Int64.Parse(PhonenoTb.Text.ToString()));
                cmd.Parameters.AddWithValue("@fees", Double.Parse(DocFeesTb.Text.ToString()));
                cmd.Parameters.AddWithValue("@spec", DocSpecTb.Text.ToString());
                
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Added Succesfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    //UserTypeCb.SelectedItem = null;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Insertion Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }
            }
            else if(UserTypeCb.SelectedItem.ToString() == "staff")
            {
                IDTb.Text += "S";
                query = "insert into staff values(@id, @pass, @name, @phoneno);";
                
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phoneno", Int64.Parse(PhonenoTb.Text.ToString()));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Added Succesfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    //UserTypeCb.SelectedItem = null;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Insertion Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }
            }
            else if (UserTypeCb.SelectedItem.ToString() == "admin")
            {
                IDTb.Text += "A";
                query = "insert into admins values(@id, @pass, @name, @phoneno);";
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phoneno", Int64.Parse(PhonenoTb.Text.ToString()));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Added Succesfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                    //UserTypeCb.SelectedItem = null;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Insertion Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }
            }
            
        }

        private void UserTypeCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if(UserTypeCb.SelectedItem.ToString() == null)
            {
                DocFeesTb.Visible = false;
                DocSpecTb.Visible = false;
                DocSpeclbl.Visible = false;
                DocFeeslbl.Visible = false;
            }
            else if (UserTypeCb.SelectedItem.ToString() == "doctor")
            {
                DocFeesTb.Visible = true;
                DocSpecTb.Visible = true;
                DocSpeclbl.Visible = true;
                DocFeeslbl.Visible = true;

            }
            else if (UserTypeCb.SelectedItem.ToString() == "admin")
            {
                DocFeesTb.Visible = false;
                DocSpecTb.Visible = false;
                DocSpeclbl.Visible = false;
                DocFeeslbl.Visible = false;

            }
            else if (UserTypeCb.SelectedItem.ToString() == "staff")
            {
                DocFeesTb.Visible = false;
                DocSpecTb.Visible = false;
                DocSpeclbl.Visible = false;
                DocFeeslbl.Visible = false;
            }
        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
