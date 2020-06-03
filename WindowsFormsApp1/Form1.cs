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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Pasko\Desktop\login.txt");
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Pasko\Desktop\login.txt");
            sw.WriteLine("JA JOS POVEECA MACKA HAHAHAHAHHA");
            sw.WriteLine("\n");
            sw.WriteLine("MACORYYYYYYYYYYYY");
            sw.Close();
            
        }
    }
}
