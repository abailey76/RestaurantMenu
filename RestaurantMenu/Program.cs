using System;

namespace RestaurantMenu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem borger = new MenuItem("Borger", 4.20, "Tasty Borger", "Borger", true);

            Console.WriteLine(borger.Description);
        }
    }
}
