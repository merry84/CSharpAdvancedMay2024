

string text = string.Empty;

int operation = int.Parse(Console.ReadLine());

Stack<string> stack = new Stack<string>();

for (int i = 0; i < operation; i++)
{
    string[] command = Console.ReadLine().Split().ToArray();
    if (command[0] == "1")
    {
        stack.Push(text);
        text += command[1];
    }
    else if (command[0] == "2")//erases the last count elements from the text.
    {
        stack.Push(text);
        int countErase = int.Parse(command[1]);
        text = text.Substring(0, text.Length - countErase);

    }
    else if (command[0] == "3")
    {
        int indexReturn = int.Parse(command[1]);
        Console.WriteLine(text[indexReturn-1]);
    }
    else// command[4] == "4"
    {
        text = stack.Pop();//undoes the last not undone command of type 1 or 2
                           //and returns the text to the state before that operation.
    }

}
