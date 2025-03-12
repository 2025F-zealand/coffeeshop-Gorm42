// See https://aka.ms/new-console-template for more information
using MandatoryJSONServer;

Console.WriteLine("Hello, World!");


JsonServer jsonServer = new JsonServer();
jsonServer.Start();
Console.ReadKey();


