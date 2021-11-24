using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }

        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItem> items, DateTime lastUpdated)
        {
            Items = items;
            LastUpdated = lastUpdated;
        }
    }
}
