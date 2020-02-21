using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.ComplexTypes;

namespace TahaBloggerProject.Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }
        public UserRoleInfo GetUserRole(int userId)
        {
            var data = _userRoleDal.GetUserRoleInfo(userId);
            return data;
        }
    }
}
