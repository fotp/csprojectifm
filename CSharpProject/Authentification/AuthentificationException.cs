using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.authentification
{
    class AuthentificationException : Exception
    {
        private string _login;
        public string login
        {
            get { return _login; }
            set { _login = value; }
        }
        public AuthentificationException(string login)
        {
            this.login = login;
        }
    }
    class UserExistsException : AuthentificationException
    {
        public UserExistsException(string login) : base(login)
        {
        }
    }




    class UserUnknownException : AuthentificationException
    {
        public UserUnknownException(string login) : base(login)
        {
        }
    }

    class WrongPasswordException : AuthentificationException
    {
        public WrongPasswordException(string login) : base(login)
        {
        }
    }


}

