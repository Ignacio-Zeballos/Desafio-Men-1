using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public Dish GetDishByName(string dish)
        {
            foreach (Dish d in dishes)
            {
                if (d.Name == dish)
                {
                    return d ;
                }
            }
            return null;
        }
    }
}