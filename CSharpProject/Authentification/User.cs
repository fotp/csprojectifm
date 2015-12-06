using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.authentification
{
    [Serializable]
    public class User
    {
        private string _login;
        private string _password;

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
      
        public User(string log, string pass)
        {
            login = log;
            password = pass;
        }
    }
}
