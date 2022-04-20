using System.Text.Json;

namespace WebServer.Entity;

public class Stud
{
    public static List<Stud> Studs { get; } = new(new[]
    {
        new Stud(1, 1, "Кокорин", "Егор", "Дмитриевич", 19, "email@mail.e", true),
        new Stud(2, 1, "Ведерников", "Михаил", "Дмитриевич", 24, "neemail@mail.nee", false),
        new Stud(3, 2, "Бессонов", "Анатолий", "Иванович", 50, "sovsememail@nemail.sov", true),
        new Stud(1374919, 1, "Голованов", "Алексей", "Олегович", 84, "voobshenee@mail.yes", true)
    });

    public int ID { get; set; }
    public int Gender { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public int Age { get; set; }
    public string? EMail { get; set; }
    public bool IsVerif { get; set; }

    public Stud()
    {
        ID = 0;
        Gender = 0;
        LastName = "";
        FirstName = "";
        Age = 0;
        IsVerif = false;
    }

    public Stud(int id, int gender, string lastName, string firstName, string middleName, int age, string eMail,
        bool isVerif)
    {
        ID = id;
        Gender = gender;
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Age = age;
        EMail = eMail;
        IsVerif = isVerif;
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