using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count => cars.Count;
        //The class' constructor should initialize the Cars with a new instance of the collection and accept capacity as a parameter. 
        //Implement the following fields:
        //•	Field cars –  a collection that holds added cars.
        //•	Field capacity – accessed only by the base class (responsible for the parking capacity).

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }
        //AddCar(Car Car)
        // The method first checks if there is already a car with the provided car registration number and if there is, the method returns the following message:
        //"Car with that registration number, already exists!"
        //Next check if the count of the cars in the parking is more than the capacity and if it returns the following message:
        //"Parking is full!"
        //Finally, if nothing from the previous conditions is true, it just adds the current
        //"Successfully added new car {Make} {RegistrationNumber}"
        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count > capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            //Removes a car with the given registration number. If the provided registration number does not exist returns the message: 
            //"Car with that registration number, doesn't exist!"
            //Otherwise, removes the car and returns the message:
            //"Successfully removed {registrationNumber}"
            Car car = cars.FirstOrDefault(x=> x.RegistrationNumber == registrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(car);
            return $"Successfully removed {car.RegistrationNumber}";
        }
            //Returns the Car with the provided registration number.
        public Car GetCar(string RegistrationNumber)
        {
           return cars.FirstOrDefault(x=>x.RegistrationNumber == RegistrationNumber);
        }
        //RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        //A void method, which removes all cars that have the provided registration numbers.Each car is removed only if the registration number exists.
        // And the following property:
        //•	Count - Returns the number of stored cars.
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string number in RegistrationNumbers)
            {
                Car car1 =cars.FirstOrDefault(x=>x.RegistrationNumber == number);
                if (car1 != null)
                {
                    cars.Remove(car1);
                }
            }
        }
    }
}
