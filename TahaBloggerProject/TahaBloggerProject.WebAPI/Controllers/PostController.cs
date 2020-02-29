using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Entities.DTOS;
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
        public Post PostGetByPostId(int postId)
        {
            var postItem = _postService.PostGetByPostId(postId);

            return postItem;
        }
        
     

        [HttpPost("AddNewPost")]
        public void AddNewPost(PostDto post)
        {
            _postService.Add(post);
        }

        [HttpPost("UpdatePost")]
        public void UpdatePost(PostUpdateDto postUpdateDto)
        {
            _postService.Update(postUpdateDto);
        }
    }

}
