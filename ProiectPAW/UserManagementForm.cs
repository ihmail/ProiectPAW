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
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            List<User> users = dbQuery.loadUsers();
            lvUsers.Items.Clear();
            foreach(User user in users)
            {
                var listViewItem = new ListViewItem(user.username);
                listViewItem.SubItems.Add(user.FirstName);
                listViewItem.SubItems.Add(user.LastName);
                listViewItem.SubItems.Add(user.specialization);
                listViewItem.SubItems.Add(user.JobTitle);
                listViewItem.SubItems.Add(user.type);

                listViewItem.Tag = user;
                lvUsers.Items.Add(listViewItem);

            }
        }
    }
}
