using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PrTask.Transpiler;

public sealed partial class TsToSharpConverter
{
    private readonly string Namespace;
    private readonly Dictionary<string, string> TypeMap = new(StringComparer.Ordinal)
    {
        ["string"] = "string",
        ["number"] = "double",
        ["boolean"] = "bool",
        ["void"] = "void",
        ["any"] = "object",
        ["unknown"] = "object",
        ["null"] = "object",
        ["undefined"] = "object",
        ["never"] = "void",
        ["bigint"] = "long",
        ["symbol"] = "string",
        ["object"] = "object",
        ["Uint8Array"] = "byte[]",
        ["ArrayBuffer"] = "byte[]",
        ["Buffer"] = "byte[]",
        ["Date"] = "DateTime",
        ["RegExp"] = "Regex",
        ["Error"] = "Exception",
        ["Promise"] = "Task",
        ["Map"] = "Dictionary",
        ["Set"] = "HashSet",
        ["Array"] = "List",
        ["Record"] = "Dictionary",
    };

    public TsToSharpConverter(string Namespace)
    {
        this.Namespace = Namespace;
    }

    public bool ConvertFile(string FilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(FilePath);
        if (FileName.EndsWith(".test", StringComparison.OrdinalIgnoreCase) ||
            FileName.EndsWith(".spec", StringComparison.OrdinalIgnoreCase) ||
            FileName.EndsWith(".d", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var ClassName = ToPascalCase(FileName);
        var Lines = File.ReadAllLines(FilePath);
        var Sb = new StringBuilder();
        var HasContent = false;

        Sb.Append("namespace ").Append(Namespace).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");

        var InFunction = false;
        var BraceDepth = 0;

        for (var I = 0; I < Lines.Length; I++)
        {
            var Line = Lines[I];
            var Trimmed = Line.TrimStart();

            if (Trimmed.StartsWith("import ", StringComparison.Ordinal) ||
                Trimmed.StartsWith("import{", StringComparison.Ordinal) ||
                Trimmed.StartsWith("require(", StringComparison.Ordinal) ||
                Trimmed.StartsWith("//", StringComparison.Ordinal) ||
                Trimmed.StartsWith("/*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("export default", StringComparison.Ordinal) ||
                Trimmed.Length == 0)
            {
                continue;
            }

            if (!InFunction)
            {
                var InterfaceMatch = InterfaceRegex().Match(Trimmed);
                if (InterfaceMatch.Success)
                {
                    var InterfaceName = InterfaceMatch.Groups[1].Value;
                    Sb.Append("    internal sealed class ").AppendLine(ToPascalCase(InterfaceName));
                    Sb.AppendLine("    {");
                    I++;
                    while (I < Lines.Length)
                    {
                        var PropLine = Lines[I].Trim();
                        if (PropLine.StartsWith("}", StringComparison.Ordinal))
                        {
                            break;
                        }

                        var PropMatch = PropertyRegex().Match(PropLine);
                        if (PropMatch.Success)
                        {
                            var PropName = PropMatch.Groups[1].Value;
                            var PropType = PropMatch.Groups[2].Value.Trim().TrimEnd(';');
                            Sb.Append("        internal ").Append(MapTsType(PropType)).Append(' ')
                              .Append(ToPascalCase(PropName)).AppendLine(" { get; set; }");
                        }

                        I++;
                    }

                    Sb.AppendLine("    }");
                    Sb.AppendLine();
                    HasContent = true;
                    continue;
                }

                var TypeAliasMatch = TypeAliasRegex().Match(Trimmed);
                if (TypeAliasMatch.Success)
                {
                    continue;
                }

                var EnumMatch = EnumRegex().Match(Trimmed);
                if (EnumMatch.Success)
                {
                    var EnumName = EnumMatch.Groups[1].Value;
                    Sb.Append("    internal enum ").AppendLine(ToPascalCase(EnumName));
                    Sb.AppendLine("    {");
                    I++;
                    while (I < Lines.Length)
                    {
                        var EnumLine = Lines[I].Trim();
                        if (EnumLine.StartsWith("}", StringComparison.Ordinal))
                        {
                            break;
                        }

                        if (EnumLine.Length > 0)
                        {
                            Sb.Append("        ").AppendLine(ConvertTsEnumLine(EnumLine));
                        }

                        I++;
                    }

                    Sb.AppendLine("    }");
                    Sb.AppendLine();
                    HasContent = true;
                    continue;
                }

                var ConstMatch = ConstRegex().Match(Trimmed);
                if (ConstMatch.Success)
                {
                    var ConstName = ConstMatch.Groups[1].Value;
                    var ConstVal = ConstMatch.Groups[2].Value.Trim().TrimEnd(';');
                    if (!ConstVal.Contains('{') && !ConstVal.Contains('[') && !ConstVal.Contains("=>"))
                    {
                        Sb.Append("    internal static readonly object ").Append(ToPascalCase(ConstName))
                          .Append(" = ").Append(ConvertTsValue(ConstVal)).AppendLine(";");
                        HasContent = true;
                    }

                    continue;
                }

                var FuncMatch = FunctionRegex().Match(Trimmed);
                if (!FuncMatch.Success)
                {
                    FuncMatch = ExportFunctionRegex().Match(Trimmed);
                }

                if (!FuncMatch.Success)
                {
                    FuncMatch = ArrowFunctionRegex().Match(Trimmed);
                }

                if (FuncMatch.Success)
                {
                    var FuncName = FuncMatch.Groups[1].Value;
                    var Params = FuncMatch.Groups[2].Value;
                    var ReturnType = FuncMatch.Groups.Count > 3 ? FuncMatch.Groups[3].Value.Trim() : string.Empty;

                    BraceDepth = Line.Count(C => C == '{') - Line.Count(C => C == '}');

                    var IsAsync = Trimmed.Contains("async ", StringComparison.Ordinal);
                    var CsRetType = ReturnType.Length > 0 ? MapTsType(ReturnType) : "void";
                    if (IsAsync && CsRetType == "void")
                    {
                        CsRetType = "Task";
                    }
                    else if (IsAsync)
                    {
                        CsRetType = string.Concat("Task<", CsRetType, ">");
                    }

                    var CsParams = ConvertTsParams(Params);
                    if (CsRetType == "void" || CsRetType == "Task")
                    {
                        Sb.Append("    internal static ").Append(CsRetType).Append(' ')
                          .Append(ToPascalCase(FuncName)).Append('(').Append(CsParams).AppendLine(")");
                        Sb.AppendLine("    {");
                        Sb.AppendLine("    }");
                    }
                    else
                    {
                        Sb.Append("    internal static ").Append(CsRetType).Append(' ')
                          .Append(ToPascalCase(FuncName)).Append('(').Append(CsParams).AppendLine(")");
                        Sb.AppendLine("        => default!;");
                    }

                    Sb.AppendLine();
                    HasContent = true;

                    InFunction = BraceDepth > 0;
                    if (InFunction)
                    {
                        SkipBody(Lines, ref I, ref BraceDepth);
                        InFunction = false;
                    }

                    continue;
                }

                continue;
            }

            if (InFunction)
            {
                SkipBody(Lines, ref I, ref BraceDepth);
                InFunction = false;
                continue;
            }
        }

        Sb.AppendLine("}");

        if (!HasContent)
        {
            return false;
        }

        var OutputPath = Path.Combine(OutDir, ClassName + ".g.cs");
        File.WriteAllText(OutputPath, Sb.ToString());
        return true;
    }

    private string ConvertTsLine(string Line)
    {
        var Result = Line;
        Result = Result.Replace("===", "==");
        Result = Result.Replace("!==", "!=");
        Result = Result.Replace("console.log(", "Console.WriteLine(");
        Result = Result.Replace("console.error(", "Console.Error.WriteLine(");
        Result = Result.Replace("console.warn(", "Console.Error.WriteLine(");
        Result = Result.Replace("JSON.stringify(", "System.Text.Json.JsonSerializer.Serialize(");
        Result = Result.Replace("JSON.parse(", "System.Text.Json.JsonSerializer.Deserialize<object>(");
        Result = Result.Replace("parseInt(", "int.Parse(");
        Result = Result.Replace("parseFloat(", "double.Parse(");
        Result = Result.Replace(".toString()", ".ToString()");
        Result = Result.Replace(".toLowerCase()", ".ToLowerInvariant()");
        Result = Result.Replace(".toUpperCase()", ".ToUpperInvariant()");
        Result = Result.Replace(".trim()", ".Trim()");
        Result = Result.Replace(".length", ".Length");
        Result = Result.Replace(".push(", ".Add(");
        Result = Result.Replace(".includes(", ".Contains(");
        Result = Result.Replace(".indexOf(", ".IndexOf(");
        Result = Result.Replace(".startsWith(", ".StartsWith(");
        Result = Result.Replace(".endsWith(", ".EndsWith(");
        Result = Result.Replace(".split(", ".Split(");
        Result = Result.Replace(".join(", "string.Join(");
        Result = Result.Replace(".map(", ".Select(");
        Result = Result.Replace(".filter(", ".Where(");
        Result = Result.Replace(".forEach(", ".ToList().ForEach(");
        Result = Result.Replace(".find(", ".FirstOrDefault(");
        Result = Result.Replace(".some(", ".Any(");
        Result = Result.Replace(".every(", ".All(");
        Result = Result.Replace(".reduce(", ".Aggregate(");
        Result = Result.Replace("Object.keys(", "object.GetType().GetProperties().Select(P => P.Name).ToArray(");
        Result = Result.Replace("Object.values(", "object.GetType().GetProperties().Select(P => P.GetValue(null)).ToArray(");
        Result = Result.Replace("Array.isArray(", "((object)");
        Result = Result.Replace("typeof ", "nameof(");
        Result = Result.Replace(" === 'string'", " is string");
        Result = Result.Replace(" === 'number'", " is double");
        Result = Result.Replace(" === 'boolean'", " is bool");
        Result = LetConstRegex().Replace(Result, "var ");
        Result = Result.Replace("null!", "null");
        Result = Result.Replace("undefined", "null");
        Result = TemplateLiteralRegex().Replace(Result, "$$\"$1\"");
        Result = AwaitRegex().Replace(Result, "await $1");
        return Result;
    }

    private string ConvertTsParams(string TsParams)
    {
        if (string.IsNullOrWhiteSpace(TsParams))
        {
            return string.Empty;
        }

        var Parts = SplitParams(TsParams);
        var CsParts = new List<string>();
        foreach (var Part in Parts)
        {
            var Trimmed = Part.Trim();
            if (Trimmed.Length == 0)
            {
                continue;
            }

            var IsOptional = Trimmed.Contains('?');
            Trimmed = Trimmed.Replace("?", string.Empty);
            var ColonIdx = Trimmed.IndexOf(':');
            if (ColonIdx < 0)
            {
                CsParts.Add("object " + ToPascalCase(Trimmed));
                continue;
            }

            var ParamName = Trimmed[..ColonIdx].Trim();
            var ParamType = Trimmed[(ColonIdx + 1)..].Trim();
            var DefaultIdx = ParamName.IndexOf('=');
            var DefaultVal = string.Empty;
            if (DefaultIdx >= 0)
            {
                DefaultVal = ParamName[(DefaultIdx + 1)..].Trim();
                ParamName = ParamName[..DefaultIdx].Trim();
            }

            DefaultIdx = ParamType.IndexOf('=');
            if (DefaultIdx >= 0)
            {
                DefaultVal = ParamType[(DefaultIdx + 1)..].Trim();
                ParamType = ParamType[..DefaultIdx].Trim();
            }

            var CsType = MapTsType(ParamType);
            if (IsOptional && DefaultVal.Length == 0)
            {
                CsType += "?";
                DefaultVal = "null";
            }

            var Param = CsType + " " + ToPascalCase(ParamName);
            if (DefaultVal.Length > 0)
            {
                Param += " = " + ConvertTsValue(DefaultVal);
            }

            CsParts.Add(Param);
        }

        return string.Join(", ", CsParts);
    }

    private string MapTsType(string TsType)
    {
        var Clean = TsType.Trim().TrimEnd(';');

        if (Clean.EndsWith("[]", StringComparison.Ordinal))
        {
            return MapTsType(Clean[..^2]) + "[]";
        }

        if (Clean.StartsWith("Promise<", StringComparison.Ordinal) && Clean.EndsWith('>'))
        {
            var Inner = Clean[8..^1];
            return "Task<" + MapTsType(Inner) + ">";
        }

        if (Clean.StartsWith("Map<", StringComparison.Ordinal) && Clean.EndsWith('>'))
        {
            return "Dictionary<string, object>";
        }

        if (Clean.StartsWith("Set<", StringComparison.Ordinal) && Clean.EndsWith('>'))
        {
            var Inner = Clean[4..^1];
            return "HashSet<" + MapTsType(Inner) + ">";
        }

        if (Clean.Contains('|'))
        {
            return "object";
        }

        return TypeMap.TryGetValue(Clean, out var Mapped) ? Mapped : ToPascalCase(Clean);
    }

    private static string ConvertTsValue(string Val)
    {
        var Trimmed = Val.Trim().TrimEnd(';');
        if (Trimmed == "true" || Trimmed == "false")
        {
            return Trimmed;
        }

        if (Trimmed == "null" || Trimmed == "undefined")
        {
            return "null";
        }

        if (Trimmed.StartsWith('\'') && Trimmed.EndsWith('\''))
        {
            return "\"" + Trimmed[1..^1] + "\"";
        }

        return Trimmed;
    }

    private static string ConvertTsEnumLine(string Line)
    {
        return Line.Replace("'", "\"").Replace("= \"", "= \"");
    }

    private static List<string> SplitParams(string Params)
    {
        var Result = new List<string>();
        var Depth = 0;
        var Start = 0;
        for (var I = 0; I < Params.Length; I++)
        {
            var Ch = Params[I];
            if (Ch is '<' or '(' or '{' or '[')
            {
                Depth++;
            }
            else if (Ch is '>' or ')' or '}' or ']')
            {
                Depth--;
            }
            else if (Ch == ',' && Depth == 0)
            {
                Result.Add(Params[Start..I]);
                Start = I + 1;
            }
        }

        if (Start < Params.Length)
        {
            Result.Add(Params[Start..]);
        }

        return Result;
    }

    private static void SkipBody(string[] Lines, ref int I, ref int BraceDepth)
    {
        while (I < Lines.Length && BraceDepth > 0)
        {
            I++;
            if (I >= Lines.Length)
            {
                break;
            }

            foreach (var Ch in Lines[I])
            {
                if (Ch == '{')
                {
                    BraceDepth++;
                }
                else if (Ch == '}')
                {
                    BraceDepth--;
                }
            }
        }
    }

    private static string ToPascalCase(string Input)
    {
        var Sb = new StringBuilder();
        var CapNext = true;
        foreach (var Ch in Input)
        {
            if (Ch is '_' or '-')
            {
                CapNext = true;
                continue;
            }

            Sb.Append(CapNext ? char.ToUpperInvariant(Ch) : Ch);
            CapNext = false;
        }

        return Sb.ToString();
    }

    [GeneratedRegex(@"^(?:export\s+)?interface\s+(\w+)")]
    private static partial Regex InterfaceRegex();

    [GeneratedRegex(@"^\s*(\w+)\??\s*:\s*(.+)")]
    private static partial Regex PropertyRegex();

    [GeneratedRegex(@"^(?:export\s+)?type\s+(\w+)")]
    private static partial Regex TypeAliasRegex();

    [GeneratedRegex(@"^(?:export\s+)?enum\s+(\w+)")]
    private static partial Regex EnumRegex();

    [GeneratedRegex(@"^(?:export\s+)?(?:const|let|var)\s+(\w+)\s*=\s*(.+)$")]
    private static partial Regex ConstRegex();

    [GeneratedRegex(@"^(?:export\s+)?(?:async\s+)?function\s+(\w+)\s*\(([^)]*)\)(?:\s*:\s*(\w[^{]*))?")]
    private static partial Regex FunctionRegex();

    [GeneratedRegex(@"^export\s+(?:async\s+)?function\s+(\w+)\s*\(([^)]*)\)(?:\s*:\s*(\w[^{]*))?")]
    private static partial Regex ExportFunctionRegex();

    [GeneratedRegex(@"^(?:export\s+)?(?:const|let|var)\s+(\w+)\s*=\s*(?:async\s+)?\(([^)]*)\)(?:\s*:\s*(\w[^=]*))?(?:\s*=>)")]
    private static partial Regex ArrowFunctionRegex();

    [GeneratedRegex(@"(?:let|const|var)\s+")]
    private static partial Regex LetConstRegex();

    [GeneratedRegex(@"`([^`]*)`")]
    private static partial Regex TemplateLiteralRegex();

    [GeneratedRegex(@"await\s+(\w)")]
    private static partial Regex AwaitRegex();
}
