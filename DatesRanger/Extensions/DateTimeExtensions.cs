﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesRanger.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToDayAndMonthString(this DateTime date)
        {
            return date.ToString();
        }
    }
}
