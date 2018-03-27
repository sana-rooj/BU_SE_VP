using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    delegate void Deleg();
    class DelegateTest
    {
        public Deleg obj1;

        public void DelegFunc()
        {
            MessageBox.Show("Call First Function");
        }

        public void DelegFunc1()
        {
            MessageBox.Show("Call Second Function");
        }

        public void DelegCall(Deleg obj)
        {
            obj();
        }
    }
}
