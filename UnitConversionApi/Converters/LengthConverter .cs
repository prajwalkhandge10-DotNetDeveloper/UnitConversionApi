namespace UnitConversionApi.Converters
{
    public class LengthConverter: IUnitConverter
    {
        public string Category => "length";

        private readonly Dictionary<string, double> _units =
            new(StringComparer.OrdinalIgnoreCase)
            {
            { "meter", 1 },
            { "kilometer", 1000 },
            { "feet", 0.3048 },
            { "inch", 0.0254 }
            };
        public double Convert(double value, string fromUnit, string toUnit)
        {
            if (!_units.ContainsKey(fromUnit))
                throw new ArgumentException($"Unsupported unit {fromUnit}");

            if (!_units.ContainsKey(toUnit))
                throw new ArgumentException($"Unsupported unit {toUnit}");

            var meters = value * _units[fromUnit];

            return meters / _units[toUnit];
        }
    }
}
