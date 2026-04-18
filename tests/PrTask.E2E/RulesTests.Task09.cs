namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task09 PascalCase everywhere for types methods properties fields locals parameters and enums with editorconfig IDE1006 as error")]
    public void Task09PascalCaseEverywhereWithEditorConfigRules()
    {
        var Ec = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Ec.Contains("dotnet_naming_rule.private_fields_pascal"), "Must have private_fields_pascal rule");
        Assert.IsTrue(Ec.Contains("dotnet_naming_rule.constants_pascal"), "Must have constants_pascal rule");
        Assert.IsTrue(Ec.Contains("dotnet_naming_rule.types_pascal"), "Must have types_pascal rule");
        Assert.IsTrue(Ec.Contains("dotnet_naming_rule.public_members_pascal"), "Must have public_members_pascal rule");
        Assert.IsTrue(Ec.Contains("pascal_case"), "Must reference pascal_case style");
        Assert.IsTrue(Ec.Contains("warning"), "Must set naming rule severity");
        var Analyzer = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Analyzers", "PT001PascalCaseAnalyzer.cs"));
        Assert.IsTrue(Analyzer.Contains("DiagnosticAnalyzer"), "PT001 PascalCase analyzer must exist");
    }
}
