﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.Models
{
   public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
        public DateTime PublishDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<PostImages> Images { get; set; }
    }
}