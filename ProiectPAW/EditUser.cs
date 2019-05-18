using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProiectPAW
{
    public partial class EditUser : Form
    {
        User user;
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        public EditUser(User userToEdit)
        {
            InitializeComponent();
            user = userToEdit;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            txtUser.Text = user.username;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            ctxtSpec.Text = user.specialization;
            ctxtTitle.Text = user.JobTitle;
            ctxtType.Text = user.type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a first name", "Warning");
                return;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a last name", "Warning");
                return;
            }
            if (MessageBox.Show("Are you sure you want to save your changes?","Edit user") == DialogResult.OK)
            {
                user.FirstName = ti.ToTitleCase(txtFirstName.Text.ToLower());
                user.LastName = ti.ToTitleCase(txtLastName.Text.ToLower());
                user.specialization = ctxtSpec.Text;
                user.JobTitle = ctxtTitle.Text;
                user.type = ctxtType.Text;
                try
                {
                    dbQuery.editUser(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
