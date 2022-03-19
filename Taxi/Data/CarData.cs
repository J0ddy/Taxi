using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class CarData
    {
        public List<Car> GetAll()
        {
            var carsList = new List<Car>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT cars.car_id, cars.license, cars.make, cars.model, cars.color, cars.company_id, cars.year, cars.engine_id, cars.caroptions_id FROM cars",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cars = new Car(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetInt32(5),
                            reader.GetString(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8)
                        );

                        carsList.Add(cars);
                    }
                }

                connection.Close();
            }

            return carsList;
        }

        public Car Get(int carsId)
        {
            Car car = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM cars WHERE cars_id=@id", connection);
                command.Parameters.AddWithValue("id", carsId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        car = new Car(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetInt32(5),
                            reader.GetString(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8)
                        );
                }

                connection.Close();
            }

            return car;
        }

        public void Add(Car car)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO cars (car_id, license, make, model, color, company_id, year, engine_id, caroptions_id) VALUES(@id, @license, @make, @model, @color, @companyId, @year, @engineId, @carOptionsId)",
                        connection);
                command.Parameters.AddWithValue("id", car.CarId);
                command.Parameters.AddWithValue("license", car.License);
                command.Parameters.AddWithValue("make", car.Make);
                command.Parameters.AddWithValue("model", car.Model);
                command.Parameters.AddWithValue("color", car.Color);
                command.Parameters.AddWithValue("companyId", car.CompanyId);
                command.Parameters.AddWithValue("year", car.Year);
                command.Parameters.AddWithValue("engineId", car.EngineId);
                command.Parameters.AddWithValue("carOptionsId", car.CaroptionsId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Car car)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE cars SET car_id=@id, license=@license, make=@make, model=@model, color=@color, company_id = @company_id, year = @year, engine_id = @engineId, caroptions_id = @carOptionsId WHERE car_id=@id",
                        connection);
                command.Parameters.AddWithValue("id", car.CarId);
                command.Parameters.AddWithValue("license", car.License);
                command.Parameters.AddWithValue("make", car.Make);
                command.Parameters.AddWithValue("model", car.Model);
                command.Parameters.AddWithValue("color", car.Color);
                command.Parameters.AddWithValue("companyId", car.CompanyId);
                command.Parameters.AddWithValue("year", car.Year);
                command.Parameters.AddWithValue("engineId", car.EngineId);
                command.Parameters.AddWithValue("carOptionsId", car.CaroptionsId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int carsId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE cars WHERE cars_id=@carsId", connection);
                command.Parameters.AddWithValue("carsId", carsId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
