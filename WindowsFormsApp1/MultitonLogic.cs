using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MultitonLogic
    {
        private static readonly MultitonLogic instance = new MultitonLogic();
        private MultitonLogic()
        {
            // read data from config
            
        }
        public static MultitonLogic Instance { get { return instance; } }

        public readonly string email;
        public readonly string passowrd;
    }
}
