using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT006NoMagicNumbersAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT006,
        "No magic numbers",
        "Use a domain constant instead of magic number '{0}'",
        "Design",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.NumericLiteralExpression);
    }

    private static bool IsSmallInteger(object? TokenValue) =>
        TokenValue switch
        {
            int IntVal when IntVal is >= 0 and <= 2 => true,
            long LongVal when LongVal is >= 0L and <= 2L => true,
            uint UintVal when UintVal <= 2U => true,
            ulong UlongVal when UlongVal <= 2UL => true,
            double DoubleVal when DoubleVal is >= -0.5 and <= 2.5 =>
                System.Math.Abs(DoubleVal - (int)DoubleVal) < 0.001 && (int)DoubleVal is >= 0 and <= 2,
            float FloatVal when FloatVal is >= -0.5f and <= 2.5f =>
                System.Math.Abs(FloatVal - (int)FloatVal) < 0.001f && (int)FloatVal is >= 0 and <= 2,
            decimal DecimalVal when DecimalVal is >= -0.5m and <= 2.5m =>
                System.Math.Abs(DecimalVal - (int)DecimalVal) < 0.001m && (int)DecimalVal is >= 0 and <= 2,
            _ => false
        };

    private static bool IsNegativeOne(object? TokenValue) =>
        TokenValue is (int and 1) or (long and 1L);

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
        var Token = LiteralExpr.Token;

        var IsNegated = LiteralExpr.Parent is PrefixUnaryExpressionSyntax PrefixParent &&
                        PrefixParent.IsKind(SyntaxKind.UnaryMinusExpression);

        if (IsSmallInteger(Token.Value) && (!IsNegated || !IsNegativeOne(Token.Value)))
        {
            return;
        }

        var FieldDecl = LiteralExpr.FirstAncestorOrSelf<FieldDeclarationSyntax>();

        if (FieldDecl != null && FieldDecl.Modifiers.Any(SyntaxKind.ConstKeyword))
        {
            return;
        }

        if (LiteralExpr.FirstAncestorOrSelf<EnumMemberDeclarationSyntax>() != null)
        {
            return;
        }

        if (LiteralExpr.FirstAncestorOrSelf<AttributeArgumentSyntax>() != null)
        {
            return;
        }

        var DisplayValue = IsNegated ? "-" + Token.Text : Token.Text;

        var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
            Rule,
            LiteralExpr.GetLocation(),
            DisplayValue);
        Context.ReportDiagnostic(Diagnostic);
    }
}
