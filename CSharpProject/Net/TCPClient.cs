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

        public TcpClient commSocket
        {
            get { return _commSocket; }
            set { _commSocket = value; }
        }

        public IPAddress ip
        {
            get{return _ip;}
            set {_ip = value;}
        }

        public int port
        {
            get{ return _port; }
            set{ _port = value;}
        }

        public NetworkStream ns
        {
            get{return _ns;}
            set{_ns = value;}
        }

        public TCPClient (IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
            commSocket = new TcpClient();
        }

        public void setServer(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public void connect()
        {
            commSocket.Connect(ip, port);
            ns = commSocket.GetStream();
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
