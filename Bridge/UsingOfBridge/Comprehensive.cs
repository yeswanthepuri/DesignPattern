using Bridge.BridgeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.UsingOfBridge
{
    public class Comprehensive : CarInsurance
    {
        public Comprehensive(int year, string make, string model,Discount discount) : base(year, make, model, discount)
        {
        }


        protected override decimal GetPremium()
        {
            return 200;
        }
    }
}
