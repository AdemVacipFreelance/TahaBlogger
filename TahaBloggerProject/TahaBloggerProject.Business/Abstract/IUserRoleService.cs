using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.ComplexTypes;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
   public interface IUserRoleService
    {
        UserRoleInfo GetUserRole(int userId);
    }
}
