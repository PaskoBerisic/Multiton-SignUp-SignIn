using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
        private static readonly Dictionary<string, User> _instance = new Dictionary<string, User>();
        public MultitonLogic()
        {
            //read data from config

            /*
             * LAPTOP VERSION
             * StreamReader sr = new StreamReader(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt", true);
            */
        }
        public static MultitonLogic Instance { get; set; }

        /*
         * LAPTOP VERSION
        StreamReader sr = new StreamReader(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt");
        StreamWriter sw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt", true);
        */
        /*
        public void UpdateBase()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\config.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\username's.txt",true);
            string temporary = sr.ReadLine();
            int index = 0;
            while (temporary != null)
            {
                if (temporary != "-")
                {
                    if (index > 0)
                    {
                        index = temporary.IndexOf("|");
                        temporary = temporary.Substring(0, index);
                        sw.WriteLine(temporary);
                        sw.WriteLine("-");
                        sw.Flush();
                        
                    }
                }
                temporary = sr.ReadLine();
            }
            sw.Close();
            sr.Dispose();
            sr.Close();
        }*/

        public bool AddUser(string username, string password)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\username's.txt");
            //provjera korisnika je li u bazi
            // ako je, return flase
            //else dodaj novog, return true
            string temporary = sr.ReadLine();
            while (temporary != null)
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\config.txt", true);
                //Check if username exist
                if (temporary == username)
                    break;
                else
                sw.Write(username);
                sw.Write("|");
                sw.WriteLine(password);
                sw.WriteLine("-");
                sw.Flush();
                sw.Close();
                //Read the next line
                temporary = sr.ReadLine();
            }
            return false;
        }
        public bool GetUser(string username)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Pasko\Source\Repos\PaskoBerisic\Multiton-SignUp-SignIn\config.txt");
            //for provjera postojio li username
            // ako postoji, vrati usera else null
            User user = new User();
            string temporary = sr.ReadLine();
            int index = 0;

            while (temporary != null)
            {
                //Remove everything after splitter
                index = temporary.IndexOf("|");
                if (index > 0)
                    temporary = temporary.Substring(0, index);
                //Check if username exist
                if (temporary == username)
                    return true;
                //Read the next line
                temporary = sr.ReadLine();
                
            }
            sr.Dispose();
            sr.Close();
            
            return false;
        }

    }
}
