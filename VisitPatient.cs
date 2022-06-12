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
    public partial class VisitPatient : Form
    {
        public VisitPatient()
        {
            InitializeComponent();
        }
        public string Doc
        {
            set
            {
                this.DocIDTb.Text = value;
            }
        }
        string VisitID = "";
        Dictionary<string, string> pats = new Dictionary<string, string>();
        Dictionary<string, string> meds = new Dictionary<string, string>();
        Dictionary<string, string> tests = new Dictionary<string, string>();
        private void VisitPatient_Load(object sender, EventArgs e)
        {
            

            PatNamCb.Items.Insert(0, "Select a Patient ...");
            PatNamCb.SelectedIndex = 0;
            populatePatients();
/*
            MedNameCb.Items.Insert(0, "Select a Medicine ...");
            MedNameCb.SelectedIndex = 0;
            populateMeds();*/


        }

        private void populateMeds()
        {
            meds.Clear();
            MedNameCb.Items.Clear();

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select medicine_id, medicine_name from medicines;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString("medicine_name");
                    meds.Add(name, rdr.GetString("medicine_id"));
                    MedNameCb.Items.Add(name);
                }
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
            if(PatNamCb.SelectedItem.ToString() != "Select a Patient ...")
            {
                PatIDTb.Text = pats[PatNamCb.SelectedItem.ToString()];
            }
                
        }

        private void PreMedsBtn_Click(object sender, EventArgs e)
        {
            string ID = meds[MedNameCb.SelectedItem.ToString()].Substring(0, 8) + PatIDTb.Text.Substring(0, 9) + DateTime.Now.Date.ToString();
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "insert into medicines_prescribed values(@id, @date, @visitid, @medid, @perday, @forday);";
            try
            {

                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@visitid", VisitID);
                cmd.Parameters.AddWithValue("@medid", meds[MedNameCb.SelectedItem.ToString()]);
                cmd.Parameters.AddWithValue("@perday", int.Parse(DoseperdayTb.Text));
                cmd.Parameters.AddWithValue("@forday", Int64.Parse(ForDaysTb.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Prescribed to" + PatNamCb.SelectedItem.ToString());
                populateMeds();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void VisitBtn_Click(object sender, EventArgs e)
        {
            VisitID = DocIDTb.Text.Substring(4, 6) + PatIDTb.Text.Substring(0, 9) + "vs" + DateTime.Now.Date.ToString();

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "insert into doctor_visits values(@id, @date, @docid, @patid, @comments);";
            try
            {

                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", VisitID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@docid", DocIDTb.Text);
                cmd.Parameters.AddWithValue("@patid", PatIDTb.Text);
                cmd.Parameters.AddWithValue("@comments", DocCommTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Visit Entry Created!");
                con.Close();

                PresMedsPanel.Visible = true;
                MedNameCb.Items.Insert(0, "Select a Medicine ...");
                MedNameCb.SelectedIndex = 0;
                populateMeds();

                PresTestspanel.Visible = true;
                TestNameCb.Items.Insert(0, "Select a Diagnostic ...");
                TestNameCb.SelectedIndex = 0;
                populateTests();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populateTests()
        {
            tests.Clear();
            TestNameCb.Items.Clear();

            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select test_id, test_name from diagnostics;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString("test_name");
                    tests.Add(name, rdr.GetString("test_id"));
                    TestNameCb.Items.Add(name);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = tests[TestNameCb.SelectedItem.ToString()].Substring(0, 8) + PatIDTb.Text.Substring(0, 9) + DateTime.Now.Date.ToString();
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "insert into tests_prescribed values(@id, @date, @visitid, @testid, null);";
            try
            {

                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@visitid", VisitID);
                cmd.Parameters.AddWithValue("@testid", tests[TestNameCb.SelectedItem.ToString()]);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Test Prescribed to" + PatNamCb.SelectedItem.ToString());
                populateMeds();
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
