using System.Collections.Generic;
using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;
using System.Linq;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class UserDal : EntityRepositoryBase<User, TahaBlogDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new TahaBlogDbContext())
            {
                var result = from operationClaim in context.OperationClaim
                             join userOperationClaim in context.UserOperationClaim
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}