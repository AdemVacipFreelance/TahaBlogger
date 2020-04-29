using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.Core.Utilities.Hashing;
using TahaBloggerProject.Core.Utilities.Security.Jwt;
using TahaBloggerProject.Entities.Dtos;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("loginAuth")]
        public ActionResult Login(LoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin == null)
            {
                return BadRequest();
            }

            var result = _authService.CreateAccessToken(userToLogin);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest((AccessToken)null);
        }

        [HttpPost("register")]
        public ActionResult Register(RegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.EMail);
            if (!userExists)
                return BadRequest(false);

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult);
            if (result == null)
            {
                return Ok((AccessToken)null);
            }

            return BadRequest(error: result);
        }
    }
}
