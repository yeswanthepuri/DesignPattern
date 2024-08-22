using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class StaticSingletoneLogger : Singletone
    {
        private static StaticSingletoneLogger staticSingletoneLogger= new StaticSingletoneLogger();

        private StaticSingletoneLogger()
        {
            
        }

        public static StaticSingletoneLogger GetInstance() {

            return staticSingletoneLogger;
        }
    }
}
