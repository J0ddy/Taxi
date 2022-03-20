using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public  class Engine
    {
        public Engine()
        {
            Cars = new HashSet<Car>();
        }

        public Engine(int engineId, int cub, int cylinders, string fuel, int kmToLitre)
        {
            this.EngineId = engineId;
            this.Cub = cub;
            this.Cylinders = cylinders;
            this.Fuel = fuel;
            this.Kmtolitre = kmToLitre;
        }

        public Engine(int cub, int cylinders, string fuel, int kmToLitre)
        {
            this.Cub = cub;
            this.Cylinders = cylinders;
            this.Fuel = fuel;
            this.Kmtolitre = kmToLitre;
        }

        public Engine(int engineId, string fuel, int kmToLitre)
        {
            this.EngineId = engineId;
            this.Fuel = fuel;
            this.Kmtolitre = kmToLitre;
        }

        public int EngineId { get; set; }
        public int? Cub { get; set; }
        public int? Cylinders { get; set; }
        public string Fuel { get; set; }
        public int Kmtolitre { get; set; }

        public  ICollection<Car> Cars { get; set; }
    }
}
