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

        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}
