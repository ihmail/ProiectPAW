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
    public partial class ViewPatientDetailsForm : Form
    {
        List<string> patientDetail;
        public ViewPatientDetailsForm(List<string> details)
        {
            InitializeComponent();
            patientDetail = details;
        }

        private void ViewPatientDetailsForm_Load(object sender, EventArgs e)
        {
            txtCnp.Text = patientDetail[0];
            txtPName.Text = patientDetail[1];
            txtPBirthdate.Text = patientDetail[2];
            txtPGender.Text = patientDetail[3];
            txtAPP.Text = patientDetail[4];
            txtAPF.Text = patientDetail[5];
            txtAHC.Text = patientDetail[6];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
