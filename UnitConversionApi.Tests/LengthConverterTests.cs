using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests
{
    public class LengthConverterTests
    {
        [Fact]
        public void Meter_To_Feet_Should_Return_Correct_Value()
        {
            var converter = new LengthConverter();

            var result = converter.Convert(
                1,
                "meter",
                "feet");

            Assert.Equal(3.2808, result, 4);
        }
    }
}
