using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process
{

    public class LuongGiac
    {
        public static double sin(double x)
        {
            return Math.Sin(x);
        }
        public static double cos(double x)
        {
            return Math.Cos(x);
        }
        public static double tan(double x)
        {
            if (x == 90) return 0;
            else return Math.Tan(x);
        }
        public static double sinh(double x)
        {
            return Math.Sinh(x);
        }
        public static double cosh(double x)
        {
            return Math.Cosh(x);
        }
        public static double tanh(double x)
        {
            return Math.Tanh(x);
        }
    }
}
