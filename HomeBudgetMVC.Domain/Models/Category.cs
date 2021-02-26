using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetMVC.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
