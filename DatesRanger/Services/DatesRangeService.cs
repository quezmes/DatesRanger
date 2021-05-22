using DatesRanger.Extensions;
using System;
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
                        return GetDatesRangeTextResult(date1.ToString("dd"), date2.ToString("dd"));
                else
                    return GetDatesRangeTextResult(date1.ToDayAndMonthString(), date2.ToDayAndMonthString());
            else
                return GetDatesRangeTextResult(date1.ToShortDateString(), date2.ToShortDateString());
        }

        private string GetDatesRangeTextResult(string date1, string date2) => string.Join(" - ", date1, date2);
    }
}
