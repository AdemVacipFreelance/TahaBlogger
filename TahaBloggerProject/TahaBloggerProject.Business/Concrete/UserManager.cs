using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Helper.MailOperation;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;
using TahaBloggerProject.Entities.ValueObjectsDTO;

namespace TahaBloggerProject.Business.Concrete
{
    public class UserManager : IUserService
    {

        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool IsUserCheck(string email, string userName)
        {
            var user = _userDal.Get(x => x.Email == email || x.UserName == userName);

            if (user != null)
                return true;
            return false;

        }

        public User LoginUser(LoginDto data)
        {
            var user = _userDal.Get(x => x.UserName == data.Username && x.Password == data.Password);
            if (user != null)
            {
                return user;
            }

            throw new Exception("Kullanıcı adı veya şifre hatalıdır. Tekrar deneyiniz ");
        }



        public User RegisterUser(RegisterDto registerDto)
        {

            if (!IsUserCheck(registerDto.EMail, registerDto.Username))
            {
                var user = new User()
                {
                    UserName = registerDto.Username,
                    Password = registerDto.Password,
                    Email = registerDto.EMail,
                    ActiveGuid = Guid.NewGuid(),
                    IsActive = false,
                    Name = registerDto.Name,
                    LastName = registerDto.LastName
                    

                };
                
                return _userDal.Add(user);
            }
            throw new Exception("Bu mail adresi ve kullanıcı adı kullanılmaktadır. Farklı bilgiler ile tekrar deneyiniz ");
        }

    }
}
