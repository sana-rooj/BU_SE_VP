using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPartIdentifier
{
    class IdentifyPartofDay
    {
        public enum partofday
        {
            morning = 0,
            afternoon = 1,
            evening = 2,
            night = 3,
            sometingelse = 4
        }
        public partofday Compute(int time)
        {
            if(time > 2000 && time < 2359 || time > 0 && time < 600)
            {
                int temp = 10;
                string str = temp.ToString();
                str = 10.ToString();
                return partofday.night;
            }
            return partofday.sometingelse;
        }
    }
}
