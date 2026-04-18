namespace PrTask.E2E;
[TestClass]
public partial class FeatureTests
{
    private static readonly string SolutionRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
    private static readonly string SourceRoot = Path.Combine(SolutionRoot, "src");
    private static string ReadSourceFile(string Project, params string[] PathParts)
    {
        var Segments = new[] { SourceRoot, Project }.Concat(PathParts).ToArray();
        var FullPath = Path.Combine(Segments);
        return File.ReadAllText(FullPath);
    }
    private static bool SourceFileExists(string Project, params string[] PathParts)
    {
        var Segments = new[] { SourceRoot, Project }.Concat(PathParts).ToArray();
        return File.Exists(Path.Combine(Segments));
    }
    private static string ReadInfraFile(params string[] PathSegments)
    {
        var Segments = new[] { SolutionRoot, "infra" }.Concat(PathSegments).ToArray();
        return File.ReadAllText(Path.Combine(Segments));
    }
    private static string ReadRootFile(params string[] PathSegments)
    {
        var Segments = new[] { SolutionRoot }.Concat(PathSegments).ToArray();
        return File.ReadAllText(Path.Combine(Segments));
    }
}
