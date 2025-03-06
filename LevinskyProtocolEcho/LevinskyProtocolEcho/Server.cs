using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LevinskyProtocolEcho
{
    internal class Server
    {
        private const int port = 7;

        //IPAddress ipAddress = IPAddress.Loopback;        
        //MGV-DM04
        //lanmagle
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                Task.Run(() =>   //=> lambda - gør det til en anonym metode.
                {
                    TcpClient tempsocket = socket;
                    DoOneClient(tempsocket);
                });
                //DoOneClient(socket);
            }

            


        }

        
        public void DoOneClient(TcpClient socket)
        {
            StreamReader reader = new StreamReader(socket.GetStream());
            StreamWriter writer = new StreamWriter(socket.GetStream());

            string line = reader.ReadLine();
            writer.WriteLine(line);
            Console.ReadLine(DoesPeterExists(line));

            writer.Flush();
            socket?.Close();
        }

        public bool? DoesPeterExist(string line)
        {
            if (line != null)
            {
                line.ToLower();
                if (line == "peter")
                {
                    return true;
                    Console.WriteLine("Peter eksisterer!! Spred ordet!!!");
                }
                else
                {
                    return false;
                    Console.Write("Det FAKE NEWS! Vi ved han eksisterer!! Led videre!!!");
                }
            }
            else
            {
                return null;
            }
            
        }
    }
}
