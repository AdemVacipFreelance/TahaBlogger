using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.Models;
using TahaBloggerProject.Entities.ValueObjectsDTO;

namespace TahaBloggerProject.Business.Abstract
{
 public  interface IUserService
    {
        User RegisterUser(RegisterDto data);

        User LoginUser(LoginDto data);

        bool IsUserCheck(string email,string userName);
    }
}
