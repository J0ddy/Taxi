using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class CarOptionsData
    {
        public List<CarOptions> GetAll()
        {
            var carOptionsList = new List<CarOptions>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT carOptions.carOptions_id, carOptions.autopilot, carOptions.active_airbag, carOptions.usb_port, carOptions.multimedia, carOptions.engine_mode FROM carOptions",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var carOptions = new CarOptions(
                            reader.GetInt32(0),
                            reader.GetBoolean(1),
                            reader.GetBoolean(2),
                            reader.GetBoolean(3),
                            reader.GetBoolean(4),
                            reader.GetString(5)
                        );

                        carOptionsList.Add(carOptions);
                    }
                }

                connection.Close();
            }

            return carOptionsList;
        }

        public CarOptions Get(int carOptionsId)
        {
            CarOptions carOptions = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM carOptions WHERE carOptions_id=@id", connection);
                command.Parameters.AddWithValue("id", carOptionsId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        carOptions = new CarOptions(
                            reader.GetInt32(0),
                            reader.GetBoolean(1),
                            reader.GetBoolean(2),
                            reader.GetBoolean(3),
                            reader.GetBoolean(4),
                            reader.GetString(5)
                        );
                }

                connection.Close();
            }

            return carOptions;
        }

        public void Add(CarOptions carOptions)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO carOptions (caroptions_id, autopilot, active_airbag, usb_port, multimedia, engine_mode) VALUES(@carOptionsId, @Autopilot, @ActiveAirbag, @UsbPort, @Multimedia, @EngineMode)",
                        connection);
                command.Parameters.AddWithValue("carOptionsId", carOptions.CarOptionsId);
                command.Parameters.AddWithValue("autoPilot", carOptions.Autopilot);
                command.Parameters.AddWithValue("activeAirbag", carOptions.ActiveAirbag);
                command.Parameters.AddWithValue("usbPort", carOptions.UsbPort);
                command.Parameters.AddWithValue("multimedia", carOptions.Multimedia);
                command.Parameters.AddWithValue("engineMode", carOptions.EngineMode);
                //command.Parameters.AddWithValue("year", carOptions.Year);
               // command.Parameters.AddWithValue("engineId", carOptions.EngineId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(CarOptions carOptions)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET caroptions_id=@carOptionsId, autopilot=@Autopilot, active_airbag=@ActiveAirbag, usb_port=@UsbPort, multimedia=@Multimedia, engine_mode=@EngineMode WHERE carOptions_id=@carOptionsId",
                        connection);
                command.Parameters.AddWithValue("carOptionsId", carOptions.CarOptionsId);
                command.Parameters.AddWithValue("autopilot", carOptions.Autopilot);
                command.Parameters.AddWithValue("active_airbag", carOptions.ActiveAirbag);
                command.Parameters.AddWithValue("usb_port", carOptions.UsbPort);
                command.Parameters.AddWithValue("multimedia", carOptions.Multimedia);
                command.Parameters.AddWithValue("engine_mode", carOptions.EngineMode);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int carOptionsId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE carOptions WHERE carOptions_id=@carOptionsId", connection);
                command.Parameters.AddWithValue("carOptionsId", carOptionsId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
