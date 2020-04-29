using System;
using System.Collections.Generic;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Business.Consts;
using TahaBloggerProject.Business.Helper.CommonOperation;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Dtos;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Messages;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class UserManager:IUserService
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
            { return true; throw new Exception("Bu mail adresi ve kullanıcı adı kullanılmaktadır. Farklı bilgiler ile tekrar deneyiniz "); }
            return false;
        }

        // yardımcı metot olduğu için dışardaki alanların görmesine gerek yok
        // sonra bir interface üzerinden yapacağın için o zaman düzeltirsin.
        // MailConst.IncorrectMailAddress hata metinleri bir sınıfta olsun kod bloklarında olduğunca az striing ifade olsun.
        private bool IsMailValidateCheck(string mailAddress)
        {
            if (!ValidationHelper.IsEmail(mailAddress))
            { return false; throw new Exception(MailConst.IncorrectMailAddress); }
            return true;
        }

        public User LoginUser(LoginDto data)
        {
            //var user = _userDal.Get(x => x.UserName == data.Name && x.Password == data.Password);
            //if (user != null)
            //{
            //    return user;
            //}
            throw new Exception("Kullanıcı adı veya şifre hatalıdır. Tekrar deneyiniz ");
        }

        //public User RegisterUser(RegisterDto registerDto)
        //{
        //    // Bu if'ler ayırılacak daha sonra
        //    // if bloklarındaki metotlar içinde exception fırlatılacak ve if blokları sadece  metotları cağıracak
        //    // IsMailValidateCheck(registerDto.EMail);
        //    // IsUserCheck(registerDto.EMail, registerDto.Username);
        //    // seklinde

        //    if (!IsMailValidateCheck(registerDto.EMail) && !IsUserCheck(registerDto.EMail, registerDto.Username))
        //    {
        //        var user = new User()
        //        {
        //            UserName = registerDto.Username,
        //            Password = registerDto.Password,
        //            Email = registerDto.EMail,
        //            ActiveGuid = Guid.NewGuid(),
        //            IsActive = false,
        //            Name = registerDto.Name,
        //            LastName = registerDto.LastName

        //        };

        //        return _userDal.Add(user);
        //    }
        //    throw new Exception("Kullanıcı kaydı sırasında bir hata oluştu.");
        //}

        public User UserActivate(Guid activateId)
        {
            var user = _userDal.Get(x => x.ActiveGuid == activateId);
            if (user != null)
            {
                if (user.IsActive == true)
                {
                    throw new Exception("Kullanıcı zaten aktif");
                }
                user.IsActive = true;
                _userDal.Update(user);
                return user;
            }
            else
            {
                throw new Exception("Aktifleştirilecek kullanıcı bulunmadı");
            }

        }

        public User GetUserByInfo(string email, string userName)
        {
            var user = _userDal.Get(x => x.Email == email && x.UserName == userName);
            return user;
        }

        public User GetByMail(string email)
        {
            var data = _userDal.Get((u => u.Email == email));
            return data;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User RegisterUser(RegisterDto data)
        {
            throw new NotImplementedException();
        }
    }
}