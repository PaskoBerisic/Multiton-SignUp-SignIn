using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var user = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["pass"];
            
            if(user == loginEmail.Text) 
            {    
                if(password == loginPassword.Text)
                {
                    MessageBox.Show("Welcome Master");

                }
                else
                {
                    MessageBox.Show("FCK OFF !!!");
                }

            }
        }
    }
}
