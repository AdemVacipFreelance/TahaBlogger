using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
   public class RoleDal:EntityRepositoryBase<Role,TahaBlogDbContext>,IRoleDal
    {
    }
}
