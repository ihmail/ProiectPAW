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
    public partial class ViewPatientHistoryForm : Form
    {
        List<string> patientDetail;
        public ViewPatientHistoryForm(List<string> details)
        {
            InitializeComponent();
            MainMenu.SetHeight(lvHosps, 100);
            patientDetail = details;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewPatientHistoryForm_Load(object sender, EventArgs e)
        {
            txtCnp.Text = patientDetail[0];
            txtPName.Text = patientDetail[1];
            txtPBirthdate.Text = patientDetail[2];
            txtPGender.Text = patientDetail[3];
            txtAPP.Text = patientDetail[4];
            txtAPF.Text = patientDetail[5];
            txtAHC.Text = patientDetail[6];
            List<Hospitalization> history = new List<Hospitalization>();
            try
            {
                history = dbQuery.getHosps(Convert.ToInt64(txtCnp.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not load patient history\nError:\n\n"+ex.ToString(), "Failure");
                this.Close();
            }

            foreach (Hospitalization hosp in history)
            {
                var listViewItem = new ListViewItem(hosp.admissionDate);
                listViewItem.SubItems.Add(hosp.reason);
                listViewItem.SubItems.Add(hosp.diagnosis);
                listViewItem.SubItems.Add(hosp.dischargeDate);
                listViewItem.SubItems.Add(hosp.status);


                listViewItem.Tag = hosp;
                lvHosps.Items.Add(listViewItem);

            }

        }

        private void btnViewGateo_Click(object sender, EventArgs e)
        {
            if (lvHosps.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a hospitalization first", "Warning");
                return;
            }
            var selectedHosp = (Hospitalization)lvHosps.SelectedItems[0].Tag;
            ViewHistoryGateoForm gateoHistory = new ViewHistoryGateoForm(selectedHosp.id_hosp);
            gateoHistory.ShowDialog();
        }
    }
}
