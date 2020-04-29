using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.Core.Utilities.Hashing;
using TahaBloggerProject.Core.Utilities.Security.Jwt;
using TahaBloggerProject.Entities.Dtos;

namespace TahaBloggerProject.Business.Concrete
{
    public class AuthManager : IAuthService
    {

        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public User Register(RegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.EMail,
                 Name = userForRegisterDto.Name,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                IsActive = true
              
            };
            _userService.Add(user);
            return user;
        }

        public User Login(LoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                throw new Exception("hata metni");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new Exception("hata metni"); ;
            }

            return userToCheck;
        }

        public bool UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return false;
            }
            return true;
        }

        public AccessToken CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }


    }
}
