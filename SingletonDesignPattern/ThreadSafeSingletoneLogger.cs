using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ThreadSafeSingletoneLogger : Singletone
    {
        private static readonly Object threadsafe = new object();
        private static ThreadSafeSingletoneLogger instance;
        private ThreadSafeSingletoneLogger()
        {

        }
        public static ThreadSafeSingletoneLogger GetInstance()
        {
            if (instance == null)
            {
                lock (threadsafe)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletoneLogger();
                    }
                }
            }
            return instance;
        }
    }
}
