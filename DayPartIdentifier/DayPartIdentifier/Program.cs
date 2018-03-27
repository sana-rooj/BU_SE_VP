using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPartIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProtectedTestChild obj = new ProtectedTestChild();
            //obj.test();
            int x = 100;
            int y = 200;
            Currency amount = new Currency(x, y);
            string str = "mystring";
            amount.Test(out x);
            float totalamount = (float)amount;
            Console.WriteLine(totalamount);
        }
    }
}
