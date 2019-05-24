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
    public partial class NewHospForm : Form
    {
        List<string> patientDetail;
        int doctorID;
        public NewHospForm(List<string> details, int docID)
        {
            InitializeComponent();
            patientDetail = details;
            doctorID = docID;
        }

        private void NewHospForm_Load(object sender, EventArgs e)
        {
            txtCnp.Text = patientDetail[0];
            txtPName.Text = patientDetail[1];
            txtPBirthdate.Text = patientDetail[2];
            txtPGender.Text = patientDetail[3];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtReason.Text == String.Empty)
            {
                MessageBox.Show("Please enter a hospitalization reason","Warning");
                return;
            }
            try
            {
                dbQuery.newHosp(Convert.ToInt64(txtCnp.Text), doctorID ,txtReason.Text);
                MessageBox.Show("New hospitalization added", "Success");
                MainMenu.addedPatient = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:\n\n"+ex.ToString(), "Failure");
            }
        }

        private void NewHospForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(51, 107, 135), 4), this.DisplayRectangle);
        }
    }
}
