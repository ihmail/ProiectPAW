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
        int docID;
        public ViewPatientDetailsForm(List<string> details) 
        {
            InitializeComponent();
            patientDetail = details;
            btnApply.Visible = false;
            btnNewHosp.Visible = false;


        }

        public ViewPatientDetailsForm(List<string> details, int user_id) 
        {
            InitializeComponent();
            patientDetail = details;
            btnApply.Visible = false;
            btneEdit.Visible = false;
            btnNewHosp.Location = new Point(526, 385);
            btnNewHosp.Visible = true;
            docID = user_id;

        }

        public ViewPatientDetailsForm(string cnp)
        {
            InitializeComponent();
            btneEdit.Visible = false;
            btnApply.Visible = false;
            btnNewHosp.Visible = false;
            txtPName.Enabled = true;
            txtAPP.Enabled = true;
            txtAPF.Enabled = true;
            txtAHC.Enabled = true;
            txtCnp.Text = cnp;

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

        private void btneEdit_Click(object sender, EventArgs e)
        {
            btneEdit.Visible = false;
            btnApply.Location = new Point(526, 385);
            btnApply.Visible = true;
            txtAPP.Enabled = true;
            txtAPF.Enabled = true;
            txtAHC.Enabled = true;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to save the changes made?","Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dbQuery.editPatient(Convert.ToInt64(txtCnp.Text), txtAPP.Text, txtAPF.Text, txtAHC.Text);
                    MessageBox.Show("Changes have been saved", "Success");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Failure");
                }
            }
        }

        private void btnNewHosp_Click(object sender, EventArgs e)
        {
            if (dbQuery.checkHosp(Convert.ToInt64(txtCnp.Text)))
            {
                MessageBox.Show("Patient currently hospitalized\nCannot create new hospitalization","Warning");
                return;
            }
            NewHospForm newHosp = new NewHospForm(patientDetail, docID);
            this.Hide();
            newHosp.ShowDialog();
            this.Show();
        }
    }
}
