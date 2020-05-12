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

        private void signIn_Click(object sender, EventArgs e)
        {
             var user = ConfigurationManager.AppSettings["user"];
              var password = ConfigurationManager.AppSettings["pass"];
           /* string user = "admin";
            string password = "admin";*/
            

            
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
            MessageBox.Show("Welcome Master");
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
