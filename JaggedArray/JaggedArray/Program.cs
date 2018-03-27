using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{

    class Program
    {


        static void Main(string[] args)
        {
            calculator obj = new calculator();
            obj.property1 = 10;
            obj.var1 = 20;

            //int avg = Average(1, "2", 3.0f);
            exceptionexample();

            int[,][,] arr = new int[3,3][,];
            arr[0,0] = new int[2,2];

            unsafe
            {
                int* p = stackalloc int[10];
            }
        }

        static int exceptionexample()
        {
            int returnval = 0;
            try
            {
                throw new Exception();
                returnval= 10;
                return returnval; 
            }
            catch(Exception e)
            {
                Console.WriteLine("Its an exceptio");
            }
            finally
            {
                Console.WriteLine("In finally");
                returnval = 0;

            }

            

            return returnval;
        }

        static int Average(params object[] arr)
        {
            int sum = 0;
            foreach(int x in arr)
            {
                sum += x;
            }
            return sum / arr.Length;

        }
        ~Program()
        { }


    }
}
