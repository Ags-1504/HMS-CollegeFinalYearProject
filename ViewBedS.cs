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
    public partial class ViewBedS : Form
    {
        public ViewBedS()
        {
            InitializeComponent();
        }

        private void ViewBedS_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateCatBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in Bedsdgv.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == true && item.Cells[0].ReadOnly == false)
                {
                    string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(connstr);
                    MySqlCommand cmd1, cmd2;

                    string query = "update beds set bed_status = @status where bed_id = @ID";
                    cmd1 = new MySqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@status", true);
                    cmd1.Parameters.AddWithValue("@ID", item.Cells[1].Value.ToString());
                    string innerquery = "update bed_category set beds_left = beds_left-1 where category_id = @id";
                    cmd2 = new MySqlCommand(innerquery, con);
                    cmd2.Parameters.AddWithValue("@id", item.Cells[2].Value.ToString());
                    try
                    {
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        
                        con.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                
            }
            MessageBox.Show("Beds Reserved. Beds Available Decreased");
        }

        private void populate()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);

            string query1 = "Select * from beds;";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            con.Open();
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            con.Close();
            foreach(DataRow dr in dt1.Rows)
            {
                int n = Bedsdgv.Rows.Add();
                if(Convert.ToBoolean(dr["bed_status"]) == true)
                {
                    Bedsdgv.Rows[n].Cells[0].ReadOnly = true;
                }
                Bedsdgv.Rows[n].Cells[0].Value = dr["bed_status"];
                Bedsdgv.Rows[n].Cells[1].Value = dr["bed_id"].ToString();
                Bedsdgv.Rows[n].Cells[2].Value = dr["bed_category_id"].ToString();
            }
        }
    }
}
