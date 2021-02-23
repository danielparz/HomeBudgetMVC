using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetMVC.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubcategoryId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public virtual Subcategory Subcategory { get; set; }
    }
}
