using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SampleMVC.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials =
                    new NetworkCredential("sample.mvc.2017@gmail.com", "4rfv$RFV")
            };
            var msg = new MailMessage("sample.mvc.2017@gmail.com", email, subject, message);
            await client.SendMailAsync(msg);
        }
    }
}
