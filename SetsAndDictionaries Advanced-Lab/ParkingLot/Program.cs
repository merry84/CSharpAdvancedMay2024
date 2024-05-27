

string input;
HashSet<string> parking = new();

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string direction = tokens[0];
    string carNumber = tokens[1];

    if (direction == "IN")
    {
        parking.Add(carNumber);
    }
    if (direction == "OUT")
    {
        parking.Remove(carNumber);
    }
}
if (parking.Count > 0)
{
    foreach (string car in parking)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}