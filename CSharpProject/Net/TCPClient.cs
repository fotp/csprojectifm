using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Net
{
    public class TCPClient : MessageConnection
    {
        TcpClient _commSocket;
        IPAddress _ip;
        int _port;
        NetworkStream _ns;

        public TcpClient CommSocket
        {
            get { return _commSocket; }
            set { _commSocket = value; }
        }

        public IPAddress ip
        {
            get{return _ip;}
            set {_ip = value;}
        }

        public int Port
        {
            get{ return _port; }
            set{ _port = value;}
        }

        public NetworkStream ns
        {
            get{return _ns;}
            set{_ns = value;}
        }

        public Message getMessage()
        {
            Message msg = Message.Receive(ns);
            return msg;
        }

        public void sendMessage(Message msg)
        {
            Message.Send(msg, ns);
        }
    }
}
