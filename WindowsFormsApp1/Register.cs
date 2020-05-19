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
            /* Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
             config.AppSettings.Settings.Add("YourKey", "YourValue");
             config.Save(ConfigurationSaveMode.Minimal);
             MessageBox.Show("You can come in but be aware of Master");*/
            int userIndex = 1;
            StreamWriter streamWriter = new StreamWriter("credentials.txt");
            streamWriter.WriteLine("djole");
            streamWriter.WriteLine("123");
            streamWriter.WriteLine("admin");
            streamWriter.WriteLine("admin");
            streamWriter.Close();
            var user = emailRegister.Text;
            var password = passwordRegister.Text;
            streamWriter.WriteLine(user);
            streamWriter.WriteLine(password);
           

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
