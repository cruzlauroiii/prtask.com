using System.Text.RegularExpressions;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [GeneratedRegex(@"^\s*public\s+(?:static\s+)?(?:readonly\s+)?(?:async\s+)?(?:override\s+)?(?:virtual\s+)?(?:abstract\s+)?(?:sealed\s+)?(?:partial\s+)?(?:class|struct|record|interface|enum)\s+([A-Za-z]\w*)")]
    private static partial Regex PublicTypeDeclarationRegex();
    [GeneratedRegex(@"^\s*public\s+(?:static\s+)?(?:readonly\s+)?(?:async\s+)?(?:override\s+)?(?:virtual\s+)?(?:abstract\s+)?(?:new\s+)?[\w<>\[\]?,\s]+?\s+([A-Za-z]\w*)\s*[({]")]
    private static partial Regex PublicMemberDeclarationRegex();
    [GeneratedRegex(@"^\s*public\s+(?:static\s+)?(?:readonly\s+)?[\w<>\[\]?,\s]+?\s+([A-Za-z]\w*)\s*\{")]
    private static partial Regex PublicPropertyDeclarationRegex();
    [GeneratedRegex(@"\bvar\s+([a-zA-Z_]\w*)\s*=")]
    private static partial Regex LocalVarDeclarationRegex();
    [GeneratedRegex(@"\bforeach\s*\(\s*var\s+([a-zA-Z_]\w*)\s+in\b")]
    private static partial Regex ForeachVarDeclarationRegex();
    [GeneratedRegex(@"\bfor\s*\(\s*var\s+([a-zA-Z_]\w*)\s*=")]
    private static partial Regex ForVarDeclarationRegex();
    [GeneratedRegex(@"\b(?:string|int|bool|long|double|float|decimal|object|byte|char|short|uint|ulong|ushort|sbyte)\??\s+([a-z]\w*)")]
    private static partial Regex BuiltInTypeParamRegex();
    [GeneratedRegex(@">\??\s+([a-z]\w*)\s*[,)=]")]
    private static partial Regex GenericTypeParamRegex();
    [GeneratedRegex(@"\bI[A-Z]\w+\??\s+([a-z]\w*)\s*[,)=]")]
    private static partial Regex InterfaceTypeParamRegex();
    [GeneratedRegex(@"\b(?:HttpClient|JsonElement|JsonNode|CancellationToken|Exception|Action|Func|Task|StringBuilder|ClaimsPrincipal|HttpContext)\??\s+([a-z]\w*)")]
    private static partial Regex CommonTypeParamRegex();
    [GeneratedRegex(@"(?<![.\w])([a-z]\w*)\s*=>")]
    private static partial Regex LambdaParamRegex();
    [GeneratedRegex(@"@([a-z]\w*)")]
    private static partial Regex AtParamRegex();
    [GeneratedRegex(@"""[^""]*""")]
    private static partial Regex QuotedStringContentRegex();
    [GeneratedRegex("[A-Z][a-z0-9]+")]
    private static partial Regex PascalWordRegex();
    private static readonly HashSet<string> CSharpContextualKeywords =
    [
        "is", "in", "not", "notnull", "and", "or", "from", "get", "set", "null",
    ];
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All types methods properties fields enums and local variables must use PascalCase naming convention")]
    public void TPascal01AllTypesMethodsPropertiesFieldsEnumsAndLocalVariablesMustUsePascalCaseNamingConvention()
    {
        var TypeRegex = PublicTypeDeclarationRegex();
        var MemberRegex = PublicMemberDeclarationRegex();
        var PropRegex = PublicPropertyDeclarationRegex();
        var VarRegex = LocalVarDeclarationRegex();
        var ForeachRegex = ForeachVarDeclarationRegex();
        var ForRegex = ForVarDeclarationRegex();
        var BuiltInParam = BuiltInTypeParamRegex();
        var GenericParam = GenericTypeParamRegex();
        var InterfaceParam = InterfaceTypeParamRegex();
        var CommonParam = CommonTypeParamRegex();
        var LambdaParam = LambdaParamRegex();
        var AtParam = AtParamRegex();
        var PascalWord = PascalWordRegex();
        var Violations = new List<string>();
        var EditorConfigPath = Path.Combine(SolutionRoot, ".editorconfig");
        Assert.IsTrue(File.Exists(EditorConfigPath), ".editorconfig not found");
        var EditorConfigContent = File.ReadAllText(EditorConfigPath);
        var PascalNamingRules = new[]
        {
            "dotnet_naming_rule.private_fields_pascal",
            "dotnet_naming_rule.constants_pascal",
            "dotnet_naming_rule.types_pascal",
            "dotnet_naming_rule.public_members_pascal",
            "dotnet_naming_rule.locals_camel_case",
            "dotnet_naming_rule.parameters_pascal_case",
        };
        foreach (var Rule in PascalNamingRules)
        {
            if (!EditorConfigContent.Contains(Rule, StringComparison.Ordinal))
            {
                Violations.Add($".editorconfig {Rule}");
            }
        }
        if (!EditorConfigContent.Contains("pascal_case", StringComparison.Ordinal))
        {
            Violations.Add(".editorconfig pascal_case");
        }
        if (!EditorConfigContent.Contains("warning", StringComparison.Ordinal))
        {
            Violations.Add(".editorconfig warning");
        }
        foreach (var CsFile in GetAllProjectFiles())
        {
            var Lines = File.ReadAllLines(CsFile);
            var FileName = Path.GetFileName(CsFile);
            for (var Index = 0; Index < Lines.Length; Index++)
            {
                var Trimmed = Lines[Index].TrimStart();
                var IsComment = Trimmed.StartsWith("//", StringComparison.Ordinal)
                    || Trimmed.StartsWith("///", StringComparison.Ordinal);
                var IsAttribute = Trimmed.StartsWith('[');
                var Line = Lines[Index];
                var CodeLine = QuotedStringContentRegex().Replace(Line, "\"\"");
                var LineRef = $"{FileName}:{Index + 1} ";
                if (IsComment)
                {
                    continue;
                }
                var TypeMatch = TypeRegex.Match(CodeLine);
                if (TypeMatch.Success)
                {
                    var Name = TypeMatch.Groups[1].Value;
                    if (!char.IsUpper(Name[0]))
                    {
                        Violations.Add($"{LineRef}{Name}");
                    }
                }
                if (!IsAttribute)
                {
                    var MemberMatch = MemberRegex.Match(CodeLine);
                    if (MemberMatch.Success)
                    {
                        var Name = MemberMatch.Groups[1].Value;
                        if (!char.IsUpper(Name[0]) && Name != "value")
                        {
                            Violations.Add($"{LineRef}{Name}");
                        }
                    }
                }
                var PropMatch = PropRegex.Match(CodeLine);
                if (PropMatch.Success)
                {
                    var Name = PropMatch.Groups[1].Value;
                    if (!char.IsUpper(Name[0]))
                    {
                        Violations.Add($"{LineRef}{Name}");
                    }
                }
                if (Trimmed.StartsWith("private ", StringComparison.Ordinal)
                    && !Trimmed.Contains('(')
                    && !Trimmed.Contains("const ", StringComparison.Ordinal))
                {
                    var Parts = Trimmed.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (Parts.Length >= 3)
                    {
                        var FieldName = Parts[^1].TrimEnd(';');
                        if (FieldName.Length > 0
                            && (FieldName[0] == '_'
                                || (char.IsLetter(FieldName[0]) && !char.IsUpper(FieldName[0]))))
                        {
                            Violations.Add($"{LineRef}{FieldName}");
                        }
                    }
                }
                CheckLocalVarPascalCase(VarRegex, PascalWord, CodeLine, FileName, Index, Violations);
                CheckLocalVarPascalCase(ForeachRegex, PascalWord, CodeLine, FileName, Index, Violations);
                CheckLocalVarPascalCase(ForRegex, PascalWord, CodeLine, FileName, Index, Violations);
                CheckParamPascalCase(BuiltInParam, CodeLine, FileName, Index, Violations);
                CheckParamPascalCase(GenericParam, CodeLine, FileName, Index, Violations);
                CheckParamPascalCase(InterfaceParam, CodeLine, FileName, Index, Violations);
                CheckParamPascalCase(CommonParam, CodeLine, FileName, Index, Violations);
                var LambdaMatch = LambdaParam.Match(CodeLine);
                if (LambdaMatch.Success)
                {
                    var Name = LambdaMatch.Groups[1].Value;
                    if (Name.Length > 0 && char.IsLower(Name[0])
                        && !CSharpContextualKeywords.Contains(Name))
                    {
                        Violations.Add($"{LineRef}{Name}");
                    }
                }
                var AtMatch = AtParam.Match(CodeLine);
                if (AtMatch.Success)
                {
                    var Name = AtMatch.Groups[1].Value;
                    if (Name.Length > 0 && char.IsLower(Name[0])
                        && !CSharpContextualKeywords.Contains(Name))
                    {
                        Violations.Add($"{LineRef}{Name}");
                    }
                }
            }
        }
        var EnumTypes = DomainAssembly.GetTypes()
            .Where(EnumItem => EnumItem.IsEnum && EnumItem.IsPublic)
            .ToList();
        foreach (var EnumType in EnumTypes)
        {
            foreach (var Name in Enum.GetNames(EnumType))
            {
                if (!char.IsUpper(Name[0]))
                {
                    Violations.Add($"{EnumType.Name}.{Name}");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count,
            $"\n{string.Join("\n", Violations)}");
    }
    private static void CheckLocalVarPascalCase(Regex RegexPattern, Regex PascalWord, string Line, string File, int LineIndex, List<string> Violations)
    {
        var Match = RegexPattern.Match(Line);
        if (!Match.Success)
        {
            return;
        }
        var Name = Match.Groups[1].Value;
        var LineRef = $"{File}:{LineIndex + 1} {Name}";
        if (Name.Length > 0 && char.IsLower(Name[0]))
        {
            Violations.Add(LineRef);
            return;
        }
        if (Name.Length < 4 && Name != "_")
        {
            Violations.Add(LineRef);
            return;
        }
        if (Name.Length >= 4 && PascalWord.Count(Name) < 1)
        {
            Violations.Add(LineRef);
        }
    }
    private static void CheckParamPascalCase(Regex RegexPattern, string Line, string File, int LineIndex, List<string> Violations)
    {
        foreach (Match ParamMatch in RegexPattern.Matches(Line))
        {
            var Name = ParamMatch.Groups[1].Value;
            if (Name.Length > 0 && char.IsLower(Name[0])
                && !CSharpContextualKeywords.Contains(Name))
            {
                Violations.Add($"{File}:{LineIndex + 1} {Name}");
            }
        }
    }
}
