namespace ZbW.Testing.Dependencies.Lib.UnitTests.Fakes
{
    using System;

    public class DateTimeGeneratorMock : IDateTimeGenerator
    {
        public bool CurrentDateTimeCalled { get; set; }

        public DateTime CurrentDateTime()
        {
            CurrentDateTimeCalled = true;
            return default(DateTime);
        }
    }
}