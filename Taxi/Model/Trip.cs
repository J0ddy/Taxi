using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public partial class Trip
    {
        public int TripId { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }
        public int CompanyId { get; set; }
        public int TripTypeId { get; set; }

        public Trip(int tripId, int driverId, int companyId, int tripTypeId)
        {
            this.TripId = tripId;
            this.DriverId = driverId;
            this.CompanyId = companyId;
            this.TripTypeId = tripTypeId;
        }

        public virtual Car Car { get; set; }
        public virtual Company Company { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual TripType Triptype { get; set; }
    }
}
