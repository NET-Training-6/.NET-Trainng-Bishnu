using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Net.Mail;

namespace WorkforceManagement.Web.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Host = "localhost";
        MailMessage message = new MailMessage();
        message.From = new MailAddress("");
        message.Subject = "";
        message.Body = "";
        //message.Attachments= new AttachmentCollection(new List<Attachment>());

        smtpClient.SendMailAsync(message);

        return View();
    }
}
