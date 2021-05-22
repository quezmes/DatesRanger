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
            return date.ToString(GetMonthAndDayDataPattern());
        }

        private static string GetMonthAndDayDataPattern()
        {
            var shortDatePattern = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
            char firstDateChar, secondDateChar;
            if (GetMonthLocationPatter() == MonthLocationPattern.AfterDay)
            {
                firstDateChar = _dayChar;
                secondDateChar = _monthChar;
            }
            else
            {
                firstDateChar = _dayChar;
                secondDateChar = _monthChar;
            }
            var monthDatePattern = shortDatePattern[
              shortDatePattern.IndexOf(firstDateChar)..(shortDatePattern.LastIndexOf(secondDateChar) + 1)
              ]
              .Replace(DateTimeFormatInfo.CurrentInfo.DateSeparator, "/");
            return monthDatePattern;
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
