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

            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
        }
    }
}
/*•	make: string
•	model: string
•	year: int
*/

