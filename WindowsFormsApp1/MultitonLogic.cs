using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MultitonLogic
    {
        private static readonly Dictionary<string,MultitonLogic> _instance = new Dictionary<string, MultitonLogic>();
        private MultitonLogic()
        {
            // read data from config
            username = "";
            passowrd = "";
        } 
        public static MultitonLogic Instance { get; set; }

        public readonly string username;
        public readonly string passowrd;
    }
}
