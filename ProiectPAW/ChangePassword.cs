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
    public partial class ChangePassword : Form
    {
        User user;
        public ChangePassword(User passedUser)
        {
            InitializeComponent();
            user = passedUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user.username;
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match", "Warning");
                txtPass.Text = "";
                txtConfirm.Text = "";
            }
            else if (txtPass.Text == txtConfirm.Text && txtPass.Text != "")
            {
                dbQuery.changePass(user, txtPass.Text);
                MessageBox.Show("Password changed", "User Management");
                this.Close();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
