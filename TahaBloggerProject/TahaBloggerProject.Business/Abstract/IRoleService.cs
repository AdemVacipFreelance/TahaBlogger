using System.Collections.Generic;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();

        Role GetRoleById(int roleId);

        Role Insert(Role role);

        Role UpdateRole(Role role);

        void RemoveRole(Role role);
    }
}