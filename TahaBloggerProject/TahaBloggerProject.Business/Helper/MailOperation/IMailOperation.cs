using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Helper.MailOperation
{
    public interface IMailOperation
    {


       Task SendEmailAsync(string email, string subject, string message);

    }
}
