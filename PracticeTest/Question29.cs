using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public interface INotifier
    {
        public string Notify() { return ""; }
    }

    public class Email : INotifier
    {
        public string Notify()
        {
            return "email";
        }
    }

    public class SMS : INotifier
    {
        public string Notify()
        {
            return "sms";
        }
    }
    internal class senNoti
    {
        public void Send(INotifier notifier, string msg)
        {
            Console.WriteLine($"Message : {msg} sent by {notifier.Notify()}");
        }
    }

    public class Question29
    {
        public void Runner()
        {
            Email email = new Email();
            SMS sms = new SMS();

            senNoti senNoti = new senNoti();
            senNoti.Send(email, "Hello");
            senNoti.Send(sms, "Hello");
        }
    }
}
