using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Registration
    {
        public int Id;
        public string Name;
        public string Course;
        public static int Counter = 0;

        public Registration(int id, string name, string course)
        {
            Id = id;
            Name = name;
            Course = course;
            Counter++;
        }
    }
    internal class Question19
    {
        Registration student1 = new Registration(1, "Deep", "CSE");
        Registration student2 = new Registration(2, "Divyarth", "CSE");
        Registration student3 = new Registration(3, "Swapnil", "CSE");

        public void Func()
        {
            var temp = student2;
            temp.Name="Swappy";
            Console.WriteLine(temp);
            Console.WriteLine(Registration.Counter);
        }


    }
}
