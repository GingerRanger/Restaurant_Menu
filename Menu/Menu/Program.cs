using System;

namespace Menu
{
        public class Menu_Item
    {
        private double Price;
        private string Description;
        private string Category;
      

        public DateTime DateAdded { get; set; }
        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - DateAdded;
                return timeSpan.Days;
            }
        }

        public Menu_Item(double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;

        }
        public void ShowMenuItem()
        {
            Console.WriteLine($"${this.Price}. {this.Description}, a delicious {this.Category}!");
            if(Age<=30)
            {
                Console.WriteLine("NEW!!!");
            }
        }


    }
    class Menu
    {
        static void Main(string[] args)
        {
            Menu_Item Menu_Item1 = new Menu_Item(7.49, "Nachos", "Appetizer");
            Menu_Item1.DateAdded = new DateTime(2021, 6, 27);
            Menu_Item Menu_Item2 = new Menu_Item(10.49, "Pizza", "Main course");
            Menu_Item2.DateAdded = new DateTime(2021, 5, 27);
            Menu_Item1.ShowMenuItem();
            Menu_Item2.ShowMenuItem();



        }
    }


}
