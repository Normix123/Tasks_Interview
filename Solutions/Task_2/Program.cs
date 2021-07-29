using System;

namespace Solution_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // N wheels and M new tires
            int n = 0, m = 0;

            // Array of maximum tire distances on various axles
            int[] a = { };

            // A small check for incorrect input (certainly does not cover all variations of incorrect input)
            try
            {
                var input = Console.ReadLine().Split();
                n = int.Parse(input?[0]);
                m = int.Parse(input?[1]);

                a = new int[n];

                for (var i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // The formula for finding the maximum distance looks like this:
            // maxDistance = m/(Σ(x/a[i])), where x - is the number of wheels on the same axle

            // By condition, there are two wheels on the same axle
            var x = 2.0;

            // Calculating the denominator of a formula
            var temp = 0.0;
            for (var i = 0; i < n; i += (int)x) temp += x / a[i];

            // Final calculating the maximum distance
            var maxDistance = m / temp;
            Console.WriteLine(Math.Round(maxDistance, 3));
        }
    }
}