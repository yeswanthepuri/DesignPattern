using Bridge.BridgeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.UsingOfBridge
{
    public class ThirdParty : CarInsurance
    {
        public ThirdParty(int year, string model, string maker,Discount discount) : base(year, model, maker, discount)
        {
        }

       

        protected override decimal GetPremium()
        {
            return 200;
        }
    }
}
