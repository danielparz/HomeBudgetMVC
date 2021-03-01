using HomeBudgetMVC.Domain.Interfaces;
using HomeBudgetMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudgetMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;

        public ItemRepository(Context context)
        {
            _context = context;
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if(item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetItemsByCategoryId(int categoryId)
        {
            var items = _context.Items.Where(i => i.CategoryId == categoryId);
            return items;
        }

        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }

        public IQueryable<Item> GetItemsByDate(int month, int year)
        {
            var items = _context.Items.Where(i => i.Date.Month == month && i.Date.Year == year);
            return items;
        }

        public int UpdateItem(Item item)
        {
            var itemToUpdate = _context.Items.Update(item);
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetAllItems()
        {
            var items = _context.Items;
            return items;
        }
    }
}
