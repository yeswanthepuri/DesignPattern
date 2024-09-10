using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class CarFactory : ICarFactory
    {
        private readonly IDictionary<EnumbTypeOfCar, ICar> cars = new Dictionary<EnumbTypeOfCar, ICar>();
        public ICar GetCar(EnumbTypeOfCar enumbTypeOfCar)
        {
            if(cars.ContainsKey(enumbTypeOfCar)) return cars[enumbTypeOfCar];
            var car = CreateCar(enumbTypeOfCar);
            cars.Add(enumbTypeOfCar, car);
            return car;
        }

        private static ICar CreateCar(EnumbTypeOfCar enumbTypeOfCar)
        {
            switch (enumbTypeOfCar)
            {
                case EnumbTypeOfCar.Bmw:
                    return new BmwCar("Red", "V8");
                case EnumbTypeOfCar.Audi:
                    return new AudiCar("Blue", "V6");
                default:
                    throw new ArgumentException("Invalid Choice");
            }
        }
    }
}
