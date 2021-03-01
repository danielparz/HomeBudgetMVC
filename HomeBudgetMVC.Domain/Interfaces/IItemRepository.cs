using HomeBudgetMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeBudgetMVC.Domain.Interfaces
{
    public interface IItemRepository
    {
        void DeleteItem(int itemId);
        int AddItem(Item item);

        IQueryable<Item> GetItemsByCategoryId(int categoryId);
        Item GetItemById(int itemId);
        IQueryable<Item> GetItemsByDate(int month, int year);
        int UpdateItem(Item item);
        IQueryable<Item> GetAllItems();
    }
}
