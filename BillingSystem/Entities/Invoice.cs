using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceingSystem.Entities
{
    internal class Invoice
    {
        public int Id { get; set; }
        public List<int> Meal { get; set; }
        public decimal TotalPrice { get; set; }

        public Invoice(int id, List<int> meal)
        {
            Id = id;
            Meal = meal;
        }

    }
}
