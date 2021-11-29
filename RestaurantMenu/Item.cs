using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Item
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime dateTime { get; }

        public bool IsNew { get; set; }

        public static List<string> categoryOptions = new List<string> { "Appetizer", "Main Course", "Dessert" };

        public Item(string name, string category, string description, double price, bool isNew)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            dateTime = DateTime.Now;
            IsNew = isNew;
        }

        public Item(string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            dateTime = DateTime.Now;
            IsNew = false;
        }
    }
}
