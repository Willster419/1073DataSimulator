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
                robotSim = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA13.58474 1.111111 2.222222 3.333333 4.444444 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 1.111111 9001";
                    server.SendTo(Encoding.ASCII.GetBytes(robotSim), Remote);
                    //Console.WriteLine(input);
                    //consoleSim = "This is a test string";
                    //consoleServer.SendTo(Encoding.ASCII.GetBytes(consoleSim), RemoteConsole);
                    //Console.WriteLine(input);
                   // robotSim = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA12.39534 1.489334 2.593567 2.334336 1.440954";
                    //server.SendTo(Encoding.ASCII.GetBytes(robotSim), Remote);
                    //Console.WriteLine(input);
                    //consoleSim = "This is a test string lol stuff";
                    //consoleServer.SendTo(Encoding.ASCII.GetBytes(consoleSim), RemoteConsole);
                    //Console.WriteLine(input);
            }
        }
    }
}