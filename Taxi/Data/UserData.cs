using System.Collections.Generic;
using System.Data.SqlClient;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class UserData
    { 
        public List<User> GetAll()
        {
            var usersList = new List<User>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT user_id, user_name, email, password, driver_id, company_id FROM users",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5)
                        );

                        usersList.Add(user);
                    }
                }

                connection.Close();
            }

            return usersList;
        }

        public User Get(int userId)
        {
            User user = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM users WHERE user_id=@id", connection);
                command.Parameters.AddWithValue("id", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        user = new User(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5)
                        );
                }

                connection.Close();
            }

            return user;
        }

        public void Add(User user)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO user (user_id, user_name,password, email, driver_id, company_id) VALUES(@userId, @userName, @email, @driverId, @companyId)",
                        connection);
                command.Parameters.AddWithValue("userId", user.UserId);
                command.Parameters.AddWithValue("userName", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("driverId", user.DriverId);
                command.Parameters.AddWithValue("companyId", user.CompanyId); 

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(User user)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET user_id=@userId, user_name=@userName, password=@password email=@email, password=@password, driver_id=@driverId WHERE company_id=@driverId",
                        connection);
                command.Parameters.AddWithValue("userId", user.UserId);
                command.Parameters.AddWithValue("userName", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("driverId", user.DriverId);
                command.Parameters.AddWithValue("companyId", user.CompanyId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int userId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE user WHERE user_id=@userId", connection);
                command.Parameters.AddWithValue("userId", userId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
