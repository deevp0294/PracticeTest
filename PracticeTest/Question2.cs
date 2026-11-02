using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    internal class Question2
    {
        int[] array = new int[]
        {
            12500, 9800, 15400, 8700, 19100, 16800 , 11200
        };
        bool[] targetMet = new bool[7];

        public void AcceptAndCompoare()
        {

            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (target <= array[i])
                {
                    targetMet[i] = true;
                }
            }

            for (int i = 0; i < targetMet.Length; i++)
            {
                if (targetMet[i])
                {
                    Console.WriteLine($"Daily sales target met on day {i + 1}");
                }
                else
                {
                    Console.WriteLine("Target felt short");
                }
            }
        }

        public void Aggregated()
        {
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            int total = 0;

            foreach (int i in array)
            {
                if (highest <= i)
                {
                    highest = i;
                }

                if (lowest >= i)
                {
                    lowest = i;
                }

                total += i;
            }

            int avg = total / array.Length;

            Console.WriteLine("\n\nHighest is " + highest);
            Console.WriteLine("Lowest is " + lowest);
            Console.WriteLine("Total is " + total);
            Console.WriteLine("Average is " + avg);
        }
    }
}
