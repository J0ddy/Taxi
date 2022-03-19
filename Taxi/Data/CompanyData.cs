using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class CompanyData
    {
        public List<Company> GetAll()
        {
            var driversList = new List<Company>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT company.driver_id, company.car_id, company.user_id, company.firstname, company.lastname, company.telephone_numebr FROM company",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var company = new Company(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3)
                        );

                        driversList.Add(company);
                    }
                }

                connection.Close();
            }

            return driversList;
        }

        public Company Get(int companyId)
        {
            Company company = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM driver WHERE driver_id=@id", connection);
                command.Parameters.AddWithValue("id", companyId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        company = new Company(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3)
                        );
                }

                connection.Close();
            }

            return company;
        }

        public void Add(Company company)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO driver (company_id, name, admin_id, telephone_number) VALUES(@companyId, @carId, @name, @adminId, @lastName, @telephoneNumber)",
                        connection);
                command.Parameters.AddWithValue("companyId", company.CompanyId);
                command.Parameters.AddWithValue("name", company.Name);
                command.Parameters.AddWithValue("adminId", company.AdminId);
                command.Parameters.AddWithValue("telephoneNumber", company.TelephoneNumber);
                //command.Parameters.AddWithValue("lastName", driver.Lastname);
                //command.Parameters.AddWithValue("telephoneNumber", driver.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Company company)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE user SET company_id=@companyId, name=@name, admin_id=@adminId, lastname=@lastName, telephone_number=@telephoneNumber WHERE driver_id=@driverId",
                        connection);
                command.Parameters.AddWithValue("companyId", company.CompanyId);
                command.Parameters.AddWithValue("name", company.Name);
                command.Parameters.AddWithValue("adminId", company.AdminId);
                command.Parameters.AddWithValue("telephoneNumber", company.TelephoneNumber);
                //command.Parameters.AddWithValue("lastName", driver.Lastname);
                //command.Parameters.AddWithValue("telephoneNumber", driver.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int companyId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE driver WHERE driver_id=@driverId", connection);
                command.Parameters.AddWithValue("comapnyId", companyId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
