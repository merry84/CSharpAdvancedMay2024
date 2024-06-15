using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //You need to start from the first bomb effect and try to mix it with the last bomb casing. 
            Queue<int> bombEffect = new Queue<int>(Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray());
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray());


            int daturaBombs = 0;//Datura Bombs: 40
            int cherryBombs = 0;//Cherry Bombs: 60
            int smokeBombs = 0;//Smoke Decoy Bombs: 120
            bool allBombs = false;
            while (bombEffect.Any() && bombCasing.Any())
            {//If the sum of their values is equal to any of the materials in the table below – create the bomb corresponding to the value and remove both bomb materials.
                int effect = bombEffect.Peek();
                int casing = bombCasing.Peek();
                if (effect + casing == 40)
                {
                    daturaBombs++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if (effect + casing == 60)
                {
                    cherryBombs++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if (effect + casing == 120)
                {
                    smokeBombs++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else//Otherwise, just decrease the value of the bomb casing by 5.
                {
                    bombCasing.Pop();
                    bombCasing.Push(casing - 5);
                }
                // To fill the bomb pouch, Ezio needs three of each of the bomb types.
                // You need to stop combining when you have no more bomb effects or bomb casings, or you successfully filled the bomb pouch.
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeBombs >= 3)
                {
                    allBombs = true;
                    break;
                }

            }

            if (allBombs)//print one of these rows according to whether Ezio succeeded in fulfilling the bomb pouch:
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else { Console.WriteLine("You don't have enough materials to fill the bomb pouch."); }

            if (bombEffect.Count == 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeBombs}");

        }
    }
}
