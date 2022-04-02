using System.Text.Json;

namespace WebServer.Entity;

public class User
{
    public static List<User> Users { get; } = new(new[] {new User("0000", "0000")});

    public string login { get; set; }
    public string pass { get; set; }

    public User()
    {
        login = "";
        pass = "";
    }

    public User(string login, string pass)
    {
        this.login = login;
        this.pass = pass;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        var user = (User) obj;
        return user.login == login && user.pass == pass;
    }
}