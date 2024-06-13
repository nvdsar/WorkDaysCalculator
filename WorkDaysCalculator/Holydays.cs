using WorkDaysCalculator;

namespace WorkDaysCalculator
{
    public record Holyday(string Date, HolydayRegion Region);

    public static class Holydays
    {
        public static List<Holyday> Days = new List<Holyday>()
        {
            new ("01/01", HolydayRegion.SolarHijri),
            new ("01/02", HolydayRegion.SolarHijri ),
            new ("01/03", HolydayRegion.SolarHijri ),
            new ("01/04", HolydayRegion.SolarHijri ),
            new ("01/12", HolydayRegion.SolarHijri ),
            new ("01/13", HolydayRegion.SolarHijri ),
            new ("03/14", HolydayRegion.SolarHijri ),
            new ("03/15", HolydayRegion.SolarHijri ),
            new ("10/22", HolydayRegion.SolarHijri ),
            new ("12/29", HolydayRegion.SolarHijri ),
            new ("12/29", HolydayRegion.SolarHijri ),


            new ("01/09", HolydayRegion.LunarHijri ),
            new ("01/10", HolydayRegion.LunarHijri ),
            new ("02/20", HolydayRegion.LunarHijri ),
            new ("02/28", HolydayRegion.LunarHijri ),
            new ("02/30", HolydayRegion.LunarHijri ),
            new ("03/08", HolydayRegion.LunarHijri ),
            new ("03/17", HolydayRegion.LunarHijri ),
            new ("06/03", HolydayRegion.LunarHijri ),
            new ("07/13", HolydayRegion.LunarHijri ),
            new ("07/27", HolydayRegion.LunarHijri ),
            new ("08/15", HolydayRegion.LunarHijri ),
            new ("09/21", HolydayRegion.LunarHijri ),
            new ("10/01", HolydayRegion.LunarHijri ),
            new ("10/02", HolydayRegion.LunarHijri ),
            new ("10/25", HolydayRegion.LunarHijri ),
            new ("12/10", HolydayRegion.LunarHijri ),
            new ("12/18", HolydayRegion.LunarHijri ),

            new ("01/01", HolydayRegion.Victoria ),
            new ("02/26", HolydayRegion.Victoria ),
            new ("03/11", HolydayRegion.Victoria ),
            new ("03/29", HolydayRegion.Victoria ),
            new ("03/30", HolydayRegion.Victoria ),
            new ("03/31", HolydayRegion.Victoria ),
            new ("04/01", HolydayRegion.Victoria ),
            new ("04/25", HolydayRegion.Victoria ),
            new ("06/10", HolydayRegion.Victoria ),
            new ("10/05", HolydayRegion.Victoria ),
            new ("11/25", HolydayRegion.Victoria ),
            new ("11/26", HolydayRegion.Victoria ),
        };
    }

    public enum HolydayRegion
    {
        SolarHijri = 0,
        LunarHijri = 1,
        Victoria = 2,
    }
}
