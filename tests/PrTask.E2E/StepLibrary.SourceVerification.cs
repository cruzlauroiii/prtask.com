namespace PrTask.E2E;
public partial class RulesTests
{
    private static void AssertSourceContains(string Project, string Path, string Expected, string? Message = null)
    {
        var Content = ReadSource(Project, Path);
        Assert.IsTrue(Content.Contains(Expected),
            Message ?? $"Expected '{Path}' in {Project} to contain '{Expected}'");
    }

    private static void AssertSourceContainsAll(string Project, string Path, params string[] ExpectedStrings)
    {
        var Content = ReadSource(Project, Path);
        foreach (var Expected in ExpectedStrings)
        {
            Assert.IsTrue(Content.Contains(Expected),
                $"Expected '{Path}' in {Project} to contain '{Expected}'");
        }
    }

    private static void AssertSourceDoesNotContain(string Project, string Path, string Unexpected, string? Message = null)
    {
        var Content = ReadSource(Project, Path);
        Assert.IsFalse(Content.Contains(Unexpected),
            Message ?? $"Expected '{Path}' in {Project} to NOT contain '{Unexpected}'");
    }

    private static void AssertFileExistsInProject(string Project, string RelativePath)
    {
        var FullPath = System.IO.Path.Combine(SourceRoot, Project, RelativePath);
        Assert.IsTrue(File.Exists(FullPath), $"Expected file '{RelativePath}' to exist in {Project}");
    }

    private static void AssertFileDoesNotExistInProject(string Project, string RelativePath)
    {
        var FullPath = System.IO.Path.Combine(SourceRoot, Project, RelativePath);
        Assert.IsFalse(File.Exists(FullPath), $"Expected file '{RelativePath}' to NOT exist in {Project}");
    }
}
