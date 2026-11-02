using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeTest
{
    internal class Question3
    {
        decimal[][] decArray = new decimal[][]
        {
            new decimal[]
            {
                12000, 9000, 5000, 7000
            },
            new decimal[]
            {
                8000, 11000, 6000, 9500
            },
            new decimal[]
            {
                15000, 7000, 8500, 4000
            }
        };

        public void Branches()
        {
            decimal highestTotal = decimal.MinValue;
            for (int i = 0; i < decArray.Length; i++)
            {
                decimal total = 0;
                decimal highest = decimal.MinValue;

                for (int j = 0; j < decArray[i].Length; j++)
                {

                    total += decArray[i][j];
                    highest = Math.Max(highest, decArray[i][j]);
                }
                highestTotal = Math.Max(highestTotal, total);
                Console.WriteLine($"Total of branch {i+1} is {total} and highest value in this branch is {highest}");
            }

            Console.WriteLine("Highest total in all branches is "+highestTotal);
        }

        public void Category()
        {
            decimal highestTotal = 0;
            for (int i = 0;i < decArray[0].Length; i++)
            {
                decimal total = 0;
                for (int j = 0;j < decArray.Length; j++)
                {
                    total += decArray[j][i];
                }
                highestTotal = Math.Max(highestTotal, total);
                Console.WriteLine("Total of the category is "+ total) ;
            }
            Console.WriteLine("Highest total in all catgeory is "+highestTotal);
        }

        public void Update()
        {
            Console.WriteLine("Select row to update : (enter 1 for yes 0 for no)");
            int choice1 = 0;
            for (int i = 0; i<decArray.Length ; i++)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                for (int j = 0;j<decArray[i].Length; j++)
                {
                    Console.Write(" " + decArray[i][j] +" ");
                }
                if(choice == 1)
                {
                    choice1 = i;
                    break;
                }
            }

            Console.WriteLine("Enter value you want to update");
            decimal value = Convert.ToDecimal(Console.ReadLine());
            for(int i = 0; i< decArray[choice1].Length ; i++)
            {
                if(decArray[choice1][i] == value)
                {
                    Console.WriteLine($"Enter value to change at place of {value}");
                    decimal value1 = Convert.ToDecimal(Console.ReadLine());
                    decArray[choice1][i] = value1;
                }
            }
        }
    }
}
