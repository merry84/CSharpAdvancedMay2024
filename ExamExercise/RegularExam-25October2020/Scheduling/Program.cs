using System;

namespace Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> threads = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int killTask = int.Parse(Console.ReadLine());
            /*•	It takes the first given thread value and the last given task value.
            •	If the thread value is greater than or equal to the task value, the task and thread get removed.
            •	If the thread value is less than the task value, the thread gets removed, but the task remains.
            */

            while (tasks.Peek() != killTask)
            {
                if (threads.Peek() >= tasks.Peek())
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            //•	Print the thread that killed the task and the task itself in the format given above.
            //•	Print the remaining threads starting from the first on a single line, separated by a single space.
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {killTask}");
            Console.WriteLine(string.Join(" ", threads));


        }
    }
}
