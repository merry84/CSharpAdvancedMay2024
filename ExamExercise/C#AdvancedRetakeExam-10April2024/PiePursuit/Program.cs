using System;
using System.Collections.Generic;
using System.Linq;

class PiePursuit
{
    static void Main(string[] args)
    {
        
        Queue<int> contestants = new (Console.ReadLine()
            .Split()
            .Select(int.Parse));
        Stack<int> pies = new (Console.ReadLine()
            .Split()
            .Select(int.Parse));

        while (contestants.Count > 0 && pies.Count > 0)
        {
            int contestant = contestants.Dequeue();
            int pie = pies.Pop();

            if (contestant >= pie)
            {
                // Contestant can eat the pie
                contestant -= pie;

                if (contestant > 0)
                {
                    // Move contestant to the back with remaining capacity
                    contestants.Enqueue(contestant);
                }
            }
            else
            {
                // Contestant cannot eat the whole pie
                pie -= contestant;

                if (pies.Count > 0)
                {
                    int nextPie = pies.Pop();
                    pies.Push(nextPie + pie);
                }
                else
                {
                    pies.Push(pie);
                }
            }
        }

        if (pies.Count == 0 && contestants.Count > 0)
        {
            Console.WriteLine("We will have to wait for more pies to be baked!");
            Console.WriteLine($"Contestants left: {string.Join(", ", contestants)}");
        }
        else if (pies.Count == 0 && contestants.Count == 0)
        {
            Console.WriteLine("We have a champion!");
        }
        else if (contestants.Count == 0 && pies.Count > 0)
        {
            Console.WriteLine("Our contestants need to rest!");
            Console.WriteLine($"Pies left: {string.Join(", ", pies)}");
        }
    }
}