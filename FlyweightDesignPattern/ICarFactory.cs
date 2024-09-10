using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public interface ICarFactory
    {
        public ICar GetCar(EnumbTypeOfCar enumbTypeOfCar);
    }
}
