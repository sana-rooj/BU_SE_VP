using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate void TestDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            TestDelegate deleg = new TestDelegate(obj.DelegateFunction);
            obj.Test(deleg);

        }
    }

    class MyClass
    {
        public void Test(TestDelegate deleg)
        {
            deleg();
        }

        public void DelegateFunction()
        {
            Console.WriteLine("Lolz");
        }
    }
}
