using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpProject.Chat
{
    public class TextGestTopics : TopicsManager
    {
        public List<string> myTopics;

        public TextGestTopics()
        {
            myTopics = new List<string>();
        }

        public string listTopics()
        {
            string list = "The opened topics are : " + "\n" ;


            for (int i = 0; i < myTopics.Count; i++)
            {
                list += myTopics.ElementAt(i) + "\n";
            }   
            return list;
        }
        public ChatRoom joinTopic(string topic)
        {
            ChatRoom cr = new TextChatRoom(topic);
            return cr;
        }

        public void createTopic(string topic)
        {
            myTopics.Add(topic);
        }

    
    }
}
