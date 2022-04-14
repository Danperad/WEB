namespace WebServer;

public class Student
{
    public int ID { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string EMail { get; private set; }

    public Student(int id, string lastName, int age, string eMail)
    {
        ID = id;
        LastName = lastName;
        Age = age;
        EMail = eMail;
    }
}