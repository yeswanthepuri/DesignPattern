using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Excel
{
    public class NumberBlock : IBlock
    {
        public int Number { get; set; }
        public string render => Number.ToString();

        public IBlock clone() => new NumberBlock();


    }
}
