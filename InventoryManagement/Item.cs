using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InventoryManagement
//Create an application which manages an inventory of products.
//Create a product class which has a price, id, and quantity on hand.
//Then create an inventory class which keeps track of various products and can sum up the inventory value.
{
    public class Item // item object class
    {
        public string value;
        public string items;
        public string number;

        public Item(string price, string name, string amount)
        {
            value = price;
            items = name;
            number = amount;
        }

        

    }



    class AddItem // add item class
    {
        static List<Item> Items = new List<Item>(); // list of items


        static void AddNewItem()
        {
            Console.WriteLine("Add new item? yes/no"); // ask if they want to add a new item
            string Answer = Console.ReadLine();
            if (Answer == "yes")
            {
                Console.Clear();
                Console.WriteLine("Please give the price of the object");
                var price = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Please give the name of the object");
                var name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Please give the amount of object's");
                var amount = Console.ReadLine();

                var item1 = new Item(price, name, amount);
                Items.Add(item1); // add new item to list
                
            }
            else // if no then stop application
            {
                Console.Clear();
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine(Items[i].value + " = price / " + Items[i].items + " = name / " + Items[i].number + " = amount / ");
                    using (StreamWriter writer = new StreamWriter(@"D:\projects\c#practis\rapidfire\ProductInventory\InventoryManagement\InventoryManagement\InventoryManagement\ProductList.txt", true))
                    {
                        writer.WriteLine(Items[i].value + " = price / " + Items[i].items + " = name / " + Items[i].number + " = amount / ");
                    }
                    //save item list to text file on application close
                }
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();
            for (int i = 0; i < Items.Count; i++) // show all items and values
            {
                Console.WriteLine(Items[i].value + " = price / " + Items[i].items + " = name / " + Items[i].number + " = amount / ");
            }
            AddNewItem(); //repeat previous actions
        }
        
        static void Main()
        {
            AddNewItem();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}