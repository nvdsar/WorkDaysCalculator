using WorkDaysCalculator;

namespace WorkDaysCalculator
{
    public record Holiday(string Date, HolidayRegion Region);

    public static class Holidays
    {
        public static List<Holiday> Days = new List<Holiday>()
        {
            new ("01/01", HolidayRegion.SolarHijri),
            new ("01/02", HolidayRegion.SolarHijri ),
            new ("01/03", HolidayRegion.SolarHijri ),
            new ("01/04", HolidayRegion.SolarHijri ),
            new ("01/12", HolidayRegion.SolarHijri ),
            new ("01/13", HolidayRegion.SolarHijri ),
            new ("03/14", HolidayRegion.SolarHijri ),
            new ("03/15", HolidayRegion.SolarHijri ),
            new ("10/22", HolidayRegion.SolarHijri ),
            new ("12/29", HolidayRegion.SolarHijri ),
            new ("12/29", HolidayRegion.SolarHijri ),


            new ("01/09", HolidayRegion.LunarHijri ),
            new ("01/10", HolidayRegion.LunarHijri ),
            new ("02/20", HolidayRegion.LunarHijri ),
            new ("02/28", HolidayRegion.LunarHijri ),
            new ("02/30", HolidayRegion.LunarHijri ),
            new ("03/08", HolidayRegion.LunarHijri ),
            new ("03/17", HolidayRegion.LunarHijri ),
            new ("06/03", HolidayRegion.LunarHijri ),
            new ("07/13", HolidayRegion.LunarHijri ),
            new ("07/27", HolidayRegion.LunarHijri ),
            new ("08/15", HolidayRegion.LunarHijri ),
            new ("09/21", HolidayRegion.LunarHijri ),
            new ("10/01", HolidayRegion.LunarHijri ),
            new ("10/02", HolidayRegion.LunarHijri ),
            new ("10/25", HolidayRegion.LunarHijri ),
            new ("12/10", HolidayRegion.LunarHijri ),
            new ("12/18", HolidayRegion.LunarHijri ),

            new ("01/01", HolidayRegion.Victoria ),
            new ("02/26", HolidayRegion.Victoria ),
            new ("03/11", HolidayRegion.Victoria ),
            new ("03/29", HolidayRegion.Victoria ),
            new ("03/30", HolidayRegion.Victoria ),
            new ("03/31", HolidayRegion.Victoria ),
            new ("04/01", HolidayRegion.Victoria ),
            new ("04/25", HolidayRegion.Victoria ),
            new ("06/10", HolidayRegion.Victoria ),
            new ("10/05", HolidayRegion.Victoria ),
            new ("11/25", HolidayRegion.Victoria ),
            new ("11/26", HolidayRegion.Victoria ),
        };
    }
}
