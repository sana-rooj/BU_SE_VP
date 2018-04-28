using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMethodExample
{
    public delegate bool DelegateHandler(int a, int b);

    class Program
    {
        DelegateHandler delhand;

        public void Test()
        {
            delhand = delegate (int x, int y)
            {
                return (x > y);
            };

        }
        
        static void Main(string[] args)
        {
            delha
        }
    }
}
