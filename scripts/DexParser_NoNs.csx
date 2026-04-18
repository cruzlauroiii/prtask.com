using System.Globalization;
using System.Text;



public sealed class DexParser
{
    private readonly byte[] Data;
    public string[] Strings { get; private set; } = [];
    public string[] TypeNames { get; private set; } = [];
    public DexProto[] Protos { get; private set; } = [];
    public DexFieldId[] FieldIds { get; private set; } = [];
    public DexMethodId[] MethodIds { get; private set; } = [];
    public List<DexClassDef> ClassDefs { get; } = [];

    public int StringIdsSize { get; private set; }
    public int TypeIdsSize { get; private set; }
    public int ProtoIdsSize { get; private set; }
    public int FieldIdsSize { get; private set; }
    public int MethodIdsSize { get; private set; }
    public int ClassDefsSize { get; private set; }

    public DexParser(byte[] Data)
    {
        this.Data = Data;
    }

    public bool Parse()
    {
        if (Data.Length < 112)
        {
            return false;
        }

        var Magic = Encoding.ASCII.GetString(Data, 0, 3);
        if (Magic != "dex")
        {
            return false;
        }

        StringIdsSize = R32(56);
        var StringIdsOff = R32(60);
        TypeIdsSize = R32(64);
        var TypeIdsOff = R32(68);
        ProtoIdsSize = R32(72);
        var ProtoIdsOff = R32(76);
        FieldIdsSize = R32(80);
        var FieldIdsOff = R32(84);
        MethodIdsSize = R32(88);
        var MethodIdsOff = R32(92);
        ClassDefsSize = R32(96);
        var ClassDefsOff = R32(100);

        Strings = new string[StringIdsSize];
        for (var I = 0; I < StringIdsSize; I++)
        {
            var Off = R32(StringIdsOff + (I * 4));
            Strings[I] = ReadMutf8(Off);
        }

        TypeNames = new string[TypeIdsSize];
        for (var I = 0; I < TypeIdsSize; I++)
        {
            var DescIdx = R32(TypeIdsOff + (I * 4));
            TypeNames[I] = DescIdx < Strings.Length ? DescriptorToCs(Strings[DescIdx]) : "object";
        }

        Protos = new DexProto[ProtoIdsSize];
        for (var I = 0; I < ProtoIdsSize; I++)
        {
            var Base = ProtoIdsOff + (I * 12);
            var ShortyIdx = R32(Base);
            var RetTypeIdx = R32(Base + 4);
            var ParamsOff = R32(Base + 8);

            var RetType = RetTypeIdx < TypeNames.Length ? TypeNames[RetTypeIdx] : "void";
            var ParamTypes = new List<string>();

            if (ParamsOff > 0 && ParamsOff + 4 <= Data.Length)
            {
                var ParamCount = R32(ParamsOff);
                for (var J = 0; J < ParamCount && J < 20; J++)
                {
                    var PTypeIdx = R16(ParamsOff + 4 + (J * 2));
                    ParamTypes.Add(PTypeIdx < TypeNames.Length ? TypeNames[PTypeIdx] : "object");
                }
            }

            Protos[I] = new DexProto(RetType, ParamTypes);
        }

        FieldIds = new DexFieldId[FieldIdsSize];
        for (var I = 0; I < FieldIdsSize; I++)
        {
            var Base = FieldIdsOff + (I * 8);
            var ClassIdx = R16(Base);
            var TypeIdx = R16(Base + 2);
            var NameIdx = R32(Base + 4);

            FieldIds[I] = new DexFieldId(
                ClassIdx < TypeNames.Length ? TypeNames[ClassIdx] : "object",
                TypeIdx < TypeNames.Length ? TypeNames[TypeIdx] : "object",
                NameIdx < Strings.Length ? Strings[NameIdx] : string.Format(CultureInfo.InvariantCulture, "field{0}", I));
        }

        MethodIds = new DexMethodId[MethodIdsSize];
        for (var I = 0; I < MethodIdsSize; I++)
        {
            var Base = MethodIdsOff + (I * 8);
            var ClassIdx = R16(Base);
            var ProtoIdx = R16(Base + 2);
            var NameIdx = R32(Base + 4);

            MethodIds[I] = new DexMethodId(
                ClassIdx < TypeNames.Length ? TypeNames[ClassIdx] : "object",
                ProtoIdx < Protos.Length ? Protos[ProtoIdx] : new DexProto("void", []),
                NameIdx < Strings.Length ? Strings[NameIdx] : string.Format(CultureInfo.InvariantCulture, "method{0}", I));
        }

        for (var I = 0; I < ClassDefsSize; I++)
        {
            var Base = ClassDefsOff + (I * 32);
            var ClassIdx = R32(Base);
            var AccessFlags = R32(Base + 4);
            var SuperIdx = R32(Base + 8);
            var InterfacesOff = R32(Base + 12);
            var SourceFileIdx = R32(Base + 16);
            var AnnotationsOff = R32(Base + 20);
            var ClassDataOff = R32(Base + 24);
            var StaticValuesOff = R32(Base + 28);

            var FullName = ClassIdx < TypeNames.Length ? TypeNames[ClassIdx] : "Unknown";
            var SuperName = SuperIdx >= 0 && SuperIdx < TypeNames.Length ? TypeNames[SuperIdx] : string.Empty;

            var Interfaces = new List<string>();
            if (InterfacesOff > 0 && InterfacesOff + 4 <= Data.Length)
            {
                var IfaceCount = R32(InterfacesOff);
                for (var J = 0; J < IfaceCount && J < 30; J++)
                {
                    var ITypeIdx = R16(InterfacesOff + 4 + (J * 2));
                    if (ITypeIdx < TypeNames.Length)
                    {
                        Interfaces.Add(TypeNames[ITypeIdx]);
                    }
                }
            }

            var Fields = new List<DexFieldDef>();
            var Methods = new List<DexMethodDef>();

            if (ClassDataOff > 0 && ClassDataOff < Data.Length)
            {
                var Pos = ClassDataOff;
                var StaticFieldsSize = ReadUleb128(ref Pos);
                var InstanceFieldsSize = ReadUleb128(ref Pos);
                var DirectMethodsSize = ReadUleb128(ref Pos);
                var VirtualMethodsSize = ReadUleb128(ref Pos);

                var FIdx = 0;
                for (var J = 0; J < StaticFieldsSize; J++)
                {
                    FIdx += ReadUleb128(ref Pos);
                    var FAcc = ReadUleb128(ref Pos);
                    if (FIdx < FieldIds.Length)
                    {
                        Fields.Add(new DexFieldDef(FieldIds[FIdx].Name, FieldIds[FIdx].TypeName, true,
                            (FAcc & 0x0010) != 0, (FAcc & 0x0008) != 0, (FAcc & 0x0001) != 0, (FAcc & 0x0002) != 0));
                    }
                }

                FIdx = 0;
                for (var J = 0; J < InstanceFieldsSize; J++)
                {
                    FIdx += ReadUleb128(ref Pos);
                    var FAcc = ReadUleb128(ref Pos);
                    if (FIdx < FieldIds.Length)
                    {
                        Fields.Add(new DexFieldDef(FieldIds[FIdx].Name, FieldIds[FIdx].TypeName, false,
                            (FAcc & 0x0010) != 0, false, (FAcc & 0x0001) != 0, (FAcc & 0x0002) != 0));
                    }
                }

                var MIdx = 0;
                for (var J = 0; J < DirectMethodsSize; J++)
                {
                    MIdx += ReadUleb128(ref Pos);
                    var MAcc = ReadUleb128(ref Pos);
                    var CodeOff = ReadUleb128(ref Pos);
                    if (MIdx < MethodIds.Length)
                    {
                        var Body = CodeOff > 0 ? DecompileMethod(CodeOff, MIdx) : string.Empty;
                        Methods.Add(new DexMethodDef(MethodIds[MIdx].Name, MethodIds[MIdx].Proto,
                            (MAcc & 0x0008) != 0, (MAcc & 0x0001) != 0, (MAcc & 0x0002) != 0,
                            (MAcc & 0x0400) != 0, CodeOff > 0, Body));
                    }
                }

                MIdx = 0;
                for (var J = 0; J < VirtualMethodsSize; J++)
                {
                    MIdx += ReadUleb128(ref Pos);
                    var MAcc = ReadUleb128(ref Pos);
                    var CodeOff = ReadUleb128(ref Pos);
                    if (MIdx < MethodIds.Length)
                    {
                        var Body = CodeOff > 0 ? DecompileMethod(CodeOff, MIdx) : string.Empty;
                        Methods.Add(new DexMethodDef(MethodIds[MIdx].Name, MethodIds[MIdx].Proto,
                            false, (MAcc & 0x0001) != 0, (MAcc & 0x0002) != 0,
                            (MAcc & 0x0400) != 0, CodeOff > 0, Body));
                    }
                }
            }

            var IsInterface = (AccessFlags & 0x0200) != 0;
            var IsAbstract = (AccessFlags & 0x0400) != 0;
            var IsEnum = (AccessFlags & 0x4000) != 0;
            var IsPublic = (AccessFlags & 0x0001) != 0;
            var IsStatic = (AccessFlags & 0x0008) != 0;
            var IsFinal = (AccessFlags & 0x0010) != 0;
            var IsAnnotation = (AccessFlags & 0x2000) != 0;

            var LastDot = FullName.LastIndexOf('.');
            var Package = LastDot >= 0 ? FullName[..LastDot] : string.Empty;
            var ClassName = LastDot >= 0 ? FullName[(LastDot + 1)..] : FullName;

            var IsSystem = Package.StartsWith("android.", StringComparison.Ordinal) ||
                           Package.StartsWith("java.", StringComparison.Ordinal) ||
                           Package.StartsWith("javax.", StringComparison.Ordinal) ||
                           Package.StartsWith("kotlin.", StringComparison.Ordinal) ||
                           Package.StartsWith("kotlinx.", StringComparison.Ordinal) ||
                           Package.StartsWith("androidx.", StringComparison.Ordinal) ||
                           Package.StartsWith("com.google.", StringComparison.Ordinal) ||
                           Package.StartsWith("okhttp3.", StringComparison.Ordinal) ||
                           Package.StartsWith("okio.", StringComparison.Ordinal) ||
                           Package.StartsWith("retrofit2.", StringComparison.Ordinal) ||
                           Package.StartsWith("dagger.", StringComparison.Ordinal) ||
                           Package.StartsWith("io.reactivex.", StringComparison.Ordinal) ||
                           Package.StartsWith("com.squareup.", StringComparison.Ordinal) ||
                           Package.StartsWith("org.bouncycastle.", StringComparison.Ordinal) ||
                           Package.StartsWith("org.conscrypt.", StringComparison.Ordinal) ||
                           Package.StartsWith("org.json.", StringComparison.Ordinal) ||
                           Package.StartsWith("dalvik.", StringComparison.Ordinal);

            ClassDefs.Add(new DexClassDef(
                FullName, ClassName, Package, SuperName, Interfaces,
                IsInterface, IsAbstract, IsEnum, IsPublic, IsStatic, IsFinal, IsAnnotation, IsSystem,
                Fields, Methods));
        }

        return true;
    }

