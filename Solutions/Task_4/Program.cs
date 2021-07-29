using System;

namespace Solution_4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int n, m;

            // A small check for incorrect input (certainly does not cover all variations of incorrect input)
            try
            {
                var input = Console.ReadLine()?.Split();
                n = int.Parse(input[0]);
                m = int.Parse(input[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // Determine the largest and smallest number of mice
            // It doesn't matter which side the mice are on, the number of transfers will be the same
            var max = n > m ? n : m;
            var min = n < m ? n : m;

            // A little proof:
            // Let's count the simplest cases of transpositions. They are 
            //
            // 1 1 -> 3;  1 2 -> 5;  1 3 -> 7;  1 4 -> 9
            // 2 1 -> 5;  2 2 -> 8;  2 3 -> 11; 2 4 -> 11
            // 3 1 -> 7;  3 2 -> 11; 3 3 -> 15; 
            // 4 1 -> 9;  4 2 -> 14
            // 5 1 -> 11; 5 2 -> 17; 
            //
            // All results are linearly dependent on rows and columns
            //
            // The formula for the linear equation of two unknowns: ax + by + c = 0
            // The formula for a linear equation of one unknown: ax + b = 0
            // If I assume that some input parameter is always 1, then the output parameter is 2* min + 1 
            // Taking into account the linear change of the second parameter, it is easy to see that the final formula will take the form:
            // (2 * min + 1) + (max - 1) * (min + 1), where  (max - 1) * (min + 1) - the difference between the rows in any of the columns

            var optimalNumberOfTransfers = 2 * min + 1 + (max - 1) * (min + 1);

            Console.WriteLine(optimalNumberOfTransfers);
        }
    }
}