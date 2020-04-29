using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Transactions;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Helper.MailOperation;
using TahaBloggerProject.Entities.Dtos;
using TahaBloggerProject.Entities.DTOS;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMailOperation _mailOperation;
        private readonly IConfiguration _configuration;

        public UserController(IUserService userService, IMailOperation mailOperation,IConfiguration configuration)
        {
            _userService = userService;
            _mailOperation = mailOperation;
            _configuration = configuration;
        }

        [HttpPost("AddNewUser")]
        public async void RegisterUser([FromBody]RegisterDto user)
        {
            //  TransactionScope birbirine bağlı işlemler için kullanılır yani
            // en az 2 işlem yapılacak ama işlemlerin herhangi birinde hata alırsa tum  işlemleri geri sarıp yapılmamış hale getirecek.
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                  
                    _userService.RegisterUser(user);
                    var registeredUser = _userService.GetUserByInfo(user.EMail, user.Username);
                    string siteUri = _configuration.GetValue<string>("MySettings:SiteUri");
                    string activateUri = $"{siteUri}/UserActivate?id={registeredUser.ActiveGuid}";
                    string body = ($"Merhaba {user.Name}<br> <br>Kullanıcı hesabınızı aktifleştirmek için <a href='{activateUri}' targer='=blank'>tıklayınız</a>");
                    await _mailOperation.SendEmailAsync(user.EMail, "Kayıt", body);
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

        [HttpGet("UserActivate")]
        public JsonResult UserActivate(Guid id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    _userService.UserActivate(id);

                    
                    scope.Complete();
                }
                catch (Exception)
                {

                    scope.Dispose();
                }
       
            }

            return Json("kullanıcı aktif edilmiştir");
        }



        [HttpPost("LoginWithUser")]
        public void Login(LoginDto loginDto)
        {
            _userService.LoginUser(loginDto);
        }
    }
}