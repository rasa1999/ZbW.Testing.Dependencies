namespace ZbW.Testing.Dependencies.Lib.Fakes
{
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class FileAnalyzerMock : IFileAnalyzer
    {
        public bool CheckFormatCalled { get; private set; }

        public bool CheckPermissionsCalled { get; private set; }

        public bool CheckFormat(string path)
        {
            CheckFormatCalled = true;
            return true;
        }

        public bool CheckPermissions(string path)
        {
            CheckPermissionsCalled = true;
            return true;
        }
    }
}