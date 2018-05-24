using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWExample
{
    class Program
    {
        static void Main(string[] args)
        {
            studentdbEntities entity = new studentdbEntities();
            var students = from student in entity.students select student;
            foreach(var student in students)
            {
                Console.WriteLine(string.Format("ID: {0} Name: {1}", student.id, student.name));
            }
        }
    }
}
