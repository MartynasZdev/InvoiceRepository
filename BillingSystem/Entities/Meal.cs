using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceingSystem.Entities
{
    internal class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }

        public Meal(int id, string name, int price, string currency)
        {
            Id = id;
            Name = name;
            Price = price;
            Currency = currency;
        }
    }
}
