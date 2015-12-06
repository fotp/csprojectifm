using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Chat
{
    public class TextChatRoom : ChatRoom
    {
        private string topic;
        private List<Chatter> listChatter;

        public TextChatRoom(string name)
        {
            topic = name;
            listChatter = new List<Chatter>();
        }

        public string post(string msg, Chatter c)
        {
            string post = null;
            for (int i = 0; i < listChatter.Count; i++)
            {
                post += "(At : " + listChatter.ElementAt(i).Alias + " ) :  " + c.receiveAMessage(msg, c) + "\n";
            }
            return post;
        }

        public string quit(Chatter c)
        {
            string s = null;
            listChatter.Remove(c);
            s = "Message from Chatroom " + topic + " : " + c.Alias + " has left the room.";
            return s;

        }

        public string join(Chatter c)
        {
            string s = null;
            listChatter.Add(c);
            s = "Message from Chatroom " + topic + " : " + c.Alias + " has joined the room.";

            return s;

        }

        public string getTopic()
        {
            return topic;
        }
    }
}
