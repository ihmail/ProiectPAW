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
        List<User> users = dbQuery.loadUsers();
        
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            displayUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayUsers()
        {
            
            lvUsers.Items.Clear();
            foreach (User user in users)
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

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            lvUsers.Items.Clear();
            foreach (User user in users)
            {
                if (user.username.ToLower().Contains(txtSearchUser.Text.ToLower()))
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


        private void txtSearchUser_Click(object sender, EventArgs e)
        {
            lvUsers.SelectedIndices.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user", "User Management");
                return;
            }
            User toBeDeleted = (User)lvUsers.SelectedItems[0].Tag;
            if(MessageBox.Show("Are you sure you want to delete the  following user:\n\nUsername: "+ toBeDeleted.username+"\nFirst Name :"+toBeDeleted.FirstName+"\nLast Name: "+ toBeDeleted.LastName, "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dbQuery.deleteUser(toBeDeleted);
                txtSearchUser.Text = "";
            }
            users.Remove(toBeDeleted);
            displayUsers();
            lvUsers.SelectedIndices.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user", "User Management");
                return;
            }

            User toBeEdited = (User)lvUsers.SelectedItems[0].Tag;
            EditUser edit = new EditUser(toBeEdited);
            edit.ShowDialog();
            users = dbQuery.loadUsers();
            displayUsers();
        }

        private void btnChgPass_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user", "User Management");
                return;
            }
            User toChangePass = (User)lvUsers.SelectedItems[0].Tag;
            ChangePassword changePass = new ChangePassword(toChangePass);
            changePass.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            users = dbQuery.loadUsers();
            displayUsers();
        }
    }
}
