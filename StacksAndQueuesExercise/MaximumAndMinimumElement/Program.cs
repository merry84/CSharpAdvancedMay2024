

int input = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0;i < input; i++)
{
    string[] action = Console.ReadLine().Split();
    if (action[0] == "1")
    {
        stack.Push(int.Parse(action[1]));
    }
    else if (action[0] == "2" && stack.Count>0)
    {
        stack.Pop();
    }
    else if (action[0] == "3" && stack.Count > 0)
    {
        Console.WriteLine(stack.Max());
    }else if (action[0] == "4" && stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }

}
Console.WriteLine(string.Join(", ", stack.ToArray()));
