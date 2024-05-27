namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            List<string> words = new List<string>();////quick is fault
            Dictionary<string, int> wordOccurrence = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(wordsFilePath))//quick is fault
            {
                words = reader.ReadToEnd().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            //-I was quick to judge him, but it wasn't his fault.
            // -Is this some kind of joke?! Is it?
            // -Quick, hide here…It is safer.
            // =>

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                string input = reader.ReadToEnd();
                MatchCollection matches = Regex.Matches(input, "[a-zA-z]+");

                foreach (var match in matches)
                {
                    string word = match.ToString().ToLower();

                    if (words.Contains(word))//finds how many times each of the words occurs in another file 
                    {
                        if (!wordOccurrence.ContainsKey(word))
                        {
                            wordOccurrence.Add(word, 1);
                            continue;
                        }

                        wordOccurrence[word]++;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // Sort the words by frequency in descending order.
                foreach (var kvp in wordOccurrence.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
                //is - 3
                // quick - 2
                // fault - 1
                // 
            }

        }
    }
}
