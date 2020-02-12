using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class UserDal : IUserDal
    {
        private readonly TahaBlogDbContext _dbContext;
        public UserDal(TahaBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Add(User entity)
        {
            _dbContext.User.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(User entity)
        {
            _dbContext.User.Remove(entity);
            _dbContext.SaveChanges();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _dbContext.User.Where(filter).FirstOrDefault();
        }

        public List<User> GetList(Expression<Func<User, bool>> filter = null)
        {
            if (filter != null)
                return _dbContext.User.Where(filter).ToList();
            return _dbContext.User.ToList();
        }

        public User Update(User entity)
        {
            _dbContext.User.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
