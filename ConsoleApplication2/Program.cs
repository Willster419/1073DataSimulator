using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleSender
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string input;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1165);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            EndPoint Remote = (EndPoint)ipep;
            while (true)
            {
                input = "This is a test string*****************************************";
                server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
                //Console.WriteLine(input);
            }
        }
    }
}