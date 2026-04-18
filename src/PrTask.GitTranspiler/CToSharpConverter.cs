using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PrTask.GitTranspiler;

public sealed partial class CToSharpConverter
{
    private readonly string SourceDir;
    private readonly string OutputDir;
    private readonly Dictionary<string, string> TypeMap = new(StringComparer.Ordinal)
    {
        ["void"] = "void",
        ["int"] = "int",
        ["unsigned int"] = "uint",
        ["unsigned"] = "uint",
        ["long"] = "long",
        ["unsigned long"] = "ulong",
        ["size_t"] = "nuint",
        ["ssize_t"] = "nint",
        ["char"] = "byte",
        ["unsigned char"] = "byte",
        ["short"] = "short",
        ["unsigned short"] = "ushort",
        ["float"] = "float",
        ["double"] = "double",
        ["FILE"] = "nint",
        ["off_t"] = "long",
        ["time_t"] = "long",
        ["pid_t"] = "int",
        ["uint32_t"] = "uint",
        ["uint64_t"] = "ulong",
        ["int32_t"] = "int",
        ["int64_t"] = "long",
        ["uint8_t"] = "byte",
        ["int8_t"] = "sbyte",
        ["uint16_t"] = "ushort",
        ["int16_t"] = "short",
        ["uintmax_t"] = "ulong",
        ["intmax_t"] = "long",
    };

    private readonly HashSet<string> SkipFiles = new(StringComparer.OrdinalIgnoreCase)
    {
        "git.c", "daemon.c", "shell.c", "http-backend.c", "http-fetch.c",
        "http-push.c", "http-walker.c", "http.c", "imap-send.c", "remote-curl.c",
        "scalar.c", "sh-i18n--envsubst.c", "common-main.c",
    };

    private readonly HashSet<string> SkipBuiltins = new(StringComparer.OrdinalIgnoreCase)
    {
        "credential-cache.c", "credential-cache--daemon.c",
        "credential-store.c", "fsmonitor--daemon.c",
    };

    public CToSharpConverter(string SourceDir, string OutputDir)
    {
        this.SourceDir = SourceDir;
        this.OutputDir = OutputDir;
    }

    public int ConvertAll()
    {
        var Count = 0;
        var RootFiles = Directory.GetFiles(SourceDir, "*.c");
        foreach (var CFile in RootFiles)
        {
            var FileName = Path.GetFileName(CFile);
            if (SkipFiles.Contains(FileName))
            {
                continue;
            }

            if (ConvertFile(CFile, OutputDir))
            {
                Count++;
            }
        }

        var BuiltinDir = Path.Combine(SourceDir, "builtin");
        if (Directory.Exists(BuiltinDir))
        {
            var BuiltinOutDir = Path.Combine(OutputDir, "Builtin");
            Directory.CreateDirectory(BuiltinOutDir);
            foreach (var CFile in Directory.GetFiles(BuiltinDir, "*.c"))
            {
                var FileName = Path.GetFileName(CFile);
                if (SkipBuiltins.Contains(FileName))
                {
                    continue;
                }

                if (ConvertFile(CFile, BuiltinOutDir))
                {
                    Count++;
                }
            }
        }

        var HeaderFiles = Directory.GetFiles(SourceDir, "*.h");
        foreach (var HFile in HeaderFiles)
        {
            if (ConvertHeader(HFile, OutputDir))
            {
                Count++;
            }
        }

        return Count;
    }

