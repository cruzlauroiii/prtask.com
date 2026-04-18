using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PrTask.Transpiler;

public sealed class JavaToCSharpConverter
{
    private static readonly Dictionary<string, string> TypeMap = new(StringComparer.Ordinal)
    {
        ["String"] = "string",
        ["boolean"] = "bool",
        ["Boolean"] = "bool",
        ["int"] = "int",
        ["Integer"] = "int",
        ["long"] = "long",
        ["Long"] = "long",
        ["float"] = "float",
        ["Float"] = "float",
        ["double"] = "double",
        ["Double"] = "double",
        ["byte"] = "byte",
        ["Byte"] = "byte",
        ["short"] = "short",
        ["Short"] = "short",
        ["char"] = "char",
        ["Character"] = "char",
        ["void"] = "void",
        ["Void"] = "void",
        ["Object"] = "object",
        ["StringBuilder"] = "StringBuilder",
        ["StringBuffer"] = "StringBuilder",
        ["List"] = "List",
        ["ArrayList"] = "List",
        ["LinkedList"] = "List",
        ["Map"] = "Dictionary",
        ["HashMap"] = "Dictionary",
        ["LinkedHashMap"] = "Dictionary",
        ["TreeMap"] = "SortedDictionary",
        ["ConcurrentHashMap"] = "Dictionary",
        ["Set"] = "HashSet",
        ["HashSet"] = "HashSet",
        ["TreeSet"] = "SortedSet",
        ["LinkedHashSet"] = "HashSet",
        ["Queue"] = "Queue",
        ["Deque"] = "Queue",
        ["ArrayDeque"] = "Queue",
        ["Stack"] = "Stack",
        ["Iterator"] = "IEnumerator",
        ["Iterable"] = "IEnumerable",
        ["Collection"] = "ICollection",
        ["Comparable"] = "IComparable",
        ["Runnable"] = "Action",
        ["Callable"] = "Func",
        ["Thread"] = "Thread",
        ["Exception"] = "Exception",
        ["RuntimeException"] = "Exception",
        ["Throwable"] = "Exception",
        ["IOException"] = "IOException",
        ["Date"] = "DateTime",
        ["Calendar"] = "DateTime",
        ["UUID"] = "Guid",
        ["Pattern"] = "Regex",
        ["Matcher"] = "Match",
        ["File"] = "string",
        ["InputStream"] = "Stream",
        ["OutputStream"] = "Stream",
        ["BufferedReader"] = "StreamReader",
        ["BufferedWriter"] = "StreamWriter",
        ["Serializable"] = "object",
        ["Closeable"] = "IDisposable",
        ["AutoCloseable"] = "IDisposable",
        ["URL"] = "Uri",
        ["URI"] = "Uri",
        ["BigDecimal"] = "decimal",
        ["BigInteger"] = "System.Numerics.BigInteger",
        ["AtomicBoolean"] = "bool",
        ["AtomicInteger"] = "int",
        ["AtomicLong"] = "long",
        ["AtomicReference"] = "object",
        ["CountDownLatch"] = "CountdownEvent",
        ["Semaphore"] = "SemaphoreSlim",
        ["ReentrantLock"] = "Lock",
        ["Future"] = "Task",
        ["ExecutorService"] = "TaskScheduler",
        ["JSONObject"] = "System.Text.Json.JsonElement",
        ["JSONArray"] = "System.Text.Json.JsonElement",
        ["Bundle"] = "Dictionary<string, object>",
        ["Intent"] = "object",
        ["Context"] = "object",
        ["View"] = "object",
        ["Activity"] = "object",
        ["Fragment"] = "object",
        ["Log"] = "Console",
        ["SharedPreferences"] = "Dictionary<string, object>",
        ["Pair"] = "ValueTuple",
        ["Optional"] = "object?",
    };

