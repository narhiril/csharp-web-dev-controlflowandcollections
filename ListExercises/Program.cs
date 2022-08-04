using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordLength;
            List<int> integerList = new List<int> { 1, 0, -12, -53, 12, 67, 19, 565, 1093, 618, -9021, 157, 380 };
            List<string> stringList = new List<string>();
            const string practiceString =
                "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse.";

            foreach (string str in practiceString.Split(' '))
            {
                stringList.Add(str.TrimEnd('.', ',', '?', '!'));
            }

            Console.Write("Enter a word length: ");
            try
            {
                wordLength = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                wordLength = 0;
            }

            Console.WriteLine($"Sum of all even numbers in list: {SumOfEvens(integerList)}");
            Console.WriteLine($"Words in list of length {wordLength}: ");
            foreach (string word in WordsOfLength(stringList, wordLength))
            {
                Console.WriteLine(word);
            }

        }

        internal static int SumOfEvens(List<int> inputList)
        {
            int sum = 0;
            foreach (int element in inputList)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                }
            }
            return sum;
        }

        internal static List<string> WordsOfLength(List<string> inputList, int matchLength)
        {
            List<string> output = new List<string>();
            foreach (string word in inputList)
            {
                if (word.Length == matchLength && !output.Contains(word))
                {
                    output.Add(word);
                }
            }
            return output;
        }
    }
}
