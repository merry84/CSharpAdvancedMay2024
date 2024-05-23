

int quatityFood = int.Parse(Console.ReadLine());

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(input);
Console.WriteLine(queue.Max());
while (queue.Count > 0 && quatityFood > 0)
{
    if(quatityFood- queue.Peek() >= 0)
    {
        quatityFood-= queue.Dequeue();
    }
    else
    {
        break;
    }
}
if(!queue.Any())
{

    Console.WriteLine($"Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
}
