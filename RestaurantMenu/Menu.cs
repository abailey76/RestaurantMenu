using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Menu
    {
        public DateTime DateTime { get; set; }

        public string Name { get; set; }    

        public List<Item> Items { get; set; }

        public Menu(string name)
        {
            DateTime = DateTime.Now;
            Name = name;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine($"{Name} {DateTime}");
            foreach (Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
    
}
