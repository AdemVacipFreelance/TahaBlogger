using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
    public interface IPostDal
    {
        List<Post> GetList(Expression<Func<Post, bool>> filter = null);
        Post Get(Expression<Func<Post, bool>> filter);
        Post Add(Post entity);
        Post Update(Post entity);
        void Delete(Post entity);
    }
}
