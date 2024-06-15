
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace TheFightForGondors
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int wavesOfOrcs = int.Parse(Console.ReadLine()); //броя вълните на орките.

            Queue<int> plates = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            Stack<int> orcs = new Stack<int>();
            int plate = plates.Peek();

            for (int i = 1; i <= wavesOfOrcs; i++)
            {
                orcs = new Stack<int>(Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray()); 
                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine())); // Добавете табелата, преди да обработите атаките.
                }
                int orc = orcs.Peek();

                while (true)
                {
                    if (!plates.Any() || !orcs.Any()) break;
                    int damage = Math.Min(plate, orc);
                    plate -=  damage;
                    orc -= damage;

                    if (orc == 0)
                    {
                        orcs.Pop();
                        if (orcs.Any()) orc = orcs.Peek();
                    }

                    if (plate == 0)
                    {
                        plates.Dequeue();
                        if (plates.Any()) plate = plates.Peek();
                    }
                }
                if (!plates.Any())
                {
                    orcs.Pop();
                    orcs.Push(orc);
                    break;

                }
            }
            if (orcs.Any())
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
            else
            {
                List<int> leftPlate = new List<int>(plates);
                leftPlate[0] = plate;
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", leftPlate)}");
            }

        }
    }
}
