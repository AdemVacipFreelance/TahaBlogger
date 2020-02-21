using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
  public  class Role:IEntity
    { 
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
