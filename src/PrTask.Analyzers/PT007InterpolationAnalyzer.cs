using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT007InterpolationAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT007,
        "No interpolation outside domain",
        "String interpolation must be in domain constants",
        "Design",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.InterpolatedStringExpression);
    }

    private static void AnalyzeNode(SyntaxNodeAnalysisContext Context)
    {
        var AssemblyName = Context.Compilation.AssemblyName ?? string.Empty;

        if (AssemblyName.StartsWith("PrTask.Domain"))
        {
            return;
        }

        if (AssemblyName.Contains("Test") || AssemblyName.Contains("E2E"))
        {
            return;
        }

        var InterpolatedExpr = (InterpolatedStringExpressionSyntax)Context.Node;

        if (InterpolatedExpr.FirstAncestorOrSelf<AttributeArgumentSyntax>() != null)
        {
            return;
        }

        var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
            Rule,
            InterpolatedExpr.GetLocation());
        Context.ReportDiagnostic(Diagnostic);
    }
}
