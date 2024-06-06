using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static double Diff(DateTime startDate, DateTime endDate)
        {
            var result = Math.Abs((startDate - endDate).TotalDays);
            return result;
        }
    }
}
