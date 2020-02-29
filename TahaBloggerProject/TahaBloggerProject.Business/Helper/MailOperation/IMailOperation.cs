using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Helper.MailOperation
{
    public interface IMailOperation
    {
        // Sonra düzenlersin from tarafı to tarafı cc tarafı jsondan sadece config ayarları olsun OK
        //Task SendEmailAsync2(string[] to, string subject, string message, string[] cc);
        Task SendEmailAsync(string email, string subject, string message);
        SmtpClient GetSmtpSettings();

    }
}
