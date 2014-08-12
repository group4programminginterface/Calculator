using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Process
{
    public class TinhToan
    {
        public static float Tinh(string so1, string pheptoan, string so2)
        {
            float val=0;
                switch (pheptoan)
                {
                    case "+": val = float.Parse(so1.ToString()) + float.Parse(so2.ToString());
                        break;
                    case "-": val = float.Parse(so1.ToString()) - float.Parse(so2.ToString());
                        break;
                    case "*": val = float.Parse(so1.ToString()) * float.Parse(so2.ToString());
                        break;
                    case "/": val = float.Parse(so1.ToString()) + float.Parse(so2.ToString());
                        break;
                }
            return val;
         }
        public static double canbac(float a)
        {
            if (a < 0) return 0;
            else return Math.Sqrt(a);
        }
        public static double phantram(double a)
        {
            if (a < 0) return 0;
            else return a / 100;
        }
        public static double motchiax(double a)
        {
            if (a < 0) return 0;
            else return 1 / a;
        }
    }
}