    private bool ConvertFile(string CFilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(CFilePath);
        var ClassName = ToPascalCase(FileName);
        var Lines = File.ReadAllLines(CFilePath);
        var Sb = new StringBuilder();

        Sb.AppendLine("namespace PrTask.Git.Generated;");
        Sb.AppendLine();
        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");

        var InFunction = false;
        var BraceDepth = 0;
        var FuncSb = new StringBuilder();
        var HasContent = false;

        for (var I = 0; I < Lines.Length; I++)
        {
            var Line = Lines[I];
            var Trimmed = Line.TrimStart();

            if (Trimmed.StartsWith("#include", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#if", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#else", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#endif", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#define", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#undef", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#pragma", StringComparison.Ordinal) ||
                Trimmed.StartsWith("/*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("//", StringComparison.Ordinal))
            {
                if (Trimmed.StartsWith("#define", StringComparison.Ordinal))
                {
                    var DefineMatch = DefineConstantRegex().Match(Trimmed);
                    if (DefineMatch.Success)
                    {
                        var DefName = DefineMatch.Groups[1].Value;
                        var DefVal = DefineMatch.Groups[2].Value.Trim();
                        if (DefVal.Length > 0 && !DefVal.Contains('(') && !DefVal.Contains('\\'))
                        {
                            Sb.Append("    internal const int ").Append(DefName)
                              .Append(" = ").Append(ConvertConstantValue(DefVal)).AppendLine(";");
                            HasContent = true;
                        }
                    }
                }

                continue;
            }

            if (!InFunction)
            {
                var FuncMatch = FunctionDefRegex().Match(Line);
                if (FuncMatch.Success && I + 1 < Lines.Length)
                {
                    var RetType = FuncMatch.Groups[1].Value.Trim();
                    var FuncName = FuncMatch.Groups[2].Value.Trim();
                    var Params = FuncMatch.Groups[3].Value.Trim();
                    var NextLine = Lines[I + 1].TrimStart();

                    if (Line.TrimEnd().EndsWith('{') || NextLine.StartsWith("{", StringComparison.Ordinal))
                    {
                        InFunction = true;
                        BraceDepth = Line.Count(C => C == '{') - Line.Count(C => C == '}');
                        if (NextLine.StartsWith("{", StringComparison.Ordinal))
                        {
                            I++;
                            BraceDepth++;
                        }

                        var CsRetType = MapType(RetType);
                        var CsParams = ConvertParams(Params);
                        Sb.Append("    internal static ").Append(CsRetType).Append(' ')
                          .Append(ToPascalCase(FuncName)).Append('(').Append(CsParams).AppendLine(")");
                        Sb.AppendLine("    {");
                        HasContent = true;
                        FuncSb.Clear();
                        continue;
                    }
                }

                var StaticMatch = StaticVarRegex().Match(Line);
                if (StaticMatch.Success)
                {
                    HasContent = true;
                }

                var StructMatch = StructDefRegex().Match(Trimmed);
                if (StructMatch.Success)
                {
                    continue;
                }

                var EnumMatch = EnumDefRegex().Match(Trimmed);
                if (EnumMatch.Success)
                {
                    var EnumName = EnumMatch.Groups[1].Value;
                    if (EnumName.Length > 0)
                    {
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

                            if (EnumLine.Length > 0 && !EnumLine.StartsWith("/*", StringComparison.Ordinal) &&
                                !EnumLine.StartsWith("*", StringComparison.Ordinal))
                            {
                                Sb.Append("        ").AppendLine(EnumLine);
                            }

                            I++;
                        }

                        Sb.AppendLine("    }");
                        HasContent = true;
                    }
                }

                continue;
            }

            foreach (var Ch in Line)
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

            if (BraceDepth <= 0)
            {
                Sb.AppendLine("    }");
                Sb.AppendLine();
                InFunction = false;
                continue;
            }

            var ConvertedLine = ConvertCLine(Trimmed);
            Sb.Append("        ").AppendLine(ConvertedLine);
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

    private bool ConvertHeader(string HFilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(HFilePath);
        var ClassName = ToPascalCase(FileName) + "H";
        var Lines = File.ReadAllLines(HFilePath);
        var Sb = new StringBuilder();
        var HasContent = false;

        Sb.AppendLine("namespace PrTask.Git.Generated;");
        Sb.AppendLine();
        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");

        foreach (var Line in Lines)
        {
            var Trimmed = Line.Trim();

            var DefineMatch = DefineConstantRegex().Match(Trimmed);
            if (DefineMatch.Success)
            {
                var DefName = DefineMatch.Groups[1].Value;
                var DefVal = DefineMatch.Groups[2].Value.Trim();
                if (DefVal.Length > 0 && !DefVal.Contains('(') && !DefVal.Contains('\\') &&
                    (char.IsDigit(DefVal[0]) || DefVal[0] == '-' || DefVal[0] == '0' || DefVal[0] == '"'))
                {
                    Sb.Append("    internal const int ").Append(DefName)
                      .Append(" = ").Append(ConvertConstantValue(DefVal)).AppendLine(";");
                    HasContent = true;
                }
            }

            var EnumMatch = EnumDefRegex().Match(Trimmed);
            if (EnumMatch.Success)
            {
                HasContent = true;
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

    private string ConvertCLine(string Line)
    {
        var Result = Line;

        Result = Result.Replace("NULL", "null");
        Result = Result.Replace("->", ".");
        Result = NullCheckRegex().Replace(Result, "$1 is null");
        Result = NotNullCheckRegex().Replace(Result, "$1 is not null");
        Result = MallocRegex().Replace(Result, "new byte[$1]");
        Result = CallocRegex().Replace(Result, "new byte[$1 * $2]");
        Result = FreeRegex().Replace(Result, string.Empty);
        Result = Result.Replace("sizeof(", "System.Runtime.InteropServices.Marshal.SizeOf(");
        Result = PrintfRegex().Replace(Result, "Console.Write(");
        Result = FprintfStderrRegex().Replace(Result, "Console.Error.Write(");
        Result = StrlenRegex().Replace(Result, "$1.Length");
        Result = StrcmpRegex().Replace(Result, "string.Compare($1, $2, StringComparison.Ordinal)");
        Result = StrncmpRegex().Replace(Result, "string.Compare($1, 0, $2, 0, $3, StringComparison.Ordinal)");
        Result = StrcpyRegex().Replace(Result, "$1 = $2");
        Result = StrcatRegex().Replace(Result, "$1 += $2");
        Result = AtoiRegex().Replace(Result, "int.Parse($1, System.Globalization.CultureInfo.InvariantCulture)");
        Result = SnprintfRegex().Replace(Result, "$1 = string.Format(System.Globalization.CultureInfo.InvariantCulture, $3)");
        Result = StrdupRegex().Replace(Result, "string.Copy($1)");
        Result = MemcpyRegex().Replace(Result, "Array.Copy($2, $1, $3)");
        Result = MemsetRegex().Replace(Result, "Array.Clear($1, 0, $3)");
        Result = MemcmpRegex().Replace(Result, "((ReadOnlySpan<byte>)$1).SequenceCompareTo($2)");
        Result = ExitRegex().Replace(Result, "Environment.Exit($1)");
        Result = DieRegex().Replace(Result, "throw new InvalidOperationException($1)");
        Result = Result.Replace("const char *", "string ");
        Result = Result.Replace("char *", "string ");
        Result = Result.Replace("const char*", "string");
        Result = Result.Replace("char*", "string");

        foreach (var (CType, CsType) in TypeMap)
        {
            if (Result.Contains(CType + " ", StringComparison.Ordinal))
            {
                Result = Result.Replace(CType + " *", CsType + " ");
                Result = Result.Replace(CType + " ", CsType + " ");
            }
        }

        return Result;
    }

    private string ConvertParams(string CParams)
    {
        if (string.IsNullOrWhiteSpace(CParams) || CParams == "void")
        {
            return string.Empty;
        }

        var Parts = CParams.Split(',');
        var CsParts = new List<string>();
        foreach (var Part in Parts)
        {
            var Trimmed = Part.Trim();
            if (Trimmed == "...")
            {
                CsParts.Add("params object[] VarArgs");
                continue;
            }

            var IsPointer = Trimmed.Contains('*');
            Trimmed = Trimmed.Replace("const ", string.Empty).Replace("*", string.Empty).Trim();
            var SpaceIdx = Trimmed.LastIndexOf(' ');
            if (SpaceIdx < 0)
            {
                CsParts.Add(MapType(Trimmed) + " Arg" + CsParts.Count.ToString(CultureInfo.InvariantCulture));
                continue;
            }

            var ParamType = Trimmed[..SpaceIdx].Trim();
            var ParamName = Trimmed[(SpaceIdx + 1)..].Trim();
            var BracketIdx = ParamName.IndexOf('[');
            if (BracketIdx >= 0)
            {
                ParamName = ParamName[..BracketIdx];
                IsPointer = true;
            }

            var CsType = IsPointer && ParamType == "char" ? "string" : MapType(ParamType);
            if (IsPointer && CsType != "string")
            {
                CsType = "nint";
            }

            CsParts.Add(CsType + " " + ToPascalCase(ParamName));
        }

        return string.Join(", ", CsParts);
    }

    private string MapType(string CType)
    {
        var Clean = CType.Replace("const ", string.Empty).Replace("static ", string.Empty)
            .Replace("struct ", string.Empty).Replace("enum ", string.Empty)
            .Replace("*", string.Empty).Trim();

        return TypeMap.TryGetValue(Clean, out var Mapped) ? Mapped : ToPascalCase(Clean);
    }

    private static string ConvertConstantValue(string Val)
    {
        if (Val.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
        {
            return Val;
        }

        if (Val.StartsWith("(1 <<", StringComparison.Ordinal) || Val.StartsWith("1 <<", StringComparison.Ordinal))
        {
            return Val.Replace("(", string.Empty).Replace(")", string.Empty);
        }

        if (Val.StartsWith('"'))
        {
            return Val;
        }

        return Val.TrimEnd('U', 'u', 'L', 'l');
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

    [GeneratedRegex(@"^#define\s+([A-Z_][A-Z0-9_]*)\s+(.+)$")]
    private static partial Regex DefineConstantRegex();

    [GeneratedRegex(@"^(?:static\s+)?(\w[\w\s\*]*?)\s+(\w+)\s*\(([^)]*)\)\s*\{?\s*$")]
    private static partial Regex FunctionDefRegex();

    [GeneratedRegex(@"^static\s+")]
    private static partial Regex StaticVarRegex();

    [GeneratedRegex(@"^struct\s+(\w+)\s*\{")]
    private static partial Regex StructDefRegex();

    [GeneratedRegex(@"^enum\s+(\w*)\s*\{")]
    private static partial Regex EnumDefRegex();

    [GeneratedRegex(@"!\s*(\w+)")]
    private static partial Regex NullCheckRegex();

    [GeneratedRegex(@"(\w+)\s*!=\s*null")]
    private static partial Regex NotNullCheckRegex();

    [GeneratedRegex(@"malloc\(([^)]+)\)")]
    private static partial Regex MallocRegex();

    [GeneratedRegex(@"calloc\(([^,]+),\s*([^)]+)\)")]
    private static partial Regex CallocRegex();

    [GeneratedRegex(@"free\([^)]+\);?")]
    private static partial Regex FreeRegex();

    [GeneratedRegex(@"printf\(")]
    private static partial Regex PrintfRegex();

    [GeneratedRegex(@"fprintf\(stderr,\s*")]
    private static partial Regex FprintfStderrRegex();

    [GeneratedRegex(@"strlen\((\w+)\)")]
    private static partial Regex StrlenRegex();

    [GeneratedRegex(@"strcmp\(([^,]+),\s*([^)]+)\)")]
    private static partial Regex StrcmpRegex();

    [GeneratedRegex(@"strncmp\(([^,]+),\s*([^,]+),\s*([^)]+)\)")]
    private static partial Regex StrncmpRegex();

    [GeneratedRegex(@"strcpy\(([^,]+),\s*([^)]+)\)")]
    private static partial Regex StrcpyRegex();

    [GeneratedRegex(@"strcat\(([^,]+),\s*([^)]+)\)")]
    private static partial Regex StrcatRegex();

    [GeneratedRegex(@"atoi\(([^)]+)\)")]
    private static partial Regex AtoiRegex();

    [GeneratedRegex(@"snprintf\((\w+),\s*[^,]+,\s*(.+)\)")]
    private static partial Regex SnprintfRegex();

    [GeneratedRegex(@"strdup\(([^)]+)\)")]
    private static partial Regex StrdupRegex();

    [GeneratedRegex(@"memcpy\(([^,]+),\s*([^,]+),\s*([^)]+)\)")]
    private static partial Regex MemcpyRegex();

    [GeneratedRegex(@"memset\(([^,]+),\s*([^,]+),\s*([^)]+)\)")]
    private static partial Regex MemsetRegex();

    [GeneratedRegex(@"memcmp\(([^,]+),\s*([^,]+),\s*([^)]+)\)")]
    private static partial Regex MemcmpRegex();

    [GeneratedRegex(@"exit\(([^)]+)\)")]
    private static partial Regex ExitRegex();

    [GeneratedRegex(@"die\((.+)\)")]
    private static partial Regex DieRegex();
}
