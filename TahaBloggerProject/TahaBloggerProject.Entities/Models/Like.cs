using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.Models
{
  public  class Like
    {
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
}
