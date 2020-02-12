using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.Models
{
   public  class User
    {
        public int UserId { get; set; }
        public string Name  { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfileImageFileName { get; set; }
        public string ActiveGuid { get; set; }
        public bool IsActive { get; set; }

        public  virtual List<Role> Roles { get; set; }
    
    }
}
