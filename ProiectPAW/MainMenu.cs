using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class MainMenu : Form
    {
        User currentUser;
        List<string> patientDetail;

        public MainMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
            if (currentUser.type != "admin")
            {
                btnDbSettings.Visible = false;
                btnUserManagement.Visible = false;
                tsAdmin.Visible = false;
            }
            lblPopName.Text = currentUser.FirstName + " " + currentUser.LastName;
            lblPopSpec.Text = currentUser.specialization;
            lblPopTitle.Text = currentUser.JobTitle;
            showMyPatients();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagement = new UserManagementForm();
            userManagement.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDbSettings_Click(object sender, EventArgs e)
        {
            dbSettingsForm dbSettings = new dbSettingsForm();
            dbSettings.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if(currentUser.password == "changeme")
            {
                UserChangePassword firstTime = new UserChangePassword(currentUser, "This is your first time logging in\nPlease change your password", 1);
                firstTime.ShowDialog();
            }
            this.Size = new Size(1206, 712);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ChangeAccountDetails changeDetails = new ChangeAccountDetails(currentUser);
            changeDetails.ShowDialog();
            Update();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            UserChangePassword firstTime = new UserChangePassword(currentUser, "Enter new password below", 0);
            firstTime.ShowDialog();
        }

        private void showMyPatients()
        {
            grPatients.Text = "My Patients";
            List<MyPatientsList> patients = dbQuery.loadMyPatientsView(currentUser.id);
            lvPatients.Items.Clear();
            foreach (MyPatientsList patient in patients)
            {
                var listViewItem = new ListViewItem(patient.name);
                listViewItem.SubItems.Add(patient.hospReason);
                listViewItem.SubItems.Add(patient.hospDate.ToString("dd/MM/yyyy"));
                

                listViewItem.Tag = patient.hosp_id;
                lvPatients.Items.Add(listViewItem);

            }
            SetHeight(lvPatients, 50);
            lblTotalPatients.Text = patients.Count.ToString();
        }

        private void loadGateo()
        {
            if (lvPatients.SelectedItems.Count != 0)
            {
                lvGateo.Items.Clear();
                pnMain.Visible = false;
                pnTest.Visible = true;
                pnTest.Location = new Point(297, 220);
                List<Gateo> gateos = dbQuery.getGateo(Convert.ToInt32(lvPatients.SelectedItems[0].Tag));
                foreach (Gateo gateo in gateos)
                {
                    var listViewItem = new ListViewItem(gateo.gateo_date.ToString("dd/MM/yyyy\nhh:mm"));
                    listViewItem.SubItems.Add(gateo.gandeste);
                    listViewItem.SubItems.Add(gateo.analize);
                    listViewItem.SubItems.Add(gateo.tratament);
                    listViewItem.SubItems.Add(gateo.evolutie);
                    listViewItem.SubItems.Add(gateo.observatii);


                    listViewItem.Tag = gateo.id_gateo;
                    lvGateo.Items.Add(listViewItem);

                }
                SetHeight(lvGateo, 200);
                lblTotalGateo.Text = gateos.Count.ToString();
            }
            else
            {
                MessageBox.Show("Please select a patient first", "Warning");
            }
        }

        private void btnViewGateo_Click(object sender, EventArgs e)
        {

            loadGateo();


        }

        private void btnBackGateo_Click(object sender, EventArgs e)
        {
            pnMain.Visible = true;
            pnTest.Visible = false;
        }

        private void btnEditGateo_Click(object sender, EventArgs e)
        {
            if(lvGateo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a GATE-O entry", "Error");
                return;
            }
            else
            {
                AddEditGateoForm editGateo = new AddEditGateoForm(Convert.ToInt32(lvGateo.SelectedItems[0].Tag), Convert.ToInt32(lvPatients.SelectedItems[0].Tag));
                editGateo.ShowDialog();
                loadGateo();
            }
        }

        private void lvPatients_Click(object sender, EventArgs e)
        {
            btnViewGateo.Enabled = true;
            btnDischarge.Enabled = true;
        }

        private void btnAddGateo_Click(object sender, EventArgs e)
        {
            AddEditGateoForm addGateo = new AddEditGateoForm(Convert.ToInt32(lvPatients.SelectedItems[0].Tag));
            addGateo.ShowDialog();
            loadGateo();
        }

        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnViewPatientDetails.Enabled = true;
                patientDetail = dbQuery.getPatientDetails(Convert.ToInt32(lvPatients.SelectedItems[0].Tag));
                txtCnp.Text = patientDetail[0];
                txtPName.Text = patientDetail[1];
                txtPBirthdate.Text = patientDetail[2];
                txtPGender.Text = patientDetail[3];
                lblPAPP.Text = patientDetail[4];
                lblPAPF.Text = patientDetail[5];
                lblPAHC.Text = patientDetail[6];
        }

        private void btnViewPatientDetails_Click(object sender, EventArgs e)
        {
            ViewPatientDetailsForm viewDetails = new ViewPatientDetailsForm(patientDetail);
            viewDetails.ShowDialog();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            var selected = lvPatients.SelectedItems[0];
            DischargePatientForm discharge = new DischargePatientForm(patientDetail, Convert.ToInt32(lvPatients.SelectedItems[0].Tag), selected.SubItems[2].Text, selected.SubItems[1].Text);
            discharge.ShowDialog();
            showMyPatients();
            lblPAHC.Text = lblPAPF.Text = lblPAPP.Text = txtCnp.Text = txtPBirthdate.Text = txtPGender.Text = txtPName.Text = String.Empty;
            btnDischarge.Enabled = false;
            btnViewGateo.Enabled = false;
            btnViewPatientDetails.Enabled = false;
        }
    }
}
