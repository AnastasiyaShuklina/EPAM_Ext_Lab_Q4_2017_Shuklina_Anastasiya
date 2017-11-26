//Дано действительное число h.
//Выяснить, имеет ли уравнение ax^2 + bx + c = 0 действительные корни, 
//если  a = ..., b = ..., c = ...
//Если действительные корни существуют, то найти их.
//В противном случае ответом должно служить сообщение,
//что действительных корней нет.
//Программа должна выводить пользователю промежуточные вычисления 
//(например, a, b, c и дискриминант (если вычисляли при помощи него) и корни (если есть)). 

using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите действительное число h: ");
            double h = double.Parse(Console.ReadLine());
            FindA(h);
            Console.ReadKey();
        }
        static void FindA(double h)
        {
            double a1 = Math.Abs(Math.Sin(8 * h)) + 17;
            double a2 = 1 - Math.Sin(4 * h) * Math.Cos(Math.Pow(h, 2) + 18);
            double a3 = Math.Pow(a2, 2);
            double a = Math.Sqrt(a1 * a3);
            Console.WriteLine("а = " + a);
            FindB(h, a);
        }
        static void FindB(double h, double a)
        {
            double b1 = Math.Abs(Math.Tan(a * Math.Pow(h, 2)) - Math.Sin(a * h));
            double b = 1 - Math.Sqrt(3 / (3 + b1));
            Console.WriteLine("b = " + b);
            FindC(h, a, b);
        }
        static void FindC(double h, double a, double b)
        {
            double c = a * Math.Pow(h, 2) * Math.Sin(b * h)
                + b * Math.Pow(h, 3) * Math.Cos(a * h);
            Console.WriteLine("c = " + c);
            FindX(a, b, c);
        }
        static void FindX(double a, double b, double c)
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
