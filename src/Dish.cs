using System.Reflection.Metadata.Ecma335;

namespace Ucu.Poo.Restaurant
{
    public class Dish
    {
        private string name;
        public string Name
        {
            get {return name;} set {name = value;}
        }
        private double price;
        public double Price
        {
            get {return price;} set{price = value; }
        }
        private bool isvegetarian;
        public bool IsVegetarian
        {
            get {return isvegetarian;} set{ isvegetarian= value;}
        }
        public Dish (string name, double price, bool isvegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isvegetarian;
        }
    }
}