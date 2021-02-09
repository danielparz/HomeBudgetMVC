using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetMVC.Domain.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
