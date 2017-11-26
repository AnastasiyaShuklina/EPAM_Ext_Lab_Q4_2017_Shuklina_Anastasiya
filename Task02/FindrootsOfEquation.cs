using System;

namespace Task02
{
    class FindRootsOfEquation
    {
        public void FindABC(double h)
        {
            double a1 = Math.Abs(Math.Sin(8 * h)) + 17;
            double a2 = Math.Pow(1 - Math.Sin(4 * h) * Math.Cos(Math.Pow(h, 2) + 18), 2);
            double a = Math.Sqrt(a1 * a2);
            Console.WriteLine("а = " + a);

            double b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * Math.Pow(h, 2))
                - Math.Sin(a * h))));
            Console.WriteLine("b = " + b);

            double c = a * Math.Pow(h, 2) * Math.Sin(b * h)
                + b * Math.Pow(h, 3) * Math.Cos(a * h);
            Console.WriteLine("c = " + c);

            FindX(a, b, c);
        }
        public void FindX(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("D = " + discriminant);
            if (discriminant < 0) Console.WriteLine("\nКорней нет");
            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("\nУравнение имеет один корень = " + x);
            }
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("\nУравнение имеет два корня: \n" + "х1 = " + x1);
                Console.WriteLine("х2 = " + x2);
            }
        }
    }
}
