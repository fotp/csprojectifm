using CSharpProject.Chat;
using CSharpProject.authentification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using CSharpProject.IHM;

namespace CSharpProject
{
    class main
    {
        static void Main(string[] args)
         {
            /// AUTHENTIFICATION       
            
            AuthentificationManager am = new Authentification();

            am.addUser("bob", "123");
            am.addUser("bob", "123");

            am.list();

            am.authentify("bob", "123");
            am.authentify("serge", "bla");

            //am.removeUser("bob");
            //am.removeUser("bob");

            am.addUser("marc", "123456");

            am.list();

            am.save("users.txt");
            am.load("users.txt");


            //am.authentify("bob", "123");
            //am.authentify("marc", "123456");
            


            //CHAT
            /*
             Chatter bob = new TextChatter("Bob");
             Chatter joe = new TextChatter("Joe");

             TopicsManager gt = new TextGestTopics();
             gt.createTopic("java");
             gt.createTopic("UML");
             Console.WriteLine(gt.listTopics());
             gt.createTopic("jeux");
             Console.WriteLine(gt.listTopics());

             ChatRoom cr = gt.joinTopic("jeux");
             Console.WriteLine(cr.join(bob));
             Console.WriteLine(cr.post("Je suis seul ou quoi ?", bob));
             Console.WriteLine(cr.join(joe));
             Console.WriteLine(cr.post("Tiens, salut Joe !", bob));

             Console.WriteLine(cr.post("Toi aussi tu chat sur les forums de jeux pendant les TP,Bob?", joe));
             */
            //NET
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
            */
        }
    }
}
