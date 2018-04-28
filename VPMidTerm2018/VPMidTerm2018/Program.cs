using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPMidTerm2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 8, 3, 7, 4 };
            int number = 10;
            Console.WriteLine(FindPair(arr, number));

            removeDuplicate();
        }

        public static bool FindPair(int []arr, int number)
        {
            for(int i=0; i<arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                        return true;
                }
            }
            return false;
        }

        static void removeDuplicate()
        {
            string inputstrnig = "Devarajan";
            string updatedstring = RemoveDuplicateChars(inputstrnig);
            Console.WriteLine("Input: " + inputstrnig + " -- Output:" + updatedstring);
        }

        static string RemoveDuplicateChars(string key)
        {

            string table = "";
            string result = "";
            foreach (char value in key)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
