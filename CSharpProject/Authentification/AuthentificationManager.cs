using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.authentification
{
    public interface AuthentificationManager
    {
        void addUser(string login, string password);
        void removeUser(string login);
        void authentify(string login, string password);
        void load(string path);
        void save(string path);
        void list();
    }
}
