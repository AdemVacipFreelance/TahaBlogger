using System.Collections.Generic;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAllComments()
        {
            return _commentDal.GetList();
        }

        public Comment GetCommentsById(int commentId)
        {
            return _commentDal.Get(x => x.CommentId == commentId);
        }

        public Comment Insert(Comment comment)
        {
            return _commentDal.Add(comment);
        }
    }
}