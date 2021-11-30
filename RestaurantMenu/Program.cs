using System;

namespace RestaurantMenu
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Alice's Restaurant: You can get anything you want...");
            Item item1 = new Item("Pecan Pie", "Dessert", "Our word-famous, top secret recipe.", 2.99);
            Item item2 = new Item("Turkey Meatloaf", "Main Course", "Basically, it's a tryptophan grenade.", 5.99, true);
            Item item3 = new Item("Chop Salad", "Appetizer", "Probably the healthiest thing on the menu.", 3.99, true);
            Item item4 = new Item("Chocolate Ice Cream", "Dessert", "Everyone's favorite flavor.", 1.99, true);
            Item item5 = new Item("Spicy Turkey Bowl", "Main Course", "The OTHER kickin' chicken", 5.99);
            Item item6 = new Item("Fried Cheese Sticks", "Appetizer", "Who doesn't love deep fried cheese?", 4.99);
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.AddItem(item3);
            menu.AddItem(item4);
            menu.AddItem(item5);
            menu.AddItem(item6);
            menu.PrintMenu();
        }
    }
}