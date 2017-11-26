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
            double h;
            Console.Write("Введите действительное число h: ");
            double.TryParse(Console.ReadLine(), out h);

            FindRootsOfEquation rootsOfEquation = new FindRootsOfEquation();
            rootsOfEquation.FindABC(h);

            Console.ReadKey();
        }
    }
}
