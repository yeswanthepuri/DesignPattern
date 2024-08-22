using AbstractFactory.Classes.CapitalCity;
using AbstractFactory.Classes.Language;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Provider
{
    public class InternationalProvider
    {
        public static ILanguage CreateLanguage(Country country)
        {
            switch (country)
            {
                case Country.ENDGLAND:
                    return new English();
                case Country.SPAIN:
                    return new Spanish();
                default:
                    throw new Exception("No language");
            }
        }

        public static ICapitalCity CreateCapitalCity(Country country)
        {
            switch (country)
            {
                case Country.ENDGLAND:
                    return new London();
                case Country.SPAIN:
                    return new Madrid();
                default:
                    throw new Exception("No City");
            }
        }
    }
}
