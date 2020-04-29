using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TahaBloggerProject.Entities.Dtos
{
    public class RegisterDto
    {
       
        public string Username { get; set; }

      
        public string EMail { get; set; }

        
        public string Password { get; set; }

       
        public string RePassword { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
