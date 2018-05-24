using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSESecondLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 56, 7, 3 };
            var val = from v in arr where v > 20  orderby v ascending  select v;

            foreach(int i in val)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Test<T, U>
    {
        T var1;
        U var2;
        public T Method1(T var2)
        {
            return var1;
        }
    }

}
