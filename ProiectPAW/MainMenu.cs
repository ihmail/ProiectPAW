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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsAdminDatabase_Click(object sender, EventArgs e)
        {
            dbSettingsForm dbSettings = new dbSettingsForm();
            dbSettings.ShowDialog();
        }

        //Button for testing purposes
        private void test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grMenu.Text = "Merge!";
            //grMenu.Update();
            dbSettingsForm dbSettings = new dbSettingsForm();
            dbSettings.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
