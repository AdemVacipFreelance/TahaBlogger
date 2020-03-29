using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class PostDal : EntityRepositoryBase<Post, TahaBlogDbContext>, IPostDal
    {
    }
}