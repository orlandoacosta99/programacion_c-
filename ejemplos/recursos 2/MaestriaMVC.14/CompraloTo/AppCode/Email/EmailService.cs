using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CompraloTo.WebPortal
{

	public interface IEmailService
	{
        void SendEmail(SendEmailCommand command);

    }


	public sealed class EmailService : IEmailService
	{
        /// <summary>
        /// Send email
        /// </summary>
        public void SendEmail(SendEmailCommand command)
        {
			using (SmtpClient smtp = new SmtpClient())
			{
				//set smtp parameters
				smtp.Host = "localhost";
				smtp.Port = 25;
				smtp.EnableSsl = false;
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.UseDefaultCredentials = false;
				smtp.Credentials = new NetworkCredential("", "");

				// Add the alternate views instead of using MailMessage.Body
				using (MailMessage mailMsg = new MailMessage())
				{
					//construct mail view
					ContentType mimeType = new System.Net.Mime.ContentType("text/html; charset=\"UTF-8\"");

					// Add the alternate body to the message.
					AlternateView mailView = AlternateView.CreateAlternateViewFromString(command.body, mimeType);
					mailMsg.AlternateViews.Add(mailView);

					// Address and send the message
					mailMsg.From = new MailAddress(command.fromEmail, command.fromName);

					mailMsg.Subject = command.subject;

					mailMsg.To.Add(new MailAddress(command.toEmail, command.toName));

					//send message
					smtp.Send(mailMsg);
				}
			};            


		}

    }



}