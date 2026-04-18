using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace PrTask.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class PT001PascalCaseAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticIds.PT001,
        "PascalCase required",
        "'{0}' must use PascalCase",
        "Naming",
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
        ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext Context)
    {
        Context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        Context.EnableConcurrentExecution();

        Context.RegisterSyntaxNodeAction(AnalyzeNode,
            SyntaxKind.ClassDeclaration,
            SyntaxKind.StructDeclaration,
            SyntaxKind.RecordDeclaration,
            SyntaxKind.InterfaceDeclaration,
            SyntaxKind.EnumDeclaration,
            SyntaxKind.MethodDeclaration,
            SyntaxKind.PropertyDeclaration,
            SyntaxKind.FieldDeclaration,
            SyntaxKind.EventFieldDeclaration,
            SyntaxKind.DelegateDeclaration,
            SyntaxKind.EnumMemberDeclaration,
            SyntaxKind.Parameter,
            SyntaxKind.ForEachStatement,
            SyntaxKind.CatchDeclaration,
            SyntaxKind.SingleVariableDesignation,
            SyntaxKind.LocalFunctionStatement,
            SyntaxKind.TypeParameter);
    }

    private static void AnalyzeNode(SyntaxNodeAnalysisContext Context)
    {
        switch (Context.Node)
        {
            case TypeDeclarationSyntax TypeDecl:
                CheckIdentifier(Context, TypeDecl.Identifier);
                break;
            case EnumDeclarationSyntax EnumDecl:
                CheckIdentifier(Context, EnumDecl.Identifier);
                break;
            case MethodDeclarationSyntax MethodDecl:
                CheckIdentifier(Context, MethodDecl.Identifier);
                break;
            case PropertyDeclarationSyntax PropertyDecl:
                CheckIdentifier(Context, PropertyDecl.Identifier);
                break;
            case FieldDeclarationSyntax FieldDecl:
                foreach (var Declarator in FieldDecl.Declaration.Variables)
                {
                    CheckIdentifier(Context, Declarator.Identifier);
                }
                break;
            case EventFieldDeclarationSyntax EventFieldDecl:
                foreach (var Declarator in EventFieldDecl.Declaration.Variables)
                {
                    CheckIdentifier(Context, Declarator.Identifier);
                }
                break;
            case DelegateDeclarationSyntax DelegateDecl:
                CheckIdentifier(Context, DelegateDecl.Identifier);
                break;
            case EnumMemberDeclarationSyntax EnumMemberDecl:
                CheckIdentifier(Context, EnumMemberDecl.Identifier);
                break;
            case ParameterSyntax ParameterDecl:
                CheckIdentifier(Context, ParameterDecl.Identifier);
                break;
            case ForEachStatementSyntax ForEachDecl:
                CheckIdentifier(Context, ForEachDecl.Identifier);
                break;
            case CatchDeclarationSyntax CatchDecl:
                CheckIdentifier(Context, CatchDecl.Identifier);
                break;
            case SingleVariableDesignationSyntax SingleVarDecl:
                CheckIdentifier(Context, SingleVarDecl.Identifier);
                break;
            case LocalFunctionStatementSyntax LocalFuncDecl:
                CheckIdentifier(Context, LocalFuncDecl.Identifier);
                break;
            case TypeParameterSyntax TypeParamDecl:
                CheckIdentifier(Context, TypeParamDecl.Identifier);
                break;
        }
    }

    private static void CheckIdentifier(SyntaxNodeAnalysisContext Context, SyntaxToken Identifier)
    {
        var Name = Identifier.Text;

        if (string.IsNullOrEmpty(Name) || Name == "_")
        {
            return;
        }

        if (!char.IsUpper(Name[0]))
        {
            var Diagnostic = Microsoft.CodeAnalysis.Diagnostic.Create(
                Rule,
                Identifier.GetLocation(),
                Name);
            Context.ReportDiagnostic(Diagnostic);
        }
    }
}
