using System.Collections.Generic;
using System.Data.SqlClient;
using Taxi.Data.Models;

namespace Taxi.Data
{
    class CompanyData
    {
        public List<Company> GetAll()
        {
            var companyList = new List<Company>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT company.company_id, company.name, company.admin_id, company.telephone_number FROM company",
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

                        companyList.Add(company);
                    }
                }

                connection.Close();
            }

            return companyList;
        }

        public Company Get(int companyId)
        {
            Company company = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM company WHERE company_id=@id", connection);
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

        public Company Get(string name)
        {
            Company company = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM company WHERE name=@name", connection);
                command.Parameters.AddWithValue("name", name);
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
                        "UPDATE company SET company_id=@companyId, name=@name, admin_id=@adminId, lastname=@lastName, telephone_number=@telephoneNumber WHERE company_id=@companyId",
                        connection);
                command.Parameters.AddWithValue("companyId", company.CompanyId);
                command.Parameters.AddWithValue("name", company.Name);
                command.Parameters.AddWithValue("adminId", company.AdminId);
                command.Parameters.AddWithValue("telephoneNumber", company.TelephoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int companyId)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE company WHERE company_id=@companyId", connection);
                command.Parameters.AddWithValue("companyId", companyId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