    private static readonly Regex ImportRegex = new(@"^\s*import\s+([\w.]+)\s*;", RegexOptions.Compiled);
    private static readonly Regex PackageRegex = new(@"^\s*package\s+([\w.]+)\s*;", RegexOptions.Compiled);
    private static readonly Regex AnnotationRegex = new(@"^\s*@(\w+)(\(.*\))?\s*$", RegexOptions.Compiled);
    private static readonly Regex TryWithResourcesRegex = new(@"try\s*\((.+)\)\s*\{", RegexOptions.Compiled);
    private static readonly Regex ThrowsRegex = new(@"\)\s*throws\s+[\w,\s]+\{", RegexOptions.Compiled);
    private static readonly Regex ThrowsDeclRegex = new(@"\)\s*throws\s+[\w,\s]+$", RegexOptions.Compiled);
    private static readonly Regex GenericRegex = new(@"<\s*([\w?]+(?:\s+(?:extends|super)\s+[\w.]+)?(?:\s*,\s*[\w?]+(?:\s+(?:extends|super)\s+[\w.]+)?)*)\s*>", RegexOptions.Compiled);
    private static readonly Regex CatchRegex = new(@"catch\s*\((\w+(?:\s*\|\s*\w+)*)\s+(\w+)\)", RegexOptions.Compiled);
    private static readonly Regex ForEachRegex = new(@"for\s*\(\s*([\w<>\[\]?,\s]+)\s+(\w+)\s*:\s*(.+)\)\s*\{", RegexOptions.Compiled);
    private static readonly Regex InstanceOfRegex = new(@"(\w+)\s+instanceof\s+([\w.]+)", RegexOptions.Compiled);
    private static readonly Regex CastRegex = new(@"\(\s*([\w.]+)\s*\)\s*(\w+)", RegexOptions.Compiled);
    private static readonly Regex SysOutRegex = new(@"System\.out\.println\s*\(", RegexOptions.Compiled);
    private static readonly Regex SysErrRegex = new(@"System\.err\.println\s*\(", RegexOptions.Compiled);
    private static readonly Regex MethodNameRegex = new(@"(?:public|private|protected|static|final|abstract|synchronized|native|volatile|transient|\s)+\s+([\w<>\[\]?,.\s]+)\s+(\w+)\s*\(", RegexOptions.Compiled);

    private readonly string TargetNamespace;

    public JavaToCSharpConverter(string TargetNamespace)
    {
        this.TargetNamespace = TargetNamespace;
    }

    public string Convert(string JavaSource)
    {
        var Lines = JavaSource.Split('\n');
        var Output = new StringBuilder();
        var Usings = new HashSet<string>(StringComparer.Ordinal);
        var SkipNextLine = false;
        var PendingOverride = false;
        var PendingNullable = false;
        var InTryWithResources = false;

        foreach (var RawLine in Lines)
        {
            var Line = RawLine.TrimEnd('\r');

            if (SkipNextLine)
            {
                SkipNextLine = false;
                continue;
            }

            var PackageMatch = PackageRegex.Match(Line);
            if (PackageMatch.Success)
            {
                Output.Append("namespace ").Append(TargetNamespace).AppendLine(".Decompiled;");
                Output.AppendLine();
                continue;
            }

            var ImportMatch = ImportRegex.Match(Line);
            if (ImportMatch.Success)
            {
                var ImportPath = ImportMatch.Groups[1].Value;
                var LastDot = ImportPath.LastIndexOf('.');
                if (LastDot > 0)
                {
                    var Ns = ConvertPackageToNamespace(ImportPath[..LastDot]);
                    Usings.Add(Ns);
                }

                continue;
            }

            var AnnotationMatch = AnnotationRegex.Match(Line);
            if (AnnotationMatch.Success)
            {
                var AnnotationName = AnnotationMatch.Groups[1].Value;
                switch (AnnotationName)
                {
                    case "Override":
                        PendingOverride = true;
                        break;
                    case "Nullable":
                        PendingNullable = true;
                        break;
                    case "NonNull" or "NotNull" or "Nonnull":
                        break;
                    case "Deprecated":
                        Output.AppendLine("    [System.Obsolete]");
                        break;
                    case "SuppressWarnings" or "SuppressLint":
                        break;
                    default:
                        break;
                }

                continue;
            }

            var Converted = ConvertLine(Line, ref PendingOverride, ref PendingNullable, ref InTryWithResources);
            Output.AppendLine(Converted);
        }

        var Result = new StringBuilder();
        foreach (var Using in Usings.OrderBy(U => U, StringComparer.Ordinal))
        {
            Result.Append("using ").Append(Using).AppendLine(";");
        }

        if (Usings.Count > 0)
        {
            Result.AppendLine();
        }

        Result.Append(Output);
        return Result.ToString();
    }

