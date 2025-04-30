using System.Net;
using System.Net.Mail;

namespace CustomerApp.Domain
{
    public class EmailService
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                //Port = 587,
                Credentials = new NetworkCredential(customer.Email, customer.Password),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(customer.Email),
                Subject = "Test mail",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(customer.Email);
            //smtpClient.Send(mailMessage);
            return true;
        }        
    }
}