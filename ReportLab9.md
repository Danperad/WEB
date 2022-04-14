<p align = center>МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>РОССИЙСКОЙ ФЕДЕРАЦИИ

<p align = center>ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>«ВЯТСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ»

<p align = center>Институт математики и информационных систем

<p align = center>Факультет автоматики и вычислительной техники

<p align = center>Кафедра систем автоматизации управления
<br>
<br>
<br>
<br>

<p align = right>Дата сдачи на проверку:

<p align = right>«___» __________ 2022 г.

<p align = right>Проверено:

<p align = right>«___» __________ 2022 г.
<br>
<br>
<br>
<br>
<br>


<p align = center>Отчет по лабораторной работе № 8

<p align = center>по дисциплине

<p align = center>«Web-программирование»

<br>
<br>
<br>
<br>


<p align = center>Разработал студент гр. ИТб-2301-01-00 ________________ /Кокорин Е.Д./

<p align = center>Проверил ст. преподаватель _________________ /Земцов М.А./

<p align = center>Работа защищена с оценкой «___________» «___» __________ 2022 г.

<br>
<br>
<br>
<br>

<p align = center>Киров 2022

<hr>
Цель: реализовать отправку электронного письма условному пользователю от имени веб-приложения на целевом языке программирования.

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Реализовать отправку электронного письма условному пользователю
    - Отправка текстового сообщения
    - Отправка тесктового сообщения с pdf документом
    - Отправка HTML-разметки, содержащей картинку и таблицу


Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Danperad/WEB)* на сайте github.com была создана новая ветвь с названием lab9 от ветки lab8.

2. Реализовать отправку электронного письма условному пользователю.

В ходе лабораторной работы был создан класс EMailHandler. С помощью встроенной библиотеки SmtpClient реализован метод отправления электронного письма с текстовым сообщением и pdf-документом и отправления электронного сообщения, содержащего HTML-разметку. Результат работы метода представлен на рисунках 1 и 2. Листинг класса представлен в приложении А.

<p align=center><img src="./Img/Lab9/Lab9PDF.png" alt="PDF"></p>
<p align = center>Рисунок 1 – Письмо, содержащее вложенный файл и текст

<p align=center><img src="./Img/Lab9/Lab9HTML.png" alt="Html"></p>
<p align = center>Рисунок 2 – Письмо, содержащее HTML-разметку


Вывод: в ходе выполнения лабораторной работы были получены навыки работы со встроенной библиотекой для рассылки электронных писем SmtpClient.

<p align = center>Приложение А

<p align = center>(обязательное) 

<p align = center>Листинг класса EMailHandler.cs

```C#
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
        msg2.Body = "<img src=\"url-photo\" alt=\"Алеша\"/>"+ Environment.NewLine;
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
```