using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Excel
{
    public class TextBlock : IBlock
    {
        public string Content { get; set; }
        public string render => Content.ToString();

        public IBlock clone() => new TextBlock();
        
    }
}
