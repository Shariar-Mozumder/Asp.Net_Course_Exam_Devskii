using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FractionPrinter
    {
        public string Print(int numerator, int denominator, int count)
        {
            return (Convert.ToDecimal(numerator) / Convert.ToDecimal(denominator)).ToString("N"+count);
        }
    }
}
