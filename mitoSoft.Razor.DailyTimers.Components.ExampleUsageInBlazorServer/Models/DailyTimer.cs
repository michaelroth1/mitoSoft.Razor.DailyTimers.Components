using mitoSoft.DailyTimers.Core.Contracts;

namespace mitoSoft.DailyTimers.Razor.Components.ExampleUsageInBlazorServer.Models
{
    public class DailyTimer : IDailyTimer
    {
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public string SwitchTime { get; set; }
        public bool IgnoreOnHolidays { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}