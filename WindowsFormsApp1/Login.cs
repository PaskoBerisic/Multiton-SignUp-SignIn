using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            string tempUser = loginUsername.Text;
            string tempPass = loginPassword.Text;

            if (MultitonLogic.Exists(tempUser) == true)
                MessageBox.Show("Dobrodošli, " + tempUser + " !");
            else
                MessageBox.Show("Ne postojite u našoj bazi korisnika");

        }

    }
}

