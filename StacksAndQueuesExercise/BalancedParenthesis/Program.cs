
char[] input = Console.ReadLine().ToCharArray();

if (input.Length % 2 != 0)
{
    Console.WriteLine("NO");
    return;
}
Stack<char> parenthesis = new Stack<char>();

foreach (char item in input)
{
    if ("({[".Contains(item))//ако в стринга се съдържа една от скобите
    {
        parenthesis.Push(item);
    }
    else if (item == ')' && parenthesis.Peek() == '(')//ако е затваряща и имаме отваряща
    {
        parenthesis.Pop();//махаме от стека
    }
    else if (item == '}' && parenthesis.Peek() == '{')
    {
        parenthesis.Pop();
    }
    else if (item == ']' && parenthesis.Peek() == '[')
    {
        parenthesis.Pop();
    }
}
if (parenthesis.Any())//ако има скоби още
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}

