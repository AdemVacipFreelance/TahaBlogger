using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
   public interface IPostService
    {
        List<Post> GetPosts();
        IQueryable<Post> GetPost();

        Post Add(Post post);

        Post GetPostByPublisherUserId(int userid);

        Post Update(Post post);


         
    }
}

