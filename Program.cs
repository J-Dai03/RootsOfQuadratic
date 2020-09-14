using System;

namespace RootsOfQuadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,;
            double[] results;
            Console.WriteLine("Please input the following values from your quadratic in this form:");
            Console.WriteLine("ax^2 + bx + c");
            Console.WriteLine("Where a, b, and c are floating point numbers")
            Console.WriteLine("Please input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input c:");
            c = Convert.ToDouble(Console.ReadLine());
            results = Roots_Of_Quadratic(a, b, c);
            Console.WriteLine(Convert.ToString(results));
        }
        static double[] Roots_Of_Quadratic(double a, double b, double c)
        {
            double discriminant, x, y, z;
            discriminant = Math.Pow(b, 2.0) - (4 * a * c);
            double[] results;

            if (discriminant < 0)
            {
                Console.WriteLine("No roots");

                results = new double[0];
                return results;
            }
            else
            {
                try
                {
                    x = Math.Pow(discriminant, 0.5);
                    y = ((-b) + x) / (2 * a);
                    z = ((-b) - x) / (2 * a);
                    results = new double[2];

                    results[0] = y;
                    results[1] = z;

                    return results;
                }
                catch
                {
                    Console.WriteLine("Unknown Error");
                    results = new double[0];
                    return results;
                }
            }

        }
    }
}
