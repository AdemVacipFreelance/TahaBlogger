using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal ;
        }
        public List<Category> GetAllCategories()
        {
          return  _categoryDal.GetList(); //ICatDaldan alıyor GetListi.
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categoryDal.Get(x => x.CategoryId == categoryId);
        }

        public Category Insert(Category category)
        {
            return _categoryDal.Add(category);
        }
    }
}
