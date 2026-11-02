using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class AuditEvent
    {
        public string test = "test";
    }
    internal class Question10
    {
        Object[] objects = new Object[]
        {
            10,10.88,"Hello",2/9/2004,new AuditEvent()
        };

        public void Display()
        {
            foreach(var obj in objects)
            {
                Console.WriteLine(obj.GetType());
            }

            Console.WriteLine(objects[4].ToString());
            Console.WriteLine(objects[4].ToString().GetType());

            AuditEvent auditEvent = (AuditEvent)objects[4];
            if(auditEvent == objects[4]) Console.WriteLine("No cast equal");
            if(auditEvent == (AuditEvent)objects[4]) Console.WriteLine("Cast equal");
        }
    }
}
