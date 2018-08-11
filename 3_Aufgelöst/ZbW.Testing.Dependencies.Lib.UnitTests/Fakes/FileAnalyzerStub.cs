namespace ZbW.Testing.Dependencies.Lib.UnitTests.Fakes
{
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class FileAnalyzerStub : IFileAnalyzer
    {
        private readonly bool _isAuthorized;

        private readonly bool _isValidFormat;

        public FileAnalyzerStub(bool isValidFormat, bool isAuthorized)
        {
            _isValidFormat = isValidFormat;
            _isAuthorized = isAuthorized;
        }

        public bool CheckFormat(string path)
        {
            return _isValidFormat;
        }

        public bool CheckPermissions(string path)
        {
            return _isAuthorized;
        }
    }
}