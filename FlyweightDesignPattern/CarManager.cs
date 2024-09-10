using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    /// <summary>
    /// This class is the place where the context gets changes.
    /// </summary>
    public class CarManager : ICarManager
    {
        private decimal lat = 0;
        private decimal lng = 0;
        private readonly ICar car;
        public CarManager(ICarFactory carFactory, EnumbTypeOfCar typeOfCar)
        {
            car = carFactory.GetCar(typeOfCar);
        }
        public void SetLocation(decimal lat, decimal lng)
        {
            this.lat = lat;
            this.lng = lng;
            car.SetLocation(lat, lng);
        }
    }
}
