namespace ZbW.Testing.Dependencies.Lib
{
    using System.IO;

    public class PersistanceService
    {
        private const string XmlExtension = "xml";
        public bool IsFileValid(string path)
        {
            var fileInfo = new FileInfo(path);

            // Überprüft ob das Format korrekt ist
            var isValidFormat = fileInfo.Extension == XmlExtension; ;

            // Überprüft ob das File existiert
            var isExisting = fileInfo.Exists;

            return isValidFormat && isExisting;
        }
    }
}