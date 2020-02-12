using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.Models
{
   public  class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public bool IsApprove { get; set; }
        public DateTime PublishDate { get; set; }
        public int  LikeCount { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
