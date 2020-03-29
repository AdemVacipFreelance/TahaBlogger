using TahaBloggerProject.Core.DataAccess;
using TahaBloggerProject.Entities.ComplexTypes;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
    public interface IUserRoleDal : IEntityRepository<UserRole>
    {
        UserRoleInfo GetUserRoleInfo(int userId);
    }
}