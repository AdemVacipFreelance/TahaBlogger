using TahaBloggerProject.Core.DataAccess;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
    }
}