using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpProject.Net
{
    [Serializable]
    public class Message : ISerializable
    {
        List<string> _data;
        Header _head;
        
        public List<string> data
        {
            get { return _data; }
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

        public static void Send(Message m, NetworkStream ns)
        {
            BinaryFormatter binaryF = new BinaryFormatter();
            try
            {
                binaryF.Serialize(ns, m);
                ns.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static Message Receive(NetworkStream ns)
        {
            BinaryFormatter binaryF = new BinaryFormatter();
            Message msg = null;
            try
            {
                msg = (Message)binaryF.Deserialize(ns);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return msg;
        }
       
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}