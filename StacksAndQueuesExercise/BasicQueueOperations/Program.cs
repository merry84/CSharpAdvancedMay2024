



int[] operatoin = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> stack = new(numbers);

int elementToPush = operatoin[0];
int elementToPop = operatoin[1];
int elemettsToPeek = operatoin[2];
for (int i = 0; i < elementToPop; i++)
{
    stack.Dequeue();
}
if (stack.Contains(elemettsToPeek))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}



