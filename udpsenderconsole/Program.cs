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
            string robotSim;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1165);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            EndPoint Remote = (EndPoint)ipep;

            string consoleSim;
            IPEndPoint console = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1166);
            Socket consoleServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint RemoteConsole = (EndPoint)console;
            while (true)
            {
                robotSim= "This is a test string";
                server.SendTo(Encoding.ASCII.GetBytes(robotSim), Remote);
                //Console.WriteLine(input);
                consoleSim = "13.5847,1.1111,2.2222,3.3333,4.4444";
                consoleServer.SendTo(Encoding.ASCII.GetBytes(consoleSim), RemoteConsole);
                //Console.WriteLine(input);
            }
        }
    }
}