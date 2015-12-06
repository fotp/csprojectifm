using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace CSharpProject.Net
{
    [Serializable]
    public class Message
    {
        List<string> _data;
        Header _head;
        
        public List<string> data
        {
            get { return _data; }
            //test
            set { _data = value; }
        }

        public Header head
        {
            get { return _head; }
            set { _head = value; }
        }

        public string debug()
        {
            return head.ToString() + ":" + data; //data est déjà du type string
        }

        public Message(Header head, List<string> data)
        {
            this.head = head;
            this.data = data;
        }

        public Message()
        {
            head = new Header();
            data = new List<string>();
        }


       
    }
}