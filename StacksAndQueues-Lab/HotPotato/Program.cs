

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
int passes = int.Parse(Console.ReadLine());
Queue<string> queue = new(names);
while (queue.Count>1)
{
    for (int i = 1; i < passes; i++)
    {
        queue.Enqueue(queue.Dequeue());
    }
    Console.WriteLine($"Removed {queue.Dequeue()}");
}
Console.WriteLine($"Last is {queue.Dequeue()}");