using System.Reflection;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All test methods must have a display name attribute for readable test output")]
    public void TDisplayName01AllTestMethodsMustHaveADisplayNameAttributeForReadableTestOutput()
    {
        var TestAssembly = typeof(ArchitectureTests).Assembly;
        var Violations = new List<string>();
        foreach (var Type in TestAssembly.GetTypes())
        {
            foreach (var Method in Type.GetMethods())
            {
                if (Method.GetCustomAttribute<TestMethodAttribute>() is null)
                {
                    continue;
                }
                if (Method.GetCustomAttribute<DisplayNameAttribute>() is null)
                {
                    Violations.Add(Method.Name);
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Missing DisplayName: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All test display name values must be non empty strings for meaningful output")]
    public void TDisplayName02AllTestDisplayNameValuesMustBeNonEmptyStringsForMeaningfulOutput()
    {
        var TestAssembly = typeof(ArchitectureTests).Assembly;
        var Violations = new List<string>();
        foreach (var Type in TestAssembly.GetTypes())
        {
            foreach (var Method in Type.GetMethods())
            {
                var DisplayAttr = Method.GetCustomAttribute<DisplayNameAttribute>();
                if (DisplayAttr is not null && string.IsNullOrWhiteSpace(DisplayAttr.DisplayName))
                {
                    Violations.Add(Method.Name);
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Empty DisplayName: {string.Join(", ", Violations.Take(10))}");
    }
}
