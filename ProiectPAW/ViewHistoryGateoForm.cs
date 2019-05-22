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
    public partial class ViewHistoryGateoForm : Form
    {
        int id;
        public ViewHistoryGateoForm(int hosp_id)
        {
            InitializeComponent();
            id = hosp_id;
        }

        private void ViewHistoryGateoForm_Load(object sender, EventArgs e)
        {
            List<Gateo> gateos = new List<Gateo>();
            try
            {
                gateos = dbQuery.getGateo(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not load data\nError:\n\n"+ex.ToString(), "Failure");
                this.Close();
            }
           
            foreach (Gateo gateo in gateos)
            {
                var listViewItem = new ListViewItem(gateo.gateo_date.ToString("dd/MM/yyyy\nhh:mm"));
                listViewItem.SubItems.Add(gateo.gandeste);
                listViewItem.SubItems.Add(gateo.analize);
                listViewItem.SubItems.Add(gateo.tratament);
                listViewItem.SubItems.Add(gateo.evolutie);
                listViewItem.SubItems.Add(gateo.observatii);


                listViewItem.Tag = gateo.id_gateo;
                lvGateo.Items.Add(listViewItem);

            }
            MainMenu.SetHeight(lvGateo, 200);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
