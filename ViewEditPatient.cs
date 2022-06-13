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
    public partial class ViewEditPatient : Form
    {
        public ViewEditPatient()
        {
            InitializeComponent();
        }

        Dictionary<string, string> pats = new Dictionary<string, string>();
        Dictionary<string, string> meds = new Dictionary<string, string>();
        Dictionary<string, string> tests = new Dictionary<string, string>();

        private void ViewEditPatient_Load(object sender, EventArgs e)
        {
            PatNamCb.Items.Insert(0, "Select a Patient ...");
            PatNamCb.SelectedIndex = 0;
            populatePatients();

            
            UpdateCnt();
        }

        private void populateTests()
        {

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select testprescription_id, test_name, prescription_date, test_comments  from tests_prescribed T left join diagnostics tt on T.test_id = tt.test_id left join" + 
" doctor_visits D on D.visit_id = T.visit_id where patient_id = @id; ";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                adapt1.Fill(dt1);
                dt1.Columns["testprescription_id"].ColumnName = "ID";
                dt1.Columns["test_name"].ColumnName = "Test Name";

                dt1.Columns["test_comments"].ColumnName = "Test Report";
                dt1.Columns["prescription_date"].ColumnName = "Date Prescribed";
                Testsdgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populateMeds()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select M.medicine_id, medicine_name, medicines_perday, medicine_fordays, prescription__date from medicines_prescribed M left join medicines mm on M.medicine_id = mm.medicine_id left join"+
" doctor_visits D on M.visit_id = D.visit_id where patient_id = @id; ";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                MySqlDataAdapter adapt1 = new MySqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                adapt1.Fill(dt1);
                dt1.Columns["medicine_id"].ColumnName =  "ID";
                dt1.Columns["medicine_name"].ColumnName = "Medicine Name";
                
                dt1.Columns["medicines_perday"].ColumnName = "Dosage/day";
                dt1.Columns["medicine_fordays"].ColumnName = "For Days";
                dt1.Columns["prescription__date"].ColumnName = "Date Prescribed";
                Medicinesdgv.DataSource = dt1;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void UpdateCnt()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select count(*) from patient;";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                object x = cmd.ExecuteScalar();
                PatCntTb.Text = x.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void populatePatients()
        {
            pats.Clear();
            PatNamCb.Items.Clear();

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select patient_id, patient_name from patient;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString("patient_name");
                    pats.Add(name, rdr.GetString("patient_id"));
                    PatNamCb.Items.Add(name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void PatNamCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatNamCb.SelectedItem.ToString() != "Select a Patient ...")
            {
                PatIDTb.Text = pats[PatNamCb.SelectedItem.ToString()];
                populateMeds();

                populateTests();
            }

        }

        private void Testsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Testsdgv.Rows[e.RowIndex];
            row.Cells[3].Value = TestReportTb.Text;
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "update tests_prescribed set test_comments = @comments where testprescription_id = @id";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@comments", TestReportTb.Text);
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Test Report Added!");
                TestReportTb.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
