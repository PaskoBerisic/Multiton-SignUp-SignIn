using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class User
    {
        public string username;
        public string password;
    }
    public class MultitonLogic
    {
        private static readonly Dictionary<string,User> _instance = new Dictionary<string, User>();
        public MultitonLogic()
        {
            //read data from config
            StreamReader sr = new StreamReader(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt", true);
        }
        public static MultitonLogic Instance { get; set; }


        StreamReader sr = new StreamReader(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\config.txt");
        StreamWriter sw = new StreamWriter(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\config.txt", true);
        /*
         * LAPTOP VERSION
        StreamReader sr = new StreamReader(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt");
        StreamWriter sw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt", true);
        */

        public bool AddUser(string username, string password)
        {
            //provjera korisnika je li u bazi
            // ako je, return flase
            //else dodaj novog, return true
            string temporary = sr.ReadLine();
            while (temporary != null)
            {
                //Check if username exist
                if (temporary == username)
                    break;
                else
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                    sw.WriteLine("-");
                    sw.Flush();
                //Read the next line
                temporary = sr.ReadLine();
            }
            sw.Close();
            return false;
          }
          public User GetUser(string username)
          {
            //for provjera postojio li username
            // ako postoji, vrati usera else null
            User user = new User();
            string temporary = sr.ReadLine();
            while (temporary != null)
            {
                //Check if username exist
                if (temporary == username)
                    return user;
                else
                    return null;
                //Read the next line
                temporary = sr.ReadLine();
            }
            sr.Dispose();
            sr.Close();
            return null;
        }
      
    }
}
