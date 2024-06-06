using System.Threading;

namespace EscapeTheMaze
{
    internal class Program
    {
        //•	'P' - Represents the starting position of the traveller.
        //•	'X' - Represents the location of the exit that leads outside of the maze.
        //•	'M' - Represents a monster which wants to harm the traveller.
        //•	'H' - Represents a health potion which will restore the health of the traveller.
        //•	'-' – Represents the maze's corridors, which the traveller can walk through.

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = -1;
            int cols = -1;
            string[,] matrix = new string[size, size];

            //пълним матрицата
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string element = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (element[j].ToString() == "P")
                    {
                        rows = i; cols = j;
                        matrix[i, j] = "-";
                    }
                    matrix[i, j] = element[j].ToString();
                }
            }
            int health = 100;

           
            while (true)
            {
                string input = Console.ReadLine();
                bool outOfMatrix = OutOfBound(matrix, input, rows, cols);
                if (outOfMatrix) continue;
                PlayerStep(input, rows, cols);

                string position = matrix[rows, cols];
                if (position == "M")
                {
                    health -= 40;
                    if (health <= 0)
                    {
                        health = 0;
                        Console.WriteLine($"Player is dead. Maze over!");
                        break;
                    }
                    matrix[rows, cols] = "-";
                }
                if(position == "H")
                {
                    health += 15;
                    if(health > 100)
                    {
                        health = 100;
                    }
                    matrix[rows, cols] = "-";
                }
                if(position == "X")
                {
                    Console.WriteLine("Player escaped the maze. Danger passed!");
                    break;
                }
            }
            matrix[rows,cols] = "P";
            Console.WriteLine($"Player's health: {health} units");
            PrintMatrix(matrix);

        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void PlayerStep(string direction,  int playerRow,  int playerCol)
        {
            if (direction == "left")
            {
                playerCol--;
            }
            if (direction == "up")
            {
                playerRow--;
            }
            if (direction == "right")
            {
                playerCol++;
            }
            if (direction == "down")
            {
                playerRow++;
            }
        }
        private static bool OutOfBound(string[,] matrix, string direction, int playerRow, int playerCol)
        {
            if ((direction == "up" && playerRow == 0) || (direction == "down" && playerRow == matrix.GetLength(0) - 1) ||
                (direction == "left" && playerCol == 0) || (direction == "right" && playerCol == matrix.GetLength(1) - 1))
            {
                return true;
            }
            return false;
        }
       
    }
}
