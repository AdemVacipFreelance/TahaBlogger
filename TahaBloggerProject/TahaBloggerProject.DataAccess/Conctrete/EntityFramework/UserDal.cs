using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public interface UserDal : EntityRepositoryBase<UserRole, TahaBlogDbContext>, IUserDal
    {
      

     
    }
}
