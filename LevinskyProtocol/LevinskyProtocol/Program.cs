namespace LevinskyProtocol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Server server = new Server();
            server.Start();
            Console.WriteLine();
            Console.ReadKey();
            

        }
    }
}
