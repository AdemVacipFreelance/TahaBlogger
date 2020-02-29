using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        Category Insert(CategoryDto category);

    }
}
