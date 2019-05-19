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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnMain.Visible = false;
            pnTest.Visible = true;
            grGateo.Text = "GATE-O";
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
        }

        private void btnViewGateo_Click(object sender, EventArgs e)
        {
            
            if(lvPatients.SelectedItems.Count != 0)
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
            }
            else
            {
                MessageBox.Show("Please select a patient first", "Warning");
            }
           
        }

        private void btnBackGateo_Click(object sender, EventArgs e)
        {
            pnMain.Visible = true;
            pnTest.Visible = false;
        }
    }
}
