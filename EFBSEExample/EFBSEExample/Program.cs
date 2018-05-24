using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFBSEExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a test message";
            string str1 = "test";
            var test = Regex.Matches(str, str1);
            //studentdbEntities obj = new studentdbEntities();
            //var students = from std in obj.students select std;

            //foreach(student s in students)
            //{
            //    Console.WriteLine(string.Format("Id: {0}, Name: {1}", s.id, s.name));
            //}
        }
    }
}
