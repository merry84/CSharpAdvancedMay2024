
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Cooking
{
    public static class Program
    {
        static void Main(string[] args)//
        {
            //You need to start with the first liquid and try to mix it with the last ingredient. 
            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            // Bread     25
            // Cake	     50
            // Pastry    75
            // Fruit Pie 100
            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            //You need to start with the first liquid and try to mix it with the last ingredient.
            //If the sum of their values is equal to any of the items in the table below – cook the food corresponding to the value and remove both the liquid and the ingredient.
            //
            //You need to stop cooking when you have no more liquids or ingredients.
            //In order to cook enough food for the bakery, you need one of each of the foods. 
            while (liquids.Any() && ingredients.Any())
            {
                int liquid = liquids.Peek();
                int ingredient = ingredients.Peek();

                if (liquid + ingredient == 25)
                {//remove both the liquid and the ingredient.
                    bread++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquid + ingredient == 50)
                {
                    cake++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquid + ingredient == 75)
                {
                    pastry++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquid + ingredient == 100)
                {
                    fruitPie++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else //Otherwise, remove only the liquid and increase the value of the ingredient by 3.
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    ingredients.Push(ingredient + 3);
                }
            }
            if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPie >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");

            }

            if (!liquids.Any())
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($": Liquids left: {string.Join(", ", liquids)}");
            }

            if (!ingredients.Any())
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");

        }
    }
}
