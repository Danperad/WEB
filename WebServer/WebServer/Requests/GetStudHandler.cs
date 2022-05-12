using RestPanda.Requests;
using RestPanda.Requests.Attributes;
using WebServer.Entity;

namespace WebServer.Requests;

[RequestHandler("/getstud")]
public class GetStudHandler
{
    [Get]
    public static void GetStuds(PandaRequest request, PandaResponse response)
    {
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());
        if (!request.Params.ContainsKey("id"))
        {
            response.Send(Stud.Studs);
            return;
        }

        var f = request.Params["id"];
        int start;
        if (f.Contains('-'))
        {
            var s = f.Split('-');
            if (!int.TryParse(s[0], out start) || !int.TryParse(s[1], out var stop))
            {
                response.Send("Error");
                return;
            }

            response.Send(Stud.Studs.Where(stud => stud.ID >= start && stud.ID <= stop));
            return;
        }

        if (!int.TryParse(f, out start))
        {
            response.Send("Error");
            return;
        }

        if (Stud.Studs.All(stud => stud.ID != start))
        {
            response.Send("Error");
            return;
        }

        response.Send(Stud.Studs.Single(stud => stud.ID == start));
    }

    [Post("/addStud")]
    public static void AddStud(PandaRequest request, PandaResponse response)
    {
        var stud = request.GetObject<Stud>();
        if (stud is null)
        {
            response.Send(new {Error = "error"});
            return;
        }
        Stud.Studs.Add(stud);
        response.Send(new {Status = true});
    }
    
}