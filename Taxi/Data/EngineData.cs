using System.Collections.Generic;
using System.Data.SqlClient;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class EngineData
    {
        public List<Engine> GetAll()
        {
            var enginesList = new List<Engine>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT engine.engine_id, engine.cub, engine.cylinders, engine.fuel, engine.kmtolitre FROM engine",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var engine = new Engine(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetString(3),
                            reader.GetInt32(4)
                        );

                        enginesList.Add(engine);
                    }
                }

                connection.Close();
            }

            return enginesList;
        }

        public Engine Get(int engineId)
        {
            Engine engine = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM engine WHERE engine_id=@id", connection);
                command.Parameters.AddWithValue("id", engineId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        engine = new Engine(
                             reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetString(3),
                            reader.GetInt32(4)
                        );
                }

                connection.Close();
            }

            return engine;
        }

        public void Add(Engine engine)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO engine (engine_id, cub, cylinders, fuel, kmtolitre) VALUES(@engineId, @cub, @cylinder, @fuel, @kmtolitre)",
                        connection);
                command.Parameters.AddWithValue("engineId", engine.EngineId);
                command.Parameters.AddWithValue("cub", engine.Cub);
                command.Parameters.AddWithValue("cylinders", engine.Cylinders);
                command.Parameters.AddWithValue("fuel", engine.Fuel);
                command.Parameters.AddWithValue("kmtolitre", engine.Kmtolitre);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Engine engine)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET engine_id=@carId, user_id=@userId, firstname=@fistName, lastname=@lastName, telephone_number=@telephoneNumber WHERE engine_id=@engineId",
                        connection);
                command.Parameters.AddWithValue("engineId", engine.EngineId);
                command.Parameters.AddWithValue("cub", engine.Cub);
                command.Parameters.AddWithValue("cylinders", engine.Cylinders);
                command.Parameters.AddWithValue("fuel", engine.Fuel);
                command.Parameters.AddWithValue("kmtolitre", engine.Kmtolitre);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int engineId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE engine WHERE engine_id=@engineId", connection);
                command.Parameters.AddWithValue("engineId", engineId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
