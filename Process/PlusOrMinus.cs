using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process
{
    public class PlusOrMinus
    {
        public static string plusorminus(string str)
        {
            float f = float.Parse(str);
            f *= -1;
            return f.ToString();
        }
    }
}
