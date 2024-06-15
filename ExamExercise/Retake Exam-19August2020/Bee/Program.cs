using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _02Bee
{
    public class Program
    {
        private const int a = 5;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] rows = Console.ReadLine().ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            Bee bee = new Bee(GetCoords(matrix));

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                bee.Move(command, matrix);
                if (bee.Lost) break;
            }

            if (bee.Lost) Console.WriteLine($"The bee got lost!");
            else matrix[bee.Row, bee.Col] = 'B';

            if (bee.Flowers < a)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {a - bee.Flowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {bee.Flowers} flowers!");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static (int, int) GetCoords(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'B')
                        return (i, j);
                }
            }
            return (0, 0);
        }
    }
    class Bee
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Flowers { get; set; }
        public bool Lost { get; set; }
        public Bee((int, int) coords)
        {
            Row = coords.Item1;
            Col = coords.Item2;
            Flowers = 0;
            Lost = false;
        }
        public void Move(string command, char[,] matrix)
        {
            matrix[Row, Col] = '.';
            switch (command)
            {
                case "up": Row--; break;
                case "down": Row++; break;
                case "left": Col--; break;
                case "right": Col++; break;
            }
            if (IsOutOfMatrix(matrix))
            {
                Lost = true;
                return;
            }
            char symbol = matrix[Row, Col];

            if (symbol == 'f')
            {
                Flowers++;
            }

            matrix[Row, Col] = '.';

            if (symbol == 'O')
            {
                Move(command, matrix);
            }
        }

        public bool IsOutOfMatrix(char[,] matrix)
        {
            return Row < 0 || Row >= matrix.GetLength(0) || Col < 0 || Col >= matrix.GetLength(1);
        }
    }
}