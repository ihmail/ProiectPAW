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
    public partial class ChangeAccountDetails : Form
    {
        User user;
        public ChangeAccountDetails(User passedUser)
        {
            InitializeComponent();
            user = passedUser;
        }

        private void ChangeAccountDetails_Load(object sender, EventArgs e)
        {
            txtUser.Text = user.username;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            ctxtSpec.Text = user.specialization;
            ctxtTitle.Text = user.JobTitle;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == " ")
            {
                MessageBox.Show("Please enter a first name","Warning");
                return;
            }
            if(txtLastName.Text == " ")
            {
                MessageBox.Show("Please enter a last name", "Warning");
                return;
            }
            if(MessageBox.Show("Are you sure you want to apply the following changes:\n\nFirst Name: "+txtFirstName.Text+"\nLast Name: "+txtLastName.Text+"\nSpecialization: "+ctxtSpec.Text+"\nJob Title: "+ctxtTitle.Text, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.specialization = ctxtSpec.Text;
                user.JobTitle = ctxtTitle.Text;
                try
                {
                    dbQuery.editUser(user);
                    MessageBox.Show("Changes saved\nPlease start GATE-O again", "Succes");
                    Application.Exit();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Failure");
                }
            }
        }
    }
}
