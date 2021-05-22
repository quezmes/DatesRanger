using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DatesRanger.Extensions
{
    public static class DateTimeExtensions
    {
        enum MonthLocationPattern
        {
            BeforeDay,
            AfterDay
        }

        static readonly char _dayChar = 'd';
        static readonly char _monthChar = 'M';

        public static string ToDayAndMonthString(this DateTime date)
        {
            return date.ToString(GetMonthDataPattern());
        }

        private static string GetMonthDataPattern()
        {
            var shortDataPattern = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
            char firstChar, secondChar;
            if (GetMonthLocationPatter() == MonthLocationPattern.AfterDay)
                return "";
            return "";
        }

        private static MonthLocationPattern GetMonthLocationPatter()
        {
            var shortDatePattern = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
            if (shortDatePattern.IndexOf(_dayChar) < shortDatePattern.IndexOf(_monthChar))
                return MonthLocationPattern.AfterDay;
            else
                return MonthLocationPattern.BeforeDay;
        }
    }
}
