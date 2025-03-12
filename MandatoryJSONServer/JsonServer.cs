using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MandatoryJSONServer
{
    public class JsonServer
    {
        //Okay, så denne klasse og den efterfølgende burde ligger i sine egne klasser, men 
        //pt. får de lov til at stå her og så må det andet med separations of concerns og god
        //datastruktur komme senere.
        public class RequestData
        {
            public string Method { get; set; }
            public int Tal1 { get; set; }
            public int Tal2 { get; set; }
        }

        public class ResponseData
        {
            public bool Success { get; set; }
            public int Result { get; set; }
            public string ErrorMessage { get; set; }
        }

        private const int JSON_PORT = 43;
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Any, JSON_PORT);
            server.Start();
            Console.WriteLine("JSON server er startet på " + JSON_PORT);
            Console.WriteLine("{\"method\": \"Add-Subtract-Random\", \"Tal1\": number, \"Tal2\": number}");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Task.Run(() => ProcessClient(client));
            }
        }

        private void ProcessClient(TcpClient client)
        {
            using NetworkStream stream = client.GetStream();
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
            { 
                string? jsonRequest = reader.ReadLine();
                try
                {
                    //vi tester om forespørgslen fra klienten har noget i sig og ikke er null.
                    if(jsonRequest == null)
                    {
                        Console.WriteLine("Du gav mig en null værdi.");
                        return;
                    }
                    if (jsonRequest != null)
                    {
                        Console.WriteLine("Modtaget fra klient " + jsonRequest);
                    }

                    //vi sørger for at alle bogstaverne er små, så vi ikke får fejl pga. store bogstaver.
                    //
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    //Så vi modtager et JSON objekt som vi får i serialized format, og derfor skal vi deserialisere det!
                    RequestData request = JsonSerializer.Deserialize<RequestData>(jsonRequest, options);
                    
                    int result = 0;
                    //Okay, nu skal vi så bruge en af de tre metoder, ligesom i den tidligere opgave.
                    //Vi bruger igen en swtich metode, vi sørger for at alle bogstaver bliver gjort ToLower.
                    //Trim sørger sammentidig for at alle "white-spaces" dvs. mellemrum(?), bliver fjernet.
                    switch (request.Method.Trim().ToLower())
                    {
                        case "random":
                            Random rand = new Random();
                            int min = Math.Min(request.Tal1, request.Tal2);
                            int max = Math.Max(request.Tal1, request.Tal2);
                            result = rand.Next(min, max + 1);
                            break;
                        case "add":
                            result = request.Tal1 + request.Tal2;
                            break;
                        case "subtract":
                            result = request.Tal1 - request.Tal2;
                            break;
                        default:
                            SendError(writer, "Unknown method.");
                            return;
                    }

                    ResponseData response = new ResponseData
                    {
                        Success = true,
                        Result = result,
                        ErrorMessage = null
                    };
                    //Som man måske kan udlede ud fra navnet, så er det her vi serialicerer vores svar
                    //og dernæst sender vi det tilbage via WriteLine();
                    //Vi bruger den klasse vi selv har lavet, ResponseData og fylder dens tre properties.
                    string jsonResponse = JsonSerializer.Serialize(response);
                    writer.WriteLine(jsonResponse);

                }
                catch(Exception exception)
                {
                    SendError(writer, "Error processing request: " + exception.Message);
                }
            }

        }

        private void SendError(StreamWriter writer, string errorMessage)
        {
            ResponseData errorResponse = new ResponseData
            {
                Success = false,
                ErrorMessage = errorMessage
            };
            string jsonResponse = JsonSerializer.Serialize(errorResponse);
            writer.WriteLine(jsonResponse);
        }
    }
    
}
