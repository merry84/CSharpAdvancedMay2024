

string[]input = Console.ReadLine().Split();
//o	Input expression: 2 + 5 + 10 - 2 - 1
// Stack: 1 - 2 - 10 + 5 + 2

Stack<string> output = new Stack<string>(input.Reverse());

int sumExpretion = int.Parse(output.Pop());//Pop the last number (in the above example 2). It is the current result.
while (output.Count > 0)
{
    string operation = output.Pop();
    int number = int.Parse(output.Pop());
    if(operation == "+")
    {
        sumExpretion += number;
    }
    else
    {
        sumExpretion -= number;
    }
}
Console.WriteLine(sumExpretion);
