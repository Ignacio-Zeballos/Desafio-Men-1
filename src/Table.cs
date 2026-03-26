using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        private string number;
        public string Number
        {
            get {return number;} set{number= value;}
        }
        private bool isoccupied;
        public bool IsOccupied
        {
            get {return isoccupied;} set{isoccupied = value;}
        }
        public Table(string number)
        {
            this.Number= number;
            this.IsOccupied = false;
        }
        public void Occupy()
        {
            this.IsOccupied = true;
        }
        public void Free()
        {
            this.IsOccupied= false;
            order.Clear();
        }
        public void AddToOrder(Dish dish)
        {
             order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}