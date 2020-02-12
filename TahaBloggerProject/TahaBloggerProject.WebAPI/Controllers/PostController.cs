using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class PostController:Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet("PostList")]
        public List<Post> GetAllPosts()
        {

            return _postService.GetPosts();
        }

        [HttpGet("GetPostInfo")]
        public Post PostGetByUserId(int userId)
        {
            var postItem = _postService.GetPostByPublisherUserId(userId);

            return postItem;
        }
     

        [HttpPost("AddNewPost")]
        public void AddNewPost(Post post)
        {
            _postService.Add(post);
        }

        [HttpPost("UpdatePost")]
        public void UpdatePost(Post post)
        {
            _postService.Update(post);
        }
    }

}
