using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests
{
    public class WeightConverterTests
    {
        [Fact]
        public void Kilogram_To_Pound_Should_Return_Correct_Value()
        {
            var converter = new WeightConverter();

            var result = converter.Convert(
                1,
                "kilogram",
                "pound");

            Assert.Equal(2.2046, result, 4);
        }
    }
}
