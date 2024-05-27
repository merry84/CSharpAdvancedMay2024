namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

            long sum = 0;

            foreach (FileInfo file in files)
            {
                sum += file.Length;
            }

            string sizeInKb = $"{(double)sum / 1024} KB";
            File.WriteAllText(outputFilePath, sizeInKb);
        }
    }
}
