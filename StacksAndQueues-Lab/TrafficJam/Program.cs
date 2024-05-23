

int numersCars = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();

string input;
int carsPassed = 0;
while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < numersCars && cars.Any(); i++)
        {
            Console.WriteLine($"{cars.Dequeue()} passed!");
            carsPassed++;
        }
    }
    else
    {
        cars.Enqueue(input);

    }
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");
