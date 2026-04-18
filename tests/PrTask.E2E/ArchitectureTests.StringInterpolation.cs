using System.Text.RegularExpressions;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No String Format usage should exist anywhere in source code files")]
    public void TInterp01NoStringFormatUsageShouldExistAnywhereInSourceCodeFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            if (StringFormatRegex().IsMatch(Content))
            {
                Violations.Add(Path.GetFileName(FilePath));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"String.Format usage in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No string concatenation with plus operator should exist in source files")]
    public void TInterp02NoStringConcatenationWithPlusOperatorShouldExistInSourceFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 0; I < Lines.Length; I++)
            {
                if (StringConcatPlusRegex().IsMatch(Lines[I]))
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"String concat in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No AppendFormat usage should exist anywhere in source code files")]
    public void TInterp03NoAppendFormatUsageShouldExistAnywhereInSourceCodeFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            if (Content.Contains("AppendFormat"))
            {
                Violations.Add(Path.GetFileName(FilePath));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"AppendFormat usage in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Project must actively use dollar sign string interpolation in source files")]
    public void TInterp04ProjectMustActivelyUseDollarSignStringInterpolationInSourceFiles()
    {
        var InterpolationCount = 0;
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            InterpolationCount += DollarInterpolationRegex().Count(Content);
        }
        Assert.IsTrue(InterpolationCount > 0, "No string interpolation usage found");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No String Concat method calls should exist anywhere in source code files")]
    public void TInterp05NoStringConcatMethodCallsShouldExistAnywhereInSourceCodeFiles()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            if (StringConcatMethodRegex().IsMatch(Content))
            {
                Violations.Add(Path.GetFileName(FilePath));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"String.Concat in: {string.Join(", ", Violations.Take(10))}");
    }
    [GeneratedRegex(@"string\.Format\s*\(")]
    private static partial Regex StringFormatRegex();
    [GeneratedRegex(@"""\s*\+\s*""")]
    private static partial Regex StringConcatPlusRegex();
    [GeneratedRegex(@"\$""")]
    private static partial Regex DollarInterpolationRegex();
    [GeneratedRegex(@"string\.Concat\s*\(")]
    private static partial Regex StringConcatMethodRegex();
}
