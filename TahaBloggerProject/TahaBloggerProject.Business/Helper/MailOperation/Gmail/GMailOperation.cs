using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Helper.MailOperation.Gmail
{
    public class GMailOperation : IMailOperation
    {
        public EmailSettings _emailSettings { get; }

        public GMailOperation(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            Execute(email, subject, message).Wait();
            return Task.FromResult(0);
        }

        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email)
                                 ? _emailSettings.ToEmail
                                 : email;
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress("vacip@gmail.com", "Vacip Derici") // String veri olmasın bir nesneden alınmalı
                };
                mail.To.Add(new MailAddress(toEmail));
                mail.CC.Add(new MailAddress("ademolguner@gmail.com"));

                mail.Subject = "Taha Blog  System - " + subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                var smtp = GetSmtpSettings();
                await smtp.SendMailAsync(mail);
                // falan filan bu sekilde ne kadar tekrar edebilecek işlem var ise metot parcalarına ayır kullan.
            }
            catch (Exception ex)
            {
                //do something here
            }
        }

        public SmtpClient GetSmtpSettings()
        {
            SmtpClient smtp = new SmtpClient(_emailSettings.PrimaryDomain, _emailSettings.SecondaryPort);
            smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
            smtp.EnableSsl = true;
            return smtp;
        }
    }
}