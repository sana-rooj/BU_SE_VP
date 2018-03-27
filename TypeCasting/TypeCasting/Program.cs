using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class currency
    {
        public int dollar, cent;
        public static explicit operator float(currency val)
        {
            return val.dollar + (val.cent / 100.0f);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            currency obj = new currency();
            obj.dollar = 100;
            obj.cent = 10;
            float total = (float) obj;
            Console.WriteLine(total);
            unsafe
            {
                int* p = stackalloc int[10];
                p[0] = 100;
            }
            
        }
    }
}
