using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   Calculation of quadratic equation     %%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Please enter numbers as any real values when asked for below, with + or -, with digits or not");
            Console.WriteLine("Quadratic equation is a*x^2+b*x+c=0, where a,b,c are known values, and x1 represents solution 1, while x2 represents solution 2");
            double a, b, c;
            Console.WriteLine("Enter value for a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = double.Parse(Console.ReadLine());

            double tempValue = b * b - 4 * a * c;
            if (tempValue >= 0)
            {
                double sol1 = (-b + Math.Sqrt(tempValue)) / (2 * a);
                double sol2 = (-b - Math.Sqrt(tempValue)) / (2 * a);
                Console.WriteLine("First solution is {0}, second solution is {1}", sol1, sol2);
            } else
            {
                double sol1 = -b / (2 * a);
                double sol2 = Math.Sqrt(-tempValue) / (2 * a);
                Console.WriteLine("First solution is {0}, second solution is +/-{1}i", sol1, sol2);
            }
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of Calculation of quadratic equation     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
