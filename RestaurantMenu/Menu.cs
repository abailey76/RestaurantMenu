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
            if (Items.Contains(item))
            {
                Console.WriteLine("Hey Ding Dong...that's already on the menu!!");
            }
            else
            {
                Items.Add(item);
            }
            
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine($"\n\n\t\t{Name} {DateTime}\n\n");

            foreach (string category in Item.categoryOptions)
            {
                Console.WriteLine("\t" + category.ToUpper() + "\n");
                foreach (Item item in Items) //if item.name.length(or count) is less than 40, take the delta and append white space to even out lengths
                                             //https://stackoverflow.com/questions/15851730/adding-whitespaces-to-a-string-in-c-sharp
                                             //https://stackoverflow.com/questions/10870037/how-to-add-certain-number-of-whitespaces-to-stringbuilder
                {
                    if (item.Category == category)
                    {
                        while (item.Name.Length < 20)
                        {
                            item.Name += " ";
                        }

                        while (item.Description.Length < 45)
                        {
                            item.Description += " ";
                        }
                        if (item.IsNew)
                        {
                            Console.WriteLine($"\t\t{item.Name} {item.Description} ${item.Price} \t!! NEW ITEM !!\n");
                        } 
                        else
                        {
                            Console.WriteLine($"\t\t{item.Name} {item.Description} ${item.Price}\n");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
