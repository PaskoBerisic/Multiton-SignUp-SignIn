using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MultitonLogic instance = new MultitonLogic();
            this.Hide();
            Login login = new Login();
           // instance.UpdateBase();
            login.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MultitonLogic instance = new MultitonLogic();
            this.Hide();
            Register register = new Register();
           // instance.UpdateBase();
            register.ShowDialog();
        }
    }
}
