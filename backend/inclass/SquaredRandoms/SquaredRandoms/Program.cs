using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.

            Random random = new Random();
            var randomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int r = random.Next(50);
                randomNumbers.Add(r);
                Console.WriteLine(r);
            }


            // 2. With the resulting List, populate a new List that contains each number squared.
            //    For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
            var squaredNumbers = new List<int>();
            foreach (var number in randomNumbers)
            {
                int squaredNumber = number * number;
                squaredNumbers.Add(squaredNumber);
                Console.WriteLine(squaredNumber);

                // 3. Then remove any number that is odd from the list of squared numbers
                    if (squaredNumber % 2 != 0)
                    {
                        Console.WriteLine($"removed {squaredNumber}");
                        squaredNumbers.Remove(squaredNumber);
                    }
            }

            Console.ReadLine();         
        }
    }
}
