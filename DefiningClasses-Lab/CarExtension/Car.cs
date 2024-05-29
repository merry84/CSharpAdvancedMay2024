using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        /*•	fuelQuantity: double
        •	fuelConsumption: double
        */

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double distance)
        {
            /*This method checks if the car fuel quantity minus the distance multiplied by
             * the car fuel consumption is bigger than zero. If it is removed from the fuel quantity,
             * the result of the multiplication between the distance and the fuel consumption*/
            if (distance * fuelConsumption > fuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                fuelQuantity -= distance * fuelConsumption;
            }
        }

        /*•	WhoAmI(): string – returns the following message: 
"Make: {this.Make}
 Model: {this.Model}
 Year: {this.Year}
 Fuel: {this.FuelQuantity:F2}"
*/
        public string WhoAmI() =>
            $"Make: {this.Make}\r\n" +
            $"Model: {this.Model}\r\n" +
            $"Year: {this.Year}\r\n" +
            $"Fuel: {FuelQuantity:F2}";
    }
}
