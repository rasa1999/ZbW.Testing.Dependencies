using System.Diagnostics.CodeAnalysis;

namespace ZbW.Testing.Dependencies.Lib.UnitTests.Fakes
{
    [ExcludeFromCodeCoverage]
    public class FileAnalyzerMock : IFileAnalyzer
    {
        public bool CheckFormatCalled { get; private set; }

        public bool CheckExistsCalled { get; private set; }

        public bool CheckFormat(string path)
        {
            CheckFormatCalled = true;
            return true;
        }

        public bool CheckExists(string path)
        {
            CheckExistsCalled = true;
            return true;
        }
    }
}