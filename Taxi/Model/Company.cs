using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public  class Company
    {
        public Company()
        {
            Cars = new HashSet<Car>();
            Trips = new HashSet<Trip>();
            User = new HashSet<User>();
        }

        public Company(int companyId, string name, int adminId, string telephoneNumnber)
        {
            this.CompanyId = companyId;
            this.Name = name;
            this.AdminId = adminId;
            this.TelephoneNumber = telephoneNumnber;
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int AdminId { get; set; }
        public string TelephoneNumber { get; set; }

        public  ICollection<Car> Cars { get; set; }
        public  ICollection<Trip> Trips { get; set; }
        public  ICollection<User> User { get; set; }
    }
}
