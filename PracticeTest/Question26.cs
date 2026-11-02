using System;

namespace PracticeTest
{
    public class Employee
    {
        public int EmployeeId;
        public string Name;
        public string Email;

        public Employee(int id, string name, string email)
        {
            EmployeeId = id;
            Name = name;
            Email = email;
        }

        public virtual void Display()
        {
            Console.WriteLine("Employee ID : " + EmployeeId);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Email : " + Email);
        }
    }
    public class Manager : Employee
    {
        public string Department;
        public int TeamSize;

        public Manager(int id, string name, string email,
                       string department, int teamSize)
            : base(id, name, email)
        {
            Department = department;

            if (teamSize < 0)
            {
                TeamSize = 0;
            }
            else
            {
                TeamSize = teamSize;
            }
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Department : " + Department);
            Console.WriteLine("Team Size : " + TeamSize);
        }
    }

    internal class Question26
    {
        public void Funct()
        {
            Employee emp1 =
                new Employee(101, "Deep", "deep@test.com");

            Employee emp2 =
                new Employee(102, "Rahul", "rahul@test.com");

            Manager mgr1 =
                new Manager(201, "Vikas",
                            "vikas@test.com",
                            "Engineering", 10);

            Manager mgr2 =
                new Manager(202, "Namrata",
                            "namrata@test.com",
                            "Product", 15);

            Employee[] directory =
            {
                emp1,
                emp2,
                mgr1,
                mgr2
            };

            foreach (Employee employee in directory)
            {
                employee.Display();
            }
        }
    }
}