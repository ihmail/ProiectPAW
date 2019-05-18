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
using System.Threading;

namespace ProiectPAW
{
    public partial class AddUser : Form
    {
        private bool check = false;
        private bool available = false;
        private TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                MessageBox.Show("Please enter a username", "Warning");
                return;
            }

            if(txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a first name", "Warning");
                return;
            }

            if(txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a last name", "Warning");
                return;
            }

            if(ctxtSpec.Text == "")
            {
                MessageBox.Show("Please enter a specialization", "Warning");
                return;
            }

            if(ctxtTitle.Text == "")
            {
                MessageBox.Show("Please select a job title", "Warning");
                return;
            }

            if(ctxtType.Text == "")
            {
                MessageBox.Show("Please select a user type", "Warning");
                return;
            }

            if (check == true)
            {
                if(available == true)
                {
                    //this is where the magic has to happen
                    dbQuery.addUser(txtUser.Text.ToLower(), ti.ToTitleCase(txtFirstName.Text.ToLower()), ti.ToTitleCase(txtLastName.Text.ToLower()), ctxtSpec.Text, ctxtTitle.Text, ctxtType.Text);
                    MessageBox.Show("The following user has been added:\n\nUsername: "+txtUser.Text.ToLower()+"\nFirst Name: "+ ti.ToTitleCase(txtFirstName.Text.ToLower()) + "\nLast Name: " + ti.ToTitleCase(txtLastName.Text.ToLower()) + "\nSpecialization: "+ ctxtSpec.Text + "\nJob title: "+ ctxtTitle.Text +"\nUser Type: "+ ctxtType.Text, "Add user\n\nDefault password is changeme - please advise user to change!");
                }
                else
                {
                    MessageBox.Show("Username not available\nPlease choose a different username", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Please click Check availability first", "Warning");
            }
            
        }

        private void btnCheckAval_Click(object sender, EventArgs e)
        {
            check = true;
            if (dbQuery.checkDupe(txtUser.Text))
            {
                MessageBox.Show("Username not available", "Error");
            }
            else
            {
                available = true;
                MessageBox.Show("Username is available", "Availability check");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            check = false;
            available = false;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
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
