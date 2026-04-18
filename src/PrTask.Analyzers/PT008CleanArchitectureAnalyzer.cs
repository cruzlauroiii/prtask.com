using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT008CleanArchitectureAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT008,
        "Clean architecture violation",
        "Layer violation: {0} cannot reference {1}",
        "Architecture",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    private static readonly string[] ApplicationForbidden =
    [
        "PrTask.Infrastructure",
        "PrTask.Server",
        "PrTask.SharedUI",
        "PrTask.Client",
        "PrTask.Maui"
    ];

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.UsingDirective);
    }

    private static void AnalyzeNode(SyntaxNodeAnalysisContext Context)
    {
        var AssemblyName = Context.Compilation.AssemblyName ?? string.Empty;
        var UsingDirective = (UsingDirectiveSyntax)Context.Node;
        var UsingName = UsingDirective.Name?.ToString();

        if (string.IsNullOrEmpty(UsingName))
        {
            return;
        }

        if (AssemblyName == "PrTask.Domain")
        {
            if (UsingName!.StartsWith("PrTask.") && !UsingName.StartsWith("PrTask.Domain"))
            {
                var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
                    Rule,
                    UsingDirective.GetLocation(),
                    AssemblyName,
                    UsingName);
                Context.ReportDiagnostic(Diagnostic);
            }
        }
        else if (AssemblyName == "PrTask.Application")
        {
            foreach (var Forbidden in ApplicationForbidden)
            {
                if (UsingName!.StartsWith(Forbidden))
                {
                    var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
                        Rule,
                        UsingDirective.GetLocation(),
                        AssemblyName,
                        UsingName);
                    Context.ReportDiagnostic(Diagnostic);
                    break;
                }
            }
        }
    }
}
