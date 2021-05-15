namespace DarkDynamics.Andromeda.Extensions
{
    public static class NumericExtensions
    {
        public static bool ApproximatelyEqualsTo(this float source, float value, float delta) => 
            source - delta <= value && source + delta >= value;

        public static bool ApproximatelyEqualsTo(this int source, int value, int delta) => 
            source - delta <= value && source + delta >= value;

        public static bool ApproximatelyEqualsTo(this double source, double value, double delta) => 
            source - delta <= value && source + delta >= value;
    }
}