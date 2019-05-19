using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProiectPAW
{
    public partial class Login : Form
    {
        public string username { get; set; }
        public Login()
        {
            InitializeComponent();
            btnLogin.Select();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectionStart = 0;
            if(txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string testResult = dbQuery.checkDb();

            if (testResult != "true")
            {
                MessageBox.Show("Connection to database failed with the following error:\n\n" + testResult + "\n\nContact your administrator if problems persist.", "Connection failure");
            }
            else
            {
                if (dbQuery.Login(txtUser.Text, txtPass.Text))
                {
                    username = txtUser.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username and/or password invalid.", "Check credentials!");
                }
            }
        }

        private void btnReqAccess_MouseEnter(object sender, EventArgs e)
        {
            btnReqAccess.ForeColor = Color.FromArgb(51, 107, 135);
            btnReqAccess.Font = new Font(btnReqAccess.Font, FontStyle.Underline);
        }

        private void btnReqAccess_MouseLeave(object sender, EventArgs e)
        {
            btnReqAccess.ForeColor = Color.Silver;
            btnReqAccess.Font = new Font(btnReqAccess.Font, FontStyle.Regular);
        }

        private void btnForgotPass_MouseEnter(object sender, EventArgs e)
        {
            btnForgotPass.ForeColor = Color.FromArgb(51, 107, 135);
            btnForgotPass.Font = new Font(btnForgotPass.Font, FontStyle.Underline); 
        }

        private void btnForgotPass_MouseLeave(object sender, EventArgs e)
        {
            btnForgotPass.ForeColor = Color.Silver;
            btnForgotPass.Font = new Font(btnForgotPass.Font, FontStyle.Regular);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

    }
}
