
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Views
{
    class DisplayTrips
    {
        public DisplayTrips()
        {
            Output();
        }

        public DisplayTrips(int id)
        {
            OutputById(id);
        }

        private void Output()
        {
            TripsData tripData = new TripsData();
            TripTypeData tripTypeData = new TripTypeData();
            List<Trip> trips = tripData.GetAll();
            List<TripType> tripTypes = tripTypeData.GetAll();
            StringBuilder sb = new StringBuilder();
            foreach (TripType trip1 in trips.Select(trip => tripTypes[trip.TripId-1]))
            {
                sb.Append("\n"+trips[trip1.TripTypeId-1].TripId+" | "+trip1.TimeLeaveArrive.ToString("dd.MM.yy HH:mm")+" | ");
                sb.Append(trip1.Origin + " --> " + trip1.Destination);
            }
            Console.WriteLine(sb);
        }

        private void OutputById(int id)
        {
            TripsData tripsData = new TripsData();
            TripTypeData tripTypeData = new TripTypeData();
            Trip trip = tripsData.Get(id);
            TripType tripType = tripTypeData.Get(trip.TripTypeId);
            Console.WriteLine($"{trip.TripId} | {tripType.TimeLeaveArrive.ToString("dd.MM.yy HH:mm")} \n{tripType.Origin} --> {tripType.Destination}");
            
        }
    }
}
