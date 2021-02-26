using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetMVC.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public string Adnotation { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
