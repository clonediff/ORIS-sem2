using dogsAPI.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace dogsAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MailController : Controller
	{
		public static string mailAddress { get; } = "oristask@gmail.com";
		public static string passwordApp { get; } = "evbbzbfiaaaetauy";
		public static MailboxAddress adminMailbox { get; } = new MailboxAddress("Админ DogsAPI Clonediff ver.", mailAddress);

		[HttpPost]
		public async Task SendMail([FromBody]FeedbackData feedback)
		{
			var guestMailbox = new MailboxAddress("Гость", feedback.Email);

			using var responseMessage = new MimeMessage();

			responseMessage.From.Add(adminMailbox);
			responseMessage.To.Add(guestMailbox);
			responseMessage.Subject = "Спасибо за отзыв";
			responseMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = "<h1>Спасибо за отзыв</h1>" +
				"<p>Спасибо, большое за ваш оставленный отзыв. Ваше мнение очень важно для нас</p>"
			};

			using var emailMessage = new MimeMessage();
			emailMessage.From.Add(guestMailbox);
			emailMessage.To.Add(adminMailbox);
			emailMessage.Subject = "Отзыв на DogsAPI";
			emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = $"<h1>Отзыв на DogsAPI от {feedback.Email}</h1>" +
						$"<p>{feedback.Message}</p>"
			};

			using (var client = new SmtpClient())
			{
				await client.ConnectAsync("smtp.gmail.com", 465, true);
				await client.AuthenticateAsync(mailAddress, passwordApp);
				await client.SendAsync(responseMessage);
				await client.SendAsync(emailMessage);

				await client.DisconnectAsync(true);
			}
		}
	}
}
