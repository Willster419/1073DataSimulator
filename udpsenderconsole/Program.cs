﻿using System;
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
            string robotSim1 = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA1,13.58,1.11,0.22,0.33,0.24,1,1,1,1,1,1,1,1.11,1.11,1.11,1.11,1.11,1,1,2,1,250,1.11,110,1.11,1.11,500,5,69,1";
            string robotSim2 = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA1,13.25,1.11,-0.22,-0.33,-0.24,0,0,0,0,0,0,0,1.11,1.11,1.11,1.11,1.11,0,0,1,1,250,1.11,110,1.11,1.11,500,5,69,1";
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1165);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            EndPoint Remote = (EndPoint)ipep;
            string consoleSim;
            IPEndPoint console = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666);
            Socket consoleServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint RemoteConsole = (EndPoint)console;
            int count = 0;
            int sendingSim1 = 2;
            while (true)
            {
                if (sendingSim1 % 2 == 0)
                {
                    server.SendTo(Encoding.ASCII.GetBytes(robotSim1), Remote);
                    System.Threading.Thread.Sleep(7);
                }
                else
                {
                    server.SendTo(Encoding.ASCII.GetBytes(robotSim2), Remote);
                    System.Threading.Thread.Sleep(7);
                }
                //Console.WriteLine(input);
                consoleSim = "This is a test string "+count+++"\n";
                consoleServer.SendTo(Encoding.ASCII.GetBytes(consoleSim), RemoteConsole);
                //Console.WriteLine(input);
                if (count == int.MaxValue) count = 0;
                if (sendingSim1 == int.MaxValue) sendingSim1 = 2;
                sendingSim1++;
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}