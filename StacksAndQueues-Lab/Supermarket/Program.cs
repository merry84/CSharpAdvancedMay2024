


string input;
Queue<string> queue = new Queue<string>();

while ((input = Console.ReadLine()) != "End")
{

    if (input == "Paid")
    {
        while (queue.Any())
        {
            Console.WriteLine(string.Join("\n", queue));
            queue.Clear();
        }
    }

    else
    {
        queue.Enqueue(input);

    }
}
Console.WriteLine($"{queue.Count} people remaining.");
