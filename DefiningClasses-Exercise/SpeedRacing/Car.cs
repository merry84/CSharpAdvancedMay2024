using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        /*•	string Model
        •	double FuelAmount
        •	double FuelConsumptionPerKilometer
        •	double Travelled distance
        */
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double distance;
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm, double distance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            Distance = distance;

        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double Distance { get; set; }
        //If it can, the car's fuel amount should be reduced by the amount of used fuel and
        //its traveled distance should be increased by the number of the traveled kilometers.
        //Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same)
        //and you should print on the console:
        //"Insufficient fuel for the drive"

        public void DriveCar(double km)
        {
            if (km * FuelConsumptionPerKm > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= km * FuelConsumptionPerKm;
                Distance += km;
            }
        }
    }
}
