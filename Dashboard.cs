using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public string LoggedInAsLabel
        {
            set
            {
                this.LoggedInAs.Text = value;
            }
        }

        public string UserID
        {
            set
            {
                this.UserIDHidden.Text = value;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void UserBtn_MouseHover(object sender, EventArgs e)
        {
            UserBtn.BackColor = Color.LightSeaGreen;
        }

        private void UserBtn_MouseLeave(object sender, EventArgs e)
        {
            UserBtn.BackColor = Color.MistyRose;
        }
        private void PatientBtn_MouseHover(object sender, EventArgs e)
        {
            PatientBtn.BackColor = Color.LightSeaGreen;
        }

        private void PatientBtn_MouseLeave(object sender, EventArgs e)
        {
            PatientBtn.BackColor = Color.YellowGreen;
        }
        private void MedicineBtn_MouseHover(object sender, EventArgs e)
        {
            MedicineBtn.BackColor = Color.LightSeaGreen;
        }

        private void MedicineBtn_MouseLeave(object sender, EventArgs e)
        {
            MedicineBtn.BackColor = Color.LightGray;
        }
        private void DiagnosticsBtn_MouseHover(object sender, EventArgs e)
        {
            DiagnosticBtn.BackColor = Color.LightSeaGreen;
        }

        private void DiagnosticsBtn_MouseLeave(object sender, EventArgs e)
        {
            DiagnosticBtn.BackColor = Color.Tan;
        }
        private void BedBtn_MouseHover(object sender, EventArgs e)
        {
            BedBtn.BackColor = Color.LightSeaGreen;
        }

        private void BedBtn_MouseLeave(object sender, EventArgs e)
        {
            BedBtn.BackColor = Color.Khaki;
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            PatientredgBtn.Visible = true;
            DischargePatientBtn.Visible = true;
            ViewEditPatientBtn.Visible = true;
            PatientVisitBtn.Visible = true;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void BedBtn_Click(object sender, EventArgs e)
        {
            AddBedBtn.Visible = true;
            ViewEditBedBtn.Visible = true;
            ManageBedCatBtn.Visible = true;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;

        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            AddUserBtn.Visible = true;
            ViewEditUserBtn.Visible = true;
            RemoveUserBtn.Visible = true;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void MedicineBtn_Click(object sender, EventArgs e)
        {
            AddMedicineBtn.Visible = true;
            ViewEditStockBtn.Visible = true;
            RemoveMedBtn.Visible = true;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void DiagnosticBtn_Click(object sender, EventArgs e)
        {
            AddTestBtn.Visible = true;
            ViewEditTestBtn.Visible = true;
            RemoveTestBtn.Visible = true;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void BackToLogInlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void ViewEditUserBtn_Click(object sender, EventArgs e)
        {
            ViewEditUser viewEditUser = new ViewEditUser();
            viewEditUser.Show();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUser ru = new RemoveUser();
            ru.Show();
        }

        private void AddTestBtn_Click(object sender, EventArgs e)
        {
            AddTest addtest = new AddTest();
            addtest.Show();
        }

        private void ViewEditTestBtn_Click(object sender, EventArgs e)
        {
            ViewEditTest viewEditTest = new ViewEditTest();
            viewEditTest.Show();
        }

        private void RemoveTestBtn_Click(object sender, EventArgs e)
        {
            RemoveTest removeTest = new RemoveTest();
            removeTest.Show();
        }

        private void AddMedicineBtn_Click(object sender, EventArgs e)
        {
            AddMeds addMedicine = new AddMeds();
            addMedicine.Show();
        }

        private void ViewEditStockBtn_Click(object sender, EventArgs e)
        {
            ViewEditMeds viewEditMeds = new ViewEditMeds();
            viewEditMeds.Show();
        }

        private void RemoveMedBtn_Click(object sender, EventArgs e)
        {
            RemoveMeds removeMeds = new RemoveMeds();
            removeMeds.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddUserBtn.Visible = true;
            ViewEditUserBtn.Visible = true;
            RemoveUserBtn.Visible = true;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddBedBtn.Visible = true;
            ViewEditBedBtn.Visible = true;
            ManageBedCatBtn.Visible = true;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PatientredgBtn.Visible = true;
            DischargePatientBtn.Visible = true;
            ViewEditPatientBtn.Visible = true;
            PatientVisitBtn.Visible = true;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddTestBtn.Visible = true;
            ViewEditTestBtn.Visible = true;
            RemoveTestBtn.Visible = true;
            AddMedicineBtn.Visible = false;
            ViewEditStockBtn.Visible = false;
            RemoveMedBtn.Visible = false;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AddMedicineBtn.Visible = true;
            ViewEditStockBtn.Visible = true;
            RemoveMedBtn.Visible = true;
            AddUserBtn.Visible = false;
            ViewEditUserBtn.Visible = false;
            RemoveUserBtn.Visible = false;
            AddBedBtn.Visible = false;
            ViewEditBedBtn.Visible = false;
            ManageBedCatBtn.Visible = false;
            PatientredgBtn.Visible = false;
            DischargePatientBtn.Visible = false;
            ViewEditPatientBtn.Visible = false;
            PatientVisitBtn.Visible = false;
            AddTestBtn.Visible = false;
            ViewEditTestBtn.Visible = false;
            RemoveTestBtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void AddBedBtn_Click(object sender, EventArgs e)
        {
            AddBedCats addBedCats = new AddBedCats();
            addBedCats.Show();
        }

        private void ViewEditBedBtn_Click(object sender, EventArgs e)
        {
            ViewBedS viewBedStatus = new ViewBedS();
            viewBedStatus.Show();
        }

        private void ManageBedCatBtn_Click(object sender, EventArgs e)
        {
            UpdateCategories updateCats = new UpdateCategories();
            updateCats.Show();
        }

        private void PatientredgBtn_Click(object sender, EventArgs e)
        {
            AdmitPatient admit = new AdmitPatient();
            admit.Show();
        }

        private void PatientVisitBtn_Click(object sender, EventArgs e)
        {
            VisitPatient visitPat = new VisitPatient();
            visitPat.Doc = UserIDHidden.Text;
            visitPat.Show();
        }
    }
}
