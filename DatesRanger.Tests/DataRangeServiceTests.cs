using DatesRanger.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatesRanger.Tests
{
    public class DataRangeServiceTests
    {

        [Fact]
        public void GetDateRange_DayRangeResult()
        {
            //Arrange
            DateTime dt1 = new(10, 12, 2020);
            DateTime dt2 = new(12, 12, 2020);
            string expected = $"{dt1.Day} - {dt2.Day}";

            //Act
            string actual = new DatesRangeService().GetDatesRange(dt1, dt2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
