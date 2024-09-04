using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Payment
{
    public class PaymentMethod
    {
        public PaymentType PaymentType { get; set; }
        public float CashToPay { get; set; }
    }
}
