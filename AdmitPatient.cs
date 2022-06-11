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
using ZXing;

namespace WindowsFormsApp1
{
    public partial class AdmitPatient : Form
    {
        public AdmitPatient()
        {
            InitializeComponent();
        }
        Dictionary<string, string> docs = new Dictionary<string, string>();
        private void AdmitPatient_Load(object sender, EventArgs e)
        {
            AllotBedCb.Items.Insert(0, "Select a Bed ID ...");
            AllotBedCb.SelectedIndex = 0;
            populateBeds();
            AdmDeptCb.Items.Insert(0, "Select a Dept ...");
            AdmDeptCb.SelectedIndex = 0;
            populatedepts();

            UpdateCnt();

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

        private void populatedepts()
        {
            AdmDeptCb.Items.Clear();
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select doctor_spec from doctor";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string dept = rdr.GetString("doctor_spec");
                    AdmDeptCb.Items.Add(dept);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populateBeds()
        {
            AllotBedCb.Items.Clear();
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select bed_id from beds where bed_status = 0";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string id = rdr.GetString("bed_id");
                    AllotBedCb.Items.Add(id);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void AdmDeptCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AdmDeptCb.Font = new Font(this.Font, FontStyle.Bold);
            DoctorAssCb.Items.Clear();
            docs.Clear();
            DoctorAssCb.ResetText();
            DoctorAssCb.Items.Insert(0, "Assign a Doctor ...");
            DoctorAssCb.SelectedIndex = 0;
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "select doctor_id, doctor_name from doctor where doctor_spec = @dept;";
            MySqlDataReader rdr;
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dept", AdmDeptCb.SelectedItem);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string docName = rdr.GetString("doctor_name");
                    docs.Add(docName, rdr.GetString("doctor_id"));
                    DoctorAssCb.Items.Add(docName);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void AllotBedCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AllotBedCb.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void DoctorAssCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void AdmitBtn_Click(object sender, EventArgs e)
        {
            AddPatient();
            UpdateBed();
            UpdateCnt();
            MessageBox.Show("Patient Admitted Succesfully!");

            /*foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }*/
            AllotBedCb.Items.Insert(0, "Select a Bed ID ...");
            AllotBedCb.SelectedIndex = 0;
            populateBeds();
            AdmDeptCb.Items.Insert(0, "Select a Dept ...");
            AdmDeptCb.SelectedIndex = 0;
            populatedepts();

        }

        private void GenerateCode(string ID)
        {
            string filename = PatNameTb.Text + PatCntTb.Text;

            BarcodeWriter bcw = new BarcodeWriter();
            bcw.Format = BarcodeFormat.QR_CODE;
            //Generate and Save the QRCode
            bcw.Write(ID).Save(@"C:\Users\Anustup\OneDrive\Desktop\" + filename+".png");
            //Fetch the QRCode
            QRcodepic.Image = Image.FromFile(@"C:\Users\Anustup\OneDrive\Desktop\" + filename + ".png");
        }

        private void UpdateBed()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "update beds set bed_status = 1 where bed_id = @id";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", AllotBedCb.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void AddAdmission(string ID)
        {
            //Add patient to admission table
            string id = ID.Substring(5, 5) + "00" + PatCntTb.Text;
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "insert into admission values(@admid, @patid, @bedid, @docid, @admdate, null);";
            try
            {

                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@admid", id);
                cmd.Parameters.AddWithValue("@patid", ID);
                cmd.Parameters.AddWithValue("@bedid", AllotBedCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@docid", docs[DoctorAssCb.SelectedItem.ToString()]);
                cmd.Parameters.AddWithValue("@admdate", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void AddPatient()
        {
            //Add patient to patient table
            string ID = PatNameTb.Text.Substring(0, 3) + PatphnnoTb.Text.Substring(6) + DateTime.Now.ToString();
            string connstr = ConfigurationManager.ConnectionStrings["DBcs"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connstr);
            MySqlCommand cmd;
            string query = "insert into patient values(@id, @name, @addr, @phno);";
            try
            {

                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", PatNameTb.Text);
                cmd.Parameters.AddWithValue("@phno", Int64.Parse(PatphnnoTb.Text));
                cmd.Parameters.AddWithValue("@addr", PatAddTb.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                AddAdmission(ID);
                GenerateCode(ID);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
