namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No trailing whitespace should exist in any C# source file")]
    public void TCompact01NoTrailingWhitespaceShouldExistInAnyCSharpSourceFile()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 0; I < Lines.Length; I++)
            {
                if (Lines[I].Length > 0 && Lines[I] != Lines[I].TrimEnd())
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Trailing whitespace in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No empty method bodies should exist in any C# source file")]
    public void TCompact02NoEmptyMethodBodiesShouldExistInAnyCSharpSourceFile()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            var Lines = Content.Split('\n');
            for (var I = 0; I < Lines.Length - 1; I++)
            {
                if (Lines[I].TrimEnd().EndsWith('{') && Lines[I + 1].TrimEnd() == "}")
                {
                    var TrimmedLine = Lines[I].Trim();
                    if (!TrimmedLine.StartsWith("namespace") && !TrimmedLine.StartsWith("static") && !TrimmedLine.StartsWith('{'))
                    {
                        Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                    }
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Empty bodies in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All C# files must use file scoped namespaces not block scoped")]
    public void TCompact04AllCSharpFilesMustUseFileScopedNamespacesNotBlockScoped()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            foreach (var Line in Lines)
            {
                var Trimmed = Line.Trim();
                if (Trimmed.StartsWith("namespace ") && Trimmed.EndsWith('{'))
                {
                    Violations.Add(Path.GetFileName(FilePath));
                    break;
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Block-scoped namespaces in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No region or end region preprocessor directives should exist in source")]
    public void TCompact05NoRegionOrEndRegionPreprocessorDirectivesShouldExistInSource()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 0; I < Lines.Length; I++)
            {
                var Trimmed = Lines[I].Trim();
                if (Trimmed.StartsWith("#region") || Trimmed.StartsWith("#endregion"))
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Regions found in: {string.Join(", ", Violations.Take(10))}");
    }
}
