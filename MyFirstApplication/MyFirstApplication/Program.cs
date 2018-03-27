using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class bsse6
    {
        public int noofstudents;
        public void test()
        {
            string[] arr = null;

            Program.Main(arr);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            bsse6 obj = new bsse6();
            obj.noofstudents = 20;

            for(int i =0; i<args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
