using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public  class Driver
    {
        public Driver()
        {
            Trips = new HashSet<Trip>();
            User = new HashSet<User>();
        }

        public Driver(int driverId, int carId, int userId, string firstname, string lastname, string telephoneNumber)
        {
            this.DriverId = driverId;
            this.CarId = carId;
            this.UserId = userId;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.TelephoneNumber = telephoneNumber;
        }


        public int DriverId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string TelephoneNumber { get; set; }

        public  Car Car { get; set; }
        public  ICollection<Trip> Trips { get; set; }
        public  ICollection<User> User { get; set; }
    }
}
