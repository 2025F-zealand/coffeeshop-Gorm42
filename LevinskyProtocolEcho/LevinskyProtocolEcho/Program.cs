namespace LevinskyProtocolEcho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Server server = new Server();
            server.Start();
            //server.DoOneClient();
           
        }
    }
}
