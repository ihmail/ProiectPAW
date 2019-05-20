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
    public partial class DischargePatientForm : Form
    {
        List<string> patientDetail;
        int hosp_id;
        string h_date;
        string hosp_reason;
        public DischargePatientForm(List<string> details, int _hosp_id, string hosp_date, string _hosp_reason)
        {
            InitializeComponent();
            patientDetail = details;
            hosp_id = _hosp_id;
            h_date = hosp_date;
            hosp_reason = _hosp_reason;
        }

        private void DischargePatientForm_Load(object sender, EventArgs e)
        {
            txtCnp.Text = patientDetail[0];
            txtPName.Text = patientDetail[1];
            txtPBirthdate.Text = patientDetail[2];
            txtPGender.Text = patientDetail[3];
            txtHospDate.Text = h_date;
            txtHospReason.Text = hosp_reason;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if(txtDischarge.Text == String.Empty)
            {
                MessageBox.Show("Please enter a discharge note", "Warning");
                return;
            }
            else
            {
                try
                {
                    dbQuery.dischargePatient(hosp_id, txtDischarge.Text);
                    MessageBox.Show("Patient has been discharged", "Success");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Failure");
                }
            }
        }
    }
}
