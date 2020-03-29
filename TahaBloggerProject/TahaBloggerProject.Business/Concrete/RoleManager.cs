using System.Collections.Generic;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetAllRoles()
        {
            var data = _roleDal.GetList();
            return data;
        }

        public Role GetRoleById(int roleId)
        {
            var data = _roleDal.Get(x => x.RoleId == roleId);
            return data;
        }

        public Role Insert(Role role)
        {
            var data = _roleDal.Add(role);
            return data;
        }

        public void RemoveRole(Role role)
        {
            _roleDal.Delete(role);
        }

        public Role UpdateRole(Role role)
        {
            var data = _roleDal.Update(role);
            return data;
        }
    }
}