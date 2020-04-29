using System.Collections.Generic;
using TahaBloggerProject.Core.DataAccess;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}