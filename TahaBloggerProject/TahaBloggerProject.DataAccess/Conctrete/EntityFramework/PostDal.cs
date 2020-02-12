using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class PostDal : IPostDal
    {
        private readonly TahaBlogDbContext _dbContext;
        public PostDal(TahaBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Post Add(Post entity)
        {
            _dbContext.Post.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(Post entity)
        {
            _dbContext.Post.Remove(entity);
            _dbContext.SaveChanges();
          
        }

        public Post Get(Expression<Func<Post, bool>> filter)
        {
            return _dbContext.Post.Where(filter).FirstOrDefault();
        }

        public List<Post> GetList(Expression<Func<Post, bool>> filter = null)
        {
            if (filter!=null)
                return _dbContext.Post.Where(filter).ToList();
            return _dbContext.Post.ToList();
           
        }

        public Post Update(Post entity)
        {
            _dbContext.Post.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
