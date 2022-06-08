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
    public partial class ViewEditUser : Form
    {
        public ViewEditUser()
        {
            InitializeComponent();
        }

        public void populate()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);

            string query1 = "Select admin_id, admin_name, admin_phoneno from admins;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            dt1.Columns["admin_id"].ColumnName = "Admin ID";
            dt1.Columns["admin_name"].ColumnName = "Admin Name";
            dt1.Columns["admin_phoneno"].ColumnName = "Admin Phone No.";
            Adminsdgv.DataSource = dt1;
            /*foreach(DataRow item in dt.Rows)
            {
                foreach (var initem in item.ItemArray)
                    MessageBox.Show(initem.ToString());
            }*/

            string query2 = "Select staff_id, staff_name, staff_phoneno from staff;";
            MySqlCommand cmd2 = new MySqlCommand(query2, con);

            MySqlDataAdapter adapt2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            dt2.Columns["staff_id"].ColumnName = "Staff ID";
            dt2.Columns["staff_name"].ColumnName = "Staff Name";
            dt2.Columns["staff_phoneno"].ColumnName = "Staff Phone No.";
            Staffdgv.DataSource = dt2;


            string query3 = "Select doctor_id, doctor_name, doctor_phoneno, doctor_fees, doctor_spec from doctor;";
            MySqlCommand cmd3 = new MySqlCommand(query3, con);

            MySqlDataAdapter adapt3 = new MySqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            adapt3.Fill(dt3);
            dt3.Columns["doctor_id"].ColumnName = "Doctor ID";
            dt3.Columns["doctor_name"].ColumnName = "Doctor Name";
            dt3.Columns["doctor_phoneno"].ColumnName = "Doctor Phone No.";
            dt3.Columns["doctor_fees"].ColumnName = "Doctor Fees";
            dt3.Columns["doctor_spec"].ColumnName = "Doctor Specialization";
            Doctorsdgv.DataSource = dt3;


            con.Close();
        }

        private void ViewEditUser_Load(object sender, EventArgs e)
        {
            populate();
            Adminsdgv.Visible = true;
            AdminsTabBtn.PerformClick();
        }

        private void Adminsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Adminsdgv.Rows[e.RowIndex];
            UserTypeCb.SelectedItem = "admin";
            IDTb.Text = row.Cells[0].Value.ToString();
            NameTb.Text = row.Cells[1].Value.ToString();
            PhonenoTb.Text = row.Cells[2].Value.ToString();

        }

        private void Staffdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Staffdgv.Rows[e.RowIndex];
            UserTypeCb.SelectedItem = "staff";
            IDTb.Text = row.Cells[0].Value.ToString();
            NameTb.Text = row.Cells[1].Value.ToString();
            PhonenoTb.Text = row.Cells[2].Value.ToString();
        }

        private void Doctorsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Doctorsdgv.Rows[e.RowIndex];
            UserTypeCb.SelectedItem = "doctor";
            IDTb.Text = row.Cells[0].Value.ToString();
            NameTb.Text = row.Cells[1].Value.ToString();
            PhonenoTb.Text = row.Cells[2].Value.ToString();
            DocFeesTb.Text = row.Cells[3].Value.ToString();
            DocSpecTb.Text = row.Cells[4].Value.ToString();
        }

        private void UserTypeCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (UserTypeCb.SelectedItem.ToString() == "doctor")
            {
                DocFeeslbl.Visible = true;
                DocFeesTb.Visible = true;
                DocSpeclbl.Visible = true;
                DocSpecTb.Visible = true;
            }
            else
            {
                DocFeeslbl.Visible = false;
                DocFeesTb.Visible = false;
                DocSpeclbl.Visible = false;
                DocSpecTb.Visible = false;
            }
        }

        private void UserEditBtn_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            
            string query = "";
            bool flag_to_pass = false;
            if (PasswordTb.Text.Length > 1)
            {
                flag_to_pass = true;
            }
            if (UserTypeCb.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please Select a Type of User first!");
            }
            else if (UserTypeCb.SelectedItem.ToString() == "doctor")
            {
                //IDTb.Text += "D";
                if (flag_to_pass == true)
                {
                    query = "update doctor set doctor_name = @name, doctor_phoneno = @phone, doctor_fees = @fees, doctor_spec = @spec, " +
                                        "doctor_password = @pass where doctor_id = @ID";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                }
                else
                {
                    query = "update doctor set doctor_name = @name, doctor_phoneno = @phone, doctor_fees = @fees, doctor_spec = @spec " +
                        "where doctor_id = @ID ";
                    cmd = new MySqlCommand(query, con);
                }
                con.Open();
                
                cmd.Parameters.AddWithValue("@ID", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phone", Int64.Parse(PhonenoTb.Text.ToString()));
                cmd.Parameters.AddWithValue("@fees", Double.Parse(DocFeesTb.Text.ToString()));
                cmd.Parameters.AddWithValue("@spec", DocSpecTb.Text.ToString());

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Updated Succesfully with Changed Parameters.");
                    populate();
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
                    MessageBox.Show("Updation Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }
            }
            else if (UserTypeCb.SelectedItem.ToString() == "staff")
            {
                //IDTb.Text += "S";
                if (flag_to_pass == true)
                {
                    query = "update staff set staff_name = @name, staff_phoneno = @phoneno, staff_password = @pass where staff_id = @id";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                }
                else
                {
                    query = "update staff set staff_name = @name, staff_phoneno = @phoneno where staff_id = @id";
                    cmd = new MySqlCommand(query, con);
                }

                con.Open();
                
                cmd.Parameters.AddWithValue("@id", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phoneno", Int64.Parse(PhonenoTb.Text.ToString()));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Updated Succesfully with Changed Parameters.");
                    populate();
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
                    MessageBox.Show("Updation Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }
            }
            else if (UserTypeCb.SelectedItem.ToString() == "admin")
            {
                //IDTb.Text += "A";
                if (flag_to_pass == true)
                {
                    query = "update admins set admin_name = @name, admin_phoneno = @phoneno, admin_password = @pass where admin_id = @id";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", ((PasswordTb.Text).GetHashCode()).ToString());
                }
                else
                {
                    query = "update admins set admin_name = @name, admin_phoneno = @phoneno where admin_id = @id";
                    cmd = new MySqlCommand(query, con);
                }

                con.Open();

                cmd.Parameters.AddWithValue("@id", IDTb.Text.ToString());
                cmd.Parameters.AddWithValue("@name", NameTb.Text.ToString());
                cmd.Parameters.AddWithValue("@phoneno", Int64.Parse(PhonenoTb.Text.ToString()));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Updated Succesfully with Changed Parameters.");
                    populate();
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
                    MessageBox.Show("Updation Unsuccessful!! Please fill all fields correctly.");
                    con.Close();
                }

                //this.InitializeComponent();

            }
        }

        private void AdminsTabBtn_Click(object sender, EventArgs e)
        {
            Adminsdgv.Visible = true;
            Doctorsdgv.Visible = false;
            Staffdgv.Visible = false;
            AdminsTabBtn.ForeColor = Color.Black;
            AdminsTabBtn.BackColor = Color.SlateBlue;
            DoctorsTabBtn.ForeColor = Color.MidnightBlue;
            DoctorsTabBtn.BackColor = Color.Aquamarine;
            StaffTabBtn.ForeColor = Color.MidnightBlue;
            StaffTabBtn.BackColor = Color.Aquamarine;
        }

        private void DoctorsTabBtn_Click(object sender, EventArgs e)
        {
            Adminsdgv.Visible = false;
            Doctorsdgv.Visible = true;
            Staffdgv.Visible = false;
            DoctorsTabBtn.ForeColor = Color.Black;
            DoctorsTabBtn.BackColor = Color.Teal;
            StaffTabBtn.ForeColor = Color.MidnightBlue;
            StaffTabBtn.BackColor = Color.Aquamarine;
            AdminsTabBtn.ForeColor = Color.MidnightBlue;
            AdminsTabBtn.BackColor = Color.Aquamarine;
        }

        private void StaffTabBtn_Click(object sender, EventArgs e)
        {
            Adminsdgv.Visible = false;
            Doctorsdgv.Visible = false;
            Staffdgv.Visible = true;
            StaffTabBtn.ForeColor = Color.Black;
            StaffTabBtn.BackColor = Color.Turquoise;
            DoctorsTabBtn.ForeColor = Color.MidnightBlue;
            DoctorsTabBtn.BackColor = Color.Aquamarine;
            AdminsTabBtn.ForeColor = Color.MidnightBlue;
            AdminsTabBtn.BackColor = Color.Aquamarine;
        }
    }
}
