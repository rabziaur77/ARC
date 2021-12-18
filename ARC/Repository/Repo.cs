using ARC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ARC.Repository
{
    public class Repo : IRepo
    {
        public string SendEMail(EmailModel emailModel)
        {
            string Response;
            try
            {
                var smtpClient = new SmtpClient(emailModel.SMTP_NAME, emailModel.SMTP_PORT);
                var mailMessage = new MailMessage(emailModel.From_User, emailModel.To_User)
                {
                    Subject = emailModel.Subject,
                    Body = emailModel.Body
                };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                smtpClient.EnableSsl = emailModel.SMTP_SSL;
                mailMessage.IsBodyHtml = emailModel.IsHtml;
                smtpClient.Credentials = new NetworkCredential(emailModel.UserName, emailModel.Password);
                smtpClient.Send(mailMessage);
                Response = "Success";
            }
            catch (Exception ex)
            {
                Response = ex.Message;
            }
            return Response;
        }
    }
}
