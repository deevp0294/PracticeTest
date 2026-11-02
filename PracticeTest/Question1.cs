using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Values
    {
        public bool paid = true;
        public int number = 1001;
        public decimal total = 2499.50m;
    }
    internal class Question1
    {
        public void Question()
        {
            Values v = new Values();

            List<object> array = new List<object>();
            array.Add(v);
            array.Add(v.number);
            array.Add(v.total);
            array.Add(v.paid);

            Console.WriteLine($"Type of item originally : ");
            Console.WriteLine("Number : "+v.number.GetType());
            Console.WriteLine("Total : "+v.total.GetType());
            Console.WriteLine("Paid : "+v.paid.GetType());

            Console.WriteLine($"Type of item when stored in arraylist : ");

            foreach(var item in array)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
