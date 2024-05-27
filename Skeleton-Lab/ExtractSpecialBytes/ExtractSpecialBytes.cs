namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {

            byte[] bytesImage = File.ReadAllBytes(binaryFilePath);
            string bytesText = File.ReadAllText(bytesFilePath);
            MatchCollection matchText = Regex.Matches(bytesText, "[0-9]+");

            List<byte> bytesToExtract = new ();
            foreach (Match match in matchText)
            {
                bytesToExtract.Add(byte.Parse(match.ToString()));
            }

            List<byte> commonBytes = new List<byte>();

            for (int i = 0; i < bytesImage.Length; i++)
            {
                if (bytesToExtract.Contains(bytesImage[i]))
                {
                    commonBytes.Add(bytesImage[i]);
                }
            }

            using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
            {
                fileStream.Write(commonBytes.ToArray());
            }
        }
    }
}
