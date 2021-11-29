using System;

namespace RestaurantMenu
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Adam's Restaurant");
            Item item1 = new Item("Turkey Taco", "Main Course", "Gobble Gobble", 12.99);
            Item item2 = new Item("Turkey Sandwich", "Main Course", "Gobble Gobble Gobble", 12.99);
            Item item3 = new Item("Turkey Taco Salad", "Main Course", "Gobble Gobble Gobble Gobble", 12.99);            
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);
        }
    }
}