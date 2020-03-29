using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.DTOS
{
   public class PostUpdateDto
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
