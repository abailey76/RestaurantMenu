using System;

namespace RestaurantMenu
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Adam's Restaurant");
            Item item1 = new Item("Turkey Taco", "Dessert", "Made with genuine Thanksgiving leftovers", 12.99);
            Item item2 = new Item("Turkey Sandwich", "Main Course", "Tryptophan on a Bun", 12.99);
            Item item3 = new Item("Turkey Salad", "Appetizer", "Thanksgiving Starter", 12.99, true);            
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.AddItem(item3);
            menu.PrintMenu();
        }
    }
}