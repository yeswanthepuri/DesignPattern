using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.CapitalCity
{
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 1000000;
        }

        public List<string> ListofTopAttractions()
        {
            return new List<string>() { "London eye", "London Bridge" };
        }
    }
}
