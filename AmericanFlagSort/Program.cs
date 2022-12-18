using System;
using System.Collections.Generic;

namespace AmericanFlagSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list of words to sort
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape" };

            // Sort the words using American Flag Sort
            AmericanFlagSort(words);

            // Print the sorted words
            Console.WriteLine("Sorted words: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }

        static void AmericanFlagSort(List<string> words)
        {
            // The alphabet used in the words
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // A list of positions representing the current position in each word
            int[] positions = new int[words.Count];

            // While there are still unsorted words
            while (true)
            {
                // Create a list of buckets, one for each character in the alphabet
                List<string>[] buckets = new List<string>[alphabet.Length];
                for (int i = 0; i < buckets.Length; i++)
                {
                    buckets[i] = new List<string>();
                }

                // Iterate over the words and add them to the appropriate bucket
                Console.WriteLine("Current positions: " + string.Join(", ", positions));
                for (int i = 0; i < words.Count; i++)
                {
                    // If the current position in the word is past the end of the word, the word is sorted
                    if (positions[i] >= words[i].Length)
                    {
                        continue;
                    }

                    // Get the character at the current position in the word
                    char c = words[i][positions[i]];

                    // Find the index of the character in the alphabet
                    int index = Array.IndexOf(alphabet, c);

                    // Add the word to the appropriate bucket
                    buckets[index].Add(words[i]);
                }

                // Check if all the words have been sorted
                bool done = true;
                foreach (List<string> bucket in buckets)
                {
                    if (bucket.Count > 0)
                    {
                        done = false;
                        break;
                    }
                }
                if (done)
                {
                    break;
                }

                // Reset the list of words and update the positions
                words.Clear();
                for (int i = 0; i < buckets.Length; i++)
                {
                    words.AddRange(buckets[i]);
                    for (int j = 0; j < buckets[i].Count; j++)
                    {
                        positions[j]++;
                    }
                }
            }
        }
    }
}
