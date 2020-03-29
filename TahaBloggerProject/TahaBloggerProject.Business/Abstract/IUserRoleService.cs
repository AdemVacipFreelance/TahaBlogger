using TahaBloggerProject.Entities.ComplexTypes;

namespace TahaBloggerProject.Business.Abstract
{
    public interface IUserRoleService
    {
        UserRoleInfo GetUserRole(int userId);
    }
}