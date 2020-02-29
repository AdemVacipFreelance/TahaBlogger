using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class PostManager : IPostService
    {

        private readonly IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public Post Add(PostDto postDto)
        {
            var post = new Post()
            {
                CategoryId = postDto.CategoryId,
                UserId = postDto.UserId,
                Content = postDto.Content,
                PublishDate = DateTime.Now,
                Title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(postDto.Title)

            };

            return _postDal.Add(post);

        }


        public IQueryable<Post> GetPost()
        {
            throw new NotImplementedException();
        }

        public Post GetPostByPostId(int postid)
        {
            throw new NotImplementedException();
        }

        public Post PostGetByPostId(int postId)
        {
            return _postDal.Get(x => x.PostId == postId);
        }

        public List<Post> GetPosts()
        {
            return _postDal.GetList();
        }

        public Post Update(PostUpdateDto postUpdateDto)
        {
            if (IsPostExist(postUpdateDto.PostId))
            {
                var post = new Post()
                {
                    CategoryId =postUpdateDto.CategoryId,
                    UserId=postUpdateDto.UserId,
                    PostId=postUpdateDto.PostId,
                    Content=postUpdateDto.Content,
                    PublishDate=DateTime.Now,
                    Title=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(postUpdateDto.Title)
                };

                return _postDal.Update(post);

            }
            throw new Exception("Bu id ye ait Post bulunamamıştır. Lütfen id bilgilerini kontrol ediniz");


        }

        public bool IsPostExist(int postid)
        {
            var post = _postDal.Get(x => x.PostId == postid);
            if (post != null)

                return true;

            return false;

        }
    }
}
