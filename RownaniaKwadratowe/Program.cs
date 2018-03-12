using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RownaniaKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj a, b, c zatwierdzając enterem");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Równanie liniowe, x={0}", -c / b);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta >= 0)
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Pierwiastki: {0} i {1}", x1, x2);
                }
                else
                {
                    Console.WriteLine("Delta mniejsza od zera");
                }
            }
            Console.ReadKey();
        }
    }
}
