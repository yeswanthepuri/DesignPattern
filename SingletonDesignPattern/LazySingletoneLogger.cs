using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class LazySingletoneLogger : Singletone
    {
        private static readonly Lazy<LazySingletoneLogger> instance = new Lazy<LazySingletoneLogger>(
            ()=>new LazySingletoneLogger());
        private LazySingletoneLogger()
        {
            
        }

        public static LazySingletoneLogger GetInstance()
        {
            return instance.Value;
        }
    }
}
