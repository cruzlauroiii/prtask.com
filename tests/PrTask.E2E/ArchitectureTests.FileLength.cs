namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All C# source files must be under three hundred lines for maintainability")]
    public void TFileLength01AllCSharpSourceFilesMustBeUnderThreeHundredLinesForMaintainability()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var LineCount = File.ReadAllLines(FilePath).Length;
            if (LineCount > MaxFileLines)
            {
                Violations.Add($"{Path.GetFileName(FilePath)} ({LineCount} lines)");
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Files over {MaxFileLines} lines: {string.Join(", ", Violations)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All Razor source files must be under three hundred lines for maintainability")]
    public void TFileLength02AllRazorSourceFilesMustBeUnderThreeHundredLinesForMaintainability()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".razor"))
        {
            var LineCount = File.ReadAllLines(FilePath).Length;
            if (LineCount > MaxFileLines)
            {
                Violations.Add($"{Path.GetFileName(FilePath)} ({LineCount} lines)");
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Razor files over {MaxFileLines} lines: {string.Join(", ", Violations)}");
    }
}
