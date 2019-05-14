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
    public partial class EditUser : Form
    {
        User user;
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
            txtSpec.Text = user.specialization;
            txtTitle.Text = user.JobTitle;
            ctxtType.Text = user.type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to save your changes?","Edit user") == DialogResult.OK)
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.specialization = txtSpec.Text;
                user.JobTitle = txtTitle.Text;
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
    }
}
