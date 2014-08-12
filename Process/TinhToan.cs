using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Process
{
    public class TinhToan
    {
        public static Double Tinh(string so1, string pheptoan, string so2)
        {
            Double val=0;
                switch (pheptoan)
                {
                    case "+": if (so2 == null) { so2 = "0"; };
                        val = Double.Parse(so1.ToString()) + Double.Parse(so2.ToString());
                        break;
                    case "-": if (so2 == null) { so2 = "0"; };
                        val = Double.Parse(so1.ToString()) - Double.Parse(so2.ToString());
                        break;
                    case "*": if (so2 == null) { so2 = "0"; }; 
                        val = Double.Parse(so1.ToString()) * Double.Parse(so2.ToString());
                        break;
                    case "/": if (so2 == null) { so2 = "1"; };
                        val = Double.Parse(so1.ToString()) / Double.Parse(so2.ToString());
                        break;
                }
            return val;
         }
       
        public static Double canbac(Double a)
        {
            if (a < 0) return 0;
            else return Math.Sqrt(a);
        }
        public static Double phantram(Double a)
        {
            if (a < 0) return 0;
            else return a / 100;
        }
        public static Double motchiax(Double a)
        {
            if (a < 0) return 0;
            else return 1 / a;
        }
    }
}

