using System;

namespace AnagramChecker
{
    class Program
    {
        private static bool keepGoing = true;
        static void Main(string[] args)
        {
            while (keepGoing)
            {
                Console.WriteLine("Enter two words seperated by a space, to check if they are anagrams.");

                string wordsToCheck = Console.ReadLine();

                if (Library.AnagramChecker.IsAnagram(wordsToCheck))
                    Console.WriteLine(string.Format("{0} are anagrams.", wordsToCheck));
                else
                    Console.WriteLine(string.Format("{0} are not anagrams.", wordsToCheck));

                Console.WriteLine("Would you like to check some other words?");
                Console.WriteLine("any key to try again, or 'n' to exit.");


                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    keepGoing = false;
                    return;
                }
            }
        }
    }
}
