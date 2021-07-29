using System;
using MathNet.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        // Number of test cases
        var T = 0;
        // Numbers for evaluation
        var a =  new double[0];

        // A small check for incorrect input (certainly does not cover all variations of incorrect input)
        try
        {
            T = Int32.Parse(Console.ReadLine());

            a = new double[T];

            for (var i = 0; i < T; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        for (var i = 0; i < T; i++)
        {
            Console.WriteLine(Math.Round(Poly(a[i]), 3));
        }
    }

    // Cheetah's mind is not so powerful, so the program calculates some polynomial. Immutable polynomial.
    // This means that the coefficients of the polynomial are constants for all cases.
    // Solving the system of equations by the matrix method, I find the coefficients and substitute them into the formula.
    // Then the formula is looking like this:
    static double Poly(double x)
    {
        return x * x * x * x + 1.2 * x * x * x - 20.0 * x * x + 123.456;
    }

}