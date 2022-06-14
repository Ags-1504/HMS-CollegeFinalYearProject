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
    public partial class DischargePatient : Form
    {
        public DischargePatient()
        {
            InitializeComponent();
        }

        Dictionary<string, string> pats = new Dictionary<string, string>();
        DateTime dischargeDate = DateTime.Now;
        DateTime admitDate;

        private void DischargePatient_Load(object sender, EventArgs e)
        {
            PatNamCb.Items.Insert(0, "Select a Patient ...");
            PatNamCb.SelectedIndex = 0;
            populatePatients();
            

        }

        private void findAdmitDate()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select admission_date from admission where patient_id = @id;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    admitDate = rdr.GetDateTime("admission_date");
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
            string query = "select patient_id, patient_name from patient where admitted = 1;";
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
                findAdmitDate();

            }
        }

        private void DischargeBtn_Click(object sender, EventArgs e)
        {

            int daysInHMS = (dischargeDate.Date - admitDate.Date).Days +1;
            double MedsPrice = CalculateMedsAmount();
            double TestsPrice = CalculateTestsAmount();
            double docfees = CalculateDocFees();
            double BedFees = daysInHMS*CalculateBedFees();
            Billdgv.Rows.Add(docfees, BedFees, MedsPrice, TestsPrice, docfees + BedFees + MedsPrice + TestsPrice);
            /*row.Cells[0].Value = docfees;
            row.Cells[1].Value = BedFees;
            row.Cells[2].Value = MedsPrice;
            row.Cells[3].Value = TestsPrice;
            row.Cells[4].Value = docfees + BedFees+ MedsPrice+ TestsPrice;*/

            //Unreserve the Bed alloted to this patient earlier
            UnreserveBed();
            DeletePatient();
        }

        private void DeletePatient()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd, cmd2;
            string query = "update patient set admitted = 0 where patient_id = @id";
            string query2 = "update admission set discharge_date = @discharge where patient_id = @id";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd2 = new MySqlCommand(query2, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);

                cmd2.Parameters.AddWithValue("@id", PatIDTb.Text);
                cmd2.Parameters.AddWithValue("@discharge", dischargeDate);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Patient Released Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void UnreserveBed()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "update beds set bed_status = 0 where bed_id in (select bed_id from admission where patient_id = @id);";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bed Unreserved Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private double CalculateBedFees()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            double bed_price = 0.0;
            string query = "select category_priceperday from bed_category BC left join beds B on BC.category_id = B.bed_category_id left join admission A on A.bed_id = B.bed_id where A.patient_id = @id;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bed_price = rdr.GetDouble("category_priceperday");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            return bed_price;
        }

        private double CalculateDocFees()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            double doc_fees = 0.0;
            string query = "select doctor_fees from doctor D left join doctor_visits DV on D.doctor_id = DV.doctor_id where DV.patient_id = @id;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    doc_fees += (double)rdr.GetDecimal("doctor_fees");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            return doc_fees;

        }

        private double CalculateTestsAmount()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            double tests_charges = 0.0;
            string query = "select test_price from diagnostics D left join tests_prescribed TD on D.test_id = TD.test_id left join doctor_visits DV on TD.visit_id = DV.visit_id where DV.patient_id = @id;";

            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tests_charges += (double)rdr.GetDecimal("test_price");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            return tests_charges;

        }

        private double CalculateMedsAmount()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            double meds_charges = 0.0;
            string query = "select M.medicine_pricepertab*MP.medicines_perday*MP.medicine_fordays Price from medicines M left join medicines_prescribed MP on M.medicine_id = MP.medicine_id left join doctor_visits DV on MP.visit_id = DV.visit_id where DV.patient_id = @id;";

            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", PatIDTb.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    meds_charges += (double)rdr.GetDecimal("Price");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            return meds_charges;


        }
    }
}
