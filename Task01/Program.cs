/* Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.  
Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). 
В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]». */

using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Введите x: ");
            double.TryParse(Console.ReadLine(), out x);

            double y;
            Console.Write("Введите y: ");
            double.TryParse(Console.ReadLine(), out y);

            Console.Write("Введите букву графика (а-к): ");
            char figure = char.Parse(Console.ReadLine());
            while (figure < 'а' || figure > 'к')
            {
                Console.WriteLine("Попробуйте снова: ");
                figure = char.Parse(Console.ReadLine());
            }
            EquationsOfFigures equations = new EquationsOfFigures();
            bool result1 = true;

            switch (figure)
            {
                case 'а':
                    result1 = equations.FigureA(x, y);
                    break;
                case 'б':
                    result1 = equations.FigureB(x, y);
                    break;
                case 'в':
                    result1 = equations.FigureV(x, y);
                    break;
                case 'г':
                    result1 = equations.FigureG(x, y);
                    break;
                case 'д':
                    result1 = equations.FigureD(x, y);
                    break;
                case 'е':
                    result1 = equations.FigureE(x, y);
                    break;
                case 'ж':
                    result1 = equations.FigureZH(x, y);
                    break;
                case 'з':
                    result1 = equations.FigureZ(x, y);
                    break;
                case 'и':
                    result1 = equations.FigureI(x, y);
                    break;
                case 'к':
                    result1 = equations.FigureK(x, y);
                    break;
            }

            if (result1 == true) Console.WriteLine("Точка (" + x + "; " + y + ") принадлежит фигуре " + figure);
            else Console.WriteLine("Точка (" + x + "; " + y + ") не принадлежит фигуре " + figure);
            Console.ReadKey();
        }
    }
}
