using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public partial class Driver
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

        public virtual Car Car { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
