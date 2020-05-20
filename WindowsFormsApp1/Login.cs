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
            string user = "admin";
            string password = "admin";
            if (loginUsername.Text == user && loginPassword.Text == password)
                MessageBox.Show("DESI DJOLE SEF");
            else
                MessageBox.Show("ZA DOMAAAA");
        }

        private void goBack_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }
} 
