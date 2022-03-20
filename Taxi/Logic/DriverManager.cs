using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Logic
{
    class DriverManager
    {
        private readonly DriverData driverData = new DriverData();
        public List<Driver> GetAll()
        {
            return driverData.GetAll();
        }

        public Driver Get(int id)
        {
            return driverData.Get(id);
        }

        public void Add(Driver driver)
        {
            driverData.Add(driver);
        }

        public void Update(Driver driver)
        {
            driverData.Update(driver);
        }

        public void Delete(int id)
        {
            driverData.Delete(id);
        }
    }
}