    private string DecompileMethod(int CodeOff, int MethodIdx)
    {
        if (CodeOff <= 0 || CodeOff + 16 > Data.Length)
        {
            return string.Empty;
        }

        try
        {
            return DecompileMethodCore(CodeOff, MethodIdx);
        }
        catch
        {
            return string.Empty;
        }
    }

    private string DecompileMethodCore(int CodeOff, int MethodIdx)
    {

        var RegistersSize = R16(CodeOff);
        var InsSize = R16(CodeOff + 2);
        var OutsSize = R16(CodeOff + 4);
        var TriesSize = R16(CodeOff + 6);
        var InsnsSize = R32(CodeOff + 12);
        var InsnsOff = CodeOff + 16;

        if (InsnsSize == 0 || InsnsOff + (InsnsSize * 2) > Data.Length)
        {
            return string.Empty;
        }

        var Sb = new StringBuilder();
        var StringRefs = new List<string>();
        var MethodRefs = new List<string>();
        var FieldRefs = new List<string>();
        var TypeRefs = new List<string>();

        var Pos = 0;
        while (Pos < InsnsSize)
        {
            var Unit = R16(InsnsOff + (Pos * 2));
            var Op = Unit & 0xFF;

            switch (Op)
            {
                case 0x00:
                    Pos++;
                    break;
                case 0x01: case 0x02: case 0x03: case 0x04: case 0x05: case 0x06: case 0x07:
                    Pos++;
                    break;
                case 0x08: case 0x09:
                    Pos += 2;
                    break;
                case 0x0A: case 0x0B: case 0x0C: case 0x0D:
                    Pos++;
                    break;
                case 0x0E:
                    Pos++;
                    break;
                case 0x0F: case 0x10: case 0x11:
                    Pos++;
                    break;
                case 0x12: case 0x13:
                    Pos += Op == 0x13 ? 2 : 1;
                    break;
                case 0x14:
                    Pos += 3;
                    break;
                case 0x15:
                    Pos += 2;
                    break;
                case 0x16:
                    Pos += 2;
                    break;
                case 0x17:
                    Pos += 3;
                    break;
                case 0x18:
                    Pos += 5;
                    break;
                case 0x19:
                    Pos += 2;
                    break;
                case 0x1A:
                {
                    var StrIdx = R16(InsnsOff + ((Pos + 1) * 2));
                    if (StrIdx < Strings.Length)
                    {
                        StringRefs.Add(Strings[StrIdx]);
                    }

                    Pos += 2;
                    break;
                }
                case 0x1B:
                {
                    var StrIdx = R32(InsnsOff + ((Pos + 1) * 2));
                    if (StrIdx < Strings.Length)
                    {
                        StringRefs.Add(Strings[StrIdx]);
                    }

                    Pos += 3;
                    break;
                }
                case 0x1C:
                {
                    var TIdx = R16(InsnsOff + ((Pos + 1) * 2));
                    if (TIdx < TypeNames.Length)
                    {
                        TypeRefs.Add(TypeNames[TIdx]);
                    }

                    Pos += 2;
                    break;
                }
                case 0x1D: case 0x1E:
                    Pos++;
                    break;
                case 0x1F:
                    Pos += 2;
                    break;
                case 0x20:
                    Pos += 2;
                    break;
                case 0x21: case 0x22:
                    Pos += Op == 0x22 ? 2 : 1;
                    if (Op == 0x22)
                    {
                        var TIdx = R16(InsnsOff + (Pos * 2 - 2));
                        if (TIdx < TypeNames.Length)
                        {
                            TypeRefs.Add(TypeNames[TIdx]);
                        }
                    }

                    break;
                case 0x23:
                    Pos += 2;
                    break;
                case 0x24: case 0x25:
                    Pos += 3;
                    break;
                case 0x26:
                    Pos += 3;
                    break;
                case 0x27:
                    Pos++;
                    break;
                case 0x28:
                    Pos++;
                    break;
                case 0x29:
                    Pos += 2;
                    break;
                case 0x2A:
                    Pos += 3;
                    break;
                case 0x2B: case 0x2C:
                    Pos += 3;
                    break;
                case >= 0x2D and <= 0x31:
                    Pos += 2;
                    break;
                case >= 0x32 and <= 0x37:
                    Pos += 2;
                    break;
                case >= 0x38 and <= 0x3D:
                    Pos += 2;
                    break;
                case >= 0x44 and <= 0x51:
                    Pos += 2;
                    break;
                case >= 0x52 and <= 0x5F:
                {
                    var FIdx = R16(InsnsOff + ((Pos + 1) * 2));
                    if (FIdx < FieldIds.Length)
                    {
                        FieldRefs.Add(string.Concat(FieldIds[FIdx].ClassName, ".", FieldIds[FIdx].Name));
                    }

                    Pos += 2;
                    break;
                }
                case >= 0x60 and <= 0x6D:
                {
                    var FIdx = R16(InsnsOff + ((Pos + 1) * 2));
                    if (FIdx < FieldIds.Length)
                    {
                        FieldRefs.Add(string.Concat(FieldIds[FIdx].ClassName, ".", FieldIds[FIdx].Name));
                    }

                    Pos += 2;
                    break;
                }
                case >= 0x6E and <= 0x72:
                {
                    var MIdx2 = R16(InsnsOff + ((Pos + 1) * 2));
                    if (MIdx2 < MethodIds.Length)
                    {
                        MethodRefs.Add(string.Concat(
                            MapJavaType(MethodIds[MIdx2].ClassName), ".",
                            MethodIds[MIdx2].Name));
                    }

                    Pos += 3;
                    break;
                }
                case >= 0x74 and <= 0x78:
                {
                    var MIdx2 = R16(InsnsOff + ((Pos + 1) * 2));
                    if (MIdx2 < MethodIds.Length)
                    {
                        MethodRefs.Add(string.Concat(
                            MapJavaType(MethodIds[MIdx2].ClassName), ".",
                            MethodIds[MIdx2].Name));
                    }

                    Pos += 3;
                    break;
                }
                case >= 0x7B and <= 0x8F:
                    Pos++;
                    break;
                case >= 0x90 and <= 0xAF:
                    Pos += 2;
                    break;
                case >= 0xB0 and <= 0xCF:
                    Pos++;
                    break;
                case >= 0xD0 and <= 0xD8:
                    Pos += 2;
                    break;
                case >= 0xD9 and <= 0xE2:
                    Pos += 2;
                    break;
                case 0xFA: case 0xFB: case 0xFC: case 0xFD: case 0xFE: case 0xFF:
                    Pos += 4;
                    break;
                default:
                    Pos++;
                    break;
            }
        }

        foreach (var S in StringRefs.Distinct().Take(20))
        {
            var Escaped = S.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r");
            if (Escaped.Length > 100)
            {
                Escaped = Escaped[..97] + "...";
            }

            Sb.AppendFormat(CultureInfo.InvariantCulture, "// str: \"{0}\"\n", Escaped);
        }

        foreach (var M in MethodRefs.Distinct().Take(20))
        {
            Sb.AppendFormat(CultureInfo.InvariantCulture, "// call: {0}\n", M);
        }

        foreach (var F in FieldRefs.Distinct().Take(15))
        {
            Sb.AppendFormat(CultureInfo.InvariantCulture, "// field: {0}\n", F);
        }

        foreach (var T in TypeRefs.Distinct().Take(10))
        {
            Sb.AppendFormat(CultureInfo.InvariantCulture, "// type: {0}\n", MapJavaType(T));
        }

        return Sb.ToString();
    }

