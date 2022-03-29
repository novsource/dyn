using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyn
{
    public class CalculatorExtended
    {
        public static string Sin(double x)
        {
            return string.Format("{0}", Math.Sin(x));
        }

        public static string Cos(double x)
        {
            return string.Format("{0}", Math.Cos(x));
        }

        public static string Tan(double x)
        {
            return string.Format("{0}", Math.Tan(x));
        }

        public static string Ctg(double x)
        {
            return string.Format("{0}", 1/Math.Tan(x));
        }
    }
}
