using TahaBloggerProject.Core.DataAccess.EntityFramework;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class CategoryDal : EntityRepositoryBase<Category, TahaBlogDbContext>, ICategoryDal
    {
    }
}