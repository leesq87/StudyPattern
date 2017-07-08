using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Math
    {
        public static double TwoTime(double num) { return num * 2; }

        public static double half(double num) { return num / 2; }

        public static Double Doubled(Double d) { return d * 2; }


    }
}
