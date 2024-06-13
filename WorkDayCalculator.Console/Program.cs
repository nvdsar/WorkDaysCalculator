using WorkDaysCalculator;

var from = new DateTime(2024, 06, 01);
var to = DateTime.Now;
var count = new Calculator().GetWorkDaysCount(from, to, HolydayRegion.SolarHijri, HolydayRegion.LunarHijri);
