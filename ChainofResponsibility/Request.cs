using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class Request
    {
        public object Data { get; set; }
        public List<string> ValidationMessages { get; set; } = new List<string>();
    }
}
