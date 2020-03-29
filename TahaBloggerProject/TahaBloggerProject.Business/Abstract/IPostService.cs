using System.Collections.Generic;
using System.Linq;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetPosts();

        IQueryable<Post> GetPost();

        Post Add(PostDto postDto);

        Post PostGetByPostId(int postId);

        Post GetPostByPostId(int postid);

        Post Update(PostUpdateDto postUpdateDto);
    }
}