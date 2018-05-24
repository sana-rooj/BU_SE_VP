using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IndexdrTest[] obj = new IndexdrTest[5];

                IndexdrTest t = new IndexdrTest();
                t["ID"] = 10.ToString();
                t["NAME"] = "test";
                obj[0] = t;
                obj[0]["ID"] = 10.ToString();

                Console.WriteLine(MonthName(2));
                int[] arr = { 1, 0, 3, 4 };
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine(arr[i]/arr[1]);
                }
            }
            catch(IndexOutOfRangeException eoub)
            {
                Console.WriteLine(eoub.Message);
            }
            catch(DivideByZeroException dbz)
            {
                Console.WriteLine(dbz.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static string MonthName(int number)
        {

            switch (number)
                {
                case 1:
                    return "january";
                    break;
                default:
                    throw new Exception("Invalid Month name");
                    break;

            }
        }
    }

    class IndexdrTest
    {
        int id;
        string name;


        public string this[string str]
            {
            get
            {
                switch (str)
                {
                    case "ID":
                        return id.ToString();
                        break;
                    case "NAME":
                        return name;
                        break;

                }
                return "";
            }
            set
            {
                switch (str)
                {
                    case "ID":
                        id = int.Parse(str);
                        break;
                    case "NAME":
                        name = str;
                        break;

                }
            }
            }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
}
