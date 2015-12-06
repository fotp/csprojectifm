using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject.Net
{
    
    abstract class TCPServer : ICloneable, MessageConnection
    {

        TcpListener _waitSock;
        TcpClient _commSocket;
        NetworkStream _ns;
        int _port;
        IPAddress _ip;

        bool _doRun = false;
        bool _treatClient = false;

        public bool doRun
        {
            get { return _doRun; }
            set { _doRun = value; }
        }
        public bool treatClient
        {
            get { return _treatClient; }
            set { _treatClient = value; }
        }


        public TcpListener waitSock
        {
            get { return _waitSock; }
            set { _waitSock = value; }
        }

        public NetworkStream ns
        {
            get { return _ns; }
            set { _ns = value; }
        }

        public IPAddress ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public int port
        {
            get { return _port; }
            set { _port = value; }
        }

        public TcpClient commSocket
        {
            get { return _commSocket; }
            set { _commSocket = value; }
        }
        public TCPServer(IPAddress ip)
        {
            this.ip = ip;
            treatClient = false;
            doRun = true;
        }

        public void startServer(int port)
        {
            this.port = port;
            waitSock = new TcpListener(ip, this.port);
            waitSock.Start();
            doRun = true; // à voir
            run();
        }


        //public void startServer(object port)
        //{
        //    this.port = (int)port;
        //    waitSock = new TcpListener(ip, this.port);
        //    waitSock.Start();
        //    doRun = true;
        //    run();
        //}

        public void stopServer()
        {
            waitSock.Stop();
            doRun = false;
        }

        public void run()
        {
            if (treatClient)
            {
                clientManager(commSocket);
            }
            else
            {
                Console.WriteLine("Server Launching...");
                while (doRun)
                {
                    try
                    {
                        Console.WriteLine("Waiting for a connection...");
                        commSocket = waitSock.AcceptTcpClient();
                        Console.WriteLine("Connection established");

                        TCPServer myClone = (TCPServer)Clone();
                        myClone.treatClient = true;
                        Thread newClient = new Thread(new ThreadStart(myClone.run));
                        newClient.Start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error : " + e.StackTrace);
                    }
                }
            }
        }

        abstract public void clientManager(TcpClient comm);

        public object Clone()
        {
            return null;
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




