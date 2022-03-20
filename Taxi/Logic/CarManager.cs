using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Logic
{
    class CarManager
    {
        private readonly CarData carData = new CarData();
        public List<Car> GetAll()
        {
            return carData.GetAll();
        }

        public Car Get(int id)
        {
            return carData.Get(id);
        }

        public void Add(Car car)
        {
            carData.Add(car);
        }

        public void Update(Car car)
        {
            carData.Update(car);
        }

        public void Delete(int id)
        {
            carData.Delete(id);
        }
    }
}
