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
            this.sw = sw;
            this.sr = sr;
        }
        public static MultitonLogic Instance { get; set; }

        public bool AddUser(string username, string password)
        {
            //provjera korisnika je li u bazi
            // ako je, return flase
            //else dodaj novog, return true
             string temporary = sr.ReadToEnd();
              for (int i = 0; i<10 ; i++)
              {
                if (temporary == username)
                    return false;
                else
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                    sw.Flush();
                    return true;
              }
            sw.Close();

            return false;
          }
          public User GetUser(string username)
          {
            //for provjera postojio li username
            // ako postoji, vrati usera else null
            User user = new User();
            string temporary = sr.ReadToEnd();
            for (int i = 0; i<10; i++)
              {
                  if (temporary == username )
                      return user;
                  else
                      return null;
              }
            sr.Close();

            return null;
        }
        StreamReader sr = new StreamReader(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt");
        StreamWriter sw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Multiton-SignUp-SignIn\config.txt", true);

    }
}
