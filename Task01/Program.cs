/* Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.  
Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). 
В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]». */

using System;

namespace Task01
{
    class Program
    {
        static bool result;
        static void Main(string[] args)
        {
            Console.Write("Введиет x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введиет y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите букву графика: ");
            char figure = char.Parse(Console.ReadLine());

            if (figure == 'а') FigureA(x, y);
            if (figure == 'б') FigureB(x, y);
            if (figure == 'в') FigureV(x, y);
            if (figure == 'г') FigureG(x, y);
            if (figure == 'д') FigureD(x, y);
            if (figure == 'е') FigureE(x, y);
            if (figure == 'ж') FigureZH(x, y);
            if (figure == 'з') FigureZ(x, y);
            if (figure == 'и') FigureI(x, y);
            if (figure == 'к') FigureK(x, y);

            if (result == true) Console.WriteLine("Точка (" + x + "; " + y + ") принадлежит фигуре " + figure);
            else Console.WriteLine("Точка (" + x + "; " + y + ") не принадлежит фигуре " + figure);
            Console.ReadKey();
        }

        static void FigureA(double x, double y)
        {
            result = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
        }
        static void FigureB(double x, double y)
        {
            result = ( ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) >= 0.5) );
        }
        static void FigureV(double x, double y)
        {
            result = (((Math.Pow(x, 2) <= 1) && (Math.Pow(y, 2) <= 1)));
        }
        static void FigureG(double x, double y)
        {
            result = Math.Abs(x) + Math.Abs(y) <= 1;
        }
        static void FigureD(double x, double y)
        {
            result = Math.Abs(x) + 0.5 * Math.Abs(y) <= 0.5;
        }
        static void FigureE(double x, double y)
        {
            result = ( ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x > 0)) 
                || ((Math.Abs(x) + 2 * Math.Abs(y)) <= 2) );
        }
        static void FigureZH(double x, double y)
        {
            result = ((2 * x + 2 - y >= 0) && (-2 * x + 2 - y >= 0) && (y >= -1));
        }
        static void FigureZ(double x, double y)
        {
            result = (((Math.Pow(x, 2) <= 1) && (Math.Pow(y, 2) <= 4)) && ((x + y <= 0) || (x - y >= 0)) );
        }
        static void FigureI(double x, double y)
        {
            result = ((2 * x + 3 - y >= 0) && (-x + 3 * y + 1 >= 0) &&
             ((x + y <= 0) || (y <= 0)));
        }
        static void FigureK(double x, double y)
        {
            result = ((y >= 1) || (x + y >= 0) && (x - y <= 0));
        }
    }
}
