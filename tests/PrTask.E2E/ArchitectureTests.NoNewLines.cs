namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No consecutive blank lines should exist in C# source files")]
    public void TNoNewLines01NoConsecutiveBlankLinesShouldExistInCSharpSourceFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 1; I < Lines.Length; I++)
            {
                if (string.IsNullOrWhiteSpace(Lines[I]) && string.IsNullOrWhiteSpace(Lines[I - 1]))
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                    break;
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Consecutive blank lines in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No trailing blank lines should exist at end of C# source files")]
    public void TNoNewLines02NoTrailingBlankLinesShouldExistAtEndOfCSharpSourceFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            if (Lines.Length > 0 && string.IsNullOrWhiteSpace(Lines[^1]))
            {
                Violations.Add(Path.GetFileName(FilePath));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Trailing blank lines in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No consecutive blank lines should exist in Razor source files")]
    public void TNoNewLines03NoConsecutiveBlankLinesShouldExistInRazorSourceFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".razor"))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 1; I < Lines.Length; I++)
            {
                if (string.IsNullOrWhiteSpace(Lines[I]) && string.IsNullOrWhiteSpace(Lines[I - 1]))
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                    break;
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Consecutive blank lines in Razor: {string.Join(", ", Violations.Take(10))}");
    }
}
