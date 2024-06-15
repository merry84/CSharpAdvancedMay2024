namespace SuperMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int livesMario = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];

            int rowMario = 0;
            int colMario = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i] = input;
                    if (matrix[i][j] == 'M')
                    {
                        rowMario = i;
                        colMario = j;
                    }
                }
            }
            bool isAlive = false;
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                char direction = char.Parse(tokens[0]);
                int spownRow = int.Parse(tokens[1]);
                int spownCol = int.Parse(tokens[2]);
                //•	First, Bowser spawns on the given index.
                matrix[spownRow][spownCol] = 'B';
                livesMario--;
                /*•	Then, Mario moves in a direction, which decreases his lives by 1.
                   It can be "W" (up), "S" (down), "A" (left), "D" (right).
                   If Mario tries to move outside of the maze, he doesn’t move but still has his lives decreased.
                   If an enemy is in the same cell where Mario moves, 
                Bowser fights him, which decreases his lives by 2. 
                .
                   If Mario kills the enemy successfully, the enemy disappears.
                   If Mario reaches the index where the throne is,
                he saves Princess Peach and they both run away (disappear from the field),
                even if his lives are 0 or below.
                    */
                if (direction == 'W')//up
                {
                    if (rowMario - 1 < 0) continue;
                    matrix[rowMario][colMario] = '-';
                    rowMario--;
                }
                if (direction == 'S')//down
                {
                    if (rowMario + 1 == rows) continue;
                    matrix[rowMario][colMario] = '-';
                    rowMario++;
                }
                if (direction == 'A')//left
                {
                    if (colMario - 1 < 0) continue;
                    matrix[rowMario][colMario] = '-';
                    colMario--;
                }
                if (direction == 'D')//right
                {
                    if (colMario + 1 == matrix[rowMario].Length) continue;
                    matrix[rowMario][colMario] = '-';
                    colMario++;
                }
                //If Mario’s lives drops at 0 or below, he dies and you should mark his position with ‘X’
                if (livesMario <= 0)
                {
                    matrix[rowMario][colMario] = 'X';
                    break;
                }
                //If an enemy is in the same cell where Mario moves, 
                // Bowser fights him, which decreases his lives by 2.
                if (matrix[rowMario][colMario] == 'B')//enemy
                {
                    livesMario -= 2;
                    if (livesMario <= 0)
                    {
                        matrix[rowMario][colMario] = 'X';
                        break;
                    }

                }
                //•	If Mario reaches the index where the throne is,
                //he saves Princess Peach and they both run away (disappear from the field),
                //even if his lives are 0 or below
                else if (matrix[rowMario][colMario] == 'P')//princess
                {
                    isAlive = true;
                    matrix[rowMario][colMario] = '-';
                    break;
                }
                matrix[rowMario][colMario] = 'M';
            }
            /*•	If Mario runs out of lives, print "Mario died at {row};{col}."
            •	If Mario reaches the throne, print "Mario has successfully saved the princess! Lives left: {lives}"
            •	Then, in all cases, print the final state of the field on the console.
            */
            if (isAlive)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {livesMario}");
            }
            else
            {
                Console.WriteLine($"Mario died at {rowMario};{colMario}.");
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(matrix[i]);
            }
        }
    }
}
