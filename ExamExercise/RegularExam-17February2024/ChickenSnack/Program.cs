using System.Drawing;

namespace ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, you will receive the integers,
            //representing the amount of money size, separated by a single space. 
            //	On the second line, you will receive the integers,
            //	representing the price size, separated by a single space
            int[] amountOfMoney = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] priceFoods = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            // You have to start with the last element from the amount of money sequence and
            // compare it with the first element from the prices sequence
            Stack<int> moneyPocket = new(amountOfMoney);
            Queue<int> price = new(priceFoods);

            int foodCount = 0;

            /*•	If their values are equal, Henry buys the food. After that, you should remove both of them from their sequences.
            •	If the amount of money is bigger than the price, he buys the food again,
            taking change (the difference between the amount of money and the price) and putting it in his pocket.
            You should calculate the difference between the values, and keep it. 
            o	Remove the current amount of money from its sequence and increase the next amount of money value
            in the sequence by the resulting difference you have calculated.
            o	Remove the price from the prices sequence.
            •	If the amount of money is lower than the price remove both of them from their sequences.
            You need to stop comparing when you have no more amounts of money or prices
            */

            while (moneyPocket.Any() && price.Any())
            {
                int money = moneyPocket.Peek();
                int priceFood = price.Peek();
                if (money == priceFood)
                {
                    price.Dequeue();
                    moneyPocket.Pop();
                    foodCount++;
                }
                else if (money > priceFood)
                {
                    int diffPrice = money - priceFood;
                    price.Dequeue();
                    moneyPocket.Pop();
                    if (moneyPocket.Any())
                    {
                        moneyPocket.Push(moneyPocket.Pop() + diffPrice);
                    }
                    else
                    {
                        moneyPocket.Push(diffPrice);
                    }

                    foodCount++;

                }
                else if (money < priceFood)
                {
                    price.Dequeue();
                    moneyPocket.Pop();
                }
            }


            if (foodCount >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodCount} foods.");
            }
            else if (foodCount > 0)
            {
                if (foodCount > 1)
                {
                    Console.WriteLine($"Henry ate: {foodCount} foods.");
                }
                else
                {
                    Console.WriteLine($"Henry ate: {foodCount} food.");

                }

            }
            else
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
