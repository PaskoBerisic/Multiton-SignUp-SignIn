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
            MultitonLogic multiton = MultitonLogic.GetInstance(tempUser);

            if (MultitonLogic.Exists(tempUser) == true)
                MessageBox.Show("Korisničko ime zauzeto!");
            else
            {
                MultitonLogic.GetInstance(tempUser);
                MessageBox.Show("Uspješno ste se registrirali.");
            }
        }
    }
}
