namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rows = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }
            Snake snake = new(GetCoords(matrix));

            while (!snake.OutOfMatrix && snake.Food < 10)
            {
                snake.MoveInMatrix(matrix);

            }
            if (snake.OutOfMatrix)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine($"You won! You fed the snake.");
                matrix[snake.Row, snake.Col] = 'S';
            }
            Console.WriteLine($"Food eaten: {snake.Food}");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        //стартова позиция на змията        
        public static (int, int) GetCoords(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S')
                        return (i, j);
                }
            }
            return (0, 0);
        }

    }
    class Snake
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Food { get; set; }
        public bool OutOfMatrix { get; set; }
        public Snake((int, int) coordinates)
        {
            Row = coordinates.Item1;
            Col = coordinates.Item2;
            Food = 0;
            OutOfMatrix = false;
        }
        public void MoveInMatrix(char[,] matrix)
        {
            matrix[Row, Col] = '.';
            string direction = Console.ReadLine();
            if (direction == "up") { Row--; }
            if (direction == "down") { Row++; }
            if (direction == "left") { Col--; }
            if (direction == "right") { Col++; }
            if (isValid(matrix))
            {
                OutOfMatrix = true;
                return;
            }
            char symbol = matrix[Row, Col];
            if (symbol == '*')//храна
            {
                Food++;
                matrix[Row, Col] = '.';
            }
            if (symbol == 'B')//дупка
            {//излизаме през другата дупка и изчезват
                matrix[Row, Col] = '.';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {
                            Row = i;
                            Col = j;
                        }
                    }
                }
                matrix[Row, Col] = '.';
            }
        }
        public bool isValid(char[,] matrix)
        {
            return Row < 0
                || Row == matrix.GetLength(0)
                || Col < 0
                || Col == matrix.GetLength(1);
        }
    }

}
