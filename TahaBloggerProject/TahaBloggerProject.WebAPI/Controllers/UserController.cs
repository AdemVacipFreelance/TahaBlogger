using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Helper.MailOperation;
using TahaBloggerProject.Business.Helper.MailOperation.Gmail;
using TahaBloggerProject.Entities.Models;
using TahaBloggerProject.Entities.ValueObjectsDTO;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMailOperation _mailOperation;

        public UserController(IUserService userService, IMailOperation mailOperation)
        {
            _userService = userService;
            _mailOperation = mailOperation;
        }
        [HttpPost("AddNewUser")]
        public async void RegisterUser(RegisterDto user)
        {
            //  TransactionScope birbirine bağlı işlemler için kullanılır yani
            // en az 2 işlem yapılacak ama işlemlerin herhangi birinde hata alırsa tum  işlemleri geri sarıp yapılmamış hale getirecek.
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    _userService.RegisterUser(user);
                    await _mailOperation.SendEmailAsync(user.EMail, "Kayıt", "Kayıt olmanız için lütfen aşağıdaki linke tıklayınız");
                    // TransactionScope basarılı oldu demek tüm
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    // TransactionScope hata aldı işlemleri geri al diyoruz.
                    scope.Dispose();
                    throw new Exception("Mail gönderim sırasında bir hata olustu. Hata: " + ex.Message);
                }
            }

        }
        [HttpPost("LoginWithUser")]
        public void Login(LoginDto loginDto)
        {
            _userService.LoginUser(loginDto);
        }



    }
}
