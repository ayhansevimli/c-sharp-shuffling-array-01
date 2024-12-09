using System;
using System.Collections.Generic;

namespace RandomizeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the array
            string[] ranges = {
                "0001-0100", "0101-0200", "0201-0300", 
                "0301-0400", "0401-0500", "0501-0600", 
                "0601-0700", "0701-0800", "0801-0900", 
                "0901-1000", "1101-1200", "1001-1100",
                "1201-1300", "1301-1400", "1401-1500",
                "1501-1600", "1601-1700", "1701-1800",
                "1801-1900"

            };

            // Create a list from the array for shuffling
            List<string> rangesList = new List<string>(ranges);

            // Shuffle the list
            Shuffle(rangesList);

            // Display the randomized ranges
            Console.WriteLine("Randomized Ranges:");
            foreach (string range in rangesList)
            {
                Console.WriteLine(range);
            }

            // Wait for the user to press a key before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Fisher-Yates Shuffle Algorithm
        static void Shuffle(List<string> list)
        {
            Random random = new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                // Swap elements
                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
