using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class TripTypeData
    {
        public List<TripType> GetAll()
        {
            var tripTypeList = new List<TripType>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT tripType.tripType_id, tripType.Tleave_Tarive,tripType.origin, tripType.destinatin FROM tripType",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tripType = new TripType(
                            reader.GetInt32(0),
                            reader.GetDateTime(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        );

                        tripTypeList.Add(tripType);
                    }
                }

                connection.Close();
            }

            return tripTypeList;
        }

        public TripType Get(int tripTypeId)
        {
            TripType tripType = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM tripType WHERE tripType_id=@id", connection);
                command.Parameters.AddWithValue("id", tripTypeId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        tripType = new TripType(
                          reader.GetInt32(0),
                            reader.GetDateTime(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        );
                }

                connection.Close();
            }

            return tripType;
        }

        public void Add(TripType tripType)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO tripType (tripType_id, Tleave_Tarive, origin, destinatin) VALUES(@tripTypeId, @TleaveTarive, @origin, @destination)",
                        connection);
                command.Parameters.AddWithValue("tripTypeId", tripType.TripTypeId);
                command.Parameters.AddWithValue("TleaveTarive", tripType.TimeLeaveArrive);
                command.Parameters.AddWithValue("origin", tripType.Origin);
                command.Parameters.AddWithValue("destination", tripType.Destination);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(TripType tripType)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET tripType_id=@tripTypeId, Tleave_Tarive=@TleaveTarive, origin=@origin, destinatin=@destination)",
                        connection); 
                command.Parameters.AddWithValue("tripTypeId", tripType.TripTypeId);
                command.Parameters.AddWithValue("TleaveTarive", tripType.TimeLeaveArrive);
                command.Parameters.AddWithValue("origin", tripType.Origin);
                command.Parameters.AddWithValue("destination", tripType.Destination);
                //command.Parameters.AddWithValue("telephoneNumber", tripType.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int tripTypeId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE tripType WHERE tripType_id=@tripTypeId", connection);
                command.Parameters.AddWithValue("tripTypeId", tripTypeId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
