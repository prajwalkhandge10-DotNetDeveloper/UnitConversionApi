namespace UnitConversionApi.Converters
{
    public class WeightConverter : IUnitConverter
    {
        public string Category => "weight";

        private readonly Dictionary<string, double> _units =
            new(StringComparer.OrdinalIgnoreCase)
            {
            { "kilogram", 1 },
            { "gram", 0.001 },
            { "pound", 0.45359237 }
            };

        public double Convert(double value, string fromUnit, string toUnit)
        {
            if (!_units.ContainsKey(fromUnit))
                throw new ArgumentException($"Unsupported unit {fromUnit}");

            if (!_units.ContainsKey(toUnit))
                throw new ArgumentException($"Unsupported unit {toUnit}");

            var kilograms = value * _units[fromUnit];

            return kilograms / _units[toUnit];
        }
    }
}
