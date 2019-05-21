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
    public partial class SearchPatient : Form
    {
        int user;
        public SearchPatient(int userID)
        {
            InitializeComponent();
            user = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtCnp.Text.Count() != 13)
            {
                MessageBox.Show("CNP does not appear to be valid", "Error");
                return;
            }
            if (dbQuery.checkPatient(Convert.ToInt64(txtCnp.Text)))
            {
                ViewPatientDetailsForm view = new ViewPatientDetailsForm(dbQuery.getPatientDetails(Convert.ToInt64(txtCnp.Text)), user);
                this.Close();
                view.ShowDialog();
            }
            else
            {
                MessageBox.Show("Patient does not exist in database", "No result");
            }
        }

        private void txtCnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
