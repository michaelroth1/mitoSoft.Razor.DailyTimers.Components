using System;
using System.Linq;

namespace mitoSoft.DailyTimers.Razor.Components.Helpers
{
    internal static class DayNameHelper
    {
        public static string ToDayName(int dayIndex)
        {
            var dayNames = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.DayNames.ToList();

            if (dayIndex == 7)
            {
                return dayNames[0];
            }
            else if (dayIndex >= 0 && dayIndex <= 6)
            {
                return dayNames[dayIndex];
            }
            else
            {
                throw new InvalidCastException($"DayIndex {dayIndex} not castable.");
            }
        }
    }
}