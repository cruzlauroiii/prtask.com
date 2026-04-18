using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT005NoMagicStringsAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT005,
        "No magic strings",
        "Use a domain constant instead of magic string",
        "Design",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.StringLiteralExpression);
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

        var LiteralExpr = (LiteralExpressionSyntax)Context.Node;
        var Value = LiteralExpr.Token.ValueText;

        if (Value.Length == 0)
        {
            return;
        }

        var FieldDecl = LiteralExpr.FirstAncestorOrSelf<FieldDeclarationSyntax>();

        if (FieldDecl != null && FieldDecl.Modifiers.Any(SyntaxKind.ConstKeyword))
        {
            return;
        }

        if (LiteralExpr.FirstAncestorOrSelf<AttributeArgumentSyntax>() != null)
        {
            return;
        }

        var InvocationExpr = LiteralExpr.FirstAncestorOrSelf<InvocationExpressionSyntax>();

        if (InvocationExpr != null)
        {
            var ExprText = InvocationExpr.Expression.ToString();

            if (ExprText == "nameof")
            {
                return;
            }

            if (ExprText.StartsWith("Log") || ExprText.EndsWith(".LogError") ||
                ExprText.EndsWith(".LogWarning") || ExprText.EndsWith(".LogInformation") ||
                ExprText.EndsWith(".LogDebug") || ExprText.EndsWith(".LogTrace") ||
                ExprText.EndsWith(".LogCritical"))
            {
                return;
            }
        }

        var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
            Rule,
            LiteralExpr.GetLocation());
        Context.ReportDiagnostic(Diagnostic);
    }
}
