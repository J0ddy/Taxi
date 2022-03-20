using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Data;
using Taxi.Data.Models;

namespace Taxi.Views
{
    class DisplayCars
    {
        public DisplayCars()
        {
            Output();
        }

        public DisplayCars(int id)
        {
            OutputById(id);
        }

        private void Output()
        {
            CarData carData = new CarData();
            CarOptionsData carOptionsData = new CarOptionsData();
            EngineData engineData = new EngineData();
            List<Car> cars = carData.GetAll();
            List <CarOptions> carOptions = carOptionsData.GetAll();
            List<Engine> engines = engineData.GetAll();
            StringBuilder sb = new StringBuilder();
            foreach (var car in cars)
            {
                CarOptions carOptions1 = carOptions[car.CaroptionsId-1];
                Engine engine = engines[car.EngineId-1];
                sb.AppendLine($"{car.CarId,2} | {car.License,2} | {Utils.FirstUpperCase(car.Make),2}" +
                              $"{Utils.FirstUpperCase(car.Model),2} {car.Year,2} {Utils.FirstUpperCase(car.Color),2}" +
                              $"{engine.Cub,2} {Utils.FirstUpperCase(engine.Fuel),2} {engine.Kmtolitre,2}");
                sb.AppendLine(
                    $"Autopilot: {(carOptions1.Autopilot ?? false ? "Yes":"No")} | Airbag: " +
                    $"{(carOptions1.ActiveAirbag ?? false ? "Yes" : "No")} | " +
                    $"USB: {(carOptions1.UsbPort ?? false ? "Yes" : "No")} | Multimedia: " +
                    $"{(carOptions1.Multimedia ?? false ? "Yes" : "No")} | EngineMode: {carOptions1.EngineMode,2}\n");
            }
            Console.WriteLine(sb);
        }

        private void OutputById(int id)
        {
            CarData carData = new CarData();
            CarOptionsData carOptionsData = new CarOptionsData();
            EngineData engineData = new EngineData();
            Car car = carData.Get(id);
            CarOptions carOptions = carOptionsData.Get(car.CaroptionsId);
            Engine engine = engineData.Get(car.EngineId);
            Console.WriteLine($"{car.CarId,2} | {car.License,2} | {Utils.FirstUpperCase(car.Make),2}" +
                              $"{Utils.FirstUpperCase(car.Model),2} {car.Year,2} {Utils.FirstUpperCase(car.Color),2}" +
                              $"{engine.Cub,2} {Utils.FirstUpperCase(engine.Fuel),2} {engine.Kmtolitre,2}"+
                              $"Autopilot: {(carOptions.Autopilot ?? false ? "Yes" : "No")} | Airbag: " +
                              $"{(carOptions.ActiveAirbag ?? false ? "Yes" : "No")} | " +
                              $"USB: {(carOptions.UsbPort ?? false ? "Yes" : "No")} | Multimedia: " +
                              $"{(carOptions.Multimedia ?? false ? "Yes" : "No")} | EngineMode: {carOptions.EngineMode,2}\n");
        }
    }
}
