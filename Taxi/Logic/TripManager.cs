using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Logic
{
    class TripManager
    {
        private readonly TripsData tripManager = new TripsData();
        public List<Trip> GetAll()
        {
            return tripManager.GetAll();
        }

        public Trip Get(int id)
        {
            return tripManager.Get(id);
        }

        public void Add(Trip trip)
        {
            tripManager.Add(trip);
        }

        public void Update(Trip trip)
        {
            tripManager.Update(trip);
        }

        public void Delete(int id)
        {
            tripManager.Delete(id);
        }
    }
}
