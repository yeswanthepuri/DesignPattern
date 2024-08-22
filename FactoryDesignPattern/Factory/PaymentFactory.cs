using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class PaymentFactory
    {
        public static IPayements Create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.PayPal:
                    return new PayPal();
                case PaymentMethod.Gpay:
                    return new Gpay();
                case PaymentMethod.PhonePay:
                    return new PhonePay();
                default:
                    throw new ArgumentException("You can't opt this payment");
            }
        }
    }
}
