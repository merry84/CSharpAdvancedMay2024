namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader sr = new StreamReader(inputFilePath)) 
            {
                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {
                    int counter = 0;
                    while (!sr.EndOfStream)// докато има текс за четене,има стрийм
                    { 
                        string line = sr.ReadLine();
                        counter++;

                        if (counter % 2 == 0)//ако е нечетен ред запиши във файла
                        { 
                            sw.WriteLine(line);
                        }

                    }

                }

            }


        }
    }
}
