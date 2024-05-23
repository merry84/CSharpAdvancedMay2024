
int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

int countPassed = 0;
Queue<string> queueCar = new Queue<string>();

string input;

while ((input = Console.ReadLine()) != "END")
{
    if (input == "green")
    {

        int timeAvailable = greenLight;
        while (timeAvailable > 0 && queueCar.Count > 0)
        {
            string currentCar = queueCar.Dequeue();
            if (timeAvailable - currentCar.Length >= 0)
            {
                timeAvailable -= currentCar.Length;
                countPassed++;
                continue;
            }
            else if (timeAvailable + freeWindow - currentCar.Length >= 0)
            {
                countPassed++;
                break;
            }
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currentCar} was hit at {currentCar[timeAvailable]}.");
            return;
        }
    }

    queueCar.Enqueue(input);
    continue;

}

//"Everyone is safe.".
//"{totalCarsPassed} total cars passed the crossroads.".
Console.WriteLine($"Everyone is safe.");
Console.WriteLine($"{countPassed} total cars passed the crossroads.");

