using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Controllers
{
    public class HelloModel
        {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>{
                new Car {ID = 1, Make="Ford", Model="Crown Victoria"},
                new Car {ID = 2, Make="Dodge", Model="Challenger"},
                new Car {ID = 3, Make="Chevy", Model="Cruze"},
            };
            return cars;
        }
    }

    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}