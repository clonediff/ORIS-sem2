using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace dogsAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MailController
	{
		[HttpGet]
		public void SendMail()
		{
			var from = new MailAddress("accformid001@gmail.com", "Вообще непонятно кто");
			var to = new MailAddress("accformid001@gmail.com");

			var msg = new MailMessage(from, to);

			msg.Subject = "Какая-то тема";
			msg.Body = "<p>Содержание письма</p><p>Кстати, это оказывается html разметка</p>";

			msg.IsBodyHtml = true;

			var smtp = new SmtpClient("smtp.gmail.com", 587);
			smtp.Credentials = new NetworkCredential("accformid001@gmail.com", "ilovemidjourney");
			smtp.EnableSsl = true;
			smtp.Send(msg);
		}
	}
}
