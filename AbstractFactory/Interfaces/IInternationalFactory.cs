using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity Capital();
    }
}
