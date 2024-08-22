using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.BridgeImplementation
{
    public class NoClaimsDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 15;
        }
    }
}
