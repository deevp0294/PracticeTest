using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeTest
{
    public interface IPrinter
    {
        public void Print();
    }
    public interface IScanner
    {
        public void Scan();
    }
    public interface IMultiFunctionDevice : IPrinter, IScanner
    {

    }
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printer is called");
        }
    }

    public class MultiFunction : IMultiFunctionDevice
    {
        public void Print()
        {
            Console.WriteLine("Printer is called");
        }

        public void Scan()
        {
            Console.WriteLine("Scanner is called");
        }
    }
    internal class Question30
    {

    }
}
