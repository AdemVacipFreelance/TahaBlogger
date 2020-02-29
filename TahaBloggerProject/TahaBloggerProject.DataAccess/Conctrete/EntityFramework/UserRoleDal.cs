using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.ComplexTypes;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class UserRoleDal : EntityRepositoryBase<UserRole, TahaBlogDbContext>, IUserRoleDal
    {
        public UserRoleInfo GetUserRoleInfo(int userId)
        {
            using (var dbContext =new TahaBlogDbContext())
            {
                var data = from ur in dbContext.UserRole
                        join us in dbContext.User
                        on ur.UserId equals us.UserId
                        join r in dbContext.Role
                        on ur.RoleId equals r.RoleId
                        where ur.UserId == userId

                        select new UserRoleInfo { RoleId = r.RoleId, RoleName = r.RoleName, UserName = us.UserName };
                       return data.FirstOrDefault();

            }
        }
    }
}
