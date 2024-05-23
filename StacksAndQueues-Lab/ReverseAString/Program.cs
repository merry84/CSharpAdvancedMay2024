

string input = Console.ReadLine();
Stack<char> output = new Stack<char>();

foreach ( char ch  in input)
{
    output.Push(ch);
}

while (output.Count > 0)
{
    Console.Write(output.Pop());
}
Console.WriteLine();