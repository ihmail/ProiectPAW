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
            //if(currentUser.type != "admin")
            //{
            //    tlAdmin.Visible = false;
            //}
            txtHostname.Text = dbQuery.hostname;
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

        //Button for testinjg purposes
        private void test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.test);
        }
    }
}
