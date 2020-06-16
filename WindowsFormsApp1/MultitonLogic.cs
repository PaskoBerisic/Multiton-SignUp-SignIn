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
    public class MultitonLogic
    {
        private static readonly Dictionary<string, MultitonLogic> users = new Dictionary<string, MultitonLogic>();
        private MultitonLogic(string username)
        {
            Username = username;
        }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public void SetPassword(string password)
        {
            Password = password;
        }
        
        public static MultitonLogic GetInstance(string username)
        {
            if (!users.ContainsKey(username))
                users.Add(username, new MultitonLogic(username));
            return users[username];
        }

        public static bool Exists(string username)
        {
            return users.ContainsKey(username);
        }
        
    }
}
