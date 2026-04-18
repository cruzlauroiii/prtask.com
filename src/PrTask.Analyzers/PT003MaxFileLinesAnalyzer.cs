using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT003MaxFileLinesAnalyzer : DiagnosticAnalyzer
{
    private const int MaxLines = 300;

    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT003,
        "File too long",
        "File has {0} lines, maximum is 300",
        "Design",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxTreeAction(AnalyzeTree);
    }

    private static void AnalyzeTree(SyntaxTreeAnalysisContext Context)
    {
        var Tree = Context.Tree;
        var LineCount = Tree.GetText().Lines.Count;

        if (LineCount > MaxLines)
        {
            var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
                Rule,
                Location.Create(Tree, TextSpan.FromBounds(0, 0)),
                LineCount);
            Context.ReportDiagnostic(Diagnostic);
        }
    }
}
