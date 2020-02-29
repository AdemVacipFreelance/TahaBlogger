using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Consts;
using TahaBloggerProject.Business.Helper.CommonOperation;
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
            { return true;  throw new Exception("Bu mail adresi ve kullanıcı adı kullanılmaktadır. Farklı bilgiler ile tekrar deneyiniz "); }
            return false;
        }

        // yardımcı metot olduğu için dışardaki alanların görmesine gerek yok 
        // sonra bir interface üzerinden yapacağın için o zaman düzeltirsin.
        // MailConst.IncorrectMailAddress hata metinleri bir sınıfta olsun kod bloklarında olduğunca az striing ifade olsun.
        private bool IsMailValidateCheck(string mailAddress)
        {
            if (!ValidationHelper.IsEmail(mailAddress))
            { return false;  throw new Exception(MailConst.IncorrectMailAddress); }
            return true;
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
            // Bu if'ler ayırılacak daha sonra
            // if bloklarındaki metotlar içinde exception fırlatılacak ve if blokları sadece  metotları cağıracak
            // IsMailValidateCheck(registerDto.EMail);
            // IsUserCheck(registerDto.EMail, registerDto.Username);
            // seklinde 


            if (!IsMailValidateCheck(registerDto.EMail) && !IsUserCheck(registerDto.EMail, registerDto.Username))
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
            throw new Exception("Kullanıcı kaydı sırasında bir hata oluştu.");

        }

    }
}
