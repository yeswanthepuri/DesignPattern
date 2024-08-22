using AbstractFactory.Classes.CapitalCity;
using AbstractFactory.Classes.Language;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Factory
{
    /// <summary>
    /// Concrete Factory 1
    /// </summary>
    public class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity Capital()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