    private int R16(int Off)
    {
        return Off + 1 < Data.Length ? BitConverter.ToUInt16(Data, Off) : 0;
    }

    private int R32(int Off)
    {
        return Off + 3 < Data.Length ? BitConverter.ToInt32(Data, Off) : 0;
    }

    private int ReadUleb128(ref int Pos)
    {
        var Result = 0;
        var Shift = 0;
        while (Pos < Data.Length)
        {
            var B = Data[Pos++];
            Result |= (B & 0x7F) << Shift;
            if ((B & 0x80) == 0)
            {
                break;
            }

            Shift += 7;
        }

        return Result;
    }

    private string ReadMutf8(int Offset)
    {
        var Pos = Offset;
        while (Pos < Data.Length && (Data[Pos] & 0x80) != 0)
        {
            Pos++;
        }

        Pos++;

        var Sb = new StringBuilder();
        while (Pos < Data.Length && Data[Pos] != 0)
        {
            var B = Data[Pos];
            if ((B & 0x80) == 0)
            {
                Sb.Append((char)B);
                Pos++;
            }
            else if ((B & 0xE0) == 0xC0 && Pos + 1 < Data.Length)
            {
                Sb.Append((char)(((B & 0x1F) << 6) | (Data[Pos + 1] & 0x3F)));
                Pos += 2;
            }
            else if ((B & 0xF0) == 0xE0 && Pos + 2 < Data.Length)
            {
                Sb.Append((char)(((B & 0x0F) << 12) | ((Data[Pos + 1] & 0x3F) << 6) | (Data[Pos + 2] & 0x3F)));
                Pos += 3;
            }
            else
            {
                Pos++;
            }
        }

        return Sb.ToString();
    }

