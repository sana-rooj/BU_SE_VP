using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    abstract class absclass
    {
        abstract public void test();

        virtual public void test1()
        {
            Console.WriteLine("Coool");
        }
    }

    interface test
    {
        void test1();
    }
    partial class bsse: absclass, test
    {
        override public void test1()
        {

        }
        public void naam()
        {
            calculator obj = new calculator();
            obj.setvar1(10);
        }
    }


    class calculator
    {
        public int property1 {get; set;}

        private int internalvar1;
        public int var1
        {
            get
            {
                internalvar1 = internalvar1 * 2;
                return internalvar1;
            }
            set
            {
                internalvar1 = value;
            }
        }

    }
}
