using HomeBudgetMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudgetMVC.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        public int AddCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int categoryId);
        IQueryable<Category> GetAllCategories();
        IQueryable<Category> GetSubcategoryByParentCategoryId(int parentCategoryId);
        void ChangeCategoryColorByCategoryId(int categoryId, string color);
        int AddSubcategoryByParentCategoryId(int parentCategoryId, Category subcategory);
        int UpdateCategory(Category category);
    }
}
