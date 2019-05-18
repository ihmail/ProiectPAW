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
    public partial class FirstTimeLogin : Form
    {
        User user;
        string password;
        public FirstTimeLogin(User newLogin)
        {
            InitializeComponent();
            user = newLogin;
        }

        private void FirstTimeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnListPatients_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Count() < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                dbQuery.changePass(user, txtPass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n" + ex.ToString(), "Error");
                this.Close();
            }
            MessageBox.Show("Password successfully changed", "Success");
            this.Close();

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void FirstTimeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }
    }
}
