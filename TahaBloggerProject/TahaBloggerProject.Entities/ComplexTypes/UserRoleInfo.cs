using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.ComplexTypes
{
    //İşimizi görecek bir sanal nesne
 public   class UserRoleInfo
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
    }
}
