using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Customer(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
    internal class Question11
    {
        Customer customer1 = new Customer(1,"Divyarth","jgxfghfvgs");
        Customer customer2 = new Customer(1,"Divyarth","jgxfghfvgs");

        public void Show()
        {
            var customer3 = customer1;
            if (customer1 == customer2) Console.WriteLine("== is giving true");
            if (customer1.Equals(customer2)) Console.WriteLine("equals is giving true");

            string code = customer1.ToString();
            string code1 = customer2.ToString();

            if (code == code1) Console.WriteLine("== is giving true after tostring");
            if (code.Equals(code1)) Console.WriteLine("equals is giving true after tostring");
        }
    }
}
