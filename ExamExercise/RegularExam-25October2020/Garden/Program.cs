namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            while (true)
            {
                string coordinates = Console.ReadLine();
                if (coordinates == "Bloom Bloom Plow") { break; }
                int row = coordinates.Split(" ").Select(int.Parse).First();
                int col = coordinates.Split(" ").Select(int.Parse).Last();
                //If you receive a position, which is outside of the garden,
                //you should print "Invalid coordinates.
                if (OutOfMatrix(rows, cols, row, col))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int r1 = 0; r1 < matrix.GetLength(0); r1++)
                {
                    for (int c1 = 0; c1 < matrix.GetLength(1); c1++)
                    {
                        if (r1 == row || c1 == col)
                        {
                            matrix[r1, c1] += 1;
                        }

                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static bool OutOfMatrix(int rows, int cols, int row, int col)
        {
            return row < 0
                || row >= rows
                || col < 0
                || col >= cols;
        }
    }
}
