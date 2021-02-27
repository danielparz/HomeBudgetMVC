using HomeBudgetMVC.Domain.Interfaces;
using HomeBudgetMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudgetMVC.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public int AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category.Id;
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            if(category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            return category;
        }

        public IQueryable<Category> GetAllCategories()
        {
            var categories = _context.Categories;
            return categories;
        }

        public IQueryable<Category> GetSubcategoryByParentCategoryId(int parentCategoryId)
        {
            var subcategories = _context.Categories.Where(s => s.ParentCategoryId == parentCategoryId);
            return subcategories;
        }

        public void ChangeCategoryColorByCategoryId(int categoryId, string color)
        {
            var category = GetCategoryById(categoryId);
            category.Color = color;
        }

        public int AddSubcategoryByParentCategoryId(int parentCategoryId, Category subcategory)
        {
            var parentCategory = GetCategoryById(parentCategoryId);
            subcategory.ParentCategory = parentCategory;
            subcategory.ParentCategoryId = parentCategory.Id;
            _context.Categories.Add(subcategory);
            return subcategory.Id;
        }

        public int UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category.Id;
        }
    }
}
