﻿using System.Data.SqlClient;

namespace Taxi.Data
{
    public static class Database
    {
        private static readonly string connectionString =
            "Server=COMP3\\NEWSERVER; Database=TaxiDB; Integrated Security=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}