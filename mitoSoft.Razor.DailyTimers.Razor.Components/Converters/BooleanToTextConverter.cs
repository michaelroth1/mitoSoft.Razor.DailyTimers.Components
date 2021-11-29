namespace mitoSoft.DailyTimers.Razor.Components.Converters
{
    internal static class BooleanToTextConverter
    {
        public static string ToText(this bool value)
        {
            if (value)
            {
                return Properties.Resources._active;
            }
            else
            {
                return Properties.Resources._inactive;
            }
        }
    }
}