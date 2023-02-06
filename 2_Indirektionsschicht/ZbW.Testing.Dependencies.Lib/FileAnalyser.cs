using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.Testing.Dependencies.Lib
{
    public class FileAnalyser : IFileAnalyser
    {
        private const string XmlExtension = "xml";

        public bool IsFileValid(string path)
        {
            var fileInfo = new FileInfo(path);

            // Überprüft ob das Format korrekt ist
            var isValidFormat = fileInfo.Extension == XmlExtension;

            // Überprüft ob das File existiert
            var isExisting = fileInfo.Exists;

            return isValidFormat && isExisting;
        }
    }
}
