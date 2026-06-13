using UnitConversionApi.Converters;
using UnitConversionApi.Models;

namespace UnitConversionApi.Services
{
    public class ConversionService:IConversionService
    {
        private readonly IEnumerable<IUnitConverter> _converters;

        public ConversionService(IEnumerable<IUnitConverter> converters)
        {
            _converters = converters;
        }

        public ConversionResponse Convert(ConversionRequest request)
        {
            var converter = _converters.FirstOrDefault(x =>
                x.Category.Equals(request.Category,
                    StringComparison.OrdinalIgnoreCase));

            if (converter == null)
                throw new ArgumentException("Unsupported category");

            var result = converter.Convert(
                request.Value,
                request.FromUnit,
                request.ToUnit);

            return new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = Math.Round(result, 4)
            };
        }
    }
}
