namespace FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You will be given two sequences of integers, representing roses and lilies.
             * You need to start making wreaths knowing that one wreath needs 15 flowers. 
             * Your goal is to make at least 5 flower wreaths.
               You will start crafting from the last lilies and the first roses. 
            If the sum of their values is equal to 15 – create one wreath and remove them. 
            If the sum is bigger than 15, just decrease the value of the lilies by 2.
            If the sum is less than 15 you have to store them for later and remove them. 
            You need to stop combining when you have no more roses or lilies. 
            In the end, if you have any stored flowers you should make as many wreaths as you can with them. 
                */
            Stack<int> lilies = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> roses = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse));
            int wreaths = 0;
            int flowersCount = 0;
            while (true)
            {
                if (!lilies.Any() || !roses.Any()) { break; }
                int lilie = lilies.Peek();
                int rose = roses.Peek();
                int sumFlowers = lilie + rose;
                if (sumFlowers > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                    continue;
                }
                else if (sumFlowers < 15)
                {
                    flowersCount += sumFlowers;
                }
                else
                { wreaths++; }

                lilies.Pop();
                roses.Dequeue();
            }
            /*•	Print whether you have succeeded in making at least 5 wreaths:
                o	"You made it, you are going to the competition with {count of wreaths} wreaths!" 
                o	"You didn't make it, you need {wreaths needed} wreaths more!"
                */
            wreaths += flowersCount / 15;
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {Math.Abs(5 - wreaths)} wreaths more!");
            }
        }
    }
}
