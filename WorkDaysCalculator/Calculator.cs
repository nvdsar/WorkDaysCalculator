using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkDaysCalculator
{
    public class Calculator
    {
        CultureInfo PersianCulture = new CultureInfo("fa-Ir");
        CultureInfo ArabicCulture = new CultureInfo("ar-SA");
        CultureInfo AustralianCulture = new CultureInfo("en-au");
        public List<DateTime> GetWorkDays(DateTime from, DateTime to, params HolydayRegion[] regions)
        {
            if (to < from)
                throw new InvalidDataException();

            var overAllDates = new List<DateTime>();

            var f = from.Date.AddDays(-1);

            do
            {
                f = f.AddDays(1);
                if (skip(HolydayRegion.SolarHijri, PersianCulture))
                    continue;
                if (skip(HolydayRegion.LunarHijri, ArabicCulture))
                    continue;
                if (skip(HolydayRegion.Victoria, AustralianCulture))
                    continue;
                overAllDates.Add(f.Date);

            } while (f.Date <= to.Date);

            bool skip(HolydayRegion region, CultureInfo culture)
            {
                if (regions.Contains(region))
                {
                    return Holydays.Days.Where(x => x.Region == region).Select(x => x.Date.Replace("/", "")).Contains(f.ToString("MMdd", culture));
                }
                return false;
            }

            var weekendDays = getWeekendDays(regions.FirstOrDefault());
            var workDays = overAllDates.Where(x => weekendDays.Contains(x.DayOfWeek) == false).ToList();

            return workDays;
        }
        public int GetWorkDaysCount(DateTime from, DateTime to, params HolydayRegion[] regions)
        {
            var workDays = GetWorkDays(from, to, regions);
            return workDays.Count;
        }
        private DayOfWeek[] getWeekendDays(HolydayRegion region)
        {
            switch (region)
            {
                case HolydayRegion.SolarHijri:
                    return [DayOfWeek.Thursday, DayOfWeek.Friday,];
                case HolydayRegion.LunarHijri:
                    return [DayOfWeek.Friday, DayOfWeek.Saturday];
                default:
                    return [DayOfWeek.Saturday, DayOfWeek.Sunday];
            }
        }
    }
}
