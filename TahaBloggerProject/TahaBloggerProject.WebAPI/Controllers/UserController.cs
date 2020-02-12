using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Entities.Models;
using TahaBloggerProject.Entities.ValueObjectsDTO;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class UserController:Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("AddNewUser")]
        public void RegisterUser(RegisterDto user)
        {
            _userService.RegisterUser(user);
        }
        [HttpPost("LoginWithUser")]
        public void Login(LoginDto loginDto)
        {
            _userService.LoginUser(loginDto);
        }

    }
}
