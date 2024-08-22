using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.CapitalCity
{
    public class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 3200000;
        }

        public List<string> ListofTopAttractions()
        {
            return new List<string>() { "Royal Palace", "Prado Museum" };
        }
    }
}
