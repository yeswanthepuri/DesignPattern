using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public abstract class Singletone
    {
        public void Log(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
