

int[] clothes = Console.ReadLine().Split()
    .Select(int.Parse)
    .ToArray();

int capacityRack = int.Parse(Console.ReadLine());

int countRack = 1;
int sum = 0;
Stack<int> stack = new Stack<int>(clothes);

while (stack.Count > 0)
{
    if (capacityRack >= stack.Peek() + sum)
    {
        sum += stack.Pop();

    }
    else
    {
      
       sum =stack.Pop();
        countRack++;
    }
 }
Console.WriteLine(countRack);
;