using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSE6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Pakistan";
            string filePath = args[0];
            stringfunctionality obj = new stringfunctionality();
            bool ispalindrom =  obj.checkpalindrom(input);
            obj.WriteToFile(input, ispalindrom, filePath);
            //Console.WriteLine(obj.ReadFile(filePath));
        }
    }
}
