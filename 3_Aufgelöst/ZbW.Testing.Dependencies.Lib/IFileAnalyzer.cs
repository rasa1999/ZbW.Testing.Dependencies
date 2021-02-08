namespace ZbW.Testing.Dependencies.Lib
{
    public interface IFileAnalyzer
    {
        bool CheckFormat(string path);

        bool CheckExists(string path);
    }
}