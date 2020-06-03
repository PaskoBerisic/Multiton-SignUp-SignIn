using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class User
    {
        public string username;
        public string password;
    }
    class MultitonLogic
    {
        private static readonly Dictionary<string,User> _instance = new Dictionary<string, User>();
        private MultitonLogic()
        {
          //read data from config
        } 
        public static MultitonLogic Instance { get; set; }

        public bool AddUser(string username, string password)
        {
            //provjera korisnika je li u bazi
            // ako je, return flase
            //else dodaj novog, return true

            for (int i = 0; i < TEXTFILE.LENGTH; int++)
            {
                if (username == textfile.username)
                    return false;
                else
                    TEXTFILE.ADD = username;
                    TEXTFILE.ADD = password;
                    return true;
            }


            return false;
        }
        public User GetUser(string username)
        {
            //for provjera postojio li username
            // ako postoji, vrati usera else null

            for (int i = 0; i<TEXTFILE.LENGTH; int++)
            {
                if (username == textfile.username)
                    return textfile.User;
                else
                    return null;
            }

            throw new NotImplementedException();
        }
      
    }
}
