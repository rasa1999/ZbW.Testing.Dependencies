using System;
using System.Xml;

namespace ZbW.Testing.Dependencies.Lib
{
    using System.IO;

    public class PersistanceService
    {

        private IFileAnalyser _fileAnalyser;

        public PersistanceService()
        {
            _fileAnalyser = new FileAnalyser();

            Console.WriteLine(_fileAnalyser.IsFileValid("MagicString"));
        }




        //public bool IsFileValid(string path)
        //{
        //    var fileInfo = new FileInfo(path);

        //    // Überprüft ob das Format korrekt ist
        //    var isValidFormat = fileInfo.Extension == XmlExtension; ;

        //    // Überprüft ob das File existiert
        //    var isExisting = fileInfo.Exists;

        //    return isValidFormat && isExisting;
        //}
    }
}