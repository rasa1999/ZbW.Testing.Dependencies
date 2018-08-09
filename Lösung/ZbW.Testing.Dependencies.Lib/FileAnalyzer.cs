namespace ZbW.Testing.Dependencies.Lib
{
    using System.IO;

    public class FileAnalyzer : IFileAnalyzer
    {
        public bool CheckFormat(string path)
        {
            var fileInfo = new FileInfo(path);

            // überprüfen, ob das Format korrekt ist
            // CODE - Zur Überprüfung des Formats
            return true;
        }

        public bool CheckPermissions(string path)
        {
            var fileInfo = new FileInfo(path);

            // überprüfung der Zugriffsrechte
            // CODE - Zur prüfung der Rechte
            return true;
        }
    }
}