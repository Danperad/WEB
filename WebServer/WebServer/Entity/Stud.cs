using System.Text.Json;

namespace WebServer.Entity;

public class Stud
{
    public static List<Stud> Studs { get; } = new(new[]
    {
        new Stud(1, "Кокорин", "Егор", "Дмитриевич", 19, "email@mail.e"),
        new Stud(2, "Ведерников", "Михаил", "Дмитриевич", 24, "neemail@mail.nee"),
        new Stud(3, "Бессонов", "Анатолий", "Иванович", 50, "sovsememail@nemail.sov"),
        new Stud(1374919, "Голованов", "Алексей", "Олегович", 84, "voobshenee@mail.yes")
    });

    public int ID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public string EMail { get; set; }

    public Stud()
    {
    }

    public Stud(int id, string lastName, string firstName, string middleName, int age, string eMail)
    {
        ID = id;
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Age = age;
        EMail = eMail;
    }

    public static Stud? GetByID(dynamic id)
    {
        return Studs.FirstOrDefault(stud => stud.ID == id);
    }

    public static string Serialize(Stud stud)
    {
        return JsonSerializer.Serialize(stud);
    }
}