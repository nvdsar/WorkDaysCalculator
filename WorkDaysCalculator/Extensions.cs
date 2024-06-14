using System.Globalization;

namespace WorkDaysCalculator
{
    internal static class Extensions
    {
        internal static string ToPadString(this object str, int totalWidth, char paddingChar)
        {
            if (str == null) str = string.Empty;
            return str.ToString().PadLeft(totalWidth, paddingChar);
        }
        private static PersianCalendar p = new PersianCalendar();
        internal static string ToPersianDate(this DateTime dt)
        {
            return string.Format("{0}/{1}/{2}", p.GetYear(dt).ToPadString(4, '0'), p.GetMonth(dt).ToPadString(2, '0'), p.GetDayOfMonth(dt).ToPadString(2, '0'));
        }

    }
}
