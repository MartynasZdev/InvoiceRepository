using InvoiceingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceingSystem.Repositories
{
internal class MealRepository
{
    public List<Meal> Meals { get; set; }
    public MealRepository()
    {
            Meals = new List<Meal>
            {
                new Meal(1, "Fish", 5, "Eur"),
                new Meal(2, "Chips", 2, "Eur"),
                new Meal(3, "Cola", 1, "Eur"),
                new Meal(4, "Fries", 1, "Eur"),
                new Meal(5, "Cheese", 1, "Eur")
            };

        }
    }
}
