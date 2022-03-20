using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Views
{
    class DisplayDrivers
    {
        public DisplayDrivers()
        {
            Output();
        }

        public DisplayDrivers(int id)
        {
            OutputById(id);
        }

        private void Output()
        {
            DriverData driverData = new DriverData();
            List<Driver> drivers = driverData.GetAll();
            StringBuilder sb = new StringBuilder();
            foreach (var driver in drivers)
            {
                sb.AppendLine($"{driver.DriverId,3} | {driver.Firstname,2} {driver.Lastname,2} {driver.TelephoneNumber,2}");
            }
            Console.WriteLine(sb);
        }

        private void OutputById(int id)
        {
            DriverData driverData = new DriverData();
            Driver driver = driverData.Get(id);
            Console.WriteLine($"{driver.DriverId,3} | {driver.Firstname,2} {driver.Lastname,2} {driver.TelephoneNumber,2}");
        }
    }
}
