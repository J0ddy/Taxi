using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public  class Trip
    {
        public int TripId { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }
        public int CompanyId { get; set; }
        public int TripTypeId { get; set; }

        public Trip(int tripId, int driverId, int carId, 
        int companyId, int tripTypeId)
        {
            this.TripId = tripId;
            this.DriverId = driverId;
            this.CarId = carId;
            this.CompanyId = companyId;
            this.TripTypeId = tripTypeId;
        }

        public  Car Car { get; set; }
        public  Company Company { get; set; }
        public  Driver Driver { get; set; }
        public  TripType Triptype { get; set; }
    }
}