    private string ConvertLine(string Line, ref bool PendingOverride, ref bool PendingNullable, ref bool InTryWithResources)
    {
        var Trimmed = Line.TrimStart();
        var Indent = Line[..^Trimmed.Length];

        if (Trimmed.Length == 0)
        {
            return string.Empty;
        }

        var Result = Trimmed;

        Result = Result.Replace("extends ", ": ");
        Result = Result.Replace("implements ", ": ");
        Result = Result.Replace("final ", "readonly ");
        Result = Result.Replace(" final ", " readonly ");

        var TryMatch = TryWithResourcesRegex.Match(Result);
        if (TryMatch.Success)
        {
            var ResourceDecl = TryMatch.Groups[1].Value;
            ResourceDecl = ConvertTypes(ResourceDecl);
            Result = string.Concat("using (", ResourceDecl, ") {");
            InTryWithResources = true;
        }

        Result = ThrowsRegex.Replace(Result, ") {");
        Result = ThrowsDeclRegex.Replace(Result, ")");

        Result = SysOutRegex.Replace(Result, "Console.WriteLine(");
        Result = SysErrRegex.Replace(Result, "Console.Error.WriteLine(");
        Result = Result.Replace("System.out.print(", "Console.Write(");
        Result = Result.Replace("System.err.print(", "Console.Error.Write(");

        var ForEachMatch = ForEachRegex.Match(Result);
        if (ForEachMatch.Success)
        {
            var ElemType = ConvertType(ForEachMatch.Groups[1].Value.Trim());
            var VarName = ToPascalCase(ForEachMatch.Groups[2].Value);
            var Collection = ConvertExpression(ForEachMatch.Groups[3].Value.Trim());
            Result = string.Concat("foreach (", ElemType, " ", VarName, " in ", Collection, ") {");
        }

        Result = InstanceOfRegex.Replace(Result, "$1 is $2");

        Result = CatchRegex.Replace(Result, M =>
        {
            var Types = M.Groups[1].Value.Split('|', StringSplitOptions.TrimEntries);
            var VarName = ToPascalCase(M.Groups[2].Value);
            if (Types.Length == 1)
            {
                return string.Concat("catch (", ConvertType(Types[0]), " ", VarName, ")");
            }

            return string.Concat("catch (Exception ", VarName, ") when (", string.Join(" || ", Types.Select(T => string.Concat(VarName, " is ", ConvertType(T)))), ")");
        });

        Result = ConvertTypes(Result);

        Result = Result.Replace(" synchronized ", " ");
        Result = Result.Replace(" native ", " ");
        Result = Result.Replace(" transient ", " ");
        Result = Result.Replace(" volatile ", " ");

        if (Result.Contains("synchronized (", StringComparison.Ordinal) || Result.Contains("synchronized(", StringComparison.Ordinal))
        {
            Result = Result.Replace("synchronized (", "lock (").Replace("synchronized(", "lock(");
        }

        Result = Result.Replace(".equals(", ".Equals(");
        Result = Result.Replace(".toString()", ".ToString()");
        Result = Result.Replace(".hashCode()", ".GetHashCode()");
        Result = Result.Replace(".getClass()", ".GetType()");
        Result = Result.Replace(".length()", ".Length");
        Result = Result.Replace(".size()", ".Count");
        Result = Result.Replace(".isEmpty()", ".Count == 0");
        Result = Result.Replace(".add(", ".Add(");
        Result = Result.Replace(".remove(", ".Remove(");
        Result = Result.Replace(".get(", "[");
        Result = Result.Replace(".put(", ".Add(");
        Result = Result.Replace(".contains(", ".Contains(");
        Result = Result.Replace(".containsKey(", ".ContainsKey(");
        Result = Result.Replace(".keySet()", ".Keys");
        Result = Result.Replace(".values()", ".Values");
        Result = Result.Replace(".entrySet()", string.Empty);
        Result = Result.Replace(".charAt(", "[");
        Result = Result.Replace(".substring(", ".Substring(");
        Result = Result.Replace(".toUpperCase()", ".ToUpperInvariant()");
        Result = Result.Replace(".toLowerCase()", ".ToLowerInvariant()");
        Result = Result.Replace(".trim()", ".Trim()");
        Result = Result.Replace(".startsWith(", ".StartsWith(");
        Result = Result.Replace(".endsWith(", ".EndsWith(");
        Result = Result.Replace(".indexOf(", ".IndexOf(");
        Result = Result.Replace(".lastIndexOf(", ".LastIndexOf(");
        Result = Result.Replace(".replace(", ".Replace(");
        Result = Result.Replace(".split(", ".Split(");
        Result = Result.Replace(".toCharArray()", ".ToCharArray()");
        Result = Result.Replace(".getBytes(", ".GetBytes(");
        Result = Result.Replace(".close()", ".Dispose()");
        Result = Result.Replace(".iterator()", ".GetEnumerator()");
        Result = Result.Replace(".hasNext()", ".MoveNext()");
        Result = Result.Replace(".next()", ".Current");
        Result = Result.Replace("null != ", string.Empty);
        Result = Result.Replace(" != null", " is not null");
        Result = Result.Replace(" == null", " is null");

        Result = Result.Replace("@interface ", "interface ");

        var MethodMatch = MethodNameRegex.Match(Result);
        if (MethodMatch.Success)
        {
            var MethodName = MethodMatch.Groups[2].Value;
            if (MethodName != "main" && !char.IsUpper(MethodName[0]))
            {
                var Pascal = ToPascalCase(MethodName);
                var Idx = MethodMatch.Groups[2].Index - (Line.Length - Line.TrimStart().Length - (Indent.Length - Indent.Length));
                Result = string.Concat(Result[..MethodMatch.Groups[2].Index], Pascal, Result[(MethodMatch.Groups[2].Index + MethodName.Length)..]);
            }

            if (PendingOverride)
            {
                Result = Result.Replace("public ", "public override ");
                Result = Result.Replace("protected ", "protected override ");
                PendingOverride = false;
            }

            if (PendingNullable)
            {
                var RetTypeGroup = MethodMatch.Groups[1];
                var RetType = RetTypeGroup.Value.Trim();
                if (RetType != "void" && !RetType.EndsWith("?", StringComparison.Ordinal))
                {
                    Result = Result[..RetTypeGroup.Index] + RetType + "?" + Result[(RetTypeGroup.Index + RetTypeGroup.Length)..];
                }

                PendingNullable = false;
            }
        }

        return string.Concat(Indent, Result);
    }

