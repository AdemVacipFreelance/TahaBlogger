using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
   public class UserRole:IEntity
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
