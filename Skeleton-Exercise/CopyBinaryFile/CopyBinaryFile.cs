namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream fileOpen = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream fileCreate = new FileStream(outputFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int bytesRead = fileOpen.Read(buffer);

                        if (bytesRead == 0)
                        {
                            break;
                        }

                        fileCreate.Write(buffer, 0, bytesRead);
                    }

                }
            }
        }
    }
}
