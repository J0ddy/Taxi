using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class DriverData
    {
        public List<Driver> GetAll()
        {
            var driversList = new List<Driver>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT driver.driver_id, driver.car_id, driver.user_id, driver.firstname, driver.lastname, driver.telephone_numebr FROM driver",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var driver = new Driver(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5)
                        );

                        driversList.Add(driver);
                    }
                }

                connection.Close();
            }

            return driversList;
        }

        public Driver Get(int driverId)
        {
            Driver driver = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM driver WHERE driver_id=@id", connection);
                command.Parameters.AddWithValue("id", driverId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        driver = new Driver(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5)
                        );
                }

                connection.Close();
            }

            return driver;
        }

        public void Add(Driver driver)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO driver (driver_id, car_id, user_id, firstname, lastname, telephone_number) VALUES(@driverId, @carId, @userId, @fistName, @lastName, @telephoneNumber)",
                        connection);
                command.Parameters.AddWithValue("driverId", driver.DriverId);
                command.Parameters.AddWithValue("carId", driver.CarId);
                command.Parameters.AddWithValue("userId", driver.UserId);
                command.Parameters.AddWithValue("fistName", driver.Firstname);
                command.Parameters.AddWithValue("lastName", driver.Lastname);
                command.Parameters.AddWithValue("telephoneNumber", driver.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Driver driver)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET car_id=@carId, user_id=@userId, firstname=@fistName, lastname=@lastName, telephone_number=@telephoneNumber WHERE driver_id=@driverId",
                        connection);
                command.Parameters.AddWithValue("driverId", driver.DriverId);
                command.Parameters.AddWithValue("carId", driver.CarId);
                command.Parameters.AddWithValue("userId", driver.UserId);
                command.Parameters.AddWithValue("fistName", driver.Firstname);
                command.Parameters.AddWithValue("lastName", driver.Lastname);
                command.Parameters.AddWithValue("telephoneNumber", driver.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int driverId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE driver WHERE driver_id=@driverId", connection);
                command.Parameters.AddWithValue("driverId", driverId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
