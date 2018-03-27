using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPartIdentifier
{
    class Currency
    {
        readonly int dollars;
        readonly int cents;

        public Currency(int d, int c)
        {
            d = 1000;
            c = 5000;
            //dollars = d;
            //cents = c;
        }

        public void Test(out int a)
        {
            a = 100;
        }

        public static explicit operator float(Currency c)
        {
            return (c.dollars + (c.cents / 100.0f));
        }
    }
}
