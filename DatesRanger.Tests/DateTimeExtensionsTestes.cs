using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Globalization;
using System.Threading;
using DatesRanger.Extensions;

namespace DatesRanger.Tests
{
    public class DateTimeExtensionsTestes
    {

    
        [Theory]
        [InlineData("09.12.2020", "en-US", "12/9")]
        [InlineData("09.12.2020", "pl-PL", "09.12")]
        public void ToDayAndMonthString_CorrectStringResult(string date, string culture, string expected)
        {
            //Arrange
            DateTime dateToTest = DateTime.Parse(date);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);

            //Act
            var actual = dateToTest.ToDayAndMonthString();

            //Assert
            Assert.Equal(actual, expected);

        }
    }
}
