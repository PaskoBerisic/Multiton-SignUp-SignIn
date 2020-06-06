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
    
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            string tempUser = registerUsername.Text;
            string tempPass = registerPassword.Text;


            User checker = MultitonLogic.Instance.GetUser(tempUser);

            if (registerUsername.Text == checker.ToString())
                MessageBox.Show("Korisničko ime zauzeto!");
            else
                MultitonLogic.Instance.AddUser(tempUser, tempPass);
                MessageBox.Show("Uspješno ste se registrirali.");

            // if answer no, korisnik postoji
            // else mozes se registrirati


        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
