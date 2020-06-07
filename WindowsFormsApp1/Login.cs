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
            MultitonLogic instance = new MultitonLogic();
            string tempUser = loginUsername.Text;
            string tempPass = loginPassword.Text;

            var checker = instance.GetUser(tempUser);
            if (checker == true) 
                MessageBox.Show("Dobrodošli!");
            else
                MessageBox.Show("Ne postojite u našoj bazi korisnika");
        }

        private void goBack_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }
} 