    public static string DescriptorToCs(string Descriptor)
    {
        if (Descriptor.Length == 0)
        {
            return "object";
        }

        if (Descriptor[0] == 'L')
        {
            return Descriptor[1..].TrimEnd(';').Replace('/', '.');
        }

        if (Descriptor[0] == '[')
        {
            return DescriptorToCs(Descriptor[1..]) + "[]";
        }

        return Descriptor[0] switch
        {
            'V' => "void",
            'Z' => "bool",
            'B' => "byte",
            'S' => "short",
            'C' => "char",
            'I' => "int",
            'J' => "long",
            'F' => "float",
            'D' => "double",
            _ => "object"
        };
    }

    public static string MapJavaType(string JavaType)
    {
        if (JavaType.EndsWith("[]", StringComparison.Ordinal))
        {
            return MapJavaType(JavaType[..^2]) + "[]";
        }

        var LastDot = JavaType.LastIndexOf('.');
        var Simple = LastDot >= 0 ? JavaType[(LastDot + 1)..] : JavaType;
        var Full = JavaType;

        return Full switch
        {
            "java.lang.String" => "string",
            "java.lang.Object" => "object",
            "java.lang.Integer" or "int" => "int",
            "java.lang.Long" or "long" => "long",
            "java.lang.Boolean" or "boolean" or "bool" => "bool",
            "java.lang.Float" or "float" => "float",
            "java.lang.Double" or "double" => "double",
            "java.lang.Byte" or "byte" => "byte",
            "java.lang.Short" or "short" => "short",
            "java.lang.Character" or "char" => "char",
            "java.lang.Void" or "void" => "void",
            "java.util.List" or "java.util.ArrayList" or "java.util.LinkedList" => "List<object>",
            "java.util.Map" or "java.util.HashMap" or "java.util.LinkedHashMap" or "java.util.TreeMap" or "java.util.IdentityHashMap" or "java.util.WeakHashMap" or "java.util.concurrent.ConcurrentHashMap" => "Dictionary<string, object>",
            "java.util.Set" or "java.util.HashSet" or "java.util.TreeSet" or "java.util.LinkedHashSet" => "HashSet<object>",
            "java.lang.Iterable" => "IEnumerable<object>",
            "java.util.Collection" => "ICollection<object>",
            "java.util.Queue" or "java.util.Deque" or "java.util.ArrayDeque" => "Queue<object>",
            "java.util.Stack" => "Stack<object>",
            "java.util.Optional" => "object?",
            "java.util.Date" => "DateTime",
            "java.util.UUID" => "Guid",
            "java.util.Locale" => "CultureInfo",
            "java.util.Calendar" or "java.util.GregorianCalendar" => "DateTime",
            "java.util.TimeZone" => "TimeZoneInfo",
            "java.util.regex.Pattern" => "System.Text.RegularExpressions.Regex",
            "java.util.concurrent.atomic.AtomicBoolean" => "bool",
            "java.util.concurrent.atomic.AtomicInteger" => "int",
            "java.util.concurrent.atomic.AtomicLong" => "long",
            "java.util.concurrent.atomic.AtomicReference" => "object",
            "java.lang.StringBuilder" => "StringBuilder",
            "java.lang.StringBuffer" => "StringBuilder",
            "java.lang.Runnable" => "Action",
            "java.lang.Thread" => "Thread",
            "java.lang.Class" => "Type",
            "java.lang.Exception" or "java.lang.Throwable" or "java.lang.RuntimeException" => "Exception",
            "java.lang.ref.WeakReference" => "WeakReference<object>",
            "java.io.InputStream" => "Stream",
            "java.io.OutputStream" => "Stream",
            "java.io.File" => "string",
            "java.io.Serializable" => "object",
            "java.io.Closeable" or "java.lang.AutoCloseable" => "IDisposable",
            "java.net.URL" => "Uri",
            "java.net.URI" => "Uri",
            "java.net.HttpURLConnection" => "HttpClient",
            "java.math.BigInteger" or "java.lang.Number" => "System.Numerics.BigInteger",
            "java.util.Iterator" => "IEnumerator<object>",
            "java.nio.ByteBuffer" => "byte[]",
            "java.nio.charset.Charset" => "System.Text.Encoding",
            "java.io.ByteArrayInputStream" or "java.io.ByteArrayOutputStream" => "MemoryStream",
            "java.io.BufferedReader" or "java.io.InputStreamReader" => "StreamReader",
            "java.io.BufferedWriter" or "java.io.OutputStreamWriter" => "StreamWriter",
            "java.io.PrintStream" or "java.io.PrintWriter" => "TextWriter",
            "java.util.concurrent.ExecutorService" or "java.util.concurrent.Executor" => "TaskScheduler",
            "java.util.concurrent.Future" => "Task<object>",
            "java.util.concurrent.CountDownLatch" => "CountdownEvent",
            "java.util.concurrent.Semaphore" => "SemaphoreSlim",
            "java.util.concurrent.locks.ReentrantLock" => "Lock",
            "java.util.concurrent.CopyOnWriteArrayList" => "List<object>",
            "java.math.BigDecimal" => "decimal",
            "java.security.MessageDigest" => "System.Security.Cryptography.HashAlgorithm",
            "java.security.KeyStore" => "System.Security.Cryptography.X509Certificates.X509Store",
            "java.security.SecureRandom" => "System.Security.Cryptography.RandomNumberGenerator",
            "javax.crypto.Cipher" => "System.Security.Cryptography.Aes",
            "javax.crypto.Mac" => "System.Security.Cryptography.HMAC",
            "javax.crypto.spec.SecretKeySpec" => "byte[]",
            "java.text.SimpleDateFormat" => "string",
            "java.text.DateFormat" => "string",
            "android.content.Context" => "object",
            "android.content.Intent" => "object",
            "android.content.SharedPreferences" => "Dictionary<string, object>",
            "android.os.Bundle" => "Dictionary<string, object>",
            "android.os.Handler" => "object",
            "android.os.Looper" => "object",
            "android.app.Activity" => "object",
            "android.app.Application" => "object",
            "android.view.View" => "object",
            "android.nfc.tech.IsoDep" => "object",
            "android.nfc.Tag" => "object",
            "android.nfc.NfcAdapter" => "object",
            "android.util.ArrayMap" or "android.util.SparseArray" => "Dictionary<string, object>",
            "android.util.Pair" => "ValueTuple<object, object>",
            "android.util.Log" => "Console",
            "io.reactivex.Single" => "Task<object>",
            "io.reactivex.Observable" => "IObservable<object>",
            "io.reactivex.Completable" => "Task",
            "io.reactivex.Flowable" => "IAsyncEnumerable<object>",
            "io.reactivex.Scheduler" => "TaskScheduler",
            "io.reactivex.disposables.Disposable" => "IDisposable",
            "io.reactivex.disposables.CompositeDisposable" => "IDisposable",
            "kotlin.Unit" => "void",
            "kotlin.Pair" => "ValueTuple<object, object>",
            "kotlin.Triple" => "ValueTuple<object, object, object>",
            "kotlin.Lazy" => "Lazy<object>",
            "kotlin.jvm.functions.Function0" => "Func<object>",
            "kotlin.jvm.functions.Function1" => "Func<object, object>",
            "kotlin.jvm.functions.Function2" => "Func<object, object, object>",
            "kotlin.coroutines.Continuation" => "object",
            "kotlin.reflect.KProperty" or "kotlin.reflect.KProperty[]" => "object",
            "kotlinx.coroutines.CoroutineScope" => "object",
            "kotlinx.coroutines.Job" => "Task",
            "kotlinx.coroutines.flow.Flow" => "IAsyncEnumerable<object>",
            "kotlinx.coroutines.flow.StateFlow" => "object",
            "kotlinx.coroutines.flow.MutableStateFlow" => "object",
            "org.json.JSONObject" => "System.Text.Json.JsonElement",
            "org.json.JSONArray" => "System.Text.Json.JsonElement",
            _ => Simple
        };
    }
}

public sealed record DexProto(string ReturnType, List<string> ParamTypes);
public sealed record DexFieldId(string ClassName, string TypeName, string Name);
public sealed record DexMethodId(string ClassName, DexProto Proto, string Name);

public sealed record DexClassDef(
    string FullName, string ClassName, string Package, string SuperClass,
    List<string> Interfaces,
    bool IsInterface, bool IsAbstract, bool IsEnum, bool IsPublic,
    bool IsStatic, bool IsFinal, bool IsAnnotation, bool IsSystem,
    List<DexFieldDef> Fields, List<DexMethodDef> Methods);

public sealed record DexFieldDef(
    string Name, string TypeName, bool IsStatic, bool IsFinal,
    bool IsConst, bool IsPublic, bool IsPrivate);

public sealed record DexMethodDef(
    string Name, DexProto Proto, bool IsStatic, bool IsPublic,
    bool IsPrivate, bool IsAbstract, bool HasCode, string DecompiledBody);

