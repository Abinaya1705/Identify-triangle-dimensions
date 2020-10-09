using System;
using System.Collections.Generic;
using System.Text;

namespace Identify_triangle_dimensions
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("It is a valid triangle");
                if (a == b && b == c)
                {
                    return "Equilateral Triangle";
                }
                else if (a == b || b == c || c == a)
                {
                    return "Isosceles Triangle";
                }
                else
                {
                    return "scalene Triangle";
                }

            }
            else
            {
                return "Its not a Triangle";
            }
        }
    }
}











