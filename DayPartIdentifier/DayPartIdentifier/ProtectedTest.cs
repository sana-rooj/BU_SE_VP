using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPartIdentifier
{
    public class ProtectedTest
    {
        protected int a = 10;

    }

    class ProtectedTestChild: ProtectedTest
    {
        readonly int temp;
        const int temp1 = 30;
        public ProtectedTestChild()
        {
            temp = 10;
            int var = 30;
            object obj = var;
            int temp2 = (int)obj;
        }
        public void test()
        {
            int a = 200;
            float f = a;
            a = (int)f;
        }

    }
}
