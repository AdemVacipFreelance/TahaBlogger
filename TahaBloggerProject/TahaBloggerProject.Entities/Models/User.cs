﻿using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
   public  class User:IEntity
    {
        public int UserId { get; set; }
        public string Name  { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfileImageRootName { get; set; }
        public string ActiveGuid { get; set; }
        public bool IsActive { get; set; }

        //Bu genelde codefirst için tablo ilişkileri için. Migration işlemlerinde kullanılır.
        public  virtual List<Role> Roles { get; set; }
    
    }
}
