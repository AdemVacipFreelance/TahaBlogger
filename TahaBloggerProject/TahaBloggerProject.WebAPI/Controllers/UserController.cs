using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            try
            {
                //_userService.RegisterUser(user);
                var data = _mailOperation.SendEmailAsync(user.EMail, "Kayıt", "Kayıt olmanız için lütfen aşağıdaki linke tıklayınız");

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost("LoginWithUser")]
        public void Login(LoginDto loginDto)
        {
            _userService.LoginUser(loginDto);
        }



    }
}
