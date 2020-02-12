using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
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
        public Post Add(Post post)
        {
            return _postDal.Add(post);

        }


        public IQueryable<Post> GetPost()
        {
            throw new NotImplementedException();
        }

        public Post GetPostByPublisherUserId(int userid)
        {
            return _postDal.Get(x => x.UserId == userid);
        }

        public List<Post> GetPosts()
        {
            return _postDal.GetList();
        }

        public Post Update(Post post)
        {
            return _postDal.Update(post);
        }
    }
}
