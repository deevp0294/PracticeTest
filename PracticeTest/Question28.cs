using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class DeliveryService
    {
        int rate = 0;
        public virtual int Charge(int km)
        {
            return rate*km;
        }
    }

    public class StandardDelivery : DeliveryService
    {
        public override int Charge(int km)
        {
            return (km / 10) * 50;
        }
    }

    public class ExpressDelivery : DeliveryService
    {
        public override int Charge(int km)
        {
            return (km / 15) * 100;
        }
    }

    internal class Question28
    {
        
        public void Funct()
        {
            int std = 0;
            int exp = 0;
            DeliveryService standardDelivery = new StandardDelivery();
            DeliveryService expressDelivery = new ExpressDelivery();
            try
            {
                std = standardDelivery.Charge(100);
                exp = (expressDelivery as ExpressDelivery).Charge(150);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in casting");
            }

            Console.WriteLine("Standard delivery cost "+std);
            Console.WriteLine("Express delivery cost "+exp);
        }
    }
}
