using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
   public  class Comment:IEntity
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public bool IsApprove { get; set; }
        public DateTime PublishDate { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
      
    }
}
