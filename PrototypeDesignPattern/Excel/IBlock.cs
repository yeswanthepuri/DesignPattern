using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Excel
{
    public interface IBlock
    {
        string render { get; }
        IBlock clone();
    }
}
