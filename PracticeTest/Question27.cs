using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeTest
{
    public class Item
    {
        public string itemName;
        public int quantity;
        public string? additionalInstruction;

        public Item(string name, int quan, string? instruct)
        {
            itemName = name;
            quantity = quan;
            additionalInstruction = instruct;
        }
    }

    internal class Restaurent
    {
        ArrayList array = new ArrayList();

        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Burger",150},
            {"Pizza",250},
            {"Coffee",80}
        };
        public void AddItem(string itemName)
        {
            AddItem(itemName, 1);
        }
        public void AddItem(string itemName, int quantity)
        {
            if (!menu.ContainsKey(itemName))
            {
                Console.WriteLine("Invalid Item");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0");
                return;
            }

            Item item = new Item(itemName, quantity, null);
            array.Add(item);
        }
        public void AddItem(string itemName, int quantity, string instruction)
        {
            if (!menu.ContainsKey(itemName))
            {
                Console.WriteLine("Invalid Item");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0");
                return;
            }

            Item item = new Item(itemName, quantity, instruction);
            array.Add(item);
        }

        public void DisplayOrder()
        {
            double total = 0;

            foreach (Item item in array)
            {
                double price = menu[item.itemName];
                double lineTotal = price * item.quantity;

                Console.WriteLine(
                    item.itemName +
                    " Qty:" + item.quantity +
                    " Price:" + price +
                    " Total:" + lineTotal);

                if (!string.IsNullOrEmpty(item.additionalInstruction))
                {
                    Console.WriteLine(
                        "Instruction: " +
                        item.additionalInstruction);
                }

                total += lineTotal;
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Grand Total : " + total);
        }
    }

    internal class Question27
    {
        public void Funct()
        {
            Restaurent r = new Restaurent();

            r.AddItem("Burger");

            r.AddItem("Pizza", 2);

            r.AddItem("Coffee", 3, "Less Sugar");

            r.DisplayOrder();
        }
    }
}