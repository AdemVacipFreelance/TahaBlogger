using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
   public interface ICategoryDal
    {
        List<Category> GetList(Expression<Func<Category, bool>> filter = null);
        Category Get(Expression<Func<Category, bool>> filter);
        Category Add(Category entity);
        Category Update(Category entity);
        void Delete(Category entity);
    }
}
