using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TahaBloggerProject.Business.Abstract;
using TahaBloggerProject.Entities.DTOS;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.WebAPI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        ///// <summary>
        ///// Listeleme işlemi
        ///// </summary>
        ///// <returns>Tüm Listeyi geri döndürür</returns>
        ///// <response code="201">Returns list of category</response>
        ///// <response code="400">The items is null</response>
        [HttpGet("ListOfCategory")]
        [ProducesResponseType(201)] //Kullanıcıya daha iyi bilgi sunmak için
        [ProducesResponseType(400)]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetAllCategories();
        }

        [HttpGet("GetCategoryInfo")]
        public Category CategoryGetById(int categoryId)
        {
            var categoryItem = _categoryService.GetCategoryById(categoryId);
            return categoryItem;
        }

        [HttpPost("AddNewCategory")]
        public void AddNewCategory(CategoryDto category)
        {
            _categoryService.Insert(category);
        }
    }
}