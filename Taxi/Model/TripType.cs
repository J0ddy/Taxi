using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public partial class TripType
    {
        public TripType()
        {
            Trips = new HashSet<Trip>();
        }

        public TripType(int tripTypeId, DateTime timeLeaveArrive, string origin, string destination)
        {
            this.TripTypeId = tripTypeId;
            this.TimeLeaveArrive = timeLeaveArrive;
            this.Origin = origin;
            this.Destination = destination;
        }

        public int TripTypeId { get; set; }
        public DateTime TimeLeaveArrive { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
