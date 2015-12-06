using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Chat
{
    public class TextChatter : Chatter
    {
        private string _name;

        public TextChatter(string n)
        {
            _name = n;
        }

        public string Alias
        {
           get { return _name; }
            set { _name = value; }
        }

        public string receiveAMessage(string msg, Chatter c)
        {
            string s = null;
            s = c.Alias + " $> " + msg;

            return s;
        }

    }
}
