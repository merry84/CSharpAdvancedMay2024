namespace TheGambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int currentRow = 0;
            int currentColumn = 0;

            for (int i = 0; i < size; i++)
            {
                char[] newRow = Console.ReadLine().Trim().ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = newRow[j];
                    if (newRow[j] == 'G')
                    {
                        currentRow = i;
                        currentColumn = j;
                    }

                }
            }
            int amount = 100;
            bool OutOfMatrix = false;

            string command;
            while ((command = Console.ReadLine()) != "end" && amount != 0)
            {
                matrix[currentRow, currentColumn] = '-';
                if (command == "up")
                {
                    currentRow--;
                }
                else if (command == "down")
                {
                    currentRow++;
                }
                else if (command == "left")
                {
                    currentColumn--;
                }
                else if (command == "right")
                {
                    currentColumn++;
                }
                if (!MoveInMatrix(matrix, currentRow, currentColumn))
                {
                    OutOfMatrix = true;
                    break;
                }
                if (matrix[currentRow, currentColumn] == 'W')//is reached the gambler takes it and adds 100$ to his amount
                {
                    amount += 100;
                }
                else if (matrix[currentRow, currentColumn] == 'P')//is reached decrease the gambler's total amount by 200$
                {
                    amount -= 200;
                }
                else if (matrix[currentRow, currentColumn] == 'J')//the gambler wins the jackpot and adds 100000$ to his amount
                                                                  //and the game ends.
                {
                    Console.WriteLine("You win the Jackpot!");
                    amount += 100000;
                    break;

                }

            }
            if (OutOfMatrix || amount <= 0)
            {
                Console.WriteLine($"Game over! You lost everything!");
                return;

            }
            matrix[currentRow, currentColumn] = 'G';//започва от старт  позиция
            Console.WriteLine($"End of the game. Total amount: {amount}$");
            PrintMatrix(matrix);

        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        static bool MoveInMatrix(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

    }
}

}
    

