﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enum
{
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Cancelled = 2
    }
}
