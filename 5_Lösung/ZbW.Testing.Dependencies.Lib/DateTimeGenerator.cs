namespace ZbW.Testing.Dependencies.Lib
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class DateTimeGenerator : IDateTimeGenerator
    {
        public DateTime CurrentDateTime()
        {
            var dateTime = DateTime.Now;
            return dateTime;
        }
    }
}