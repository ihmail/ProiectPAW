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
    public partial class AddSearchPatient : Form
    {
        int user;
        public AddSearchPatient()
        {
            InitializeComponent();
            btnSearch.Visible = false;
            btnAdd.Location = new Point(41, 74);

        }

        public AddSearchPatient(int userID)
        {
            InitializeComponent();
            btnAdd.Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCnp.Text.Count() != 13)
            {
                MessageBox.Show("CNP does not appear to be valid", "Error");
                return;
            }
            if (dbQuery.checkPatient(Convert.ToInt64(txtCnp.Text)))
            {
                MessageBox.Show("Patient already in database", "Error");
                return;
            }
            this.Close();
            AddPatientForm add = new AddPatientForm(txtCnp.Text);
            add.ShowDialog();
        }
    }
}