    private static string ConvertTypes(string Text)
    {
        foreach (var Kvp in TypeMap)
        {
            if (Text.Contains(Kvp.Key, StringComparison.Ordinal))
            {
                Text = Text.Replace(Kvp.Key, Kvp.Value);
            }
        }

        Text = GenericRegex.Replace(Text, M =>
        {
            var Inner = M.Groups[1].Value;
            Inner = Regex.Replace(Inner, @"\?\s+extends\s+(\w+)", "$1");
            Inner = Regex.Replace(Inner, @"\?\s+super\s+(\w+)", "$1");
            Inner = Inner.Replace("?", "object");
            return "<" + Inner + ">";
        });

        return Text;
    }

    private static string ConvertType(string JavaType)
    {
        var Trimmed = JavaType.Trim();
        if (TypeMap.TryGetValue(Trimmed, out var Mapped))
        {
            return Mapped;
        }

        return Trimmed;
    }

    private static string ConvertExpression(string Expr)
    {
        return ConvertTypes(Expr);
    }

    private static string ConvertPackageToNamespace(string Package)
    {
        var Parts = Package.Split('.');
        var Sb = new StringBuilder();
        for (var I = 0; I < Parts.Length; I++)
        {
            if (I > 0)
            {
                Sb.Append('.');
            }

            Sb.Append(ToPascalCase(Parts[I]));
        }

        return Sb.ToString();
    }

    private static string ToPascalCase(string Value)
    {
        if (Value.Length == 0)
        {
            return Value;
        }

        if (Value.Contains('_', StringComparison.Ordinal))
        {
            var Parts = Value.Split('_', StringSplitOptions.RemoveEmptyEntries);
            var Sb = new StringBuilder();
            foreach (var Part in Parts)
            {
                Sb.Append(char.ToUpperInvariant(Part[0]));
                if (Part.Length > 1)
                {
                    Sb.Append(Part[1..]);
                }
            }

            return Sb.ToString();
        }

        return char.ToUpperInvariant(Value[0]) + Value[1..];
    }
}
