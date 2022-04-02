using RestPanda.Requests;
using RestPanda.Requests.Attributes;
using WebServer.Entity;

namespace WebServer.Requests;

[RequestHandler("/auth")]
public class AuthHandler
{
    [Post("/signin")]
    public static void SignIn(PandaRequest request, PandaResponse response)
    {
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());
        var user = request.GetObject<User>();
        if (user is null)
        {
            response.Send("Error");
            return;
        }
        if (User.Users.Contains(user))
        {
            response.Send(new {IsValid=true});
            return;
        }
        response.Send(new {IsValid=false});
    }
    
    [Post("/check")]
    public static void Check(PandaRequest request, PandaResponse response)
    {
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());

        var user = request.GetObject<User>();
        if (user is null)
        {
            response.Send("Error");
            return;
        }
        if (User.Users.Any(u => u.login == user.login))
        {
            response.Send(new {IsValid=false});
            return;
        }
        response.Send(new {IsValid=true});
    }
}