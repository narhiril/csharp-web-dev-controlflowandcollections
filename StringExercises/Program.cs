using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice String:");
            string practiceString = 
                "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse.";
            string[] practiceWords = practiceString.Split(' ');
            Console.WriteLine(string.Join(" ", practiceWords));
            Console.WriteLine("Break By Sentences:");
            string[] practiceSentences = practiceString.Split(". ");
            Console.WriteLine(string.Join(".\n", practiceSentences));

        }
    }
}
