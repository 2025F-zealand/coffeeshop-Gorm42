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
        }

        public void DoOneClient(TcpClient socket)
        {
            StreamReader reader = new StreamReader(socket.GetStream());
            StreamWriter writer = new StreamWriter(socket.GetStream());
            writer.AutoFlush = true;

            int attempts = 0;
            bool validCommand = false;

            while (attempts < 3)
            {
                writer.WriteLine("Random, Add or Subtract?"); // Step 1: Ask for input
                string? command = reader.ReadLine();
                if (command == null) break; // Exit if no input

                command = command.Trim().ToLower();

                if (command == "random" || command == "add" || command == "subtract")
                {
                    validCommand = true;
                    writer.WriteLine("Input numbers"); // Step 2: Prompt for numbers

                    string? numberInput = reader.ReadLine();
                    if (numberInput == null) break; // Exit if no input

                    string[] parts = numberInput.Split(' ');
                    if (parts.Length != 2 || !int.TryParse(parts[0], out int num1) || !int.TryParse(parts[1], out int num2))
                    {
                        writer.WriteLine("Invalid numbers. Connection closing.");
                        break;
                    }

                    int result = 0;
                    if (command == "random")
                    {
                        Random rand = new Random();
                        result = rand.Next(Math.Min(num1, num2), Math.Max(num1, num2) + 1);
                    }
                    else if (command == "add")
                    {
                        result = num1 + num2;
                    }
                    else if (command == "subtract")
                    {
                        result = num1 - num2;
                    }

                    writer.WriteLine(result); // Step 4: Send result
                    break;
                }
                else
                {
                    attempts++;
                    writer.WriteLine($"Invalid command. {3 - attempts} attempts remaining.");
                }
            }

            if (!validCommand)
            {
                writer.WriteLine("Too many failed attempts. Disconnecting.");
            }

            socket.Close();
        }

    }
}
