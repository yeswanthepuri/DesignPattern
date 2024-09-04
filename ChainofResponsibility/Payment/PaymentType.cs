using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Payment
{
    public enum PaymentType
    {
        CreditCard = 1,
        DebitCard = 2,
        PaymentWallet = 3,
        NetBanking = 4,
        Paypal = 5,
    }
}
