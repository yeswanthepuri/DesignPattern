using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.Payments
{
    internal class Gpay : IPayements
    {
        public void Payment(BigInteger amount)
        {
            Console.WriteLine($"Made a payment of {amount} from {GetType()}");
        }
    }
}
