namespace ZbW.Testing.Dependencies.Lib
{
    using System;

    public class FileNameGenerator
    {

        private IDateTimeGenerator _dateTimeGenerator;

        public FileNameGenerator(IDateTimeGenerator dateTimeGenerator)
        {
            _dateTimeGenerator = dateTimeGenerator;
        }

        public string ReturnFileName(string name, string extension)
        {
            return _dateTimeGenerator.Generate(name, extension);
        }

       
        


        //private const string DATE_FORMAT = "yyyyMMddHHmmss";

        //public string Generate(string name, string extension)
        //{
        //    var dateTime = DateTime.Now;
        //    var suffixString = dateTime.ToString(DATE_FORMAT);

        //    return $"{name}{suffixString}.{extension}";
        //}
    }
}