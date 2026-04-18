using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;

namespace PrTask.Transpiler;

public sealed class BinaryToSharpConverter
{
    private readonly string Namespace;

    public BinaryToSharpConverter(string Namespace)
    {
        this.Namespace = Namespace;
    }

    public bool ConvertFile(string FilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(FilePath);
        var ClassName = ToPascalCase(FileName);

        try
        {
            using var Stream = File.OpenRead(FilePath);
            using var PeReader = new PEReader(Stream);

            if (PeReader.HasMetadata)
            {
                return ConvertManagedAssembly(PeReader, ClassName, OutDir, FilePath);
            }

            return ConvertNativeBinary(ClassName, OutDir, FilePath);
        }
        catch
        {
            return false;
        }
    }

    private bool ConvertManagedAssembly(PEReader PeReader, string ClassName, string OutDir, string FilePath)
    {
        var MetadataReader = PeReader.GetMetadataReader();
        var Sb = new StringBuilder();
        var HasContent = false;
        var EscapedPath = FilePath.Replace("\\", "\\\\");

        Sb.Append("namespace ").Append(Namespace).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");
        Sb.Append("    private const string AsmPath = @\"").Append(EscapedPath).AppendLine("\";");
        Sb.AppendLine("    private static readonly global::System.Reflection.Assembly Asm = System.Reflection.Assembly.LoadFrom(AsmPath);");
        Sb.AppendLine("    private const global::System.Reflection.BindingFlags PublicStatic = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static;");
        Sb.AppendLine("    private const System.Reflection.BindingFlags PublicInstance = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance;");
        Sb.AppendLine("    private const System.Reflection.BindingFlags PublicAll = PublicInstance | PublicStatic;");
        Sb.AppendLine();

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

            var IsPublic = (TypeDef.Attributes & TypeAttributes.VisibilityMask) is TypeAttributes.Public;
            if (!IsPublic)
            {
                continue;
            }

            var FullTypeName = TypeNamespace.Length > 0
                ? string.Concat(TypeNamespace, ".", TypeName)
                : TypeName;

            var IsEnum = false;
            var BaseTypeHandle = TypeDef.BaseType;
            if (!BaseTypeHandle.IsNil)
            {
                var BaseTypeName = GetTypeName(MetadataReader, BaseTypeHandle);
                IsEnum = BaseTypeName == "System.Enum";
            }

            var IsInterface = (TypeDef.Attributes & TypeAttributes.Interface) == TypeAttributes.Interface;

            if (IsEnum)
            {
                Sb.Append("    internal enum ").AppendLine(ToPascalCase(TypeName));
                Sb.AppendLine("    {");
                foreach (var FieldHandle in TypeDef.GetFields())
                {
                    var Field = MetadataReader.GetFieldDefinition(FieldHandle);
                    var FieldName = MetadataReader.GetString(Field.Name);
                    if (FieldName == "value__")
                    {
                        continue;
                    }

                    Sb.Append("        ").Append(FieldName).AppendLine(",");
                }

                Sb.AppendLine("    }");
                Sb.AppendLine();
                HasContent = true;
                continue;
            }

            if (IsInterface)
            {
                continue;
            }

            var ProxyName = ToPascalCase(TypeName) + "Proxy";
            Sb.Append("    internal static class ").AppendLine(ProxyName);
            Sb.AppendLine("    {");
            Sb.Append("        private const string TypeFullName = \"").Append(FullTypeName).AppendLine("\";");
            Sb.AppendLine("        private static readonly global::System.Type T = Asm.GetType(TypeFullName)!;");
            Sb.AppendLine();

            var MethodConstants = new List<string>();

            foreach (var MethodHandle in TypeDef.GetMethods())
            {
                var Method = MetadataReader.GetMethodDefinition(MethodHandle);
                var MethodName = MetadataReader.GetString(Method.Name);

                if (MethodName.StartsWith("get_", StringComparison.Ordinal) ||
                    MethodName.StartsWith("set_", StringComparison.Ordinal) ||
                    MethodName.StartsWith("add_", StringComparison.Ordinal) ||
                    MethodName.StartsWith("remove_", StringComparison.Ordinal) ||
                    MethodName == ".cctor")
                {
                    continue;
                }

                var IsMethodPublic = (Method.Attributes & MethodAttributes.Public) is not MethodAttributes.PrivateScope;
                if (!IsMethodPublic)
                {
                    continue;
                }

                var IsMethodStatic = (Method.Attributes & MethodAttributes.Static) is not MethodAttributes.PrivateScope;

                if (MethodName == ".ctor")
                {
                    Sb.AppendLine("        internal static object Create(params object?[] Args)");
                    Sb.AppendLine("        {");
                    Sb.AppendLine("            var ArgTypes = Args.Length > 0 ? global::System.Array.ConvertAll(Args, A => A?.GetType() ?? typeof(object)) : System.Type.EmptyTypes;");
                    Sb.AppendLine("            var Ctor = T.GetConstructor(PublicInstance, ArgTypes);");
                    Sb.AppendLine("            return Ctor!.Invoke(Args);");
                    Sb.AppendLine("        }");
                    Sb.AppendLine();
                    HasContent = true;
                    continue;
                }

                var ConstName = string.Concat("Method", ToPascalCase(MethodName));
                if (!MethodConstants.Contains(ConstName))
                {
                    Sb.Append("        private const string ").Append(ConstName).Append(" = \"").Append(MethodName).AppendLine("\";");
                    MethodConstants.Add(ConstName);
                }

                if (IsMethodStatic)
                {
                    Sb.Append("        internal static object? ").Append(MethodName).AppendLine("(params object?[] Args)");
                    Sb.AppendLine("        {");
                    Sb.Append("            var M = T.GetMethod(").Append(ConstName).AppendLine(", PublicStatic);");
                    Sb.AppendLine("            return M?.Invoke(null, Args);");
                    Sb.AppendLine("        }");
                }
                else
                {
                    Sb.Append("        internal static object? ").Append(MethodName).AppendLine("(object Instance, params object?[] Args)");
                    Sb.AppendLine("        {");
                    Sb.Append("            var M = T.GetMethod(").Append(ConstName).AppendLine(", PublicInstance);");
                    Sb.AppendLine("            return M?.Invoke(Instance, Args);");
                    Sb.AppendLine("        }");
                }

                Sb.AppendLine();
                HasContent = true;
            }

            foreach (var PropertyHandle in TypeDef.GetProperties())
            {
                var Property = MetadataReader.GetPropertyDefinition(PropertyHandle);
                var PropName = MetadataReader.GetString(Property.Name);
                var PropConst = string.Concat("Prop", ToPascalCase(PropName));

                Sb.Append("        private const string ").Append(PropConst).Append(" = \"").Append(PropName).AppendLine("\";");

                Sb.Append("        internal static object? Get").Append(PropName).AppendLine("(object? Instance = null)");
                Sb.AppendLine("        {");
                Sb.Append("            var P = T.GetProperty(").Append(PropConst).AppendLine(", PublicAll);");
                Sb.AppendLine("            return P?.GetValue(Instance);");
                Sb.AppendLine("        }");
                Sb.AppendLine();

                Sb.Append("        internal static void Set").Append(PropName).AppendLine("(object Value, object? Instance = null)");
                Sb.AppendLine("        {");
                Sb.Append("            var P = T.GetProperty(").Append(PropConst).AppendLine(", PublicAll);");
                Sb.AppendLine("            P?.SetValue(Instance, Value);");
                Sb.AppendLine("        }");
                Sb.AppendLine();
                HasContent = true;
            }

            Sb.AppendLine("    }");
            Sb.AppendLine();
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

    private bool ConvertNativeBinary(string ClassName, string OutDir, string FilePath)
    {
        var X86Conv = new X86ToSharpConverter(Namespace);
        if (X86Conv.ConvertFile(FilePath, OutDir))
        {
            return true;
        }

        return ConvertNativeBinaryFallback(ClassName, OutDir, FilePath);
    }

    private bool ConvertNativeBinaryFallback(string ClassName, string OutDir, string FilePath)
    {
        var Sb = new StringBuilder();
        var HasContent = false;
        var EscapedPath = FilePath.Replace("\\", "\\\\");

        Sb.Append("namespace ").Append(Namespace).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");
        Sb.Append("    private const string LibPath = @\"").Append(EscapedPath).AppendLine("\";");
        Sb.AppendLine("    private static readonly nint LibHandle = global::System.Runtime.InteropServices.NativeLibrary.Load(LibPath);");
        Sb.AppendLine();

        try
        {
            using var Stream = File.OpenRead(FilePath);
            using var PeReader = new PEReader(Stream);
            var ExportDir = PeReader.PEHeaders.PEHeader?.ExportTableDirectory;
            if (ExportDir is { Size: > 0 })
            {
                var SectionData = PeReader.GetSectionData(ExportDir.Value.RelativeVirtualAddress);
                if (SectionData.Length > 0)
                {
                    var Reader = SectionData.GetReader();
                    Reader.ReadUInt32();
                    Reader.ReadUInt32();
                    Reader.ReadUInt16();
                    Reader.ReadUInt16();
                    Reader.ReadInt32();
                    Reader.ReadUInt32();
                    Reader.ReadInt32();
                    var NumberOfNames = Reader.ReadInt32();
                    Reader.ReadUInt32();
                    var NamePointerRva = Reader.ReadInt32();

                    if (NumberOfNames > 0 && NamePointerRva > 0)
                    {
                        var NameSection = PeReader.GetSectionData(NamePointerRva);
                        var NameReader = NameSection.GetReader();
                        var EmittedNames = new HashSet<string>(StringComparer.Ordinal);

                        for (var I = 0; I < NumberOfNames && I < 10000; I++)
                        {
                            var FuncNameRva = NameReader.ReadInt32();
                            var FuncNameData = PeReader.GetSectionData(FuncNameRva);
                            var FuncReader = FuncNameData.GetReader();
                            var NameBuilder = new StringBuilder();
                            byte B;
                            while ((B = FuncReader.ReadByte()) is not 0)
                            {
                                NameBuilder.Append((char)B);
                            }

                            var ExportName = NameBuilder.ToString();
                            var PascalName = ToPascalCase(ExportName);
                            if (ExportName.Length > 0 && char.IsLetter(ExportName[0]) && IsValidIdentifier(ExportName) && EmittedNames.Add(PascalName))
                            {
                                var ExportConst = string.Concat("Export", PascalName);
                                Sb.Append("    private const string ").Append(ExportConst).Append(" = \"").Append(ExportName).AppendLine("\";");
                                Sb.Append("    private static readonly nint Ptr").Append(PascalName)
                                  .Append(" = System.Runtime.InteropServices.NativeLibrary.GetExport(LibHandle, ").Append(ExportConst).AppendLine(");");
                                Sb.AppendLine();
                                Sb.Append("    internal static unsafe nint ").Append(PascalName).AppendLine("()")
                                  .Append("        => ((delegate* unmanaged<nint>)Ptr").Append(PascalName).AppendLine(")();");
                                Sb.AppendLine();
                                Sb.Append("    internal static unsafe nint ").Append(PascalName).AppendLine("(nint A0)")
                                  .Append("        => ((delegate* unmanaged<nint, nint>)Ptr").Append(PascalName).AppendLine(")(A0);");
                                Sb.AppendLine();
                                Sb.Append("    internal static unsafe nint ").Append(PascalName).AppendLine("(nint A0, nint A1)")
                                  .Append("        => ((delegate* unmanaged<nint, nint, nint>)Ptr").Append(PascalName).AppendLine(")(A0, A1);");
                                Sb.AppendLine();
                                Sb.Append("    internal static unsafe nint ").Append(PascalName).AppendLine("(nint A0, nint A1, nint A2)")
                                  .Append("        => ((delegate* unmanaged<nint, nint, nint, nint>)Ptr").Append(PascalName).AppendLine(")(A0, A1, A2);");
                                Sb.AppendLine();
                                Sb.Append("    internal static unsafe nint ").Append(PascalName).AppendLine("(nint A0, nint A1, nint A2, nint A3)")
                                  .Append("        => ((delegate* unmanaged<nint, nint, nint, nint, nint>)Ptr").Append(PascalName).AppendLine(")(A0, A1, A2, A3);");
                                Sb.AppendLine();

                                HasContent = true;
                            }
                        }
                    }
                }
            }
        }
        catch
        {
        }

        if (!HasContent)
        {
            Sb.Append("    internal const string SourcePath = @\"").Append(EscapedPath).AppendLine("\";");
        }

        if (FilePath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
        {
            Sb.AppendLine("    internal static global::System.Diagnostics.Process Run(params string[] Args)");
            Sb.AppendLine("    {");
            Sb.AppendLine("        var Psi = new global::System.Diagnostics.ProcessStartInfo");
            Sb.AppendLine("        {");
            Sb.AppendLine("            FileName = LibPath,");
            Sb.AppendLine("            UseShellExecute = false,");
            Sb.Append("            WorkingDirectory = global::System.IO.Path.GetDirectoryName(LibPath) ?? ").AppendLine("string.Empty,");
            Sb.AppendLine("        };");
            Sb.AppendLine("        foreach (var Arg in Args)");
            Sb.AppendLine("        {");
            Sb.AppendLine("            Psi.ArgumentList.Add(Arg);");
            Sb.AppendLine("        }");
            Sb.AppendLine("        return global::System.Diagnostics.Process.Start(Psi)!;");
            Sb.AppendLine("    }");
            Sb.AppendLine();
            Sb.AppendLine("    internal static global::System.Diagnostics.Process RunAndWait(params string[] Args)");
            Sb.AppendLine("    {");
            Sb.AppendLine("        var Proc = Run(Args);");
            Sb.AppendLine("        Proc.WaitForExit();");
            Sb.AppendLine("        return Proc;");
            Sb.AppendLine("    }");
            Sb.AppendLine();
        }

        Sb.AppendLine("}");

        var OutputPath = Path.Combine(OutDir, ClassName + ".g.cs");
        File.WriteAllText(OutputPath, Sb.ToString());
        return true;
    }

    private static string GetTypeName(MetadataReader Reader, EntityHandle Handle)
    {
        if (Handle.Kind == HandleKind.TypeReference)
        {
            var TypeRef = Reader.GetTypeReference((TypeReferenceHandle)Handle);
            return string.Concat(Reader.GetString(TypeRef.Namespace), ".", Reader.GetString(TypeRef.Name));
        }

        if (Handle.Kind == HandleKind.TypeDefinition)
        {
            var TypeDef = Reader.GetTypeDefinition((TypeDefinitionHandle)Handle);
            return string.Concat(Reader.GetString(TypeDef.Namespace), ".", Reader.GetString(TypeDef.Name));
        }

        return string.Empty;
    }

    private static bool IsValidIdentifier(string Name)
    {
        foreach (var Ch in Name)
        {
            if (!char.IsLetterOrDigit(Ch) && Ch is not '_')
            {
                return false;
            }
        }

        return true;
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
}
