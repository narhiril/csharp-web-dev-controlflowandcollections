using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string input, name;

            do
            {
                Console.Write("Enter a student ID number, or press ENTER to quit: ");
                input = Console.ReadLine();
                try
                {
                    do
                    {
                        Console.Write($"Enter student #{int.Parse(input)}'s name: ");
                        name = Console.ReadLine();
                        if (Equals(name, ""))
                        {
                            Console.WriteLine("Error: Name cannot be blank!");
                        }
                        else
                        {
                            students.Add(int.Parse(input), name);
                            Console.WriteLine($"Student #{int.Parse(input)} ({name}) added!");
                            break;
                        }
                    } while(true);
                }
                catch (FormatException e)
                {
                    if (Equals(input, ""))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: invalid ID number.");
                    }
                }
            } while(true);

            Console.WriteLine($"\nClass roster ({students.Count} students):");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"Student #{student.Key}: {student.Value}");
            }
        }
    }
}
