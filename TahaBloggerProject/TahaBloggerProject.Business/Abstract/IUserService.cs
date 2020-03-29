using System;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface IUserService
    {
        User RegisterUser(RegisterDto data);

        User LoginUser(LoginDto data);

        bool IsUserCheck(string email, string userName);

        User UserActivate(Guid activateId);

        User GetUserByInfo(string email,string userName);
    }
}