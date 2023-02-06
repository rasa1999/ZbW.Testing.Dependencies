using System;

namespace ZbW.Testing.Dependencies.Lib
{
    public class DateTimeGeneratorStub : IDateTimeGenerator
    {
        private const string DATE_FORMAT = "yyyyMMddHHmmss";

        private int _year, _month, _day, _hour, _minute, _second;

        public DateTimeGeneratorStub(int year, int month, int day, int hour, int minute, int second)
        {
            _year = year;
            _month = month;
            _day = day;
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public string Generate(string name, string extension)
        {
            var dateTime = new DateTime(_year, _month, _day, _hour, _minute, _second);
            var suffixString = dateTime.ToString(DATE_FORMAT);

            return $"{name}{suffixString}.{extension}";
        }
    }
}
