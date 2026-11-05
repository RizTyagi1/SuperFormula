using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;

namespace WebApplication2
{

   public class Class1
    {
        public static double SuperFormula(double theta, double m, double n1, double n2, double n3, double a, double b)
        {
            double t1 = Math.Pow(Math.Abs(Math.Cos(m * theta / 4) / a), n2);
            double t2 = Math.Pow(Math.Abs(Math.Sin(m * theta / 4) / b), n3);
            return Math.Pow(t1 + t2, -1.0 / n1);
        }

        public static void Main()
        {
            double m = 9.53, n1 = 0.31, n2 = 1.69, n3 = 1.69, a = 1, b = 1;
            double scale = 100;
            string path = "";

            for (double theta = 0; theta <= 2 * Math.PI; theta += 0.01)
            {
                double r = SuperFormula(theta, m, n1, n2, n3, a, b);
                double x = 300 + r * Math.Cos(theta) * scale;
                double y = 300 + r * Math.Sin(theta) * scale;
                path += $"{x.ToString(CultureInfo.InvariantCulture)},{y.ToString(CultureInfo.InvariantCulture)} ";
            }

            string svg = $"<svg width='600' height='600' xmlns='http://www.w3.org/2000/svg'><polyline points='{path}' fill='none' stroke='cyan' stroke-width='2'/></svg>";
            Console.WriteLine(svg); // Copy this output into a .svg file
        }
    }
}