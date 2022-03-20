using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Logic
{
    class CompanyManager
    {
        private readonly CompanyData companyData = new CompanyData();
        public List<Company> GetAll()
        {
            return companyData.GetAll();
        }

        public Company Get(int id)
        {
            return companyData.Get(id);
        }

        public Company Get(string name)
        {
            return companyData.Get(name);
        }

        public void Add(Company company)
        {
            companyData.Add(company);
        }

        public void Update(Company company)
        {
            companyData.Update(company);
        }

        public void Delete(int id)
        {
            companyData.Delete(id);
        }
    }
}
