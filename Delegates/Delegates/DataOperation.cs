using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class DataOperation
    {
        private static DataOperation DataOp;
        public static DataOperation DATAOPS
        {
            get
            {
                if (DataOp == null)
                    DataOp = new DataOperation();
                return DataOp;
            }
        }

        StreamReader obj;
        private DataOperation()
        {
            obj = new StreamReader("data.txt");
        }

        public string ReadData()
        {
            return "read";
        }

        public void WriteData(string data)
        {
        }
    }
}
