using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates.Recurring
{
    [Flags]
    public enum Day : int
    {
        
        SUNDAY = 1,

        MONDAY = 2,

        TUESDAY = 4,

        WEDNESDAY = 8,

        THURSDAY = 16,

        FRIDAY = 32,

        SATURDAY = 64
    }
}
