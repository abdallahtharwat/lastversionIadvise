using MimeKit;
using Project.DataAccess.Repository.IRepository;
using Project.Models.Models;


using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;
//using MailKit.Security;

namespace Project.DataAccess.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {

        public async Task<bool> SendEmail(Feedback Feedback, string? language)
        {
            try
            {
                var host = "smtp.office365.com";
                var emailSender = "";
                var password = "Iadvise123456@";
                var port = 587;
                var ssl = true;
                var fromEmail = emailSender;
                var fromName = "IAdvise";
                var subject = "Feedback";
                var message = "\nFirst Name:  " + Feedback.FName + "\n|| Last Name: " + Feedback.LName + "\n|| Business Activity: " + Feedback.BusinessActivity + "\n|| Phone:  " + Feedback.Mobile + "\n|| package: " + Feedback.package + "\n|| Email : " + Feedback.Email + "\n|| Message : " + Feedback.Message;
                var emails = emailSender;



                try
                {
                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var email = new MimeMessage();
                    email.Sender = MailboxAddress.Parse(emailSender);
                    if (!string.IsNullOrEmpty(fromName))
                        email.Sender.Name = fromName;
                    email.From.Add(new MailboxAddress(fromName, fromEmail));
                    if (!string.IsNullOrEmpty(emails))
                    {
                        foreach (var mail in emails.Split(","))
                        {
                            email.To.Add(MailboxAddress.Parse(mail));
                        }
                    }

                    email.To.Add(MailboxAddress.Parse(emails));
                    email.Subject = subject;
                    email.Body = new TextPart(TextFormat.Html) { Text = message };

                    // send email
                    using (var smtp = new SmtpClient())
                    {
                        await smtp.ConnectAsync(host, (int)port, SecureSocketOptions.StartTls);
                        await smtp.AuthenticateAsync(emailSender, password);
                        await smtp.SendAsync(email);
                        await smtp.DisconnectAsync(true);
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }


            }
            catch (Exception ex)
            {

            }
            return false;

        }



    }
}
