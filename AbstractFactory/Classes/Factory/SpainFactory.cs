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
    /// Concrete Factory 2
    /// </summary>
    public class SpainFactory : IInternationalFactory
    {
        public ICapitalCity Capital()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}
