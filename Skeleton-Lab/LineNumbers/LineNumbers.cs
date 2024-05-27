namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {
                    int count = 1;
                    while (!sr.EndOfStream)// докато има текс за четене,има стрийм
                    {
                       
                        string line = sr.ReadLine();
                        sw.WriteLine($"{count}. {line}");
                        count++;                       

                    }

                }

            }
        }
    }
}
