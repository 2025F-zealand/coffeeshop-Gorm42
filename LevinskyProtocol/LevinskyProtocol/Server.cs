using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LevinskyProtocol
{
    internal class Server
    {

        private const int portNummer = 17;

        public void Start()
        {
            TcpListener server = new TcpListener(portNummer);
            server.Start();

            TcpClient socket = server.AcceptTcpClient(); //Venter på three-way handshake.

            StreamReader reader = new StreamReader(socket.GetStream());
            StreamWriter writer = new StreamWriter(socket.GetStream());

            string line = reader.ReadLine();


            line = line.ToUpper();

            writer.WriteLine(line);
            writer.Flush(); //vi har en buffer der først sender ting afsted før den er fyldt.
                            //Ved at bruge flush tvinger vi vores writer-buffer til at sende det videre 
                            //i dens socket stream.
                            //Hvis vi ikke siger flush til serveren, så sker der ikke noget.

            socket?.Close(); //hvis socket ikke er null, så lukker den.

        }
    }
}
