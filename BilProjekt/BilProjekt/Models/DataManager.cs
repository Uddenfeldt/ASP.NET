using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilProjekt.Models
{
    public class DataManager
    {
        static List<Car> cars = new List<Car>
        {
            new Car{Id = 1, Brand = "Audi", Doors = 4, TopSpeed = 251},
            new Car{Id = 2, Brand = "Volkswagen", Doors = 2, TopSpeed = 70},
            new Car{Id = 2, Brand = "BMW", Doors = 4, TopSpeed = 249},
        };

        public static void AddCar(CarsCreateVM viewModel)
        {
            Car car = new Car
            {
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
                Id = cars.Max(c => c.Id) + 1
            };
            cars.Add(car);
        }

        public static CarsIndexVM[] ListCars()
        {
            return cars.Select(o => new CarsIndexVM
            {
                Brand = o.Brand,
                ShowAsFast = o.TopSpeed > 250
            }).ToArray();
        }
    }
}
