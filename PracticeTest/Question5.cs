using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace PracticeTest
{
    public class EmployeeInfo
    {
        public int ID;
        public int? age;
        public double? bonusAmount;
        public DateTime? joiningDate;

        public EmployeeInfo(int Id, int? age, double? bonusAmount, DateTime? joiningDate)
        {
            this.ID = Id;
            this.age = age;
            this.bonusAmount = bonusAmount;
            this.joiningDate = joiningDate;
        }
    }
    internal class Question5
    {
        List<EmployeeInfo> employees = new List<EmployeeInfo>();
        List<EmployeeInfo> toUpadteEmployees = new List<EmployeeInfo>();

        public void input()
        {
            bool choice = false;
            do
            {
                Console.WriteLine("Enter employee info : (id, age, bonus, joining date)");
                int id = Convert.ToInt32(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());
                double bonus = Convert.ToDouble(Console.ReadLine());
                DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());
                employees.Add(
                new EmployeeInfo(id, age, bonus, joiningDate)
                 );
                Console.WriteLine("Do you want to add another employee");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 0) choice = false;
                if (choice1 == 1) choice = true;
            } while (choice);
        }

        public void Report()
        {
            int nullAges = 0;
            int nullBonus = 0;
            int nullJoiningDate = 0;

            foreach (dynamic emp in employees)
            {
                if (emp.age <= 0 || emp.age == null)
                {
                    nullAges++;
                    toUpadteEmployees.Add(emp);
                    employees.Remove(emp);
                }

                if (emp.bonusAmount <= 0 || emp.bonusAmount == null)
                {
                    nullBonus++;
                    toUpadteEmployees.Add(emp);
                    employees.Remove(emp);
                }

                if (emp.joiningDate == null)
                {
                    nullJoiningDate++;
                    toUpadteEmployees.Add(emp);
                    employees.Remove(emp);
                }
            }

            Console.WriteLine($"Total age faults : {nullAges}, bonus faults : {nullBonus}, joining date faults {nullJoiningDate}");
            Console.WriteLine("Employee data which needs correction : ");
            foreach (dynamic item in toUpadteEmployees)
            {
                Console.WriteLine($"\nID : {item.ID}\tAge : {item.Age}\tBonus : {item.bonusAmount}\tJoining Date : {item.joiningDate}");
            }
        }

        public void Updation()
        {
            foreach (dynamic emp in employees)
            {
                if (emp.age <= 0 || emp.age == null)
                {
                    Console.WriteLine("Update the age");
                    emp.Age = Convert.ToInt32(Console.ReadLine());
                }

                if (emp.bonusAmount <= 0 || emp.bonusAmount == null)
                {
                    Console.WriteLine("Update the bonus");
                    emp.bonusAmount = Convert.ToDouble(Console.ReadLine());
                }

                if (emp.joiningDate == null)
                {
                    Console.WriteLine("Update the joining date");
                    emp.joiningDate = Convert.ToDateTime(Console.ReadLine());
                }
            }
        }
    }
}
