using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Excel
{
    public class DatetimeBlock : IBlock
    {
        public DateTime DateTime { get; set; }
        public string Format { get; set; }
        public string render => DateTime.ToString(Format);

        public IBlock clone() => (DatetimeBlock)MemberwiseClone();  
    }
}
