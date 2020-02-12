using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
   public interface IUserDal
    {
        List<User> GetList(Expression<Func<User, bool>> filter = null);
        User Get(Expression<Func<User, bool>> filter);
        User Add(User entity);
        User Update(User entity);
        void Delete(User entity);
    }
}
