using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class dbSettingsForm : Form
    {
        
        public dbSettingsForm()
        {
            InitializeComponent();
        }

        private void dbSettingsForm_Load(object sender, EventArgs e)
        {
            txtHostname.Text = Properties.Settings.Default.dbHostname;
            txtPort.Text = Properties.Settings.Default.dbPort;
            txtDatabase.Text = Properties.Settings.Default.dbDatabase;
            txtUsername.Text = Properties.Settings.Default.dbUsername;
            txtPassword.Text = Properties.Settings.Default.dbPassword;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string testResult = dbQuery.checkNewDbConnection(txtHostname.Text, txtPort.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            if (testResult != "true")
            {
                MessageBox.Show("Connection could not be established.\nError:\n\n" + testResult, "Admin");
            }
            else
            {
                MessageBox.Show("Connection successful", "Admin");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string test = dbQuery.checkNewDbConnection(txtHostname.Text, txtPort.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            if(test != "true")
            {
                MessageBox.Show("Please make sure that you Check Database Connectivity first and that there are no errors before applying settings", "Admin");
            }
            else
            {
                Properties.Settings.Default.dbHostname = txtHostname.Text;
                Properties.Settings.Default.dbPort = txtPort.Text;
                Properties.Settings.Default.dbDatabase = txtDatabase.Text;
                Properties.Settings.Default.dbUsername = txtUsername.Text;
                Properties.Settings.Default.dbPassword = txtPassword.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Database settings saved, application will now exit.\nPlease start GATE-O again for changes to take effect.","Admin");
                Application.Exit();
            }
        }
    }
}
