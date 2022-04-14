using System.Net;
using System.Net.Mail;
using System.Text;
using RestPanda.Requests;
using RestPanda.Requests.Attributes;

namespace WebServer.Handler;

[RequestHandler]
public class EMailHandler
{
    private static List<Student> _students =
        new (new []
        {
            new Student(1, "Кокорин", 19, "Почта"),
            new Student(2, "Бессонов", 20, "Тоже Почта"),
            new Student(3, "Ведерников", 19, "И Это Почта"),
        });

    private static string FillTable()
    {
        var s = new StringBuilder("<table style=\"border-collapse: collapse\">"+ Environment.NewLine);
        s.Append("<tr><th>id</th><th>Фамилия</th><th>Возраст</th><th>Почта</th></tr>" + Environment.NewLine);
        foreach (var student in _students)
        {
            s.Append("<tr>").Append($"<td>{student.ID}</td>").Append($"<td>{student.LastName}</td>")
                .Append($"<td>{student.Age}</td>").Append($"<td>{student.EMail}</td>").Append("</tr>"+Environment.NewLine);
        }

        s.Append("</table>");
        return s.ToString();
    }
    
    [Get]
    public static void What(PandaRequest request, PandaResponse response)
    {
        var from = new MailAddress("from", "name");
        var to = new MailAddress("to", "name");
        var msg = new MailMessage(from, to);
        msg.Subject = "Письмо";
        msg.Attachments.Add(
            new Attachment("filepath"));
        msg.Body = "Тра-та-та";
        using (var smtp = new SmtpClient("smtp.mail.ru", 587))
        {
            smtp.Credentials = new NetworkCredential("email", "password");
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }

        var msg2 = new MailMessage(from, to);
        msg2.Subject = "Тра-та-та";
        msg2.Body = "<img src=\"https://static.wikia.nocookie.net/character-power/images/a/ad/%D0%90%D0%BB%D1%91%D1%88%D0%B0_%D0%9F%D0%BE%D0%BF%D0%BE%D0%B2%D0%B8%D1%87.png/revision/latest?cb=20180724181754&path-prefix=ru\" alt=\"Алеша\"/>"+ Environment.NewLine;
        msg2.Body += FillTable();
        msg2.IsBodyHtml = true;
        using (var smtp = new SmtpClient("smtp.mail.ru", 587))
        {
            smtp.Credentials = new NetworkCredential("email", "password");
            smtp.EnableSsl = true;
            smtp.Send(msg2);
        }

        response.Send("");
    }
}