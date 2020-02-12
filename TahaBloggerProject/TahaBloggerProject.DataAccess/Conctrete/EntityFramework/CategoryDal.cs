using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class CategoryDal : ICategoryDal
    {
        private readonly TahaBlogDbContext _dbContext;
        public CategoryDal(TahaBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category Add(Category entity)
        {
            _dbContext.Category.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(Category entity)
        {
            _dbContext.Category.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _dbContext.Category.Where(filter).FirstOrDefault();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            if (filter != null)
                return _dbContext.Category.Where(filter).ToList();
            return _dbContext.Category.ToList();
        }

        public Category Update(Category entity)
        {
            _dbContext.Category.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
