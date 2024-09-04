using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Payment
{
    public class CreditCardHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod payment)
            {
                if(payment.PaymentType == PaymentType.CreditCard)
                {
                    Console.WriteLine($"Processed Request Through  {PaymentType.CreditCard.ToString()}");
                }
                else if(_handler != null)
                {
                    _handler.Process(request);
                }
                else
                {
                    request.ValidationMessages.Add("In valid Payment option selected");
                }
            }
            else
            {
                throw new Exception("Invalid Hndler Exception");
            }
        }
    }
    public class DebitCardHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod payment)
            {
                if (payment.PaymentType == PaymentType.DebitCard)
                {
                    Console.WriteLine($"Processed Request Through  {payment.PaymentType.ToString()}");
                }
                else if (_handler != null)
                {
                    _handler.Process(request);
                }
                else
                {
                    request.ValidationMessages.Add("In valid Payment option selected");
                }
            }
            else
            {
                throw new Exception("Invalid Hndler Exception");
            }
        }
    }
    public class NetBankingHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod payment)
            {
                if (payment.PaymentType == PaymentType.NetBanking)
                {
                    Console.WriteLine($"Processed Request Through  {payment.PaymentType.ToString()}");
                }
                else if (_handler != null)
                {
                    _handler.Process(request);
                }
                else
                {
                    request.ValidationMessages.Add("In valid Payment option selected");
                }
            }
            else
            {
                throw new Exception("Invalid Hndler Exception");
            }
        }
    }
    public class PaymentWalletHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod payment)
            {
                if (payment.PaymentType == PaymentType.PaymentWallet)
                {
                    Console.WriteLine($"Processed Request Through  {payment.PaymentType.ToString()}");
                }
                else if (_handler != null)
                {
                    _handler.Process(request);
                }
                else
                {
                    request.ValidationMessages.Add("In valid Payment option selected");
                }
            }
            else
            {
                throw new Exception("Invalid Hndler Exception");
            }
        }
    }
}
