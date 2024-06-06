using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System;

namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //The first line will give you a sequence of integers representing worms.
            //Afterwards, you will be given another sequence of integers representing holes.
            //You have to start with the last worm and try to match it with the first hole.

            //•	If their values are equal, the worm fits the hole and can get into it.
            //After that, you should remove both of them from their sequences.
            //Otherwise, you should remove the hole and decrease the value of the worm by 3.

            //•	If the worm value becomes equal to or below 0, remove it from the sequence before trying to match it with the hole.
            //You need to stop matching when you have no more worms or holes.
            Stack<int> worms = new (Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> holes = new (Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int matchCount = 0;
            int countWorms = worms.Count;
            while (worms.Count > 0 && holes.Count>0)
            {
                int worm = worms.Peek();
                int hole = holes.Peek();
                if(worm == hole)
                {
                    worms.Pop();
                    holes.Dequeue();
                    matchCount++;
                    continue;
                }
                //Otherwise, you should remove the hole and decrease the value of the worm by 3.
                holes.Dequeue();
                worms.Push(worms.Pop() - 3);
                if(worm < 1)
                {
                    worms.Pop();
                }
            }
            /*	If there are matches print the following: 
            o	"Matches: {matchesCount}"
            	If there are no matches print the following:
            o	"There are no matches."
            */
            if (matchCount > 0)
            {
                Console.WriteLine($"Matches: {matchCount}");
            }
            else
            {
                Console.WriteLine($"There are no matches.");
            }
            /*	If there are no worms left and all of them fit a hole:
                o	"Every worm found a suitable hole!"
                	If there are no worms left but only some of them fit a hole:
                o	"Worms left: none"
                */
           
            if (worms.Count == 0 && matchCount == countWorms)
            {
                Console.WriteLine($"Every worm found a suitable hole!");
            }
            else if(worms.Count == 0)
            {

                Console.WriteLine("Worms left: none");
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ",worms)}");
            }
            //	If there are no holes left:
            //o   "Holes left: none"
            //	If there are holes left:
            //o   "Holes left: {hole1}, {hole2}, (…),{holen}"
            if(holes.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {string.Join(", ",holes)}");
            }


        }
    }
}
