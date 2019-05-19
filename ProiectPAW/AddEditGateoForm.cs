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
    public partial class AddEditGateoForm : Form
    {
        Gateo toEdit;
        bool edit = false;
        int gateo_id;
        int hosp_id;
        public AddEditGateoForm(int _gateo_id, int hosp_id)
        {
            InitializeComponent();
            edit = true;
            gateo_id = _gateo_id;
            toEdit = dbQuery.getGateoToEdit(_gateo_id);
            rtxtGandeste.Text = toEdit.gandeste;
            rtxtAnalize.Text = toEdit.analize;
            rtxtTratament.Text = toEdit.tratament;
            rtxtEvolutie.Text = toEdit.evolutie;
            rtxtObservatii.Text = toEdit.observatii;
        }

        public AddEditGateoForm(int hosp_id, string addGateo)
        {
            InitializeComponent();
        }

        private void btnBackEditGateo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplyEditGateo_Click(object sender, EventArgs e)
        {
            if(edit == true)
            {
                if(rtxtGandeste.Text == string.Empty)
                {
                    MessageBox.Show("\"Gandeste\" field cannot be empty","Warnign");
                    return;
                }
                if (rtxtAnalize.Text == string.Empty)
                {
                    MessageBox.Show("\"Analize\" field cannot be empty", "Warnign");
                    return;
                }
                if (rtxtTratament.Text == string.Empty)
                {
                    MessageBox.Show("\"ratament\" field cannot be empty", "Warnign");
                    return;
                }
                if (rtxtEvolutie.Text == string.Empty)
                {
                    MessageBox.Show("\"Evolutie\" field cannot be empty", "Warnign");
                    return;
                }
                if (rtxtObservatii.Text == string.Empty)
                {
                    MessageBox.Show("\"Observatii\" field cannot be empty", "Warnign");
                    return;
                }
                if (MessageBox.Show("Please confirm changes","Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        dbQuery.editGateo(gateo_id, rtxtGandeste.Text, rtxtAnalize.Text, rtxtTratament.Text, rtxtEvolutie.Text, rtxtObservatii.Text);
                        MessageBox.Show("Changes have been saved!","Success");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Changes could not be saved:\n\n"+ex.ToString(), "Failure");
                    }
                }
            }
            else
            {
                //dbquery.addgateo
            }
        }
    }
}
