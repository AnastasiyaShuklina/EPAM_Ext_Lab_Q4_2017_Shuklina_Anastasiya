using System;

namespace Task01
{
    class EquationsOfFigures
    {
        public bool result;
        public bool FigureA(double x, double y)
        {
            return result = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
        }
        public bool FigureB(double x, double y)
        {
            return result = (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) >= 0.5));
        }
        public bool FigureV(double x, double y)
        {
            return result = (((Math.Pow(x, 2) <= 1) && (Math.Pow(y, 2) <= 1)));
        }
        public bool FigureG(double x, double y)
        {
            return result = Math.Abs(x) + Math.Abs(y) <= 1;
        }
        public bool FigureD(double x, double y)
        {
            return result = Math.Abs(x) + 0.5 * Math.Abs(y) <= 0.5;
        }
        public bool FigureE(double x, double y)
        {
            return result = (((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x > 0))
                || ((Math.Abs(x) + 2 * Math.Abs(y)) <= 2));
        }
        public bool FigureZH(double x, double y)
        {
            return result = ((2 * x + 2 - y >= 0) && (-2 * x + 2 - y >= 0) && (y >= -1));
        }
        public bool FigureZ(double x, double y)
        {
            return result = (((Math.Pow(x, 2) <= 1) && (Math.Pow(y, 2) <= 4)) && ((x + y <= 0) || (x - y >= 0)));
        }
        public bool FigureI(double x, double y)
        {
            return result = ((2 * x + 3 - y >= 0) && (-x + 3 * y + 1 >= 0) &&
             ((x + y <= 0) || (y <= 0)));
        }
        public bool FigureK(double x, double y)
        {
            return result = ((y >= 1) || (x + y >= 0) && (x - y <= 0));
        }
    }
}
