using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeTest
{
    internal class Question6
    {
        public void Function()
        {
            var itemCode = 234;
            var quantity = 10;
            var unitPrice = 45.00;
            int[] quantities = new int[]
            {
                10,23,23,1,2,32,32,1,21,23
            };

            int inventoryValue = 0;

            foreach(var item in quantities)
            {
                inventoryValue = item * (int)unitPrice;
            }

            Console.WriteLine($"Inventory value is {inventoryValue}");
            Console.WriteLine($"Data type of itemCode is {itemCode.GetType()}");
            Console.WriteLine($"Data type of quantity is {quantity.GetType()}");
            Console.WriteLine($"Data type of unitPrice is {unitPrice.GetType()}");
            Console.WriteLine($"Data type of unitPrice is {quantities.GetType()}");


            itemCode = 24;
            quantity = 120;
            unitPrice = 45.008768347;
            //quantity = 2.3; error
        }
    }
}
