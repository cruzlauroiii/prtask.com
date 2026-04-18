using System.Reflection;
using System.Text.RegularExpressions;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All test display names must be compact complete comprehensive detailed sentences with at least eight words")]
    public void AllTestDisplayNamesAreCompactCompleteComprehensiveDetailedSentencesWithAtLeastEightWords()
    {
        var TestAssembly = typeof(ArchitectureTests).Assembly;
        var Violations = new List<string>();
        foreach (var Type in TestAssembly.GetTypes())
        {
            foreach (var Method in Type.GetMethods())
            {
                var DisplayAttr = Method.GetCustomAttribute<DisplayNameAttribute>();
                if (DisplayAttr is null)
                {
                    continue;
                }
                var WordCount = DisplayAttr.DisplayName.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                if (WordCount < 8)
                {
                    Violations.Add($"{Method.Name}: \"{DisplayAttr.DisplayName}\" ({WordCount} words)");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Short display names: {string.Join(", ", Violations.Take(5))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All test method names must contain at least four PascalCase words to be descriptive enough")]
    public void AllTestMethodNamesContainAtLeastFourPascalCaseWordsToBeDescriptiveEnoughForAutomation()
    {
        var TestAssembly = typeof(ArchitectureTests).Assembly;
        var Violations = new List<string>();
        var PascalWordPattern = PascalCaseWordRegex();
        foreach (var Type in TestAssembly.GetTypes())
        {
            foreach (var Method in Type.GetMethods())
            {
                if (Method.GetCustomAttribute<TestMethodAttribute>() is null)
                {
                    continue;
                }
                var Words = PascalWordPattern.Matches(Method.Name);
                if (Words.Count < 4)
                {
                    Violations.Add($"{Method.Name} ({Words.Count} words)");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Short method names: {string.Join(", ", Violations.Take(5))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All public classes and methods in source projects must contain at least two PascalCase words")]
    public void AllPublicClassesAndMethodsInSourceProjectsContainAtLeastTwoPascalCaseWordsForClarity()
    {
        var Assemblies = new[] { DomainAssembly, ApplicationAssembly, InfrastructureAssembly };
        var Violations = new List<string>();
        var PascalWordPattern = PascalCaseWordRegex();
        foreach (var Assembly in Assemblies)
        {
            foreach (var Type in Assembly.GetExportedTypes())
            {
                if (Type.IsEnum)
                {
                    continue;
                }
                var TypeWords = PascalWordPattern.Matches(Type.Name);
                if (TypeWords.Count < 2 && !Type.IsInterface)
                {
                    Violations.Add($"Type: {Type.Name} ({TypeWords.Count} words)");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Short names: {string.Join(", ", Violations.Take(10))}");
    }
    [GeneratedRegex("[A-Z][a-z]+")]
    private static partial Regex PascalCaseWordRegex();
}
