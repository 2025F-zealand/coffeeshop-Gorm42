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

            try
            {
                using (StreamReader reader = new StreamReader(socket.GetStream()))
                using (StreamWriter writer = new StreamWriter(socket.GetStream()))
                {
                    writer.AutoFlush = true;

                    // Step 1: Læser kommando fra klienten.
                    string? command = reader.ReadLine();
                    Console.WriteLine("Received command: " + command);

                    // Step 2: sender tilbage til socket "Input numbers".
                    writer.WriteLine("Input numbers");

                    // Step 2: Læser to tal fra socket med mellemrum.
                    string? numbersLine = reader.ReadLine();
                    Console.WriteLine("Received numbers: " + numbersLine);
                    if (numbersLine == null)
                    {
                        writer.WriteLine("Error: No numbers received.");
                        return;
                    }

                    string[] parts = numbersLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2)
                    {
                        writer.WriteLine("Error: Expected two numbers separated by space.");
                        return;
                    }

                    if (!int.TryParse(parts[0], out int number1) || !int.TryParse(parts[1], out int number2))
                    {
                        writer.WriteLine("Error: Invalid number format.");
                        return;
                    }

                    int result = 0;
                    // Bruger switch-case til at vælge hvilken operation der skal udføres.
                    switch (command?.Trim().ToUpper())
                    {
                        case "RANDOM":
                            // Ensure correct order for Random.Next(min, max+1)
                            int min = Math.Min(number1, number2);
                            int max = Math.Max(number1, number2);
                            Random rand = new Random();
                            result = rand.Next(min, max + 1);
                            break;
                        case "ADD":
                            result = number1 + number2;
                            break;
                        case "SUBTRACT":
                            result = number1 - number2;
                            break;
                        default:
                            writer.WriteLine("Unknown command.");
                            return;
                    }

                    // Send the result back to the client
                    writer.WriteLine(result);
                    Console.WriteLine("Sent result: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling client: " + ex.Message);
            }
            finally
            {
                socket.Close();
            }

        }
    }
}
