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

        public DateTime DateTime { get; }

        public bool IsNew { get; set; }

        public static List<string> categoryOptions = new List<string> { "Appetizer", "Main Course", "Dessert" };
        internal bool isNew;

        public Item(string name, string category, string description, double price, bool isNew)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            DateTime = DateTime.Now;
            IsNew = isNew;
        }

        public Item(string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            DateTime = DateTime.Now;
            IsNew = false;
        }

        public override string ToString()
        {
            if (IsNew)
            {
                return $"{Name} {Description} ${Price} **!!NEW ITEM!!**";
            } 
            else
            {
                return $"{Name} {Description} ${Price}";
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
