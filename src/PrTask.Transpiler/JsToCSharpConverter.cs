using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using PrTask.Application.Services;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed partial class JsToCSharpConverter : IJsTranspiler
{
    private readonly Dictionary<string, string> TypeMap = new(StringComparer.Ordinal)
    {
        [JsTranspilerConstants.JsTypeString] = JsTranspilerConstants.CsTypeString,
        [JsTranspilerConstants.JsTypeNumber] = JsTranspilerConstants.CsTypeDouble,
        [JsTranspilerConstants.JsTypeBoolean] = JsTranspilerConstants.CsTypeBool,
        [JsTranspilerConstants.JsTypeVoid] = JsTranspilerConstants.CsTypeVoid,
        [JsTranspilerConstants.JsTypeAny] = JsTranspilerConstants.CsTypeObject,
        [JsTranspilerConstants.JsTypeUnknown] = JsTranspilerConstants.CsTypeObject,
        [JsTranspilerConstants.JsTypeNever] = JsTranspilerConstants.CsTypeVoid,
        [JsTranspilerConstants.JsTypeBigint] = JsTranspilerConstants.CsTypeLong,
        [JsTranspilerConstants.JsTypeSymbol] = JsTranspilerConstants.CsTypeString,
        [JsTranspilerConstants.JsTypeObject] = JsTranspilerConstants.CsTypeObject,
        [JsTranspilerConstants.JsTypeUint8Array] = JsTranspilerConstants.CsTypeByteArray,
        [JsTranspilerConstants.JsTypeArrayBuffer] = JsTranspilerConstants.CsTypeByteArray,
        [JsTranspilerConstants.JsTypeBuffer] = JsTranspilerConstants.CsTypeByteArray,
        [JsTranspilerConstants.JsTypeDate] = JsTranspilerConstants.CsTypeDateTime,
        [JsTranspilerConstants.JsTypeRegExp] = JsTranspilerConstants.CsTypeRegex,
        [JsTranspilerConstants.JsTypeError] = JsTranspilerConstants.CsTypeException,
        [JsTranspilerConstants.JsTypePromise] = JsTranspilerConstants.CsTypeTask,
        [JsTranspilerConstants.JsTypeMap] = "Dictionary",
        [JsTranspilerConstants.JsTypeSet] = "HashSet",
        [JsTranspilerConstants.JsTypeArray] = "List",
        [JsTranspilerConstants.JsTypeRecord] = "Dictionary",
        [JsTranspilerConstants.JsTypeReadableStream] = JsTranspilerConstants.CsTypeStream,
        [JsTranspilerConstants.JsTypeWritableStream] = JsTranspilerConstants.CsTypeStream,
        [JsTranspilerConstants.JsTypeWebSocket] = JsTranspilerConstants.CsTypeClientWebSocket,
        [JsTranspilerConstants.JsTypeEventEmitter] = "IObservable<object>",
    };

    private readonly Dictionary<string, string> MethodReplacements = new(StringComparer.Ordinal)
    {
        [JsTranspilerConstants.JsMethodToString] = JsTranspilerConstants.CsMethodToString,
        [JsTranspilerConstants.JsMethodToLowerCase] = JsTranspilerConstants.CsMethodToLower,
        [JsTranspilerConstants.JsMethodToUpperCase] = JsTranspilerConstants.CsMethodToUpper,
        [JsTranspilerConstants.JsMethodTrim] = JsTranspilerConstants.CsMethodTrim,
        [JsTranspilerConstants.JsMethodTrimStart] = JsTranspilerConstants.CsMethodTrimStart,
        [JsTranspilerConstants.JsMethodTrimEnd] = JsTranspilerConstants.CsMethodTrimEnd,
        [JsTranspilerConstants.JsMethodLength] = JsTranspilerConstants.CsMethodLength,
        [JsTranspilerConstants.JsMethodPush] = JsTranspilerConstants.CsMethodAdd,
        [JsTranspilerConstants.JsMethodIncludes] = JsTranspilerConstants.CsMethodContains,
        [JsTranspilerConstants.JsMethodIndexOf] = JsTranspilerConstants.CsMethodIndexOf,
        [JsTranspilerConstants.JsMethodLastIndexOf] = JsTranspilerConstants.CsMethodLastIndexOf,
        [JsTranspilerConstants.JsMethodStartsWith] = JsTranspilerConstants.CsMethodStartsWith,
        [JsTranspilerConstants.JsMethodEndsWith] = JsTranspilerConstants.CsMethodEndsWith,
        [JsTranspilerConstants.JsMethodSplit] = JsTranspilerConstants.CsMethodSplit,
        [JsTranspilerConstants.JsMethodMap] = JsTranspilerConstants.CsMethodSelect,
        [JsTranspilerConstants.JsMethodFilter] = JsTranspilerConstants.CsMethodWhere,
        [JsTranspilerConstants.JsMethodForEach] = JsTranspilerConstants.CsMethodToListForEach,
        [JsTranspilerConstants.JsMethodFind] = JsTranspilerConstants.CsMethodFirstOrDefault,
        [JsTranspilerConstants.JsMethodSome] = JsTranspilerConstants.CsMethodAny,
        [JsTranspilerConstants.JsMethodEvery] = JsTranspilerConstants.CsMethodAll,
        [JsTranspilerConstants.JsMethodReduce] = JsTranspilerConstants.CsMethodAggregate,
        [JsTranspilerConstants.JsMethodFlatMap] = JsTranspilerConstants.CsMethodSelectMany,
        [JsTranspilerConstants.JsMethodReverse] = JsTranspilerConstants.CsMethodReverse,
        [JsTranspilerConstants.JsMethodReplace] = JsTranspilerConstants.CsMethodReplace,
        [JsTranspilerConstants.JsMethodSubstring] = JsTranspilerConstants.CsMethodSubstring,
        [JsTranspilerConstants.JsMethodPadStart] = JsTranspilerConstants.CsMethodPadLeft,
        [JsTranspilerConstants.JsMethodPadEnd] = JsTranspilerConstants.CsMethodPadRight,
        [JsTranspilerConstants.JsMethodCharAt] = "[",
        [JsTranspilerConstants.JsMethodSize] = JsTranspilerConstants.CsMethodCount,
    };

    private readonly Dictionary<string, string> GlobalReplacements = new(StringComparer.Ordinal)
    {
        [JsTranspilerConstants.JsConsoleLog] = JsTranspilerConstants.CsConsoleWriteLine,
        [JsTranspilerConstants.JsConsoleError] = JsTranspilerConstants.CsConsoleErrorWriteLine,
        [JsTranspilerConstants.JsConsoleWarn] = JsTranspilerConstants.CsConsoleErrorWriteLine,
        [JsTranspilerConstants.JsJsonStringify] = JsTranspilerConstants.CsJsonSerialize,
        [JsTranspilerConstants.JsJsonParse] = JsTranspilerConstants.CsJsonDeserialize,
        [JsTranspilerConstants.JsParseInt] = JsTranspilerConstants.CsIntParse,
        [JsTranspilerConstants.JsParseFloat] = JsTranspilerConstants.CsDoubleParse,
    };

    private readonly Dictionary<string, string> ProcessReplacements = new(StringComparer.Ordinal)
    {
        [JsTranspilerConstants.JsProcessPlatform] = "\"browser\"",
        [JsTranspilerConstants.JsProcessCwd] = "Environment.CurrentDirectory",
        [JsTranspilerConstants.JsProcessStdin] = "Console.In",
        [JsTranspilerConstants.JsProcessStdout] = "Console.Out",
        [JsTranspilerConstants.JsProcessStderr] = "Console.Error",
        [JsTranspilerConstants.JsProcessArgv] = "Environment.GetCommandLineArgs()",
        [JsTranspilerConstants.JsProcessEnv] = "Environment.GetEnvironmentVariables()",
    };

    public JsTranspileResult TranspileFile(string InputPath, string OutputDir, string TargetNs)
    {
        if (!File.Exists(InputPath))
        {
            return new JsTranspileResult
            {
                Success = false,
                Errors = [string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.InputFileNotFoundFormat, InputPath)]
            };
        }

        var JsSource = File.ReadAllText(InputPath);
        return TranspileSource(JsSource, OutputDir, TargetNs);
    }

    public JsTranspileResult TranspileSource(string JsSource, string OutputDir, string TargetNs)
    {
        Directory.CreateDirectory(OutputDir);

        var Unwrapped = UnwrapCjsModule(JsSource);
        var Segments = SplitIntoSegments(Unwrapped);
        var OutputFiles = new List<string>();
        var Errors = new List<string>();
        var Warnings = new List<string>();
        var TotalClasses = 0;
        var TotalFunctions = 0;
        var TotalComponents = 0;
        var TotalLines = 0;

        foreach (var Segment in Segments)
        {
            try
            {
                if (Segment.Source.Length > JsTranspilerConstants.MaxSegmentSourceLength)
                {
                    Warnings.Add(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.SkippedModuleFormat, Segment.Name));
                    continue;
                }

                var Result = ConvertSegment(Segment, TargetNs);
                if (Result.Content.Length == 0)
                {
                    continue;
                }

                var FileName = Result.ClassName + JsTranspilerConstants.GeneratedFileSuffix;
                var FilePath = Path.Combine(OutputDir, FileName);
                File.WriteAllText(FilePath, Result.Content);
                OutputFiles.Add(FilePath);
                TotalClasses += Result.ClassCount;
                TotalFunctions += Result.FunctionCount;
                TotalComponents += Result.ComponentCount;
                TotalLines += Result.Content.Split(JsTranspilerConstants.JsNewline).Length;
            }
            catch (Exception Ex)
            {
                Errors.Add(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.ParseErrorFormat, 0, 0, Ex.Message));
            }
        }

        return new JsTranspileResult
        {
            Success = Errors.Count == 0,
            ClassCount = TotalClasses,
            FunctionCount = TotalFunctions,
            ComponentCount = TotalComponents,
            LineCount = TotalLines,
            FileCount = OutputFiles.Count,
            OutputFiles = OutputFiles,
            Errors = Errors,
            Warnings = Warnings
        };
    }

    public IReadOnlyList<BlazorComponentResult> GenerateBlazorComponents(string JsSource, string OutputDir, string TargetNs)
    {
        var Unwrapped = UnwrapCjsModule(JsSource);
        var Generator = new BlazorComponentGenerator(TargetNs);
        return Generator.ExtractAndGenerate(Unwrapped, OutputDir);
    }

    private static string UnwrapCjsModule(string Source)
    {
        var Trimmed = Source.TrimStart();

        if (Trimmed.StartsWith(JsTranspilerConstants.BunBytecodeDirective, StringComparison.Ordinal))
        {
            var NewlineIdx = Trimmed.IndexOf(JsTranspilerConstants.JsNewline);
            if (NewlineIdx >= 0)
            {
                Trimmed = Trimmed[(NewlineIdx + 1)..].TrimStart();
            }
        }

        if (Trimmed.StartsWith(JsTranspilerConstants.ShebangPrefix, StringComparison.Ordinal))
        {
            var NewlineIdx = Trimmed.IndexOf(JsTranspilerConstants.JsNewline);
            if (NewlineIdx >= 0)
            {
                Trimmed = Trimmed[(NewlineIdx + 1)..].TrimStart();
            }
        }

        if (Trimmed.StartsWith(JsTranspilerConstants.CjsModuleWrapper, StringComparison.Ordinal))
        {
            var WrapperLen = JsTranspilerConstants.CjsModuleWrapper.Length;
            Trimmed = Trimmed[WrapperLen..];

            while (Trimmed.Length > 0 && Trimmed[0] is '\n' or '\r' or '/' or ' ')
            {
                if (Trimmed.StartsWith("//", StringComparison.Ordinal))
                {
                    var CommentEnd = Trimmed.IndexOf(JsTranspilerConstants.JsNewline);
                    if (CommentEnd >= 0)
                    {
                        Trimmed = Trimmed[(CommentEnd + 1)..];
                    }
                    else
                    {
                        break;
                    }
                }
                else if (Trimmed[0] is '\n' or '\r' or ' ')
                {
                    Trimmed = Trimmed[1..];
                }
                else
                {
                    break;
                }
            }

            var EndIdx = Trimmed.LastIndexOf(JsTranspilerConstants.CjsModuleWrapperEnd, StringComparison.Ordinal);
            if (EndIdx >= 0)
            {
                Trimmed = Trimmed[..EndIdx];
            }
        }

        return Trimmed;
    }

    private List<JsSegment> SplitIntoSegments(string Source)
    {
        var Segments = new List<JsSegment>();
        var Pos = 0;
        var SegmentIndex = 0;

        while (Pos < Source.Length)
        {
            SkipWhitespaceAndComments(Source, ref Pos);
            if (Pos >= Source.Length)
            {
                break;
            }

            var SegmentStart = Pos;
            var SegmentKind = DetectSegmentKind(Source, Pos);

            switch (SegmentKind)
            {
                case JsSegmentKind.ClassDeclaration:
                    ExtractClassSegment(Source, ref Pos, Segments, ref SegmentIndex);
                    break;
                case JsSegmentKind.FunctionDeclaration:
                    ExtractFunctionSegment(Source, ref Pos, Segments, ref SegmentIndex);
                    break;
                case JsSegmentKind.VariableDeclaration:
                    ExtractVariableSegment(Source, ref Pos, Segments, ref SegmentIndex);
                    break;
                case JsSegmentKind.ExportStatement:
                    ExtractExportSegment(Source, ref Pos, Segments, ref SegmentIndex);
                    break;
                case JsSegmentKind.ImportStatement:
                    SkipToStatementEnd(Source, ref Pos);
                    break;
                default:
                    SkipToStatementEnd(Source, ref Pos);
                    break;
            }

            if (Pos == SegmentStart)
            {
                Pos++;
            }
        }

        if (Segments.Count == 0 && Source.Length > 0)
        {
            Segments.Add(new JsSegment
            {
                Kind = JsSegmentKind.FunctionDeclaration,
                Name = "Module",
                Source = Source,
                Index = 0,
            });
        }

        return Segments;
    }

    private static JsSegmentKind DetectSegmentKind(string Source, int Pos)
    {
        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordClass + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordClass + " "))
        {
            return JsSegmentKind.ClassDeclaration;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordFunction + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordAsync + " " + JsTranspilerConstants.JsKeywordFunction + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordFunction + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordAsync + " " + JsTranspilerConstants.JsKeywordFunction + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordDefault + " " + JsTranspilerConstants.JsKeywordFunction + " "))
        {
            return JsSegmentKind.FunctionDeclaration;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordVar + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordLet + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordConst + " "))
        {
            return JsSegmentKind.VariableDeclaration;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " "))
        {
            return JsSegmentKind.ExportStatement;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordImport + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordImport + "{"))
        {
            return JsSegmentKind.ImportStatement;
        }

        return JsSegmentKind.Unknown;
    }

    private static bool LookaheadMatch(string Source, int Pos, string Pattern)
    {
        if (Pos + Pattern.Length > Source.Length)
        {
            return false;
        }

        return Source.AsSpan(Pos, Pattern.Length).SequenceEqual(Pattern.AsSpan());
    }

    private static void ExtractClassSegment(string Source, ref int Pos, List<JsSegment> Segments, ref int SegmentIndex)
    {
        var Start = Pos;
        var NameStart = Pos;

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordExport.Length + 1;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordDefault + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordDefault.Length + 1;
        }

        Pos += JsTranspilerConstants.JsKeywordClass.Length + 1;
        NameStart = Pos;
        while (Pos < Source.Length && IsIdentChar(Source[Pos]))
        {
            Pos++;
        }

        var ClassName = Source[NameStart..Pos];

        SkipToBrace(Source, ref Pos);
        if (Pos < Source.Length)
        {
            SkipBraceBlock(Source, ref Pos);
        }

        Segments.Add(new JsSegment
        {
            Kind = JsSegmentKind.ClassDeclaration,
            Name = ClassName,
            Source = Source[Start..Pos],
            Index = SegmentIndex++,
        });
    }

    private static void ExtractFunctionSegment(string Source, ref int Pos, List<JsSegment> Segments, ref int SegmentIndex)
    {
        var Start = Pos;
        var IsAsync = false;

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordExport.Length + 1;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordDefault + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordDefault.Length + 1;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordAsync + " "))
        {
            IsAsync = true;
            Pos += JsTranspilerConstants.JsKeywordAsync.Length + 1;
        }

        Pos += JsTranspilerConstants.JsKeywordFunction.Length + 1;
        var NameStart = Pos;
        while (Pos < Source.Length && IsIdentChar(Source[Pos]))
        {
            Pos++;
        }

        var FuncName = Source[NameStart..Pos];
        if (FuncName.Length == 0)
        {
            FuncName = string.Concat("AnonymousFunc", SegmentIndex.ToString(CultureInfo.InvariantCulture));
        }

        SkipToBrace(Source, ref Pos);
        if (Pos < Source.Length)
        {
            SkipBraceBlock(Source, ref Pos);
        }

        Segments.Add(new JsSegment
        {
            Kind = JsSegmentKind.FunctionDeclaration,
            Name = FuncName,
            Source = Source[Start..Pos],
            Index = SegmentIndex++,
            IsAsync = IsAsync,
        });
    }

    private void ExtractVariableSegment(string Source, ref int Pos, List<JsSegment> Segments, ref int SegmentIndex)
    {
        var Start = Pos;

        Pos += Source[Pos] switch
        {
            'v' => 4,
            'l' => 4,
            'c' => 6,
            _ => 4,
        };

        while (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsSpace)
        {
            Pos++;
        }

        var NameStart = Pos;
        while (Pos < Source.Length && IsIdentChar(Source[Pos]))
        {
            Pos++;
        }

        var VarName = Source[NameStart..Pos];

        while (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsSpace)
        {
            Pos++;
        }

        if (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsEquals)
        {
            Pos++;
            while (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsSpace)
            {
                Pos++;
            }

            var IsArrowFunc = IsArrowFunction(Source, Pos);
            var IsClassExpr = LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordClass + " ") ||
                              LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordClass + "{");

            if (IsArrowFunc || LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordFunction + "(") ||
                LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordFunction + " ") ||
                LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordAsync + " "))
            {
                SkipToExpressionEnd(Source, ref Pos);

                Segments.Add(new JsSegment
                {
                    Kind = JsSegmentKind.FunctionDeclaration,
                    Name = VarName,
                    Source = Source[Start..Pos],
                    Index = SegmentIndex++,
                    IsAsync = Source[Start..Pos].Contains(JsTranspilerConstants.JsKeywordAsync + " ", StringComparison.Ordinal),
                });
                return;
            }

            if (IsClassExpr)
            {
                SkipToBrace(Source, ref Pos);
                if (Pos < Source.Length)
                {
                    SkipBraceBlock(Source, ref Pos);
                }

                Segments.Add(new JsSegment
                {
                    Kind = JsSegmentKind.ClassDeclaration,
                    Name = VarName,
                    Source = Source[Start..Pos],
                    Index = SegmentIndex++,
                });
                return;
            }
        }

        SkipToStatementEnd(Source, ref Pos);

        Segments.Add(new JsSegment
        {
            Kind = JsSegmentKind.VariableDeclaration,
            Name = VarName,
            Source = Source[Start..Pos],
            Index = SegmentIndex++,
        });
    }

    private void ExtractExportSegment(string Source, ref int Pos, List<JsSegment> Segments, ref int SegmentIndex)
    {
        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordClass + " "))
        {
            ExtractClassSegment(Source, ref Pos, Segments, ref SegmentIndex);
            return;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordFunction + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordAsync + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordDefault + " " + JsTranspilerConstants.JsKeywordFunction + " "))
        {
            ExtractFunctionSegment(Source, ref Pos, Segments, ref SegmentIndex);
            return;
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordVar + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordLet + " ") ||
            LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordConst + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordExport.Length + 1;
            ExtractVariableSegment(Source, ref Pos, Segments, ref SegmentIndex);
            return;
        }

        SkipToStatementEnd(Source, ref Pos);
    }

    private ConvertedSegment ConvertSegment(JsSegment Segment, string Namespace)
    {
        var ClassName = ToPascalCase(Segment.Name);
        if (ClassName.Length == 0)
        {
            ClassName = string.Concat("Module", Segment.Index.ToString(CultureInfo.InvariantCulture));
        }

        return Segment.Kind switch
        {
            JsSegmentKind.ClassDeclaration => ConvertClassSegment(Segment, Namespace, ClassName),
            JsSegmentKind.FunctionDeclaration => ConvertFunctionSegment(Segment, Namespace, ClassName),
            JsSegmentKind.VariableDeclaration => ConvertVariableSegment(Segment, Namespace, ClassName),
            _ => new ConvertedSegment { ClassName = ClassName, Content = string.Empty },
        };
    }

    private ConvertedSegment ConvertClassSegment(JsSegment Segment, string Namespace, string ClassName)
    {
        var Sb = new StringBuilder(JsTranspilerConstants.ChunkSize);
        Sb.Append(JsTranspilerConstants.CsKeywordNamespace).Append(JsTranspilerConstants.JsSpace).Append(Namespace).AppendLine(";");
        Sb.AppendLine();

        var Source = Segment.Source;
        var BaseClass = ExtractBaseClass(Source);
        var Members = ExtractClassMembers(Source);

        Sb.Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordSealed).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordPartial).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordClass).Append(JsTranspilerConstants.JsSpace)
          .Append(ClassName);

        if (BaseClass.Length > 0)
        {
            Sb.Append(" : ").Append(ToPascalCase(BaseClass));
        }

        Sb.AppendLine();
        Sb.AppendLine("{");

        var ClassFuncCount = 0;
        foreach (var Member in Members)
        {
            if (Member.IsConstructor)
            {
                EmitConstructor(Sb, Member, ClassName);
            }
            else if (Member.IsProperty)
            {
                EmitProperty(Sb, Member);
            }
            else if (Member.IsMethod)
            {
                EmitMethod(Sb, Member);
                ClassFuncCount++;
            }
            else if (Member.IsField)
            {
                EmitField(Sb, Member);
            }
        }

        Sb.AppendLine("}");

        return new ConvertedSegment
        {
            ClassName = ClassName,
            Content = Sb.ToString(),
            ClassCount = 1,
            FunctionCount = ClassFuncCount,
        };
    }

    private ConvertedSegment ConvertFunctionSegment(JsSegment Segment, string Namespace, string ClassName)
    {
        var Sb = new StringBuilder(JsTranspilerConstants.ChunkSize);
        Sb.Append(JsTranspilerConstants.CsKeywordNamespace).Append(JsTranspilerConstants.JsSpace).Append(Namespace).AppendLine(";");
        Sb.AppendLine();

        Sb.Append(JsTranspilerConstants.CsKeywordInternal).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordPartial).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordClass).Append(JsTranspilerConstants.JsSpace)
          .AppendLine(ClassName);
        Sb.AppendLine("{");

        var FuncInfo = ParseFunctionSignature(Segment.Source);
        var CsReturnType = Segment.IsAsync ? JsTranspilerConstants.CsTypeTask : JsTranspilerConstants.CsTypeVoid;
        var CsParams = ConvertParameters(FuncInfo.Parameters);
        var Body = ExtractFunctionBody(Segment.Source);
        var ConvertedBody = ConvertJsBody(Body);

        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordInternal).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace);
        if (Segment.IsAsync)
        {
            Sb.Append(JsTranspilerConstants.CsKeywordAsync).Append(JsTranspilerConstants.JsSpace);
        }

        Sb.Append(CsReturnType).Append(JsTranspilerConstants.JsSpace)
          .Append(ToPascalCase(FuncInfo.Name.Length > 0 ? FuncInfo.Name : Segment.Name))
          .Append(JsTranspilerConstants.JsParenOpen).Append(CsParams)
          .AppendLine(")");
        Sb.AppendLine("    {");

        foreach (var Line in ConvertedBody)
        {
            Sb.Append("        ").AppendLine(Line);
        }

        Sb.AppendLine("    }");
        Sb.AppendLine("}");

        return new ConvertedSegment
        {
            ClassName = ClassName,
            Content = Sb.ToString(),
            FunctionCount = 1,
        };
    }

    private ConvertedSegment ConvertVariableSegment(JsSegment Segment, string Namespace, string ClassName)
    {
        var Sb = new StringBuilder(JsTranspilerConstants.ChunkSize);
        Sb.Append(JsTranspilerConstants.CsKeywordNamespace).Append(JsTranspilerConstants.JsSpace).Append(Namespace).AppendLine(";");
        Sb.AppendLine();

        Sb.Append(JsTranspilerConstants.CsKeywordInternal).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordPartial).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordClass).Append(JsTranspilerConstants.JsSpace)
          .AppendLine(ClassName);
        Sb.AppendLine("{");

        var VarValue = ExtractVariableValue(Segment.Source);
        var ConvertedValue = ConvertJsExpression(VarValue);

        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordInternal).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordReadonly).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsTypeObject).Append(JsTranspilerConstants.JsSpace)
          .Append("Value = ").Append(ConvertedValue).AppendLine(";");

        Sb.AppendLine("}");

        return new ConvertedSegment
        {
            ClassName = ClassName,
            Content = Sb.ToString(),
        };
    }

    private string ConvertJsExpression(string Expr)
    {
        var Result = Expr.Trim().TrimEnd(JsTranspilerConstants.JsSemicolon);

        Result = Result.Replace(JsTranspilerConstants.JsStrictEquals, JsTranspilerConstants.CsEquals);
        Result = Result.Replace(JsTranspilerConstants.JsStrictNotEquals, JsTranspilerConstants.CsNotEquals);

        foreach (var Kvp in GlobalReplacements)
        {
            Result = Result.Replace(Kvp.Key, Kvp.Value);
        }

        foreach (var Kvp in MethodReplacements)
        {
            Result = Result.Replace(Kvp.Key, Kvp.Value);
        }

        foreach (var Kvp in ProcessReplacements)
        {
            Result = Result.Replace(Kvp.Key, Kvp.Value);
        }

        Result = Result.Replace(JsTranspilerConstants.JsKeywordUndefined, JsTranspilerConstants.CsKeywordNull);
        Result = LetConstVarRegex().Replace(Result, JsTranspilerConstants.CsKeywordVar + " ");
        Result = TemplateLiteralRegex().Replace(Result, "$$\"$1\"");
        Result = AwaitExprRegex().Replace(Result, JsTranspilerConstants.CsKeywordAwait + " $1");
        Result = TypeofRegex().Replace(Result, "$1.GetType().Name");

        return Result;
    }

    private List<string> ConvertJsBody(string Body)
    {
        var Lines = new List<string>();
        var BodyLines = Body.Split(JsTranspilerConstants.JsNewline);

        foreach (var RawLine in BodyLines)
        {
            var Trimmed = RawLine.Trim();
            if (Trimmed.Length == 0)
            {
                continue;
            }

            var Converted = ConvertJsStatement(Trimmed);
            if (Converted.Length > 0)
            {
                Lines.Add(Converted);
            }
        }

        return Lines;
    }

    private string ConvertJsStatement(string Statement)
    {
        var Result = Statement;

        if (Result.StartsWith(JsTranspilerConstants.JsKeywordImport + " ", StringComparison.Ordinal) ||
            Result.StartsWith(JsTranspilerConstants.JsKeywordImport + "{", StringComparison.Ordinal))
        {
            return string.Empty;
        }

        if (Result.StartsWith(JsTranspilerConstants.JsKeywordExport + " " + JsTranspilerConstants.JsKeywordDefault + " ", StringComparison.Ordinal))
        {
            Result = Result[(JsTranspilerConstants.JsKeywordExport.Length + JsTranspilerConstants.JsKeywordDefault.Length + 2)..];
        }
        else if (Result.StartsWith(JsTranspilerConstants.JsKeywordExport + " ", StringComparison.Ordinal))
        {
            Result = Result[(JsTranspilerConstants.JsKeywordExport.Length + 1)..];
        }

        Result = ConvertJsExpression(Result);
        Result = ConvertHookPatterns(Result);

        return Result;
    }

    private static string ConvertHookPatterns(string Line)
    {
        var Result = Line;

        var UseStateMatch = UseStateRegex().Match(Result);
        if (UseStateMatch.Success)
        {
            var VarName = UseStateMatch.Groups[1].Value;
            var InitialValue = UseStateMatch.Groups[3].Value;
            Result = string.Concat(JsTranspilerConstants.CsKeywordPrivate, " ", JsTranspilerConstants.CsTypeObject, " ",
                ToPascalCase(VarName), " = ", InitialValue.Length > 0 ? ConvertLiteralValue(InitialValue) : JsTranspilerConstants.CsKeywordNull, ";");
        }

        var UseEffectMatch = UseEffectRegex().Match(Result);
        if (UseEffectMatch.Success)
        {
            Result = string.Concat(JsTranspilerConstants.CsKeywordProtected, " ", JsTranspilerConstants.CsKeywordOverride, " ",
                JsTranspilerConstants.CsTypeVoid, " ", JsTranspilerConstants.BlazorOnAfterRender, "(", JsTranspilerConstants.CsTypeBool, " FirstRender) { }");
        }

        var UseCallbackMatch = UseCallbackRegex().Match(Result);
        if (UseCallbackMatch.Success)
        {
            var CallbackName = UseCallbackMatch.Groups[1].Value;
            Result = string.Concat(JsTranspilerConstants.CsKeywordPrivate, " ", JsTranspilerConstants.CsTypeVoid, " ",
                ToPascalCase(CallbackName), "() { }");
        }

        var UseRefMatch = UseRefRegex().Match(Result);
        if (UseRefMatch.Success)
        {
            var RefName = UseRefMatch.Groups[1].Value;
            var InitialValue = UseRefMatch.Groups[2].Value;
            Result = string.Concat(JsTranspilerConstants.CsKeywordPrivate, " ", JsTranspilerConstants.CsTypeObject, "? ",
                ToPascalCase(RefName), " = ", InitialValue.Length > 0 ? ConvertLiteralValue(InitialValue) : JsTranspilerConstants.CsKeywordNull, ";");
        }

        var UseMemoMatch = UseMemoRegex().Match(Result);
        if (UseMemoMatch.Success)
        {
            var MemoName = UseMemoMatch.Groups[1].Value;
            Result = string.Concat(JsTranspilerConstants.CsKeywordPrivate, " Lazy<", JsTranspilerConstants.CsTypeObject, "> ",
                ToPascalCase(MemoName), " = ", JsTranspilerConstants.CsKeywordNew, " Lazy<", JsTranspilerConstants.CsTypeObject, ">(() => ",
                JsTranspilerConstants.CsKeywordNull, "!);");
        }

        return Result;
    }

    private static string ConvertLiteralValue(string Value)
    {
        var Trimmed = Value.Trim();
        if (Trimmed is JsTranspilerConstants.JsKeywordTrue or JsTranspilerConstants.JsKeywordFalse)
        {
            return Trimmed;
        }

        if (Trimmed is JsTranspilerConstants.JsKeywordNull or JsTranspilerConstants.JsKeywordUndefined)
        {
            return JsTranspilerConstants.CsKeywordNull;
        }

        if (Trimmed.Length > 0 && Trimmed[0] == JsTranspilerConstants.JsSingleQuote && Trimmed[^1] == JsTranspilerConstants.JsSingleQuote)
        {
            return string.Concat("\"", Trimmed[1..^1], "\"");
        }

        return Trimmed;
    }

    private string ConvertParameters(List<string> Params)
    {
        var CsParts = new List<string>(Params.Count);
        foreach (var Param in Params)
        {
            var Trimmed = Param.Trim();
            if (Trimmed.Length == 0)
            {
                continue;
            }

            if (Trimmed.StartsWith(JsTranspilerConstants.JsSpread, StringComparison.Ordinal))
            {
                var ParamName = Trimmed[3..].Trim();
                CsParts.Add(string.Concat("params ", JsTranspilerConstants.CsTypeObject, "[] ", ToPascalCase(ParamName)));
                continue;
            }

            var DefaultIdx = Trimmed.IndexOf(JsTranspilerConstants.JsEquals);
            var IsOptional = Trimmed.Contains(JsTranspilerConstants.JsQuestion);
            Trimmed = Trimmed.Replace("?", string.Empty);

            if (DefaultIdx >= 0)
            {
                var ParamName = ToPascalCase(Trimmed[..DefaultIdx].Trim());
                var DefaultVal = ConvertLiteralValue(Trimmed[(DefaultIdx + 1)..]);
                CsParts.Add(string.Concat(JsTranspilerConstants.CsTypeObject, " ", ParamName, " = ", DefaultVal));
            }
            else if (IsOptional)
            {
                CsParts.Add(string.Concat(JsTranspilerConstants.CsTypeObject, "? ", ToPascalCase(Trimmed), " = ", JsTranspilerConstants.CsKeywordNull));
            }
            else
            {
                CsParts.Add(string.Concat(JsTranspilerConstants.CsTypeObject, " ", ToPascalCase(Trimmed)));
            }
        }

        return string.Join(", ", CsParts);
    }

    private static string ExtractBaseClass(string Source)
    {
        var ExtendsMatch = ClassExtendsRegex().Match(Source);
        return ExtendsMatch.Success ? ExtendsMatch.Groups[1].Value : string.Empty;
    }

    private List<ClassMember> ExtractClassMembers(string Source)
    {
        var Members = new List<ClassMember>();
        var BraceStart = Source.IndexOf(JsTranspilerConstants.JsBraceOpen);
        if (BraceStart < 0)
        {
            return Members;
        }

        var Body = ExtractBraceContent(Source, BraceStart);
        var Pos = 0;

        while (Pos < Body.Length)
        {
            SkipWhitespaceAndComments(Body, ref Pos);
            if (Pos >= Body.Length)
            {
                break;
            }

            var MemberStart = Pos;
            var IsStatic = false;
            var IsAsync = false;
            var IsGetter = false;
            var IsSetter = false;

            if (LookaheadMatch(Body, Pos, JsTranspilerConstants.JsKeywordStatic + " "))
            {
                IsStatic = true;
                Pos += JsTranspilerConstants.JsKeywordStatic.Length + 1;
            }

            if (LookaheadMatch(Body, Pos, JsTranspilerConstants.JsKeywordAsync + " "))
            {
                IsAsync = true;
                Pos += JsTranspilerConstants.JsKeywordAsync.Length + 1;
            }

            if (LookaheadMatch(Body, Pos, JsTranspilerConstants.JsKeywordGet + " "))
            {
                IsGetter = true;
                Pos += JsTranspilerConstants.JsKeywordGet.Length + 1;
            }
            else if (LookaheadMatch(Body, Pos, JsTranspilerConstants.JsKeywordSet + " "))
            {
                IsSetter = true;
                Pos += JsTranspilerConstants.JsKeywordSet.Length + 1;
            }

            var NameStart = Pos;
            while (Pos < Body.Length && IsIdentChar(Body[Pos]))
            {
                Pos++;
            }

            if (Pos == NameStart)
            {
                Pos++;
                continue;
            }

            var MemberName = Body[NameStart..Pos];

            while (Pos < Body.Length && Body[Pos] == JsTranspilerConstants.JsSpace)
            {
                Pos++;
            }

            if (Pos < Body.Length && Body[Pos] == JsTranspilerConstants.JsParenOpen)
            {
                var ParamsStr = ExtractParenContent(Body, Pos);
                Pos += ParamsStr.Length + 2;

                while (Pos < Body.Length && Body[Pos] != JsTranspilerConstants.JsBraceOpen)
                {
                    Pos++;
                }

                var MethodBody = string.Empty;
                if (Pos < Body.Length)
                {
                    var BodyStart = Pos;
                    SkipBraceBlock(Body, ref Pos);
                    MethodBody = Body[BodyStart..Pos];
                }

                var IsConstructor = MemberName == JsTranspilerConstants.JsKeywordConstructor;

                Members.Add(new ClassMember
                {
                    Name = MemberName,
                    IsMethod = !IsConstructor && !IsGetter && !IsSetter,
                    IsConstructor = IsConstructor,
                    IsProperty = IsGetter || IsSetter,
                    IsStatic = IsStatic,
                    IsAsync = IsAsync,
                    Parameters = SplitParameters(ParamsStr),
                    Body = MethodBody,
                });
            }
            else if (Pos < Body.Length && Body[Pos] == JsTranspilerConstants.JsEquals)
            {
                Pos++;
                var ValueStart = Pos;
                SkipToStatementEnd(Body, ref Pos);
                var Value = Body[ValueStart..Pos].Trim().TrimEnd(JsTranspilerConstants.JsSemicolon);

                Members.Add(new ClassMember
                {
                    Name = MemberName,
                    IsField = true,
                    IsStatic = IsStatic,
                    DefaultValue = Value,
                });
            }
            else if (Pos < Body.Length && Body[Pos] == JsTranspilerConstants.JsSemicolon)
            {
                Pos++;
                Members.Add(new ClassMember
                {
                    Name = MemberName,
                    IsField = true,
                    IsStatic = IsStatic,
                });
            }
            else
            {
                SkipToStatementEnd(Body, ref Pos);
            }
        }

        return Members;
    }

    private void EmitConstructor(StringBuilder Sb, ClassMember Member, string ClassName)
    {
        var CsParams = ConvertParameters(Member.Parameters);
        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace)
          .Append(ClassName).Append(JsTranspilerConstants.JsParenOpen).Append(CsParams).AppendLine(")")
          .AppendLine("    {");

        var Body = ExtractBraceInnerContent(Member.Body);
        var ConvertedBody = ConvertJsBody(Body);
        foreach (var Line in ConvertedBody)
        {
            Sb.Append("        ").AppendLine(Line);
        }

        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private void EmitMethod(StringBuilder Sb, ClassMember Member)
    {
        var CsParams = ConvertParameters(Member.Parameters);
        var ReturnType = Member.IsAsync ? JsTranspilerConstants.CsTypeTask : JsTranspilerConstants.CsTypeVoid;

        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace);
        if (Member.IsStatic)
        {
            Sb.Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace);
        }

        if (Member.IsAsync)
        {
            Sb.Append(JsTranspilerConstants.CsKeywordAsync).Append(JsTranspilerConstants.JsSpace);
        }

        Sb.Append(ReturnType).Append(JsTranspilerConstants.JsSpace)
          .Append(ToPascalCase(Member.Name))
          .Append(JsTranspilerConstants.JsParenOpen).Append(CsParams).AppendLine(")")
          .AppendLine("    {");

        var Body = ExtractBraceInnerContent(Member.Body);
        var ConvertedBody = ConvertJsBody(Body);
        foreach (var Line in ConvertedBody)
        {
            Sb.Append("        ").AppendLine(Line);
        }

        Sb.AppendLine("    }");
        Sb.AppendLine();
    }

    private static void EmitProperty(StringBuilder Sb, ClassMember Member)
    {
        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsTypeObject).Append(JsTranspilerConstants.JsSpace)
          .Append(ToPascalCase(Member.Name))
          .AppendLine(" { get; set; }");
        Sb.AppendLine();
    }

    private static void EmitField(StringBuilder Sb, ClassMember Member)
    {
        Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPrivate).Append(JsTranspilerConstants.JsSpace);
        if (Member.IsStatic)
        {
            Sb.Append(JsTranspilerConstants.CsKeywordStatic).Append(JsTranspilerConstants.JsSpace);
        }

        Sb.Append(JsTranspilerConstants.CsTypeObject).Append(JsTranspilerConstants.JsSpace)
          .Append(ToPascalCase(Member.Name));

        if (Member.DefaultValue.Length > 0)
        {
            Sb.Append(" = ").Append(ConvertLiteralValue(Member.DefaultValue));
        }

        Sb.AppendLine(";");
    }

    private static FunctionInfo ParseFunctionSignature(string Source)
    {
        var Match = FunctionSignatureRegex().Match(Source);
        if (Match.Success)
        {
            return new FunctionInfo
            {
                Name = Match.Groups[2].Value,
                Parameters = SplitParameters(Match.Groups[3].Value),
                IsAsync = Match.Groups[1].Value.Contains(JsTranspilerConstants.JsKeywordAsync, StringComparison.Ordinal),
            };
        }

        var ArrowMatch = ArrowFuncSignatureRegex().Match(Source);
        if (ArrowMatch.Success)
        {
            return new FunctionInfo
            {
                Name = ArrowMatch.Groups[1].Value,
                Parameters = SplitParameters(ArrowMatch.Groups[3].Value),
                IsAsync = ArrowMatch.Groups[2].Value.Contains(JsTranspilerConstants.JsKeywordAsync, StringComparison.Ordinal),
            };
        }

        return new FunctionInfo
        {
            Name = string.Empty,
            Parameters = [],
        };
    }

    private static string ExtractFunctionBody(string Source)
    {
        var BraceStart = Source.IndexOf(JsTranspilerConstants.JsBraceOpen);
        if (BraceStart < 0)
        {
            var ArrowIdx = Source.IndexOf(JsTranspilerConstants.JsArrow, StringComparison.Ordinal);
            if (ArrowIdx >= 0)
            {
                return Source[(ArrowIdx + 2)..].Trim().TrimEnd(JsTranspilerConstants.JsSemicolon);
            }

            return string.Empty;
        }

        return ExtractBraceInnerContent(Source[BraceStart..]);
    }

    private static string ExtractVariableValue(string Source)
    {
        var EqIdx = Source.IndexOf(JsTranspilerConstants.JsEquals);
        if (EqIdx < 0)
        {
            return JsTranspilerConstants.CsKeywordNull;
        }

        if (EqIdx + 1 < Source.Length && Source[EqIdx + 1] == JsTranspilerConstants.JsEquals)
        {
            return JsTranspilerConstants.CsKeywordNull;
        }

        return Source[(EqIdx + 1)..].Trim().TrimEnd(JsTranspilerConstants.JsSemicolon);
    }

    private static List<string> SplitParameters(string ParamsStr)
    {
        var Result = new List<string>();
        var Depth = 0;
        var Start = 0;

        for (var I = 0; I < ParamsStr.Length; I++)
        {
            var Ch = ParamsStr[I];
            if (Ch is '(' or '[' or '{' or '<')
            {
                Depth++;
            }
            else if (Ch is ')' or ']' or '}' or '>')
            {
                Depth--;
            }
            else if (Ch == JsTranspilerConstants.JsComma && Depth == 0)
            {
                var Param = ParamsStr[Start..I].Trim();
                if (Param.Length > 0)
                {
                    Result.Add(Param);
                }

                Start = I + 1;
            }
        }

        if (Start < ParamsStr.Length)
        {
            var Last = ParamsStr[Start..].Trim();
            if (Last.Length > 0)
            {
                Result.Add(Last);
            }
        }

        return Result;
    }

    private static string ExtractBraceContent(string Source, int BraceStart)
    {
        var Depth = 0;
        var I = BraceStart;
        while (I < Source.Length)
        {
            var Ch = Source[I];
            if (Ch == JsTranspilerConstants.JsBraceOpen)
            {
                Depth++;
            }
            else if (Ch == JsTranspilerConstants.JsBraceClose)
            {
                Depth--;
                if (Depth == 0)
                {
                    return Source[(BraceStart + 1)..I];
                }
            }
            else if (Ch is '\'' or '"' or '`')
            {
                I = SkipString(Source, I);
                continue;
            }

            I++;
        }

        return Source[(BraceStart + 1)..];
    }

    private static string ExtractBraceInnerContent(string Source)
    {
        var Start = Source.IndexOf(JsTranspilerConstants.JsBraceOpen);
        if (Start < 0)
        {
            return Source;
        }

        return ExtractBraceContent(Source, Start);
    }

    private static string ExtractParenContent(string Source, int ParenStart)
    {
        var Depth = 0;
        var I = ParenStart;
        while (I < Source.Length)
        {
            var Ch = Source[I];
            if (Ch == JsTranspilerConstants.JsParenOpen)
            {
                Depth++;
            }
            else if (Ch == JsTranspilerConstants.JsParenClose)
            {
                Depth--;
                if (Depth == 0)
                {
                    return Source[(ParenStart + 1)..I];
                }
            }
            else if (Ch is '\'' or '"' or '`')
            {
                I = SkipString(Source, I);
                continue;
            }

            I++;
        }

        return Source[(ParenStart + 1)..];
    }

    private static void SkipWhitespaceAndComments(string Source, ref int Pos)
    {
        while (Pos < Source.Length)
        {
            var Ch = Source[Pos];
            if (Ch is ' ' or '\t' or '\n' or '\r')
            {
                Pos++;
                continue;
            }

            if (Pos + 1 < Source.Length && Ch == JsTranspilerConstants.JsForwardSlash)
            {
                if (Source[Pos + 1] == JsTranspilerConstants.JsForwardSlash)
                {
                    while (Pos < Source.Length && Source[Pos] != JsTranspilerConstants.JsNewline)
                    {
                        Pos++;
                    }

                    continue;
                }

                if (Source[Pos + 1] == JsTranspilerConstants.JsAsterisk)
                {
                    Pos += 2;
                    while (Pos + 1 < Source.Length && !(Source[Pos] == JsTranspilerConstants.JsAsterisk && Source[Pos + 1] == JsTranspilerConstants.JsForwardSlash))
                    {
                        Pos++;
                    }

                    Pos += 2;
                    continue;
                }
            }

            break;
        }
    }

    private static void SkipToBrace(string Source, ref int Pos)
    {
        while (Pos < Source.Length && Source[Pos] != JsTranspilerConstants.JsBraceOpen)
        {
            if (Source[Pos] is '\'' or '"' or '`')
            {
                Pos = SkipString(Source, Pos);
            }
            else
            {
                Pos++;
            }
        }
    }

    private static void SkipBraceBlock(string Source, ref int Pos)
    {
        if (Pos >= Source.Length || Source[Pos] != JsTranspilerConstants.JsBraceOpen)
        {
            return;
        }

        var Depth = 0;
        while (Pos < Source.Length)
        {
            var Ch = Source[Pos];
            if (Ch == JsTranspilerConstants.JsBraceOpen)
            {
                Depth++;
            }
            else if (Ch == JsTranspilerConstants.JsBraceClose)
            {
                Depth--;
                if (Depth == 0)
                {
                    Pos++;
                    return;
                }
            }
            else if (Ch is '\'' or '"' or '`')
            {
                Pos = SkipString(Source, Pos);
                continue;
            }

            Pos++;
        }
    }

    private static void SkipToStatementEnd(string Source, ref int Pos)
    {
        var Depth = 0;
        while (Pos < Source.Length)
        {
            var Ch = Source[Pos];
            if (Ch is '(' or '[' or '{')
            {
                Depth++;
            }
            else if (Ch is ')' or ']' or '}')
            {
                if (Depth == 0)
                {
                    return;
                }

                Depth--;
            }
            else if (Ch == JsTranspilerConstants.JsSemicolon && Depth == 0)
            {
                Pos++;
                return;
            }
            else if (Ch == JsTranspilerConstants.JsNewline && Depth == 0)
            {
                Pos++;
                return;
            }
            else if (Ch is '\'' or '"' or '`')
            {
                Pos = SkipString(Source, Pos);
                continue;
            }

            Pos++;
        }
    }

    private static void SkipToExpressionEnd(string Source, ref int Pos)
    {
        var Depth = 0;
        while (Pos < Source.Length)
        {
            var Ch = Source[Pos];
            if (Ch is '(' or '[' or '{')
            {
                Depth++;
            }
            else if (Ch is ')' or ']' or '}')
            {
                Depth--;
                if (Depth < 0)
                {
                    return;
                }
            }
            else if (Ch == JsTranspilerConstants.JsSemicolon && Depth == 0)
            {
                Pos++;
                return;
            }
            else if (Ch is '\'' or '"' or '`')
            {
                Pos = SkipString(Source, Pos);
                continue;
            }

            Pos++;
        }
    }

    private static int SkipString(string Source, int Pos)
    {
        var Quote = Source[Pos];
        Pos++;
        while (Pos < Source.Length)
        {
            if (Source[Pos] == JsTranspilerConstants.JsBackslash)
            {
                Pos += 2;
                continue;
            }

            if (Source[Pos] == Quote)
            {
                return Pos + 1;
            }

            Pos++;
        }

        return Pos;
    }

    private static bool IsArrowFunction(string Source, int Pos)
    {
        if (Pos >= Source.Length)
        {
            return false;
        }

        var SavedPos = Pos;

        if (Source[Pos] == JsTranspilerConstants.JsParenOpen)
        {
            var Depth = 1;
            Pos++;
            while (Pos < Source.Length && Depth > 0)
            {
                if (Source[Pos] == JsTranspilerConstants.JsParenOpen)
                {
                    Depth++;
                }
                else if (Source[Pos] == JsTranspilerConstants.JsParenClose)
                {
                    Depth--;
                }

                Pos++;
            }

            while (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsSpace)
            {
                Pos++;
            }

            return Pos + 1 < Source.Length && Source[Pos] == '=' && Source[Pos + 1] == '>';
        }

        if (IsIdentChar(Source[Pos]))
        {
            while (Pos < Source.Length && IsIdentChar(Source[Pos]))
            {
                Pos++;
            }

            while (Pos < Source.Length && Source[Pos] == JsTranspilerConstants.JsSpace)
            {
                Pos++;
            }

            return Pos + 1 < Source.Length && Source[Pos] == '=' && Source[Pos + 1] == '>';
        }

        if (LookaheadMatch(Source, Pos, JsTranspilerConstants.JsKeywordAsync + " "))
        {
            Pos += JsTranspilerConstants.JsKeywordAsync.Length + 1;
            return IsArrowFunction(Source, Pos);
        }

        return false;
    }

    private static bool IsIdentChar(char Ch)
    {
        return Ch is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or (>= '0' and <= '9') or '_' or '$';
    }

    internal static string ToPascalCase(string Input)
    {
        if (Input.Length == 0)
        {
            return Input;
        }

        var Sb = new StringBuilder(Input.Length);
        var CapNext = true;
        foreach (var Ch in Input)
        {
            if (Ch is '_' or '-' or '.' or ' ' or '$' or ',' or '@')
            {
                CapNext = true;
                continue;
            }

            if (!char.IsLetterOrDigit(Ch))
            {
                continue;
            }

            Sb.Append(CapNext ? char.ToUpperInvariant(Ch) : Ch);
            CapNext = false;
        }

        if (Sb.Length > 0 && char.IsDigit(Sb[0]))
        {
            Sb.Insert(0, 'C');
        }

        return Sb.Length > 0 ? Sb.ToString() : "X";
    }

    [GeneratedRegex(@"(?:var|let|const)\s+")]
    private static partial Regex LetConstVarRegex();

    [GeneratedRegex(@"`([^`]*)`")]
    private static partial Regex TemplateLiteralRegex();

    [GeneratedRegex(@"await\s+(\w)")]
    private static partial Regex AwaitExprRegex();

    [GeneratedRegex(@"typeof\s+(\w+)")]
    private static partial Regex TypeofRegex();

    [GeneratedRegex(@"class\s+\w+\s+extends\s+(\w+)")]
    private static partial Regex ClassExtendsRegex();

    [GeneratedRegex(@"(?:export\s+)?(?:default\s+)?(async\s+)?function\s+(\w*)\s*\(([^)]*)\)")]
    private static partial Regex FunctionSignatureRegex();

    [GeneratedRegex(@"(?:var|let|const)\s+(\w+)\s*=\s*(async\s+)?(?:function\s*)?\(([^)]*)\)\s*=>")]
    private static partial Regex ArrowFuncSignatureRegex();

    [GeneratedRegex(@"(?:var|let|const)\s+\[(\w+),\s*(\w+)\]\s*=\s*useState\(([^)]*)\)")]
    private static partial Regex UseStateRegex();

    [GeneratedRegex(@"useEffect\s*\(")]
    private static partial Regex UseEffectRegex();

    [GeneratedRegex(@"(?:var|let|const)\s+(\w+)\s*=\s*useCallback\(")]
    private static partial Regex UseCallbackRegex();

    [GeneratedRegex(@"(?:var|let|const)\s+(\w+)\s*=\s*useRef\(([^)]*)\)")]
    private static partial Regex UseRefRegex();

    [GeneratedRegex(@"(?:var|let|const)\s+(\w+)\s*=\s*useMemo\(")]
    private static partial Regex UseMemoRegex();

    private sealed class JsSegment
    {
        internal JsSegmentKind Kind { get; init; }
        internal required string Name { get; init; }
        internal required string Source { get; init; }
        internal int Index { get; init; }
        internal bool IsAsync { get; init; }
    }

    private enum JsSegmentKind
    {
        Unknown,
        ClassDeclaration,
        FunctionDeclaration,
        VariableDeclaration,
        ExportStatement,
        ImportStatement,
    }

    private sealed class ConvertedSegment
    {
        internal required string ClassName { get; init; }
        internal required string Content { get; init; }
        internal int ClassCount { get; init; }
        internal int FunctionCount { get; init; }
        internal int ComponentCount { get; init; }
    }

    private sealed class ClassMember
    {
        internal required string Name { get; init; }
        internal bool IsMethod { get; init; }
        internal bool IsProperty { get; init; }
        internal bool IsField { get; init; }
        internal bool IsConstructor { get; init; }
        internal bool IsStatic { get; init; }
        internal bool IsAsync { get; init; }
        internal List<string> Parameters { get; init; } = [];
        internal string Body { get; init; } = string.Empty;
        internal string DefaultValue { get; init; } = string.Empty;
    }

    private sealed class FunctionInfo
    {
        internal required string Name { get; init; }
        internal required List<string> Parameters { get; init; }
        internal bool IsAsync { get; init; }
    }
}
