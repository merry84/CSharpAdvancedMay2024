


List<int> nubers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
Stack<int> stack = new Stack<int>();
foreach (var n in nubers)
{
    stack.Push(n);
}

string command;
while((command = Console.ReadLine().ToLower())!= "end")
{
    string[] elements= command.Split(" ");
    int firstNumber = int.Parse(elements[1]);
    if (elements[0] == "add")
    {
        int secondNumber = int.Parse(elements[2]);
        stack.Push(firstNumber);
        stack.Push(secondNumber);
    }
    else
    {
        if(stack.Count>= firstNumber)
        {
            for (int i = 0; i < firstNumber; i++)
            stack.Pop();
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");

