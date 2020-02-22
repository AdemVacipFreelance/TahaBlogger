using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
  public  class Like:IEntity
    {
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
}
