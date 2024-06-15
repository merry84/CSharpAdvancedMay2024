using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> cars;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => cars.Count;
        //•	Method Add(Car car) – adds an entity to the data if there is an empty cell for the car.
        public void Add(Car car)
        {
            if (Count < Capacity)
            {
                cars.Add(car);
            }
        }
        //•	Method Remove(string manufacturer, string model) – removes the car by given manufacturer and model,
        //if such exists, and returns bool.
        public bool Remove(string manufacturer, string model)
            => cars.Remove(cars.Find(x => x.Manufacturer == manufacturer && x.Model == model));
        //•	Method GetLatestCar() – returns the latest car (by year) or null if it has no cars.
        public Car GetLatestCar() => cars.OrderByDescending(x => x.Year).FirstOrDefault();
        //•	Method GetCar(string manufacturer, string model)
        //– returns the car with the given manufacturer and model or null if there is no such car.
        public Car GetCar(string manufacturer, string model)
            => cars.Find(x => x.Manufacturer == manufacturer && x.Model == model);

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}");
            foreach (var car in cars)
            {
                sb.AppendLine($"{car.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
