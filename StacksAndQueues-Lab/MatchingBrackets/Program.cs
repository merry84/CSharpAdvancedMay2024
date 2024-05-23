

using System.Linq.Expressions;
using System.Xml.Linq;

string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0;i< input.Length;i++)
{
    if (input[i] ==  '(')
    {
        stack.Push(i);
    }
    //oIf you find an opening bracket, push its index (position in the input expression) into the stack.
    // If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.
    // Use the current and the popped index to extract the sub-expression.

    else if (input[i] == ')') 
    {
        int startIndex = stack.Pop();
        Console.WriteLine(input.Substring(startIndex,i - startIndex+1));
    }
}