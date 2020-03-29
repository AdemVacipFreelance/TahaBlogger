using System.Collections.Generic;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAllComments();

        Comment GetCommentsById(int commentId);

        Comment Insert(Comment comment);
    }
}