namespace ZbW.Testing.Dependencies.Lib
{
    public class PersistanceService
    {
        private readonly IFileAnalyzer _fileAnalyzer;

        public PersistanceService(IFileAnalyzer fileAnalyzer)
        {
            _fileAnalyzer = fileAnalyzer;
        }

        public bool IsFileValid(string path)
        {
            var isValidFormat = _fileAnalyzer.CheckFormat(path);
            var isAuthorized = _fileAnalyzer.CheckPermissions(path);

            return isValidFormat && isAuthorized;
        }
    }
}