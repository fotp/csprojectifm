using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.authentification
{
    [Serializable]
    public class Authentification : AuthentificationManager
    {
        private List<User> _userList;

        public List<User> userList
        {
            get { return _userList; }
            set { _userList = value; }
        }

        public Authentification()
        {
            userList = new List<User>();
        }

        public void addUser(string login, string password)
        {
            
            int var = 0;

            for (int i = 0; i < userList.Count(); i++)
            {
                if (userList[i].login == login)
                {
                    var = 1;
                }
            }

            if (var == 1)
            {
                Console.WriteLine("Login : " + login + " already used !");
            }
            else
            {
                User u = new User(login, password);
                userList.Add(u);
                Console.WriteLine("User : " + login + " properly added !");
            }
            
       


        }
        public void authentify(string login, string password)
        {

            int var = 0;

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].login == login && userList[i].password == password)
                {
                    var = 1;
                }
            }
            if (var == 1)
            {
                Console.WriteLine("Authentification of : " + login + " OK, access granted !");
            }
            else
            {
                Console.WriteLine("Authentification of " + login + " failed.");
            }





        }

        public void list()
        {
            Console.WriteLine("The user list contains the following users : ");
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + userList[i].login + ", password : " + userList[i].password);
            }
        }

        public void removeUser(string login)
        {

            int var = 0;
            int var2 = 0;

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].login == login)
                {
                    var = 1;
                    var2 = i;
                }
            }
            if (var == 0)
            {
                Console.WriteLine("Login: " + login + " not found.");
            }
            else
            {
                userList.RemoveAt(var2);
                Console.WriteLine("User : " + login + " successfuly removed");
            }
        }

        public void save(string path)
        {
            // N'EST PAS LA SERIALISATION, MAIS MARCHE JUSTE POUR ECRIRE LES FICHIERS, LES USERS NE SONT PAS DES OBJETS 
            // POUR LIRE IL FAUDRAIT METTRE EN PLACE UN SYSTEME AVEC SEPARATEUR
            /*
            // we create an ArrayList, which fill itself with the user list (login + password)
            ArrayList users = new ArrayList();
            for (int i = 0; i < userList.Count; i++)
            {
                string data = userList[i].getLogin() + " " + userList[i].getPassword();
                users.Add(data);
            }

            //convert an ArrayList to an Array
            string[] tab = users.ToArray(typeof(string)) as string[];

            //
            System.IO.File.WriteAllLines(@"C:\Users\florentinponzio\Desktop\ProjetCSharp\" + path, tab);
            */

            //S'ENREGISTRE DANS "C:\Users\florentinponzio\Desktop\ProjetCSharp\ProjetCSharp\ProjetCSharp\bin\Debug" + path; ICI PATH = users.txt

            IFormatter formatter = new BinaryFormatter();
            Stream fs = new FileStream(path, FileMode.Create);

            formatter.Serialize(fs, userList);
            fs.Close();

            Console.WriteLine("Serialization done !");
        }

        public void load(string path)
        {
            List<User> uList = new List<User>();
            IFormatter formatter = new BinaryFormatter();
            Stream fs = new FileStream(path, FileMode.Open);

            uList = (List<User>)formatter.Deserialize(fs);
            userList = uList;
            Console.WriteLine("Deserialization done !");
        }
    }
}
