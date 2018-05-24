using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,4,3,5,6,3};
            var result = from n in numbers where n > 1 select n;
            GenericsExample < string > myobject = new GenericsExample<string>();

            ArrayExample<int> obj = new ArrayExample<int>();
            obj.CreateArray(19);
        }
    }

    public class ArrayExample<T>
    {
        public T[] CreateArray(int size)
        {
            T[] test = new T[size];
            return test;
        }
    }

    public class GenericsExample<T>
    {
        T abc;
        public T GetValue()
        {
            return abc;
        }
        public void SetValue(T val)
        {
            abc = val;
        }
    }
}
