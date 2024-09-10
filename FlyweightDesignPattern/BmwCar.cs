using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    /// <summary>
    /// place where the information which doesn't change
    /// </summary>
    public class BmwCar : ICar
    {
        public string Color { get; private set; }

        public string Engine { get; private set; }

        public BmwCar(string color,string engine)
        {
            Engine = engine;
            Color = color;
        }

        public void SetLocation(decimal lat, decimal lng)
        {
            Console.WriteLine($"Current location of the car is at Latitude {lat}, Longitude{lng}");
        }
    }
}
