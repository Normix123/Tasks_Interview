using System;
using System.Numerics;

namespace Solution_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Different natural numbers
            int a, b, N;

            // A small check for incorrect input (certainly does not cover all variations of incorrect input)
            try
            {
                var input = Console.ReadLine()?.Split();
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);
                N = int.Parse(input[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // The maximum number of possible combinations of the sums of two given numbers not exceeding N
            var n = a > b ? N / b : N / a;

            // Variation iteration array and filling it with numbers
            var mas = new int[n + 1];
            for (var i = 0; i < n + 1; i++) mas[i] = a;

            // Result array
            var res = new int[n];

            // The greatest possible value of multiplying these numbers
            BigInteger max = 0;

            // Enumeration of combinations
            for (var j = 0; j < n; j++)
            {
                for (var k = 0; k < n + 1; k++)
                    if (res[j] < N)
                    {
                        res[j] += mas[k];
                    }
                    else if (res[j] == N)
                    {
                        BigInteger temp = 1;
                        for (var y = 0; y < k; y++) temp *= mas[y];
                        if (max < temp) max = temp;
                        break;
                    }
                    else
                    {
                        break;
                    }

                mas[j] = b;
            }

            Console.WriteLine(max == 1 ? 0 : max);
        }
    }
}