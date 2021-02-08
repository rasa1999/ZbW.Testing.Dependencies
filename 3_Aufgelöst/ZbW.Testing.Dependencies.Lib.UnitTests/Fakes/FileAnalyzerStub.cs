using System.Diagnostics.CodeAnalysis;

namespace ZbW.Testing.Dependencies.Lib.UnitTests.Fakes
{
    [ExcludeFromCodeCoverage]
    public class FileAnalyzerStub : IFileAnalyzer
    {
        private readonly bool _isExisting;

        private readonly bool _isValidFormat;

        public FileAnalyzerStub(bool isValidFormat, bool isExisting)
        {
            _isValidFormat = isValidFormat;
            _isExisting = isExisting;
        }

        public bool CheckFormat(string path)
        {
            return _isValidFormat;
        }

        public bool CheckExists(string path)
        {
            return _isExisting;
        }
    }
}