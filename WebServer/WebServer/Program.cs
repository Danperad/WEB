using RestPanda;

namespace WebServer;

public class Program
{
    private static List<DateTime> _times = new();

    public static int GetTimes()
    {
        _times.Add(DateTime.Now);
        foreach (var time in _times.Where(time => (time - _times[^1]).Minutes >= 1))
        {
            _times.Remove(time);
        }

        return _times.Count;
    }

    public static void Main(string[] args)
    {
        const string url = "http://localhost:8888/";
        var server = new PandaServer(typeof(Program), new Uri(url));
        server.Start();
        Console.WriteLine($"Start Listen at {url}");
        Console.WriteLine("Press Enter to stop server");
        Console.Read();
        server.Stop();
    }
}