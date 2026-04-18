using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;

namespace PrTask.Transpiler;

public sealed class IlToSharpDecompiler
{
    private readonly Dictionary<string, DecompiledAssembly> Assemblies = new(StringComparer.Ordinal);

    public void LoadAssembly(string FilePath)
    {
        try
        {
            var Bytes = File.ReadAllBytes(FilePath);
            using var Stream = new MemoryStream(Bytes, writable: false);
            using var PeReader = new PEReader(Stream);
            if (!PeReader.HasMetadata)
            {
                return;
            }

            var MetadataReader = PeReader.GetMetadataReader();
            var AsmName = MetadataReader.GetString(MetadataReader.GetAssemblyDefinition().Name);

            var Result = new DecompiledAssembly(AsmName);

            foreach (var TypeHandle in MetadataReader.TypeDefinitions)
            {
                var TypeDef = MetadataReader.GetTypeDefinition(TypeHandle);
                var TypeName = MetadataReader.GetString(TypeDef.Name);
                var TypeNamespace = MetadataReader.GetString(TypeDef.Namespace);

                if (TypeName.StartsWith("<", StringComparison.Ordinal) ||
                    TypeName.StartsWith("__", StringComparison.Ordinal))
                {
                    continue;
                }

                var FullName = TypeNamespace.Length > 0
                    ? string.Concat(TypeNamespace, ".", TypeName)
                    : TypeName;

                var IsInterface = (TypeDef.Attributes & TypeAttributes.Interface) != 0;
                var IsEnum = false;
                var IsSealed = (TypeDef.Attributes & TypeAttributes.Sealed) != 0;
                var IsAbstract = (TypeDef.Attributes & TypeAttributes.Abstract) != 0;
                var IsStatic = IsSealed && IsAbstract;
                var IsRecord = false;

                var BaseTypeName = string.Empty;
                if (!TypeDef.BaseType.IsNil)
                {
                    BaseTypeName = GetHandleName(MetadataReader, TypeDef.BaseType);
                    IsEnum = BaseTypeName == "System.Enum";
                }

                var Interfaces = new List<string>();
                foreach (var InterfaceImpl in TypeDef.GetInterfaceImplementations())
                {
                    var Impl = MetadataReader.GetInterfaceImplementation(InterfaceImpl);
                    Interfaces.Add(GetHandleName(MetadataReader, Impl.Interface));
                }

                var Fields = new List<DecompiledField>();
                foreach (var FieldHandle in TypeDef.GetFields())
                {
                    var Field = MetadataReader.GetFieldDefinition(FieldHandle);
                    var FieldName = MetadataReader.GetString(Field.Name);
                    var FieldAttrs = Field.Attributes;
                    var IsFieldStatic = (FieldAttrs & FieldAttributes.Static) != 0;
                    var IsFieldConst = (FieldAttrs & FieldAttributes.Literal) != 0;
                    var IsFieldReadonly = (FieldAttrs & FieldAttributes.InitOnly) != 0;
                    var FieldSigType = DecodeFieldType(MetadataReader, Field);

                    string ConstValue = string.Empty;
                    if (IsFieldConst)
                    {
                        ConstValue = ReadConstantValue(MetadataReader, Field);
                    }

                    Fields.Add(new DecompiledField(FieldName, FieldSigType, IsFieldStatic, IsFieldConst, IsFieldReadonly, ConstValue));
                }

                var Properties = new List<DecompiledProperty>();
                foreach (var PropHandle in TypeDef.GetProperties())
                {
                    var Prop = MetadataReader.GetPropertyDefinition(PropHandle);
                    var PropName = MetadataReader.GetString(Prop.Name);
                    var PropSigType = DecodePropertyType(MetadataReader, Prop);

                    var Accessors = Prop.GetAccessors();
                    var HasGet = !Accessors.Getter.IsNil;
                    var HasSet = !Accessors.Setter.IsNil;

                    Properties.Add(new DecompiledProperty(PropName, PropSigType, HasGet, HasSet));
                }

                var Methods = new List<DecompiledMethod>();
                foreach (var MethodHandle in TypeDef.GetMethods())
                {
                    var Method = MetadataReader.GetMethodDefinition(MethodHandle);
                    var MethodName = MetadataReader.GetString(Method.Name);
                    var IsMethodStatic = (Method.Attributes & MethodAttributes.Static) != 0;
                    var IsMethodPublic = (Method.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
                    var IsMethodVirtual = (Method.Attributes & MethodAttributes.Virtual) != 0;
                    var IsMethodAbstract = (Method.Attributes & MethodAttributes.Abstract) != 0;
                    var ReturnType = DecodeMethodReturnType(MetadataReader, Method);
                    var Params = DecodeMethodParameters(MetadataReader, Method);
                    var Visibility = IsMethodPublic ? "public" :
                        ((Method.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Family) ? "protected" :
                        ((Method.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Assembly) ? "internal" : "private";

                    var IlBody = string.Empty;
                    if (!IsMethodAbstract && !IsInterface)
                    {
                        IlBody = DecompileMethodBody(MetadataReader, PeReader, Method, MethodName, ReturnType, Params, FullName);
                    }

                    Methods.Add(new DecompiledMethod(
                        MethodName, ReturnType, Params, IsMethodStatic, IsMethodPublic,
                        IsMethodVirtual, IsMethodAbstract, Visibility, IlBody));
                }

                var Events = new List<DecompiledEvent>();
                foreach (var EventHandle in TypeDef.GetEvents())
                {
                    var Evt = MetadataReader.GetEventDefinition(EventHandle);
                    var EvtName = MetadataReader.GetString(Evt.Name);
                    var EvtType = GetHandleName(MetadataReader, Evt.Type);
                    Events.Add(new DecompiledEvent(EvtName, SimplifyTypeName(EvtType)));
                }

                var NestedTypes = new List<string>();

                var HasCloneMethod = Methods.Any(M => M.Name.StartsWith("<Clone>", StringComparison.Ordinal));
                var HasBackingFields = Fields.Any(F => F.Name.Contains("k__BackingField", StringComparison.Ordinal));

                if (HasCloneMethod || (HasBackingFields && TypeDef.GetProperties().Count > 0))
                {
                    IsRecord = true;
                }

                Fields.RemoveAll(F => F.Name.Contains("k__BackingField", StringComparison.Ordinal));

                Result.Types.Add(new DecompiledType(
                    FullName, TypeName, TypeNamespace, IsInterface, IsEnum, IsStatic,
                    IsSealed && !IsStatic, IsRecord, BaseTypeName, Interfaces,
                    Fields, Properties, Methods, Events, NestedTypes));
            }

            Assemblies[AsmName] = Result;
        }
        catch
        {
        }
    }

    public DecompiledAssembly? GetAssembly(string Name)
    {
        return Assemblies.TryGetValue(Name, out var Asm) ? Asm : null;
    }

    public IReadOnlyDictionary<string, DecompiledAssembly> GetAllAssemblies() => Assemblies;

    public string GenerateSourceFile(DecompiledType Type, string OutputNamespace, Func<string, string>? ApiMapper = null)
    {
        var Sb = new StringBuilder();
        var Usings = new HashSet<string> { "System", "System.Text", "System.Text.Json", "System.Text.Json.Nodes" };

        foreach (var Field in Type.Fields)
        {
            CollectUsings(Field.TypeName, Usings);
        }

        foreach (var Prop in Type.Properties)
        {
            CollectUsings(Prop.TypeName, Usings);
        }

        foreach (var Using in Usings.OrderBy(U => U, StringComparer.Ordinal))
        {
            Sb.Append("using ").Append(Using).AppendLine(";");
        }

        Sb.AppendLine();
        Sb.Append("namespace ").Append(OutputNamespace).AppendLine(";");
        Sb.AppendLine();

        if (Type.IsInterface)
        {
            GenerateInterface(Sb, Type);
        }
        else if (Type.IsEnum)
        {
            GenerateEnum(Sb, Type);
        }
        else if (Type.IsRecord)
        {
            GenerateRecord(Sb, Type);
        }
        else
        {
            GenerateClass(Sb, Type, ApiMapper);
        }

        return Sb.ToString();
    }

    private static void GenerateInterface(StringBuilder Sb, DecompiledType Type)
    {
        Sb.Append("public interface ").AppendLine(Type.TypeName);
        Sb.AppendLine("{");

        foreach (var Prop in Type.Properties)
        {
            var TypeStr = SimplifyTypeName(Prop.TypeName);
            Sb.Append("    ").Append(TypeStr).Append(' ').Append(Prop.Name);
            if (Prop.HasGet && Prop.HasSet)
            {
                Sb.AppendLine(" { get; set; }");
            }
            else if (Prop.HasGet)
            {
                Sb.AppendLine(" { get; }");
            }
            else
            {
                Sb.AppendLine(" { set; }");
            }
        }

        if (Type.Properties.Count > 0 && (Type.Events.Count > 0 || Type.Methods.Any(M => !IsAccessor(M.Name))))
        {
            Sb.AppendLine();
        }

        foreach (var Evt in Type.Events)
        {
            Sb.Append("    event ").Append(Evt.TypeName).Append(' ').Append(Evt.Name).AppendLine(";");
        }

        if (Type.Events.Count > 0 && Type.Methods.Any(M => !IsAccessor(M.Name)))
        {
            Sb.AppendLine();
        }

        foreach (var Method in Type.Methods.Where(M => !IsAccessor(M.Name) && M.Name != ".ctor"))
        {
            var RetType = SimplifyTypeName(Method.ReturnType);
            Sb.Append("    ").Append(RetType).Append(' ').Append(Method.Name).Append('(');
            WriteParams(Sb, Method.Parameters);
            Sb.AppendLine(");");
        }

        Sb.AppendLine("}");
    }

    private static void GenerateEnum(StringBuilder Sb, DecompiledType Type)
    {
        Sb.Append("public enum ").AppendLine(Type.TypeName);
        Sb.AppendLine("{");

        foreach (var Field in Type.Fields.Where(F => F.Name != "value__"))
        {
            if (Field.ConstValue.Length > 0)
            {
                Sb.Append("    ").Append(Field.Name).Append(" = ").Append(Field.ConstValue).AppendLine(",");
            }
            else
            {
                Sb.Append("    ").Append(Field.Name).AppendLine(",");
            }
        }

        Sb.AppendLine("}");
    }

    private static void GenerateRecord(StringBuilder Sb, DecompiledType Type)
    {
        var Modifier = Type.IsSealed ? "public sealed record " : "public record ";
        Sb.Append(Modifier).Append(Type.TypeName).AppendLine("(");

        var CtorProps = Type.Properties.Where(P => P.HasGet && P.Name != "EqualityContract").ToArray();
        var NonCtorMethods = Type.Methods.Where(M =>
            !IsAccessor(M.Name) && M.Name != ".ctor" && M.Name != "ToString" &&
            M.Name != "GetHashCode" && M.Name != "Equals" && M.Name != "Deconstruct" &&
            M.Name != "PrintMembers" && !M.Name.StartsWith("<Clone>", StringComparison.Ordinal) &&
            M.Name != "op_Equality" && M.Name != "op_Inequality").ToArray();

        for (var I = 0; I < CtorProps.Length; I++)
        {
            var Prop = CtorProps[I];
            var TypeStr = SimplifyTypeName(Prop.TypeName);
            Sb.Append("    ").Append(TypeStr).Append(' ').Append(Prop.Name);
            Sb.AppendLine(I < CtorProps.Length - 1 ? "," : NonCtorMethods.Length > 0 ? ")" : ");");
        }

        if (NonCtorMethods.Length > 0)
        {
            Sb.AppendLine("{");
            foreach (var Method in NonCtorMethods)
            {
                WriteMethodWithBody(Sb, Method, "    ", null);
            }

            Sb.AppendLine("}");
        }
    }

    private static void GenerateClass(StringBuilder Sb, DecompiledType Type, Func<string, string>? ApiMapper)
    {
        var Modifier = Type.IsStatic ? "public static class " :
            Type.IsSealed ? "public sealed class " : "public class ";
        Sb.Append(Modifier).Append(Type.TypeName);

        var Implements = new List<string>();
        if (Type.Interfaces.Count > 0)
        {
            foreach (var Iface in Type.Interfaces)
            {
                Implements.Add(SimplifyTypeName(Iface));
            }
        }

        if (Implements.Count > 0)
        {
            Sb.Append(" : ").Append(string.Join(", ", Implements));
        }

        Sb.AppendLine();
        Sb.AppendLine("{");

        foreach (var Field in Type.Fields)
        {
            WriteField(Sb, Field);
        }

        if (Type.Fields.Count > 0 && (Type.Properties.Count > 0 || Type.Events.Count > 0))
        {
            Sb.AppendLine();
        }

        foreach (var Evt in Type.Events)
        {
            Sb.Append("    public event ").Append(Evt.TypeName).Append("? ").Append(Evt.Name).AppendLine(";");
        }

        if (Type.Events.Count > 0 && Type.Properties.Count > 0)
        {
            Sb.AppendLine();
        }

        foreach (var Prop in Type.Properties)
        {
            WriteProperty(Sb, Prop);
        }

        if (Type.Properties.Count > 0 && Type.Methods.Any(M => !IsAccessor(M.Name)))
        {
            Sb.AppendLine();
        }

        foreach (var Method in Type.Methods.Where(M => !IsAccessor(M.Name)))
        {
            WriteMethodWithBody(Sb, Method, "    ", ApiMapper);
        }

        Sb.AppendLine("}");
    }

    private static void WriteField(StringBuilder Sb, DecompiledField Field)
    {
        Sb.Append("    ");
        if (Field.IsConst)
        {
            Sb.Append("private const ");
        }
        else
        {
            Sb.Append(Field.IsStatic ? "private static " : "private ");
            if (Field.IsReadonly)
            {
                Sb.Append("readonly ");
            }
        }

        Sb.Append(SimplifyTypeName(Field.TypeName)).Append(' ').Append(Field.Name);

        if (Field.IsConst && Field.ConstValue.Length > 0)
        {
            Sb.Append(" = ").Append(Field.ConstValue);
        }

        Sb.AppendLine(";");
    }

    private static void WriteProperty(StringBuilder Sb, DecompiledProperty Prop)
    {
        var TypeStr = SimplifyTypeName(Prop.TypeName);
        Sb.Append("    public ").Append(TypeStr).Append(' ').Append(Prop.Name);
        if (Prop.HasGet && Prop.HasSet)
        {
            Sb.AppendLine(" { get; set; }");
        }
        else if (Prop.HasGet)
        {
            Sb.AppendLine(" { get; private set; }");
        }
        else
        {
            Sb.AppendLine(" { set; }");
        }
    }

    private static void WriteMethodWithBody(StringBuilder Sb, DecompiledMethod Method, string Indent, Func<string, string>? ApiMapper)
    {
        if (Method.Name == ".ctor")
        {
            return;
        }

        Sb.Append(Indent).Append(Method.Visibility).Append(' ');
        if (Method.IsStatic)
        {
            Sb.Append("static ");
        }

        if (Method.IsVirtual && !Method.IsAbstract)
        {
            Sb.Append("virtual ");
        }

        var RetType = SimplifyTypeName(Method.ReturnType);
        Sb.Append(RetType).Append(' ').Append(Method.Name).Append('(');
        WriteParams(Sb, Method.Parameters);
        Sb.AppendLine(")");
        Sb.Append(Indent).AppendLine("{");

        if (Method.IlBody.Length > 0)
        {
            var Body = Method.IlBody;
            if (ApiMapper is not null)
            {
                Body = ApiMapper(Body);
            }

            foreach (var Line in Body.Split('\n'))
            {
                if (Line.Trim().Length > 0)
                {
                    Sb.Append(Indent).Append("    ").AppendLine(Line.TrimEnd());
                }
            }
        }
        else
        {
            if (RetType == "Task")
            {
                Sb.Append(Indent).AppendLine("    return Task.CompletedTask;");
            }
            else if (RetType == "void")
            {
            }
            else if (RetType == "bool")
            {
                Sb.Append(Indent).AppendLine("    return false;");
            }
            else if (RetType == "int")
            {
                Sb.Append(Indent).AppendLine("    return 0;");
            }
            else if (RetType == "string")
            {
                Sb.Append(Indent).AppendLine("    return string.Empty;");
            }
            else
            {
                Sb.Append(Indent).AppendLine("    return default!;");
            }
        }

        Sb.Append(Indent).AppendLine("}");
        Sb.AppendLine();
    }

    private static void WriteParams(StringBuilder Sb, IReadOnlyList<DecompiledParameter> Params)
    {
        for (var I = 0; I < Params.Count; I++)
        {
            if (I > 0)
            {
                Sb.Append(", ");
            }

            Sb.Append(SimplifyTypeName(Params[I].TypeName)).Append(' ').Append(Params[I].Name);
        }
    }

    private string DecompileMethodBody(
        MetadataReader MetadataReader, PEReader PeReader,
        MethodDefinition Method, string MethodName,
        string ReturnType, IReadOnlyList<DecompiledParameter> Params,
        string DeclaringTypeName)
    {
        try
        {
            var Rva = Method.RelativeVirtualAddress;
            if (Rva == 0)
            {
                return string.Empty;
            }

            var Body = PeReader.GetMethodBody(Rva);
            var IlBytes = Body.GetILBytes();
            if (IlBytes is null || IlBytes.Length == 0)
            {
                return string.Empty;
            }

            return DecompileIlBytes(MetadataReader, IlBytes, ReturnType, Params, MethodName, DeclaringTypeName);
        }
        catch
        {
            return string.Empty;
        }
    }

    private string DecompileIlBytes(
        MetadataReader MetadataReader, byte[] Il,
        string ReturnType, IReadOnlyList<DecompiledParameter> Params,
        string MethodName, string DeclaringTypeName)
    {
        var Sb = new StringBuilder();
        var Pos = 0;
        var StringLiterals = new List<string>();
        var MethodCalls = new List<string>();
        var FieldRefs = new List<string>();

        while (Pos < Il.Length)
        {
            var OpCode = Il[Pos++];
            switch (OpCode)
            {
                case 0x00:
                    break;
                case 0x02:
                case 0x03:
                case 0x04:
                case 0x05:
                    break;
                case 0x06:
                case 0x07:
                case 0x08:
                case 0x09:
                    break;
                case 0x0A:
                case 0x0B:
                case 0x0C:
                case 0x0D:
                    break;
                case 0x14:
                    break;
                case 0x15:
                case 0x16:
                case 0x17:
                case 0x18:
                case 0x19:
                case 0x1A:
                case 0x1B:
                case 0x1C:
                case 0x1D:
                case 0x1E:
                    break;
                case 0x1F:
                    if (Pos < Il.Length)
                    {
                        Pos++;
                    }

                    break;
                case 0x20:
                    if (Pos + 3 < Il.Length)
                    {
                        Pos += 4;
                    }

                    break;
                case 0x21:
                    if (Pos + 7 < Il.Length)
                    {
                        Pos += 8;
                    }

                    break;
                case 0x25:
                    break;
                case 0x26:
                    break;
                case 0x28:
                case 0x6F:
                    if (Pos + 3 < Il.Length)
                    {
                        var Token = BitConverter.ToInt32(Il, Pos);
                        Pos += 4;
                        var CallTarget = ResolveToken(MetadataReader, Token);
                        MethodCalls.Add(CallTarget);
                    }

                    break;
                case 0x2A:
                    break;
                case 0x2B:
                    if (Pos < Il.Length)
                    {
                        Pos++;
                    }

                    break;
                case 0x2C:
                case 0x2D:
                case 0x2E:
                case 0x2F:
                case 0x30:
                case 0x31:
                case 0x32:
                case 0x33:
                case 0x34:
                case 0x35:
                case 0x36:
                case 0x37:
                case 0x38:
                case 0x39:
                case 0x3A:
                case 0x3B:
                case 0x3C:
                case 0x3D:
                case 0x3E:
                case 0x3F:
                case 0x40:
                case 0x41:
                case 0x42:
                case 0x43:
                case 0x44:
                    if (Pos + 3 < Il.Length)
                    {
                        Pos += 4;
                    }

                    break;
                case 0x45:
                    if (Pos + 3 < Il.Length)
                    {
                        var Count = BitConverter.ToInt32(Il, Pos);
                        Pos += 4 + (Count * 4);
                    }

                    break;
                case 0x58:
                case 0x59:
                case 0x5A:
                case 0x5B:
                case 0x5F:
                case 0x60:
                case 0x61:
                case 0x62:
                case 0x63:
                    break;
                case 0x72:
                    if (Pos + 3 < Il.Length)
                    {
                        var Token = BitConverter.ToInt32(Il, Pos);
                        Pos += 4;
                        var Str = ResolveStringToken(MetadataReader, Token);
                        StringLiterals.Add(Str);
                    }

                    break;
                case 0x73:
                    if (Pos + 3 < Il.Length)
                    {
                        var Token = BitConverter.ToInt32(Il, Pos);
                        Pos += 4;
                        var CtorTarget = ResolveToken(MetadataReader, Token);
                        MethodCalls.Add("new:" + CtorTarget);
                    }

                    break;
                case 0x7B:
                case 0x7C:
                case 0x7D:
                case 0x7E:
                case 0x80:
                    if (Pos + 3 < Il.Length)
                    {
                        var Token = BitConverter.ToInt32(Il, Pos);
                        Pos += 4;
                        var FieldRef = ResolveToken(MetadataReader, Token);
                        FieldRefs.Add(FieldRef);
                    }

                    break;
                case 0x8C:
                case 0x8D:
                case 0xA3:
                case 0xA4:
                    if (Pos + 3 < Il.Length)
                    {
                        Pos += 4;
                    }

                    break;
                case 0xD0:
                    if (Pos + 3 < Il.Length)
                    {
                        Pos += 4;
                    }

                    break;
                case 0xFE:
                    if (Pos < Il.Length)
                    {
                        var SubOp = Il[Pos++];
                        if (SubOp is 0x06 or 0x09 or 0x0C)
                        {
                            if (Pos + 1 < Il.Length)
                            {
                                Pos += 2;
                            }
                        }
                    }

                    break;
                default:
                    if (Pos + 3 < Il.Length && OpCode is >= 0x70 and <= 0x75)
                    {
                        Pos += 4;
                    }

                    break;
            }
        }

        Sb.AppendLine("// Decompiled from IL");
        Sb.AppendFormat(CultureInfo.InvariantCulture, "// Method: {0} IL size: {1} bytes", MethodName, Il.Length);
        Sb.AppendLine();
        Sb.AppendFormat(CultureInfo.InvariantCulture, "// Strings: {0}, Method calls: {1}, Field refs: {2}",
            StringLiterals.Count, MethodCalls.Count, FieldRefs.Count);
        Sb.AppendLine();

        if (StringLiterals.Count > 0)
        {
            foreach (var S in StringLiterals)
            {
                Sb.AppendFormat(CultureInfo.InvariantCulture, "// String: \"{0}\"", S.Length > 80 ? S[..77] + "..." : S);
                Sb.AppendLine();
            }
        }

        if (MethodCalls.Count > 0)
        {
            foreach (var M in MethodCalls.Distinct())
            {
                Sb.AppendFormat(CultureInfo.InvariantCulture, "// Calls: {0}", M);
                Sb.AppendLine();
            }
        }

        if (FieldRefs.Count > 0)
        {
            foreach (var F in FieldRefs.Distinct())
            {
                Sb.AppendFormat(CultureInfo.InvariantCulture, "// Field: {0}", F);
                Sb.AppendLine();
            }
        }

        var SimpleRet = SimplifyTypeName(ReturnType);
        if (SimpleRet == "Task")
        {
            Sb.AppendLine("return Task.CompletedTask;");
        }
        else if (SimpleRet == "void")
        {
        }
        else if (SimpleRet == "bool")
        {
            Sb.AppendLine("return false;");
        }
        else if (SimpleRet == "int")
        {
            Sb.AppendLine("return 0;");
        }
        else if (SimpleRet == "string")
        {
            Sb.AppendLine("return string.Empty;");
        }
        else if (SimpleRet.EndsWith("?", StringComparison.Ordinal))
        {
            Sb.AppendLine("return null;");
        }
        else
        {
            Sb.AppendLine("return default!;");
        }

        return Sb.ToString();
    }

    private static string ResolveToken(MetadataReader MetadataReader, int Token)
    {
        try
        {
            var Handle = MetadataTokens.EntityHandle(Token);
            if (Handle.Kind == HandleKind.MethodDefinition)
            {
                var Method = MetadataReader.GetMethodDefinition((MethodDefinitionHandle)Handle);
                var TypeDef = MetadataReader.GetTypeDefinition(Method.GetDeclaringType());
                var TypeName = MetadataReader.GetString(TypeDef.Name);
                var MethodName = MetadataReader.GetString(Method.Name);
                return string.Concat(TypeName, ".", MethodName);
            }

            if (Handle.Kind == HandleKind.MemberReference)
            {
                var MemberRef = MetadataReader.GetMemberReference((MemberReferenceHandle)Handle);
                var MemberName = MetadataReader.GetString(MemberRef.Name);
                var ParentName = GetHandleName(MetadataReader, MemberRef.Parent);
                return string.Concat(SimplifyTypeName(ParentName), ".", MemberName);
            }

            if (Handle.Kind == HandleKind.FieldDefinition)
            {
                var Field = MetadataReader.GetFieldDefinition((FieldDefinitionHandle)Handle);
                return MetadataReader.GetString(Field.Name);
            }

            return string.Format(CultureInfo.InvariantCulture, "token:0x{0:X8}", Token);
        }
        catch
        {
            return string.Format(CultureInfo.InvariantCulture, "token:0x{0:X8}", Token);
        }
    }

    private static string ResolveStringToken(MetadataReader MetadataReader, int Token)
    {
        try
        {
            var Handle = MetadataTokens.UserStringHandle(Token & 0x00FFFFFF);
            return MetadataReader.GetUserString(Handle);
        }
        catch
        {
            return string.Format(CultureInfo.InvariantCulture, "string:0x{0:X8}", Token);
        }
    }

    private static string GetHandleName(MetadataReader MetadataReader, EntityHandle Handle)
    {
        if (Handle.IsNil)
        {
            return string.Empty;
        }

        try
        {
            if (Handle.Kind == HandleKind.TypeReference)
            {
                var TypeRef = MetadataReader.GetTypeReference((TypeReferenceHandle)Handle);
                var Name = MetadataReader.GetString(TypeRef.Name);
                var Ns = MetadataReader.GetString(TypeRef.Namespace);
                return Ns.Length > 0 ? string.Concat(Ns, ".", Name) : Name;
            }

            if (Handle.Kind == HandleKind.TypeDefinition)
            {
                var TypeDef = MetadataReader.GetTypeDefinition((TypeDefinitionHandle)Handle);
                var Name = MetadataReader.GetString(TypeDef.Name);
                var Ns = MetadataReader.GetString(TypeDef.Namespace);
                return Ns.Length > 0 ? string.Concat(Ns, ".", Name) : Name;
            }

            if (Handle.Kind == HandleKind.TypeSpecification)
            {
                var TypeSpec = MetadataReader.GetTypeSpecification((TypeSpecificationHandle)Handle);
                return DecodeTypeSpec(MetadataReader, TypeSpec);
            }

            return string.Format(CultureInfo.InvariantCulture, "handle:{0}", Handle.Kind);
        }
        catch
        {
            return "unknown";
        }
    }

    private static string DecodeTypeSpec(MetadataReader MetadataReader, TypeSpecification TypeSpec)
    {
        try
        {
            var Reader = MetadataReader.GetBlobReader(TypeSpec.Signature);
            return DecodeTypeFromSignature(MetadataReader, ref Reader);
        }
        catch
        {
            return "object";
        }
    }

    private static string DecodeFieldType(MetadataReader MetadataReader, FieldDefinition Field)
    {
        try
        {
            var Reader = MetadataReader.GetBlobReader(Field.Signature);
            Reader.ReadByte();
            return DecodeTypeFromSignature(MetadataReader, ref Reader);
        }
        catch
        {
            return "object";
        }
    }

    private static string DecodePropertyType(MetadataReader MetadataReader, PropertyDefinition Prop)
    {
        try
        {
            var Reader = MetadataReader.GetBlobReader(Prop.Signature);
            Reader.ReadByte();
            var ParamCount = Reader.ReadCompressedInteger();
            return DecodeTypeFromSignature(MetadataReader, ref Reader);
        }
        catch
        {
            return "object";
        }
    }

    private static string DecodeMethodReturnType(MetadataReader MetadataReader, MethodDefinition Method)
    {
        try
        {
            var Reader = MetadataReader.GetBlobReader(Method.Signature);
            var Header = Reader.ReadByte();
            var ParamCount = Reader.ReadCompressedInteger();
            return DecodeTypeFromSignature(MetadataReader, ref Reader);
        }
        catch
        {
            return "void";
        }
    }

    private static IReadOnlyList<DecompiledParameter> DecodeMethodParameters(MetadataReader MetadataReader, MethodDefinition Method)
    {
        var Params = new List<DecompiledParameter>();
        try
        {
            var Reader = MetadataReader.GetBlobReader(Method.Signature);
            var Header = Reader.ReadByte();
            var ParamCount = Reader.ReadCompressedInteger();
            DecodeTypeFromSignature(MetadataReader, ref Reader);

            var ParamHandles = Method.GetParameters().ToArray();
            for (var I = 0; I < ParamCount; I++)
            {
                var ParamType = DecodeTypeFromSignature(MetadataReader, ref Reader);
                var ParamName = string.Format(CultureInfo.InvariantCulture, "P{0}", I);

                if (I < ParamHandles.Length)
                {
                    var ParamDef = MetadataReader.GetParameter(ParamHandles[I]);
                    if (ParamDef.SequenceNumber > 0)
                    {
                        var Name = MetadataReader.GetString(ParamDef.Name);
                        if (Name.Length > 0)
                        {
                            ParamName = Name;
                        }
                    }
                }

                Params.Add(new DecompiledParameter(ParamName, ParamType));
            }
        }
        catch
        {
        }

        return Params;
    }

    private static string DecodeTypeFromSignature(MetadataReader MetadataReader, ref BlobReader Reader)
    {
        if (Reader.RemainingBytes == 0)
        {
            return "void";
        }

        var TypeCode = Reader.ReadByte();

        return TypeCode switch
        {
            0x01 => "void",
            0x02 => "bool",
            0x03 => "char",
            0x04 => "sbyte",
            0x05 => "byte",
            0x06 => "short",
            0x07 => "ushort",
            0x08 => "int",
            0x09 => "uint",
            0x0A => "long",
            0x0B => "ulong",
            0x0C => "float",
            0x0D => "double",
            0x0E => "string",
            0x0F => DecodeTypeFromSignature(MetadataReader, ref Reader) + "*",
            0x10 => DecodeTypeFromSignature(MetadataReader, ref Reader) + "&",
            0x11 => DecodeTypeDefOrRef(MetadataReader, ref Reader),
            0x12 => DecodeTypeDefOrRef(MetadataReader, ref Reader),
            0x14 => DecodeArray(MetadataReader, ref Reader),
            0x15 => DecodeGenericInst(MetadataReader, ref Reader),
            0x1C => "object",
            0x1D => DecodeTypeFromSignature(MetadataReader, ref Reader) + "[]",
            0x1E => "IntPtr",
            0x1F => "UIntPtr",
            _ => "object"
        };
    }

    private static string DecodeTypeDefOrRef(MetadataReader MetadataReader, ref BlobReader Reader)
    {
        var Coded = Reader.ReadCompressedInteger();
        var Tag = Coded & 0x03;
        var RowNumber = Coded >> 2;

        EntityHandle Handle = Tag switch
        {
            0 => MetadataTokens.TypeDefinitionHandle(RowNumber),
            1 => MetadataTokens.TypeReferenceHandle(RowNumber),
            2 => MetadataTokens.TypeSpecificationHandle(RowNumber),
            _ => default
        };

        return Handle.IsNil ? "object" : GetHandleName(MetadataReader, Handle);
    }

    private static string DecodeGenericInst(MetadataReader MetadataReader, ref BlobReader Reader)
    {
        var ElementType = Reader.ReadByte();
        var TypeName = DecodeTypeDefOrRef(MetadataReader, ref Reader);
        var ArgCount = Reader.ReadCompressedInteger();
        var Args = new List<string>();

        for (var I = 0; I < ArgCount; I++)
        {
            Args.Add(DecodeTypeFromSignature(MetadataReader, ref Reader));
        }

        return string.Format(CultureInfo.InvariantCulture, "{0}<{1}>", SimplifyTypeName(TypeName), string.Join(", ", Args.Select(SimplifyTypeName)));
    }

    private static string DecodeArray(MetadataReader MetadataReader, ref BlobReader Reader)
    {
        var ElementType = DecodeTypeFromSignature(MetadataReader, ref Reader);
        return ElementType + "[]";
    }

    private static string ReadConstantValue(MetadataReader MetadataReader, FieldDefinition Field)
    {
        try
        {
            var ConstHandle = Field.GetDefaultValue();
            if (ConstHandle.IsNil)
            {
                return string.Empty;
            }

            var Constant = MetadataReader.GetConstant(ConstHandle);
            var Reader = MetadataReader.GetBlobReader(Constant.Value);

            return Constant.TypeCode switch
            {
                ConstantTypeCode.Int32 => Reader.ReadInt32().ToString(CultureInfo.InvariantCulture),
                ConstantTypeCode.Int64 => Reader.ReadInt64().ToString(CultureInfo.InvariantCulture),
                ConstantTypeCode.UInt32 => Reader.ReadUInt32().ToString(CultureInfo.InvariantCulture),
                ConstantTypeCode.Byte => Reader.ReadByte().ToString(CultureInfo.InvariantCulture),
                ConstantTypeCode.Int16 => Reader.ReadInt16().ToString(CultureInfo.InvariantCulture),
                ConstantTypeCode.String => string.Concat("\"", Reader.ReadUTF16(Reader.Length).Replace("\\", "\\\\").Replace("\"", "\\\""), "\""),
                ConstantTypeCode.Boolean => Reader.ReadBoolean() ? "true" : "false",
                _ => string.Empty
            };
        }
        catch
        {
            return string.Empty;
        }
    }

    public static string SimplifyTypeName(string FullName)
    {
        return FullName switch
        {
            "System.Void" => "void",
            "System.Boolean" => "bool",
            "System.Char" => "char",
            "System.SByte" => "sbyte",
            "System.Byte" => "byte",
            "System.Int16" => "short",
            "System.UInt16" => "ushort",
            "System.Int32" => "int",
            "System.UInt32" => "uint",
            "System.Int64" => "long",
            "System.UInt64" => "ulong",
            "System.Single" => "float",
            "System.Double" => "double",
            "System.String" => "string",
            "System.Object" => "object",
            "System.IntPtr" => "nint",
            "System.UIntPtr" => "nuint",
            "System.Nullable`1<System.Boolean>" => "bool?",
            "System.Threading.Tasks.Task" => "Task",
            "System.EventHandler" => "EventHandler",
            "System.Action" => "Action",
            "System.DateTimeOffset" => "DateTimeOffset",
            "System.Collections.Generic.List`1<System.String>" => "List<string>",
            "System.Collections.Generic.IReadOnlyList`1<System.String>" => "IReadOnlyList<string>",
            "System.Collections.Generic.HashSet`1<System.String>" => "HashSet<string>",
            "System.Collections.Generic.Dictionary`2<System.String, System.String>" => "Dictionary<string, string>",
            _ => SimplifyTypeNameFallback(FullName)
        };
    }

    private static string SimplifyTypeNameFallback(string FullName)
    {
        if (FullName.StartsWith("System.Collections.Generic.IReadOnlyList`1<", StringComparison.Ordinal))
        {
            var Inner = FullName["System.Collections.Generic.IReadOnlyList`1<".Length..^1];
            return string.Concat("IReadOnlyList<", SimplifyTypeName(Inner), ">");
        }

        if (FullName.StartsWith("System.Collections.Generic.List`1<", StringComparison.Ordinal))
        {
            var Inner = FullName["System.Collections.Generic.List`1<".Length..^1];
            return string.Concat("List<", SimplifyTypeName(Inner), ">");
        }

        if (FullName.StartsWith("System.Nullable`1<", StringComparison.Ordinal))
        {
            var Inner = FullName["System.Nullable`1<".Length..^1];
            return SimplifyTypeName(Inner) + "?";
        }

        if (FullName.StartsWith("System.Threading.Tasks.Task`1<", StringComparison.Ordinal))
        {
            var Inner = FullName["System.Threading.Tasks.Task`1<".Length..^1];
            return string.Concat("Task<", SimplifyTypeName(Inner), ">");
        }

        var Cleaned = FullName;
        var BacktickIdx = Cleaned.IndexOf('`');
        if (BacktickIdx >= 0)
        {
            var AngleIdx = Cleaned.IndexOf('<', BacktickIdx);
            if (AngleIdx >= 0)
            {
                Cleaned = Cleaned[..BacktickIdx] + Cleaned[AngleIdx..];
            }
            else
            {
                Cleaned = Cleaned[..BacktickIdx];
            }
        }

        var LastDot = Cleaned.LastIndexOf('.');
        return LastDot >= 0 ? Cleaned[(LastDot + 1)..] : Cleaned;
    }

    private static void CollectUsings(string TypeName, HashSet<string> Usings)
    {
        if (TypeName.Contains("Task", StringComparison.Ordinal))
        {
            Usings.Add("System.Threading.Tasks");
        }

        if (TypeName.Contains("List", StringComparison.Ordinal) ||
            TypeName.Contains("IReadOnlyList", StringComparison.Ordinal) ||
            TypeName.Contains("Dictionary", StringComparison.Ordinal) ||
            TypeName.Contains("HashSet", StringComparison.Ordinal))
        {
            Usings.Add("System.Collections.Generic");
        }
    }

    private static bool IsAccessor(string Name)
    {
        return Name.StartsWith("get_", StringComparison.Ordinal) ||
               Name.StartsWith("set_", StringComparison.Ordinal) ||
               Name.StartsWith("add_", StringComparison.Ordinal) ||
               Name.StartsWith("remove_", StringComparison.Ordinal);
    }

    private static string ToPascalCase(string Value)
    {
        if (Value.Length == 0)
        {
            return Value;
        }

        return char.ToUpperInvariant(Value[0]) + Value[1..];
    }
}

public sealed class DecompiledAssembly
{
    public string Name { get; }
    public List<DecompiledType> Types { get; } = [];

    public DecompiledAssembly(string Name) => this.Name = Name;
}

public sealed record DecompiledType(
    string FullName,
    string TypeName,
    string TypeNamespace,
    bool IsInterface,
    bool IsEnum,
    bool IsStatic,
    bool IsSealed,
    bool IsRecord,
    string BaseTypeName,
    List<string> Interfaces,
    List<DecompiledField> Fields,
    List<DecompiledProperty> Properties,
    List<DecompiledMethod> Methods,
    List<DecompiledEvent> Events,
    List<string> NestedTypes);

public sealed record DecompiledField(
    string Name,
    string TypeName,
    bool IsStatic,
    bool IsConst,
    bool IsReadonly,
    string ConstValue);

public sealed record DecompiledProperty(
    string Name,
    string TypeName,
    bool HasGet,
    bool HasSet);

public sealed record DecompiledMethod(
    string Name,
    string ReturnType,
    IReadOnlyList<DecompiledParameter> Parameters,
    bool IsStatic,
    bool IsPublic,
    bool IsVirtual,
    bool IsAbstract,
    string Visibility,
    string IlBody);

public sealed record DecompiledParameter(string Name, string TypeName);

public sealed record DecompiledEvent(string Name, string TypeName);
