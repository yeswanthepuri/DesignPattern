using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Language
{
    /// <summary>
    /// Concrete Product A1
    /// </summary>
    public class Spanish : ILanguage
    {
        public void Greeting()
        {
            Console.WriteLine("Hola!");
        }
    }
}
