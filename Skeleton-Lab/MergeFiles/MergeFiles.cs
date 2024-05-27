namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> files1 = new List<string>();
            List<string> files2 = new List<string>();

            using (StreamReader sr = new StreamReader(firstInputFilePath))
            {
                while (!sr.EndOfStream)
                {
                    files1.Add(sr.ReadLine());
                }
            }
            using (StreamReader sr1 = new StreamReader(secondInputFilePath))
            {
                while (!sr1.EndOfStream)
                {
                    files2.Add(sr1.ReadLine());
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                while (files1.Count > 0 && files2.Count>0)
                {
                    writer.WriteLine(files1[0]);
                    writer.WriteLine(files2[0]);

                    files1.RemoveAt(0);
                    files2.RemoveAt(0);
                }
                List<string> leftLines = files1.Count > 0 ? files1 : files2;


                for (int i = 0; i < leftLines.Count; i++)
                {
                    writer.WriteLine(leftLines[i]);
                }
            }
        }
    }
}
