using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT002NamespaceAndRegionAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor NamespaceRule = new(
        DiagnosticIds.PT002,
        "Use file-scoped namespace",
        "Use file-scoped namespace",
        "Style",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor RegionRule = new(
        DiagnosticIds.PT002,
        "Remove region directive",
        "Remove region directive",
        "Style",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(NamespaceRule, RegionRule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNamespace, SyntaxKind.NamespaceDeclaration);
        Context.RegisterSyntaxTreeAction(AnalyzeTree);
    }

    private static void AnalyzeNamespace(SyntaxNodeAnalysisContext Context)
    {
        var NamespaceDecl = (NamespaceDeclarationSyntax)Context.Node;
        var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
            NamespaceRule,
            NamespaceDecl.NamespaceKeyword.GetLocation());
        Context.ReportDiagnostic(Diagnostic);
    }

    private static void AnalyzeTree(SyntaxTreeAnalysisContext Context)
    {
        var Root = Context.Tree.GetRoot(Context.CancellationToken);

        foreach (var Trivia in Root.DescendantTrivia())
        {
            if (Trivia.IsKind(SyntaxKind.RegionDirectiveTrivia) ||
                Trivia.IsKind(SyntaxKind.EndRegionDirectiveTrivia))
            {
                var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
                    RegionRule,
                    Trivia.GetLocation());
                Context.ReportDiagnostic(Diagnostic);
            }
        }
    }
}
