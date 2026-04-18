using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PrTask.Transpiler;

public sealed partial class CToSharpConverter
{
    private readonly string SourceDir;
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly HashSet<string> SkipFiles;
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
        ["bool"] = "bool",
        ["BOOL"] = "bool",
        ["DWORD"] = "uint",
        ["HANDLE"] = "nint",
        ["HRESULT"] = "int",
        ["LPSTR"] = "string",
        ["LPCSTR"] = "string",
        ["LPWSTR"] = "string",
        ["LPCWSTR"] = "string",
        ["BYTE"] = "byte",
        ["WORD"] = "ushort",
    };

    public CToSharpConverter(string SourceDir, string OutputDir, string Namespace, HashSet<string> SkipFiles)
    {
        this.SourceDir = SourceDir;
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.SkipFiles = SkipFiles;
    }

    private static readonly HashSet<string> SkipDirs = new(StringComparer.OrdinalIgnoreCase)
    {
        "obj", "bin", "node_modules", ".git", ".github", ".vscode",
        "t", "test", "tests", "__tests__", "__mocks__",
        "Documentation", "docs", "po", "templates", "contrib",
        "gitweb", "git-gui", "gitk-git", "perl", "dist", "build",
        "coverage", "fixtures", "vendor", "third_party",
    };

    public int ConvertAll()
    {
        var TsConverter = new TsToSharpConverter(Namespace);
        var Count = 0;
        Count += ConvertDirectory(SourceDir, OutputDir, TsConverter);
        foreach (var SubDir in Directory.GetDirectories(SourceDir, "*", SearchOption.TopDirectoryOnly))
        {
            var DirName = Path.GetFileName(SubDir);
            if (DirName.StartsWith('.') || SkipDirs.Contains(DirName))
            {
                continue;
            }

            var SubOutDir = Path.Combine(OutputDir, ToPascalCase(DirName));
            Directory.CreateDirectory(SubOutDir);
            Count += ConvertDirectory(SubDir, SubOutDir, TsConverter);
        }

        return Count;
    }

    private int ConvertDirectory(string Dir, string OutDir, TsToSharpConverter TsConverter)
    {
        var Count = 0;
        var CExtensions = new[] { "*.c", "*.cc", "*.cpp" };
        foreach (var Ext in CExtensions)
        {
            foreach (var CFile in Directory.GetFiles(Dir, Ext))
            {
                if (SkipFiles.Contains(Path.GetFileName(CFile)))
                {
                    continue;
                }

                if (ConvertFile(CFile, OutDir))
                {
                    Count++;
                }
            }
        }

        foreach (var HFile in Directory.GetFiles(Dir, "*.h"))
        {
            if (SkipFiles.Contains(Path.GetFileName(HFile)))
            {
                continue;
            }

            if (ConvertHeader(HFile, OutDir))
            {
                Count++;
            }
        }

        var TsExtensions = new[] { "*.ts", "*.js", "*.mjs", "*.mts" };
        foreach (var Ext in TsExtensions)
        {
            foreach (var TsFile in Directory.GetFiles(Dir, Ext))
            {
                if (SkipFiles.Contains(Path.GetFileName(TsFile)))
                {
                    continue;
                }

                if (TsConverter.ConvertFile(TsFile, OutDir))
                {
                    Count++;
                }
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

        Sb.Append("namespace ").Append(Namespace).AppendLine(";");
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
                Trimmed.StartsWith("#undef", StringComparison.Ordinal) ||
                Trimmed.StartsWith("#pragma", StringComparison.Ordinal) ||
                Trimmed.StartsWith("/*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("*", StringComparison.Ordinal) ||
                Trimmed.StartsWith("//", StringComparison.Ordinal))
            {
                continue;
            }

            if (Trimmed.StartsWith("#define", StringComparison.Ordinal))
            {
                var DefineMatch = DefineConstantRegex().Match(Trimmed);
                if (DefineMatch.Success)
                {
                    var DefName = DefineMatch.Groups[1].Value;
                    var DefVal = DefineMatch.Groups[2].Value.Trim();
                    if (DefVal.Length > 0 && !DefVal.Contains('(') && !DefVal.Contains('\\') &&
                        IsValidConstantValue(DefVal))
                    {
                        var ConstType = DefVal.StartsWith('"') ? "string" : "int";
                        Sb.Append("    internal const ").Append(ConstType).Append(' ').Append(DefName)
                          .Append(" = ").Append(ConvertConstantValue(DefVal)).AppendLine(";");
                        HasContent = true;
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
                        var CsFuncName = ToPascalCase(FuncName);
                        Sb.Append("    internal static ").Append(CsRetType).Append(' ')
                          .Append(CsFuncName).Append('(').Append(CsParams).AppendLine(")");
                        if (CsRetType == "void")
                        {
                            Sb.AppendLine("    {");
                            Sb.AppendLine("    }");
                            Sb.AppendLine();
                        }
                        else
                        {
                            Sb.Append("        => default;");
                            Sb.AppendLine();
                            Sb.AppendLine();
                        }

                        HasContent = true;
                        FuncSb.Clear();
                        SkipFunctionBody(Lines, ref I, ref BraceDepth);
                        InFunction = false;
                        continue;
                    }
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
                                !EnumLine.StartsWith("*", StringComparison.Ordinal) &&
                                !EnumLine.StartsWith("//", StringComparison.Ordinal))
                            {
                                var CleanEnum = CleanEnumValue(EnumLine);
                                if (CleanEnum.Length > 0)
                                {
                                    Sb.Append("        ").AppendLine(CleanEnum);
                                }
                            }

                            I++;
                        }

                        Sb.AppendLine("    }");
                        HasContent = true;
                    }
                }

                continue;
            }

            if (InFunction)
            {
                SkipFunctionBody(Lines, ref I, ref BraceDepth);
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

    private static void SkipFunctionBody(string[] Lines, ref int I, ref int BraceDepth)
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

    private bool ConvertHeader(string HFilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(HFilePath);
        var ClassName = ToPascalCase(FileName) + "H";
        var Lines = File.ReadAllLines(HFilePath);
        var Sb = new StringBuilder();
        var HasContent = false;

        Sb.Append("namespace ").Append(Namespace).AppendLine(";");
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
                    IsValidConstantValue(DefVal))
                {
                    var ConstType = DefVal.StartsWith('"') ? "string" : "int";
                    Sb.Append("    internal const ").Append(ConstType).Append(' ').Append(DefName)
                      .Append(" = ").Append(ConvertConstantValue(DefVal)).AppendLine(";");
                    HasContent = true;
                }
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
        Result = Result.Replace("nullptr", "null");
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
        Result = Result.Replace("std::string", "string");
        Result = Result.Replace("std::vector", "System.Collections.Generic.List");
        Result = Result.Replace("std::map", "System.Collections.Generic.Dictionary");
        Result = Result.Replace("std::unique_ptr", string.Empty);
        Result = Result.Replace("std::shared_ptr", string.Empty);
        Result = Result.Replace("std::move(", "(");
        Result = Result.Replace("std::cout", "Console.Out");
        Result = Result.Replace("std::cerr", "Console.Error");
        Result = Result.Replace("std::endl", "Environment.NewLine");

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
            var IsRef = Trimmed.Contains('&') && !Trimmed.Contains("&&");
            Trimmed = Trimmed.Replace("const ", string.Empty).Replace("*", string.Empty)
                .Replace("&", string.Empty).Trim();
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

            var Prefix = IsRef ? "ref " : string.Empty;
            CsParts.Add(Prefix + CsType + " " + ToPascalCase(ParamName));
        }

        return string.Join(", ", CsParts);
    }

    private string MapType(string CType)
    {
        var Clean = CType.Replace("const ", string.Empty).Replace("static ", string.Empty)
            .Replace("inline ", string.Empty).Replace("__attribute__((unused)) ", string.Empty)
            .Replace("struct ", string.Empty).Replace("enum ", string.Empty)
            .Replace("class ", string.Empty).Replace("extern ", string.Empty)
            .Replace("volatile ", string.Empty).Replace("register ", string.Empty)
            .Replace("restrict ", string.Empty).Replace("signed ", string.Empty)
            .Replace("*", string.Empty).Trim();

        return TypeMap.TryGetValue(Clean, out var Mapped) ? Mapped : ToPascalCase(Clean);
    }

    private static bool IsValidConstantValue(string Val)
    {
        var Trimmed = Val.Trim().TrimEnd('U', 'u', 'L', 'l');
        if (Trimmed.Length == 0)
        {
            return false;
        }

        if (Trimmed.StartsWith('"'))
        {
            return true;
        }

        if (Trimmed.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (Trimmed.StartsWith("1 <<", StringComparison.Ordinal) || Trimmed.StartsWith("(1 <<", StringComparison.Ordinal))
        {
            return true;
        }

        if (char.IsDigit(Trimmed[0]) || Trimmed[0] == '-')
        {
            return true;
        }

        return false;
    }

    private static string CleanEnumValue(string Line)
    {
        var CommentIdx = Line.IndexOf("/*", StringComparison.Ordinal);
        var Result = CommentIdx >= 0 ? Line[..CommentIdx].Trim() : Line;
        CommentIdx = Result.IndexOf("//", StringComparison.Ordinal);
        Result = CommentIdx >= 0 ? Result[..CommentIdx].Trim() : Result;
        Result = Result.Replace("(1 << ", "(1 << ").Replace("1U", "1").Replace("0U", "0");
        if (Result.Length > 0 && !Result.EndsWith(','))
        {
            Result += ",";
        }

        return Result;
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
