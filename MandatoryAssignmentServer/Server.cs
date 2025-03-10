using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentServer
{
    public class Server
    {
        private const int PORTNUMMER = 42;
        public void Start()
        {
            TcpListener server = new TcpListener(PORTNUMMER);
            server.Start();
            Console.WriteLine("Server startet at port" + PORTNUMMER);

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient(); //Svarer til en socket. Venter på 3-way handskake.
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoOneClient(tempSocket);
                });
            }

            //StreamReader reader = new StreamReader(socket.GetStream()); //Læser fra socket
            //StreamWriter writer = new StreamWriter(socket.GetStream()); //Skriver til socket
            ////Nu kan vi læse og skrive string.
            //writer.AutoFlush = true;
                                   
        }

        public void DoOneClient(TcpClient socket)
        {

            StreamReader reader = new StreamReader(socket.GetStream()); //Læser fra socket
            StreamWriter writer = new StreamWriter(socket.GetStream()); //Skriver til socket
            writer.AutoFlush = true;

            //Her begynder protokollen

            string? line = reader.ReadLine();
            Console.WriteLine("Line from client is: " + line);
            line = line.ToUpper();
            writer.WriteLine(line);

            socket?.Close();

        }
    }
}
