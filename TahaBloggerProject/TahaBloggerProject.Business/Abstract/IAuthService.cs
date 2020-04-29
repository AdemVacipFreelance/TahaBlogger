using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.Core.Utilities.Security.Jwt;
using TahaBloggerProject.Entities.Dtos;

namespace TahaBloggerProject.Business.Abstract
{
   public interface IAuthService
    {
        User Register(RegisterDto userForRegisterDto, string password);

        User Login(LoginDto userForLoginDto);

        bool UserExists(string email);

        AccessToken CreateAccessToken(User user);
    }
}
