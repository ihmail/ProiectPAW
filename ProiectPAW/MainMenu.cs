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
    }
}
