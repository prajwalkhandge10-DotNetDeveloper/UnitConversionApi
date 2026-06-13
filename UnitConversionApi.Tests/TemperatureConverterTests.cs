using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests
{
    public class TemperatureConverterTests
    {
        [Fact]
        public void Celsius_To_Fahrenheit_Should_Return_Correct_Value()
        {
            var converter = new TemperatureConverter();

            var result = converter.Convert(
                100,
                "celsius",
                "fahrenheit");

            Assert.Equal(212, result);
        }
    }
}
