namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Make = "volvo";
            car.Model = "525";
            car.Year = 1998;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());


        }
    }
}
/*•	make: string
•	model: string
•	year: int
*/

