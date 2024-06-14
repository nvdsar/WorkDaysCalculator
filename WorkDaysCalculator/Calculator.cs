using System.Globalization;

namespace WorkDaysCalculator
{
    public class Calculator
    {
        CultureInfo PersianCulture = new CultureInfo("fa-Ir");
        CultureInfo ArabicCulture = new CultureInfo("ar-SA");
        CultureInfo AmericanCulture = new CultureInfo("en-US");
        public List<DateTime> GetWorkDays(DateTime from, DateTime to, params HolidayRegion[] regions)
        {
            if (to < from)
                throw new InvalidDataException("The date indicating as \'To\' should be bigger (aka later) than \'From\'");

            var overAllDates = new List<DateTime>();

            var f = from.Date.AddDays(-1);

            do
            {
                f = f.AddDays(1);
                if (skip(HolidayRegion.SolarHijri, PersianCulture))
                    continue;
                if (skip(HolidayRegion.LunarHijri, ArabicCulture))
                    continue;
                if (skip(HolidayRegion.USA, AmericanCulture))
                    continue;
                overAllDates.Add(f.Date);

            } while (f.Date <= to.Date);

            bool skip(HolidayRegion region, CultureInfo culture)
            {
                if (regions.Contains(region))
                {
                    return Holidays.Days.Where(x => x.Region == region).Select(x => x.Date.Replace("/", "")).Contains(f.ToString("MMdd", culture));
                }
                return false;
            }

            var weekendDays = getWeekendDays(regions.FirstOrDefault());
            var workDays = overAllDates.Where(x => weekendDays.Contains(x.DayOfWeek) == false).ToList();

            return workDays;
        }
        public int GetWorkDaysCount(DateTime from, DateTime to, params HolidayRegion[] regions)
        {
            var workDays = GetWorkDays(from, to, regions);
            return workDays.Count;
        }
        private DayOfWeek[] getWeekendDays(HolidayRegion region)
        {
            switch (region)
            {
                case HolidayRegion.SolarHijri:
                    return new DayOfWeek[] { DayOfWeek.Thursday, DayOfWeek.Friday, };
                case HolidayRegion.LunarHijri:
                    return new DayOfWeek[] { DayOfWeek.Friday, DayOfWeek.Saturday };
                default:
                    return new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday };
            }
        }
    }
}
