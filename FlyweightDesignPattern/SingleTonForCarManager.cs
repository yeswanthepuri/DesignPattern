using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class SingleTonForCarManager
    {
        public CarManager[] CarManagers { get; private set; }

        private static readonly CarFactory Instance2 = new CarFactory();
        private static SingleTonForCarManager instance;
        private SingleTonForCarManager()
        {
            CarManagers = new CarManager[]
            {
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Audi),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Audi),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Audi),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
                new CarManager(Instance2,EnumbTypeOfCar.Bmw),
            }; 
        }
        public static SingleTonForCarManager GetInstance()
        {
            if (instance == null)
            {
                lock (Instance2)
                {
                    if (instance == null)
                    {
                        instance = new SingleTonForCarManager();
                    }
                }
            }
            return instance;
        }

    }
}
