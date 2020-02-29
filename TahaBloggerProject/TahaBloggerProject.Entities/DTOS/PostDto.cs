using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Entities.DTOS
{
 public   class PostDto
    {
       

        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

    }
}
