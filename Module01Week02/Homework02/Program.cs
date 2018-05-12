using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenceOne = "The dog is barking.";
            string sentenceTwo = "The bird is flying.";
            string sentenceThree = "    He is happy.    ";

            Console.WriteLine($"sentenceOne = {sentenceOne}");
            Console.WriteLine($"sentenceTwo = {sentenceTwo}");
            Console.WriteLine($"sentenceThree = {sentenceThree}");

            // Example 1
            int compare = string.Compare(sentenceOne, sentenceTwo);
            Console.WriteLine("\n" + compare + ", this means sentenceTwo is smaller than sentenceOne");

            // Example 2
            string trim = sentenceThree.Trim();
            Console.WriteLine("\nsentenceThree have been trimmed\n" + trim);

            // Example 3
            string concat = string.Concat(sentenceTwo, sentenceThree);
            Console.WriteLine($"\nConcatenated strings:\n {concat}");

            // Example 4
            Console.WriteLine("\nUppercase: " + sentenceThree.ToUpper());
            Console.WriteLine("Lowercase: " + sentenceThree.ToLower());

            // Example 5
            bool isDogInSentence = sentenceTwo.Contains("dog");
            Console.WriteLine($"\nDoes sentenceTwo contain the word \"dog\"? {isDogInSentence}");

            // Example 6
            Console.WriteLine("\n +40742505550 after Format(): " + string.Format("{0:+## ### ### ###}", 40742505550));

            // Example 7
            if (sentenceThree.StartsWith("    "))
            {
                Console.WriteLine("\nThis is sentenceThree.");
            }


            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
