using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process
{
    public class ToanHoc
    {
        public static double binhphuong(double x, double y)
        {
            return Math.Pow(x,y);
        }
        public static double canbac(double x, double y)
        {
            if (x < 0) return 0;
            else
                return Math.Pow(x, 1.0 / y);
        }
        public static double giaithua(int x)
        {
            double kq=1;
            for (int i = 1; i <= x; i++)
                kq *= x;
            return kq;
        }
        public static double pi()
        {
            return Math.PI;
        }
    }
}
