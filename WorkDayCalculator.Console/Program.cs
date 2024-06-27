using Quicksilver.PersianDate;
using WorkDaysCalculator;

var calculator = new Calculator();
var from = new DateTime(2024, 06, 01);
var to = DateTime.Now;
var count = calculator.GetWorkDaysCount(from, to, HolidayRegion.SolarHijri, HolidayRegion.LunarHijri);

var fromSolarHijri = "1403/01/01";
var toSolarHijri = to.ToPersianDate(DateFormat.yyyy_MM_dd);
var countSolarHijri = calculator.GetWorkDaysCount(fromSolarHijri, toSolarHijri, HolidayRegion.SolarHijri, HolidayRegion.LunarHijri);

Console.WriteLine(count);
Console.ReadKey();
