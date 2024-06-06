namespace ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];
            int enemyCount = 0;
            int amor = 300;

            int planeRow = -1;
            int planeCol = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)// рандъм позиция и послe "-"
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newRow[j].ToString();
                    if (newRow[j] == 'J')
                    {

                        planeRow = i;
                        planeCol = j;
                        matrix[i, j] = "-";

                    }
                    else if (newRow[j] == 'E')
                    {
                        enemyCount++;

                    }
                }
            }
            /*The jetfighter will start at a random position, marked with the letter 'J'. 
             * In random positions also, enemy aircraft will be marked with the letter 'E'. 
             * There will also be repair points marked with the letter 'R'. 
             * All of the empty positions will be marked with the symbol'-'.  
            HINT: It may be helpful to track the count of the enemy aircraft.
            The jetfighter has an initial armor value of 300 units. When it receives a command, 
            it moves one position towards the given direction. 
            The program will end when аll enemy planes are shot down or the jetfighter’s armor becomes 0. 
            The final state of the airspace, must always be printed on the console at the end.
            */
            while (enemyCount > 0)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "up")
                {
                    planeRow--;
                }
                if (command == "down")
                {
                    planeRow++;
                }
                if (command == "left")
                {
                    planeCol--;
                }
                if (command == "right")
                {
                    planeCol++;
                }
                string position = matrix[planeRow, planeCol];
                matrix[planeRow, planeCol] = "-";
                if (position == "E")
                {
                    //	In case this is not the last enemy, the jetfighter takes damage – its armor loses 100 units.
                    enemyCount--;
                    amor -= 100;
                }
                if (amor == 0)
                {
                    /*o	If its armor reaches zero, it crashes and the mission fails. 
                     * The program ends and the following message should be displayed on the console:
                     * "Mission failed, your jetfighter was shot down! Last coordinates [{row}, {col}]!"
                    o	Do not forget the final state of the airspace */
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{planeRow}, {planeCol}]!");
                    PrintMatrix(matrix, planeRow, planeCol);
                    return;
                }
                if (position == "R")
                {
                    amor = 300;
                }
            }
            /*	In case this is the last enemy, the program ends and the following message should be displayed on the console: 
             * "Mission accomplished, you neutralized the aerial threat!"
            o	Do not forget the final state of the airspace.
            */
            Console.WriteLine($"Mission accomplished, you neutralized the aerial threat!");
            PrintMatrix(matrix, planeRow, planeCol);
        }

        private static void PrintMatrix(string[,] matrix, int planeRow, int planeCol)
        {
            matrix[planeRow, planeCol] = "J";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
