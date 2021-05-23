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

        [Theory]
        [InlineData("10/10/2020", "12/10/2020", "10 - 12.10.2020")] //days
        [InlineData("12.10.2020", "10/10/2020", "12 - 10.10.2020")] // days reverse
        [InlineData("10/10/2020", "12/11/2020", "10.10 - 12.11.2020")] //month
        [InlineData("10.10.2020", "12.9.2021", "10.10.2020 - 12.09.2021")] //year
        public void GetDateRange_RangeResult(string dt1Str, string dt2Str, string expected)
        {
            //Arrange
            DateTime dt1 = DateTime.Parse(dt1Str);
            DateTime dt2 = DateTime.Parse(dt2Str);
 
            //Act
            string actual1 = new DatesRangeService().GetDatesRange(dt1, dt2);

            //Assert
            Assert.Equal(expected, actual1);
        }
    }
}
