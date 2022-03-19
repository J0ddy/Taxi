using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public partial class Car
    {
        public Car()
        {
            Driver = new HashSet<Driver>();
            Trips = new HashSet<Trip>();
        }

        public Car(int id, string license, string make, string model, string color, int companyId, string year, int engineId, int carOptionsId)
        {
            this.CarId = id;
            this.License = license;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.CompanyId = companyId;
            this.Year = year;
            this.EngineId = engineId;
            this.CaroptionsId = carOptionsId;
        }
        public int CarId { get; set; }
        public string License { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int CompanyId { get; set; }
        public string Year { get; set; }
        public int EngineId { get; set; }
        public int CaroptionsId { get; set; }

        public virtual CarOptions Caroptions { get; set; }
        public virtual Company Company { get; set; }
        public virtual Engine Engine { get; set; }
        public virtual ICollection<Driver> Driver { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
