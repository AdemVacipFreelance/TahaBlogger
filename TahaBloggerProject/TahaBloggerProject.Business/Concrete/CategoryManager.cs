using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.DataAccess.Abstract;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;
using System.Globalization;

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

        public Category Insert(CategoryDto categoryDto)
        {
            if (!IsCategoryCheck(categoryDto.Title))
            {
                var category = new Category()
                {
                    Description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(categoryDto.Description),
                    Title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(categoryDto.Title)
                };
                return _categoryDal.Add(category);

            }
            throw new Exception("Girdiğiniz Kategori bilgilerini kontrol ediniz");
        }
        public bool IsCategoryCheck(string title)
        {
            var data = _categoryDal.Get(x=>x.Title ==title);

            if (data != null)
                return true;
            return false;

        }
     


    }
}
