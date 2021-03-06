﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates.Recurring
{
    [Flags]
    public enum Month : int
    {
        JANUARY = 1,

        FEBRUARY = 2,

        MARCH = 4,

        APRIL = 8,

        MAY = 16,

        JUNE = 32,

        JULY = 64,

        AUGUST = 128,

        SEPTEMBER = 256,

        OCTOBER = 512,

        NOVEMBER = 1024,

        DECEMBER = 2048
    }
}
