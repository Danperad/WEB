using RestPanda;

namespace WebServer;

internal class Program
{
    public static void Main(string[] args)
    {
        var server = new PandaServer("http://localhost:8888/",typeof(Program));
        server.Start();
        Console.WriteLine("Start listen");
        Console.Read();
        server.Stop();
    }
}