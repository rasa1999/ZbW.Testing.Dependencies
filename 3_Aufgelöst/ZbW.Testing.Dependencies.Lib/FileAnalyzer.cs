using System.IO;

namespace ZbW.Testing.Dependencies.Lib
{
    public class FileAnalyzer : IFileAnalyzer
    {
        private const string XmlExtension = "xml";

        public bool CheckFormat(string path)
        {
            var fileInfo = new FileInfo(path);
            return fileInfo.Extension == XmlExtension;
        }

        public bool CheckExists(string path)
        {
            var fileInfo = new FileInfo(path);
            return fileInfo.Exists;
        }
    }
}