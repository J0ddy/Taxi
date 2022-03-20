using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Views
{
    class DisplayCompanies
    {
        public DisplayCompanies()
        {
            Output();
        }

        public DisplayCompanies(int id)
        {
            OutputById(id);
        }

        private void Output()
        {
            CompanyData companyData = new CompanyData();
            UserData userData = new UserData();
            List<Company> companies = companyData.GetAll();
            List<User> users = userData.GetAll();
            StringBuilder sb = new StringBuilder();
            foreach (var company in companies)
            {
                sb.AppendLine($"{company.Name,12} | {company.TelephoneNumber,13} | Admin: {users.Where(x => x.DriverId == company.AdminId).ElementAt(0).UserName,10}");
            }
            Console.WriteLine(sb);
        }

        private void OutputById(int id)
        {
            CompanyData companyData = new CompanyData();
            UserData userData = new UserData();
            Company company = companyData.Get(id);
            Console.WriteLine($"{company.Name,12} | {company.TelephoneNumber,13} | Admin: {userData.Get(company.AdminId).UserName,10}");
        }
    }
}
