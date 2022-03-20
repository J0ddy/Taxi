using System.Collections.Generic;
using System.Data.SqlClient;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class TripsData
    {
        public List<Trip> GetAll()
        {
            var tripsList = new List<Trip>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT trips.trip_id, trips.driver_id, trips.car_id, trips.company_id, trips.triptype_id FROM trips",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var trip = new Trip(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4)
                        );

                        tripsList.Add(trip);
                    }
                }

                connection.Close();
            }

            return tripsList;
        }

        public Trip Get(int tripId)
        {
            Trip trip = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM trips WHERE trip_id=@tripId", connection);
                command.Parameters.AddWithValue("tripId", tripId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        trip = new Trip(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4)
                        );
                }

                connection.Close();
            }

            return trip;
        }

        public void Add(Trip trip)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO driver (trip_id, driver_id, car_id , company_id, triptype_id, ) VALUES(@tripId, @driverId, @carId, @companyId, @triptypeId)",
                        connection);
                command.Parameters.AddWithValue("tripId", trip.TripId);
                command.Parameters.AddWithValue("driverId", trip.DriverId);
                command.Parameters.AddWithValue("carId", trip.CarId);
                command.Parameters.AddWithValue("companyId", trip.CompanyId);
                command.Parameters.AddWithValue("triptypeId", trip.TripTypeId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Trip trip)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET trip_id=@tripId, driver_id=@driverId, car_id=@carId, company_id=@companyId, triptype_id=@triptypeId WHERE trip_id=@tripId",
                        connection);
                command.Parameters.AddWithValue("tripId", trip.TripId);
                command.Parameters.AddWithValue("driverId", trip.DriverId);
                command.Parameters.AddWithValue("carId", trip.CarId);
                command.Parameters.AddWithValue("companyId", trip.CompanyId);
                command.Parameters.AddWithValue("triptypeId", trip.TripTypeId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int tripId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE driver WHERE trip_id=@tripId", connection);
                command.Parameters.AddWithValue("tripId", tripId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
