namespace ZbW.Testing.Dependencies.Lib
{
    using System.IO;

    public class PersistanceService
    {
        public bool IsFileValid(string path)
        {
            var fileInfo = new FileInfo(path);

            // überprüfen, ob das Format korrekt ist
            // CODE - Zur Überprüfung des Formats
            var isValidFormat = true;

            // überprüfung der Zugriffsrechte
            // CODE - Zur prüfung der Rechte
            var isAuthorized = true;

            return isValidFormat && isAuthorized;
        }
    }
}