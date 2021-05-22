﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesRanger.Services
{
    public class DatesRangeService
    {
        private readonly string _theSameDatesErrorText = "You provided two same dates.";
        public string GetDatesRange(DateTime date1, DateTime date2)
        {
            if (date1.Year == date2.Year)
                if (date1.Month == date2.Month)
                    if (date1.Day == date2.Day)
                        return _theSameDatesErrorText;
                    else
                        return "";
                else
                    return "";
            else
                return "";
        }
    }
}