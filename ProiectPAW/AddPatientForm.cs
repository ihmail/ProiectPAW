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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm(string cnp)
        {
            InitializeComponent();
            txtCnp.Text = cnp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == String.Empty)
            {
                MessageBox.Show("First name cannot be empty", "Warning");
                return;
            }

            if (txtLastName.Text == String.Empty)
            {
                MessageBox.Show("Last name cannot be empty", "Warning");
                return;
            }

            if (ctxtSex.Text == String.Empty)
            {
                MessageBox.Show("Please select a gender", "Warning");
                return;
            }

            if (dtpBirth.Text == String.Empty)
            {
                MessageBox.Show("Please enter birth date", "Warning");
                return;
            }
            if(MessageBox.Show("Are you sure all information is correct?","Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dbQuery.addPatient(Convert.ToInt64(txtCnp.Text), txtFirstName.Text, txtLastName.Text, dtpBirth.Value.ToString("yyyy-MM-dd"), ctxtSex.Text, txtAPP.Text, txtAPF.Text, txtAHC.Text);
                    MessageBox.Show("Patient succesfully added to the dataabse", "Success");
                    if(MessageBox.Show("Would you like to hospitalize patient now?","New hospitalization", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //var newHosp = new NewHospForm(MainMenu.currentUser.id);   <-- need to fix this in order to get a new hospitalization
                    }
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Patient could not be added\nError:\n\n"+ex.ToString(), "Failure");
                }
            }
        }
    }
}
