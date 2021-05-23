using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesRanger.Services
{
    public interface IDatesRangeService
    {
        public string GetDatesRange(DateTime date1, DateTime date2);
    }
}
