using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class MainMenu : Form
    {
        User currentUser;
        public MainMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
            if(currentUser.type != "admin")
            {
                tlAdmin.Visible = false;
            }
        }
    }
}
