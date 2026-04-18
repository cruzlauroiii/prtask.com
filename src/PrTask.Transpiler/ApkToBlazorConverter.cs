using System.Buffers.Binary;
using System.Globalization;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed class ApkToBlazorConverter
{
    private readonly string ApkPath;
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly string AppTitle;

    public ApkToBlazorConverter(string ApkPath, string OutputDir, string Namespace, string AppTitle)
    {
        this.ApkPath = ApkPath;
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.AppTitle = AppTitle;
    }

    public ApkConversionResult Convert()
    {
        var Result = new ApkConversionResult();

        try
        {
            using var Archive = ZipFile.OpenRead(ApkPath);

            var ExtractedDir = Path.Combine(OutputDir, ApkConstants.ExtractedDirectory);
            Directory.CreateDirectory(ExtractedDir);

            var WwwrootCount = ExtractWwwrootAssets(Archive, OutputDir);
            Result.WwwrootAssetCount = WwwrootCount;

            var Assemblies = ExtractAssemblies(Archive, ExtractedDir);
            Result.AssemblyCount = Assemblies.Count;

            if (Assemblies.Count == 0 && Archive.Entries.Any(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)))
            {
                var DexConverter = new DexToBlazorConverter(ApkPath, OutputDir, Namespace, AppTitle);
                return DexConverter.Convert();
            }

            var AppAssemblies = ClassifyAssemblies(Assemblies, ExtractedDir);
            Result.AppAssemblyCount = AppAssemblies.Count;

            var TypeMap = AnalyzeAssemblies(AppAssemblies);
            Result.TypeCount = TypeMap.Count;

            GenerateBlazorProject(AppAssemblies, TypeMap);

            Result.Success = true;
        }
        catch (InvalidDataException)
        {
            Console.Error.WriteLine(ApkConstants.InvalidApkMessage);
        }

        return Result;
    }

    private static int ExtractWwwrootAssets(ZipArchive Archive, string OutputDir)
    {
        var Count = 0;
        var WwwrootDir = Path.Combine(OutputDir, ApkConstants.WwwrootDirectory);

        foreach (var Entry in Archive.Entries)
        {
            if (!Entry.FullName.StartsWith(ApkConstants.AssetsWwwrootPrefix, StringComparison.Ordinal))
            {
                continue;
            }

            var RelativePath = Entry.FullName[ApkConstants.AssetsWwwrootPrefix.Length..];
            if (RelativePath.Length == 0)
            {
                continue;
            }

            if (RelativePath.EndsWith('/'))
            {
                continue;
            }

            var TargetPath = Path.Combine(WwwrootDir, RelativePath.Replace('/', Path.DirectorySeparatorChar));
            var TargetDir = Path.GetDirectoryName(TargetPath);
            if (TargetDir is not null)
            {
                Directory.CreateDirectory(TargetDir);
            }

            Entry.ExtractToFile(TargetPath, overwrite: true);
            Count++;
        }

        return Count;
    }

    private static List<ExtractedAssembly> ExtractAssemblies(ZipArchive Archive, string ExtractedDir)
    {
        var Assemblies = new List<ExtractedAssembly>();

        var IndividualDlls = ExtractIndividualElfDlls(Archive, ExtractedDir);
        if (IndividualDlls.Count > 0)
        {
            Assemblies.AddRange(IndividualDlls);
            return Assemblies;
        }

        var StoreEntry = FindAssemblyStore(Archive);
        if (StoreEntry is not null)
        {
            var StoreBytes = ReadEntryBytes(StoreEntry);
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.AssemblyStoreFoundFormat, StoreEntry.FullName, StoreBytes.Length));

            byte[] PayloadBytes;
            if (IsElfBinary(StoreBytes))
            {
                PayloadBytes = ExtractElfPayload(StoreBytes, StoreEntry.FullName);
            }
            else
            {
                PayloadBytes = StoreBytes;
            }

            if (PayloadBytes.Length > 0)
            {
                ParseXabaStore(PayloadBytes, ExtractedDir, Assemblies);
            }

            return Assemblies;
        }

        foreach (var Entry in Archive.Entries)
        {
            if (!Entry.FullName.StartsWith(ApkConstants.AssembliesDirectoryPrefix, StringComparison.Ordinal))
            {
                continue;
            }

            if (!Entry.Name.EndsWith(ApkConstants.DllExtension, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var DllBytes = ReadEntryBytes(Entry);
            var DllName = Entry.Name;

            if (IsXalzCompressed(DllBytes))
            {
                DllBytes = DecompressXalz(DllBytes);
            }

            var OutputPath = Path.Combine(ExtractedDir, DllName);
            File.WriteAllBytes(OutputPath, DllBytes);
            Assemblies.Add(new ExtractedAssembly(DllName, OutputPath, DllBytes.Length));
        }

        return Assemblies;
    }

    private static List<ExtractedAssembly> ExtractIndividualElfDlls(ZipArchive Archive, string ExtractedDir)
    {
        var Result = new List<ExtractedAssembly>();
        var PreferredArch = ApkConstants.Arm64Directory;
        var Seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var Entry in Archive.Entries)
        {
            if (!Entry.FullName.StartsWith(ApkConstants.LibPrefix, StringComparison.Ordinal))
            {
                continue;
            }

            if (!Entry.Name.StartsWith(ApkConstants.IndividualDllSoPrefix, StringComparison.Ordinal) ||
                !Entry.Name.EndsWith(ApkConstants.IndividualDllSoSuffix, StringComparison.Ordinal))
            {
                continue;
            }

            if (!Entry.FullName.Contains(PreferredArch, StringComparison.Ordinal))
            {
                continue;
            }

            var AsmName = Entry.Name[ApkConstants.IndividualDllSoPrefix.Length..^ApkConstants.IndividualDllSoSuffix.Length];
            if (!Seen.Add(AsmName))
            {
                continue;
            }

            var ElfBytes = ReadEntryBytes(Entry);
            byte[] DllBytes;

            if (IsElfBinary(ElfBytes))
            {
                DllBytes = ExtractElfPayload(ElfBytes, Entry.FullName);
                if (DllBytes.Length == 0)
                {
                    DllBytes = ExtractElfDotNetSection(ElfBytes);
                }

                if (DllBytes.Length == 0)
                {
                    DllBytes = ElfBytes;
                }
            }
            else
            {
                DllBytes = ElfBytes;
            }

            if (IsXalzCompressed(DllBytes))
            {
                DllBytes = DecompressXalz(DllBytes);
            }

            var FileName = AsmName + ApkConstants.DllExtension;
            var OutputPath = Path.Combine(ExtractedDir, FileName);
            File.WriteAllBytes(OutputPath, DllBytes);

            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.AssemblyExtractedFormat, FileName, DllBytes.Length));
            Result.Add(new ExtractedAssembly(FileName, OutputPath, DllBytes.Length));
        }

        return Result;
    }

    private static byte[] ExtractElfDotNetSection(byte[] ElfData)
    {
        var Is64 = ElfData.Length > 5 && ElfData[4] == ApkConstants.ElfClass64;

        int ShOff;
        int ShEntSize;
        int ShNum;
        int ShStrNdx;
        int ShOffsetField;
        int ShSizeField;

        if (Is64)
        {
            ShOff = (int)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShOffsetPosition));
            ShEntSize = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShEntSizePosition));
            ShNum = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShNumPosition));
            ShStrNdx = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShStrNdxPosition));
            ShOffsetField = ApkConstants.Elf64ShOffsetFieldPosition;
            ShSizeField = ApkConstants.Elf64ShSizeFieldPosition;
        }
        else
        {
            ShOff = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(32));
            ShEntSize = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(46));
            ShNum = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(48));
            ShStrNdx = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(50));
            ShOffsetField = 16;
            ShSizeField = 20;
        }

        if (ShOff == 0 || ShNum == 0 || ShStrNdx >= ShNum)
        {
            return [];
        }

        var StrTabHeaderOff = ShOff + (ShStrNdx * ShEntSize);
        int StrTabOff;
        int StrTabSize;

        if (Is64)
        {
            StrTabOff = (int)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShOffsetField));
            StrTabSize = (int)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShSizeField));
        }
        else
        {
            StrTabOff = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShOffsetField));
            StrTabSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShSizeField));
        }

        for (var I = 0; I < ShNum; I++)
        {
            var HeaderOff = ShOff + (I * ShEntSize);
            var NameIdx = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff));
            var SectionName = ReadNullTerminatedString(ElfData, StrTabOff + NameIdx, StrTabOff + StrTabSize);

            if (!SectionName.Equals("payload", StringComparison.Ordinal) &&
                !SectionName.Equals(".managed", StringComparison.Ordinal) &&
                !SectionName.Equals(".rodata", StringComparison.Ordinal))
            {
                continue;
            }

            int SectionOff;
            int SectionSize;

            if (Is64)
            {
                SectionOff = (int)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(HeaderOff + ShOffsetField));
                SectionSize = (int)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(HeaderOff + ShSizeField));
            }
            else
            {
                SectionOff = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff + ShOffsetField));
                SectionSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff + ShSizeField));
            }

            if (SectionSize < 2 || SectionOff + SectionSize > ElfData.Length)
            {
                continue;
            }

            var PeMagic = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(SectionOff));
            if (PeMagic == ApkConstants.PeMagicMz)
            {
                var Payload = new byte[SectionSize];
                Buffer.BlockCopy(ElfData, SectionOff, Payload, 0, SectionSize);
                return Payload;
            }
        }

        return [];
    }

    private static ZipArchiveEntry? FindAssemblyStore(ZipArchive Archive)
    {
        foreach (var Entry in Archive.Entries)
        {
            if (!Entry.FullName.StartsWith(ApkConstants.LibPrefix, StringComparison.Ordinal))
            {
                continue;
            }

            if (Entry.Name.Equals(ApkConstants.AssemblyStoreFileName, StringComparison.Ordinal) ||
                (Entry.Name.StartsWith(ApkConstants.AssembliesBlobPrefix, StringComparison.Ordinal) &&
                 Entry.Name.EndsWith(ApkConstants.AssembliesBlobSuffix, StringComparison.Ordinal)))
            {
                return Entry;
            }
        }

        foreach (var Entry in Archive.Entries)
        {
            if (Entry.FullName.StartsWith(ApkConstants.AssembliesDirectoryPrefix, StringComparison.Ordinal) &&
                Entry.Name.Equals(ApkConstants.AssembliesBlobName, StringComparison.Ordinal))
            {
                return Entry;
            }
        }

        return null;
    }

    private static bool IsElfBinary(byte[] Data)
    {
        return Data.Length > ApkConstants.Elf64HeaderSize &&
               Data[0] == ApkConstants.ElfMagic0 &&
               Data[1] == ApkConstants.ElfMagic1 &&
               Data[2] == ApkConstants.ElfMagic2 &&
               Data[3] == ApkConstants.ElfMagic3;
    }

    private static byte[] ExtractElfPayload(byte[] ElfData, string SourceName)
    {
        var Is64 = ElfData[4] == ApkConstants.ElfClass64;
        if (!Is64)
        {
            return ExtractElfPayload32(ElfData, SourceName);
        }

        var ShOff = (long)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShOffsetPosition));
        var ShEntSize = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShEntSizePosition));
        var ShNum = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShNumPosition));
        var ShStrNdx = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ApkConstants.Elf64ShStrNdxPosition));

        if (ShOff == 0 || ShNum == 0 || ShStrNdx >= ShNum)
        {
            Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ElfPayloadNotFoundFormat, SourceName));
            return [];
        }

        var StrTabHeaderOff = ShOff + ((long)ShStrNdx * ShEntSize);
        var StrTabOff = (long)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan((int)StrTabHeaderOff + ApkConstants.Elf64ShOffsetFieldPosition));
        var StrTabSize = (long)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan((int)StrTabHeaderOff + ApkConstants.Elf64ShSizeFieldPosition));

        for (var I = 0; I < ShNum; I++)
        {
            var HeaderOff = ShOff + ((long)I * ShEntSize);
            var NameIdx = BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan((int)HeaderOff + ApkConstants.Elf64ShNamePosition));

            var SectionName = ReadNullTerminatedString(ElfData, (int)(StrTabOff + NameIdx), (int)(StrTabOff + StrTabSize));
            if (!SectionName.Equals(ApkConstants.ElfPayloadSectionName, StringComparison.Ordinal))
            {
                continue;
            }

            var SectionOff = (long)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan((int)HeaderOff + ApkConstants.Elf64ShOffsetFieldPosition));
            var SectionSize = (long)BinaryPrimitives.ReadUInt64LittleEndian(ElfData.AsSpan((int)HeaderOff + ApkConstants.Elf64ShSizeFieldPosition));

            var Payload = new byte[SectionSize];
            Buffer.BlockCopy(ElfData, (int)SectionOff, Payload, 0, (int)SectionSize);
            return Payload;
        }

        Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ElfPayloadNotFoundFormat, SourceName));
        return [];
    }

    private static byte[] ExtractElfPayload32(byte[] ElfData, string SourceName)
    {
        const int ShOffPos32 = 32;
        const int ShEntSizePos32 = 46;
        const int ShNumPos32 = 48;
        const int ShStrNdxPos32 = 50;
        const int ShNamePos32 = 0;
        const int ShOffsetField32 = 16;
        const int ShSizeField32 = 20;

        var ShOff = BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(ShOffPos32));
        var ShEntSize = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ShEntSizePos32));
        var ShNum = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ShNumPos32));
        var ShStrNdx = BinaryPrimitives.ReadUInt16LittleEndian(ElfData.AsSpan(ShStrNdxPos32));

        if (ShOff == 0 || ShNum == 0 || ShStrNdx >= ShNum)
        {
            Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ElfPayloadNotFoundFormat, SourceName));
            return [];
        }

        var StrTabHeaderOff = (int)(ShOff + ((uint)ShStrNdx * ShEntSize));
        var StrTabOff = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShOffsetField32));
        var StrTabSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(StrTabHeaderOff + ShSizeField32));

        for (var I = 0; I < ShNum; I++)
        {
            var HeaderOff = (int)(ShOff + ((uint)I * ShEntSize));
            var NameIdx = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff + ShNamePos32));

            var SectionName = ReadNullTerminatedString(ElfData, StrTabOff + NameIdx, StrTabOff + StrTabSize);
            if (!SectionName.Equals(ApkConstants.ElfPayloadSectionName, StringComparison.Ordinal))
            {
                continue;
            }

            var SectionOff = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff + ShOffsetField32));
            var SectionSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(ElfData.AsSpan(HeaderOff + ShSizeField32));

            var Payload = new byte[SectionSize];
            Buffer.BlockCopy(ElfData, SectionOff, Payload, 0, SectionSize);
            return Payload;
        }

        Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ElfPayloadNotFoundFormat, SourceName));
        return [];
    }

    private static void ParseXabaStore(byte[] Data, string ExtractedDir, List<ExtractedAssembly> Assemblies)
    {
        if (Data.Length < ApkConstants.XabaHeaderSize)
        {
            return;
        }

        var Magic = BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(0));
        if (Magic != ApkConstants.XabaMagic)
        {
            Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.XabaInvalidMagicFormat, Magic, ApkConstants.XabaMagic));
            return;
        }

        var EntryCount = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(8));
        var IndexEntryCount = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(12));
        var IndexSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(16));

        var DescriptorOffset = ApkConstants.XabaHeaderSize + IndexSize;

        for (var I = 0; I < EntryCount; I++)
        {
            var DescOff = DescriptorOffset + (I * ApkConstants.XabaDescriptorSize);
            if (DescOff + ApkConstants.XabaDescriptorSize > Data.Length)
            {
                break;
            }

            var DataOffset = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(DescOff + 4));
            var DataSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(DescOff + 8));

            if (DataOffset <= 0 || DataSize <= 0 || DataOffset + DataSize > Data.Length)
            {
                continue;
            }

            var AssemblyData = new byte[DataSize];
            Buffer.BlockCopy(Data, DataOffset, AssemblyData, 0, DataSize);

            var OriginalSize = DataSize;
            if (IsXalzCompressed(AssemblyData))
            {
                AssemblyData = DecompressXalz(AssemblyData);
            }

            var AssemblyName = GetAssemblyNameFromPe(AssemblyData);
            if (AssemblyName.Length == 0)
            {
                AssemblyName = string.Format(CultureInfo.InvariantCulture, "assembly_{0}", I);
            }

            var FileName = AssemblyName + ApkConstants.DllExtension;
            var OutputPath = Path.Combine(ExtractedDir, FileName);
            File.WriteAllBytes(OutputPath, AssemblyData);

            if (OriginalSize != AssemblyData.Length)
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.AssemblyDecompressedFormat, FileName, OriginalSize, AssemblyData.Length));
            }
            else
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.AssemblyExtractedFormat, FileName, AssemblyData.Length));
            }

            Assemblies.Add(new ExtractedAssembly(FileName, OutputPath, AssemblyData.Length));
        }
    }

    private static bool IsXalzCompressed(byte[] Data)
    {
        if (Data.Length < ApkConstants.XalzHeaderSize)
        {
            return false;
        }

        var Magic = BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(0));
        return Magic == ApkConstants.XalzMagic;
    }

    private static byte[] DecompressXalz(byte[] Data)
    {
        var UncompressedLength = (int)BinaryPrimitives.ReadUInt32LittleEndian(Data.AsSpan(8));
        var CompressedData = Data.AsSpan(ApkConstants.XalzHeaderSize);
        var Output = new byte[UncompressedLength];

        Lz4BlockDecompress(CompressedData, Output);
        return Output;
    }

    private static void Lz4BlockDecompress(ReadOnlySpan<byte> Source, Span<byte> Dest)
    {
        var SrcPos = 0;
        var DstPos = 0;

        while (SrcPos < Source.Length)
        {
            var Token = Source[SrcPos++];
            var LiteralLen = (Token >> 4) & 0x0F;

            if (LiteralLen == 15)
            {
                byte Extra;
                do
                {
                    Extra = Source[SrcPos++];
                    LiteralLen += Extra;
                } while (Extra == 255);
            }

            if (LiteralLen > 0)
            {
                Source.Slice(SrcPos, LiteralLen).CopyTo(Dest[DstPos..]);
                SrcPos += LiteralLen;
                DstPos += LiteralLen;
            }

            if (SrcPos >= Source.Length)
            {
                break;
            }

            var Offset = BinaryPrimitives.ReadUInt16LittleEndian(Source[SrcPos..]);
            SrcPos += 2;

            var MatchLen = (Token & 0x0F) + 4;

            if (MatchLen == 19)
            {
                byte Extra;
                do
                {
                    Extra = Source[SrcPos++];
                    MatchLen += Extra;
                } while (Extra == 255);
            }

            var MatchPos = DstPos - Offset;
            for (var J = 0; J < MatchLen; J++)
            {
                Dest[DstPos++] = Dest[MatchPos + J];
            }
        }
    }

    private static string GetAssemblyNameFromPe(byte[] Data)
    {
        if (Data.Length < 2)
        {
            return string.Empty;
        }

        var MagicMz = BinaryPrimitives.ReadUInt16LittleEndian(Data.AsSpan(0));
        if (MagicMz != ApkConstants.PeMagicMz)
        {
            return string.Empty;
        }

        try
        {
            using var Stream = new MemoryStream(Data, writable: false);
            using var PeReader = new PEReader(Stream);
            if (!PeReader.HasMetadata)
            {
                return string.Empty;
            }

            var MetadataReader = PeReader.GetMetadataReader();
            var AsmDef = MetadataReader.GetAssemblyDefinition();
            return MetadataReader.GetString(AsmDef.Name);
        }
        catch
        {
            return string.Empty;
        }
    }

    private static List<ExtractedAssembly> ClassifyAssemblies(List<ExtractedAssembly> All, string ExtractedDir)
    {
        var AppAssemblies = new List<ExtractedAssembly>();

        foreach (var Asm in All)
        {
            var BaseName = Path.GetFileNameWithoutExtension(Asm.FileName);
            if (IsSystemAssembly(BaseName))
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.SkippedSystemAssemblyFormat, Asm.FileName));
                continue;
            }

            AppAssemblies.Add(Asm);
        }

        return AppAssemblies;
    }

    private static bool IsSystemAssembly(string Name)
    {
        return Name.StartsWith(ApkConstants.SystemAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith(ApkConstants.MicrosoftAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith(ApkConstants.MonoAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith(ApkConstants.JavaInteropAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith(ApkConstants.XamarinAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith(ApkConstants.AndroidAssemblyPrefix, StringComparison.Ordinal) ||
               Name.StartsWith("GoogleGson", StringComparison.Ordinal) ||
               Name.StartsWith("Jsr305", StringComparison.Ordinal) ||
               Name.StartsWith("WindowsBase", StringComparison.Ordinal) ||
               Name.Equals(ApkConstants.NetstandardAssembly, StringComparison.Ordinal) ||
               Name.Equals(ApkConstants.MscorlibAssembly, StringComparison.Ordinal);
    }

    private static Dictionary<string, AssemblyTypeInfo> AnalyzeAssemblies(List<ExtractedAssembly> Assemblies)
    {
        var TypeMap = new Dictionary<string, AssemblyTypeInfo>(StringComparer.Ordinal);

        foreach (var Asm in Assemblies)
        {
            try
            {
                using var Stream = File.OpenRead(Asm.FilePath);
                using var PeReader = new PEReader(Stream);
                if (!PeReader.HasMetadata)
                {
                    continue;
                }

                var MetadataReader = PeReader.GetMetadataReader();
                var AsmName = MetadataReader.GetString(MetadataReader.GetAssemblyDefinition().Name);
                var Info = new AssemblyTypeInfo(AsmName);

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

                    var IsInterface = (TypeDef.Attributes & System.Reflection.TypeAttributes.Interface) != 0;
                    var FullName = TypeNamespace.Length > 0
                        ? string.Concat(TypeNamespace, ".", TypeName)
                        : TypeName;

                    var Methods = new List<string>();
                    foreach (var MethodHandle in TypeDef.GetMethods())
                    {
                        var Method = MetadataReader.GetMethodDefinition(MethodHandle);
                        var MethodName = MetadataReader.GetString(Method.Name);
                        if (!MethodName.StartsWith(".", StringComparison.Ordinal) &&
                            !MethodName.StartsWith("get_", StringComparison.Ordinal) &&
                            !MethodName.StartsWith("set_", StringComparison.Ordinal) &&
                            !MethodName.StartsWith("add_", StringComparison.Ordinal) &&
                            !MethodName.StartsWith("remove_", StringComparison.Ordinal))
                        {
                            Methods.Add(MethodName);
                        }
                    }

                    var Properties = new List<string>();
                    foreach (var PropHandle in TypeDef.GetProperties())
                    {
                        var Prop = MetadataReader.GetPropertyDefinition(PropHandle);
                        Properties.Add(MetadataReader.GetString(Prop.Name));
                    }

                    Info.Types.Add(new DiscoveredType(FullName, TypeName, TypeNamespace, IsInterface, Methods, Properties));
                }

                TypeMap[AsmName] = Info;
            }
            catch
            {
            }
        }

        return TypeMap;
    }

    private void GenerateBlazorProject(List<ExtractedAssembly> AppAssemblies, Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        Directory.CreateDirectory(OutputDir);
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.CssDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.PagesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.LayoutDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.ServicesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.ModelsDirectory));

        var PrimaryInterface = FindPrimaryServiceInterface(TypeMap);
        if (PrimaryInterface is not null &&
            PrimaryInterface.TypeName.Contains("Nfc", StringComparison.OrdinalIgnoreCase))
        {
            var FullGenerator = new NfcBlazorGenerator(OutputDir, Namespace, AppTitle, AppAssemblies);
            FullGenerator.Generate();
            return;
        }

        WriteCsproj();
        WriteProgram(TypeMap);
        WriteImports();
        WriteAppRazor();
        WriteMainLayout();
        WriteNotFoundPage();
        WriteIndexHtml();
        WriteCss();
        WriteServiceStubs(TypeMap);
        WriteModelFiles(TypeMap);
        WriteHomePage(TypeMap);
    }

    private void WriteCsproj()
    {
        var Sb = new StringBuilder();
        Sb.Append("<Project Sdk=\"").Append(ApkConstants.BlazorProjectSdk).AppendLine("\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.Append("    <TargetFramework>").Append(ApkConstants.BlazorTargetFramework).AppendLine("</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.Append("    <RootNamespace>").Append(Namespace).AppendLine("</RootNamespace>");
        Sb.Append("    <NoWarn>").Append(ApkConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("    <EnableTrimAnalyzer>false</EnableTrimAnalyzer>");
        Sb.AppendLine("    <TrimMode>partial</TrimMode>");
        Sb.AppendLine("    <StaticWebAssetsFingerprintContent>true</StaticWebAssetsFingerprintContent>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.Append("    <PackageReference Include=\"").Append(ApkConstants.BlazorWasmPackageId).Append("\" Version=\"").Append(ApkConstants.BlazorWasmPackageVersion).AppendLine("\" />");
        Sb.Append("    <PackageReference Include=\"").Append(ApkConstants.BlazorDevServerPackageId).Append("\" Version=\"").Append(ApkConstants.BlazorDevServerPackageVersion).AppendLine("\" PrivateAssets=\"all\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(OutputDir, Namespace + ApkConstants.CsprojExtension), Sb.ToString());
    }

    private void WriteProgram(Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using Microsoft.AspNetCore.Components.WebAssembly.Hosting;");
        Sb.Append("using ").Append(Namespace).Append('.').Append(ApkConstants.ServicesDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.AppendLine("var Builder = WebAssemblyHostBuilder.CreateDefault(args);");
        Sb.Append("Builder.RootComponents.Add<").Append(Namespace).Append(".App>(\"").Append(ApkConstants.BlazorRootSelector).AppendLine("\");");
        Sb.AppendLine("Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });");

        foreach (var Kvp in TypeMap)
        {
            foreach (var T in Kvp.Value.Types)
            {
                if (!T.IsInterface)
                {
                    continue;
                }

                if (!T.TypeName.StartsWith("I", StringComparison.Ordinal) || T.TypeName.Length < 2 || !char.IsUpper(T.TypeName[1]))
                {
                    continue;
                }

                var ImplName = T.TypeName[1..] + "Stub";
                Sb.Append("Builder.Services.AddSingleton<").Append(Namespace).Append('.').Append(ApkConstants.ServicesDirectory).Append('.').Append(T.TypeName);
                Sb.Append(", ").Append(Namespace).Append('.').Append(ApkConstants.ServicesDirectory).Append('.').Append(ImplName).AppendLine(">();");
            }
        }

        Sb.AppendLine("await Builder.Build().RunAsync();");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.ProgramFileName), Sb.ToString());
    }

    private void WriteImports()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Web");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Routing");
        Sb.AppendLine("@using Microsoft.JSInterop");
        Sb.Append("@using ").AppendLine(Namespace);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(ApkConstants.PagesDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(ApkConstants.LayoutDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(ApkConstants.ServicesDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(ApkConstants.ModelsDirectory);

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.ImportsRazorFileName), Sb.ToString());
    }

    private void WriteAppRazor()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Router AppAssembly=\"typeof(Program).Assembly\">");
        Sb.AppendLine("    <Found Context=\"routeData\">");
        Sb.Append("        <RouteView RouteData=\"routeData\" DefaultLayout=\"typeof(").Append(ApkConstants.LayoutDirectory).AppendLine(".MainLayout)\" />");
        Sb.AppendLine("    </Found>");
        Sb.AppendLine("    <NotFound>");
        Sb.Append("        <LayoutView Layout=\"typeof(").Append(ApkConstants.LayoutDirectory).AppendLine(".MainLayout)\">");
        Sb.AppendLine("            <p>Not found</p>");
        Sb.AppendLine("        </LayoutView>");
        Sb.AppendLine("    </NotFound>");
        Sb.AppendLine("</Router>");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.AppRazorFileName), Sb.ToString());
    }

    private void WriteMainLayout()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@inherits LayoutComponentBase");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"layout-frame\">");
        Sb.AppendLine("    @Body");
        Sb.AppendLine("</div>");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.LayoutDirectory, ApkConstants.MainLayoutFileName), Sb.ToString());
    }

    private void WriteNotFoundPage()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/notfound\"");
        Sb.AppendLine();
        Sb.Append("<h1>").Append(AppTitle).AppendLine("</h1>");
        Sb.AppendLine("<p>Page not found.</p>");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.PagesDirectory, ApkConstants.NotFoundRazorFileName), Sb.ToString());
    }

    private void WriteIndexHtml()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<!DOCTYPE html>");
        Sb.AppendLine("<html lang=\"en\">");
        Sb.AppendLine("<head>");
        Sb.AppendLine("    <meta charset=\"utf-8\" />");
        Sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no, viewport-fit=cover\" />");
        Sb.Append("    <title>").Append(AppTitle).AppendLine("</title>");
        Sb.AppendLine("    <base href=\"/\" />");
        Sb.AppendLine("    <link rel=\"icon\" href=\"data:,\" />");
        Sb.Append("    <link rel=\"stylesheet\" href=\"").Append(ApkConstants.CssDirectory).Append('/').Append(ApkConstants.AppCssFileName).AppendLine("\" />");
        Sb.Append("    <link rel=\"stylesheet\" href=\"").Append(Namespace).AppendLine(".styles.css\" />");
        Sb.AppendLine("</head>");
        Sb.AppendLine("<body>");
        Sb.Append("    <div id=\"app\">Loading ").Append(AppTitle).AppendLine("...</div>");
        Sb.AppendLine();
        Sb.AppendLine("    <div id=\"blazor-error-ui\">");
        Sb.AppendLine("        An unhandled error has occurred.");
        Sb.AppendLine("        <a href=\"\" class=\"reload\">Reload</a>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("    <script src=\"_framework/blazor.webassembly.js\" autostart=\"false\"></script>");
        Sb.AppendLine("    <script>Blazor.start();</script>");
        Sb.AppendLine("</body>");
        Sb.AppendLine("</html>");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.IndexHtmlFileName), Sb.ToString());
    }

    private void WriteCss()
    {
        var SourceCssPath = Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.AppCssFileName);
        if (File.Exists(SourceCssPath))
        {
            var TargetCssDir = Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.CssDirectory);
            Directory.CreateDirectory(TargetCssDir);
            File.Copy(SourceCssPath, Path.Combine(TargetCssDir, ApkConstants.AppCssFileName), overwrite: true);
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.CssExtractedFormat, ApkConstants.AppCssFileName));
            return;
        }

        var Sb = new StringBuilder();
        Sb.AppendLine(":root { --ink-0: #0f1722; --ink-1: #172334; --ink-2: #223247; --mint: #8cffd7; --rose: #ff8fb0; --gold: #ffd36e; --text: #edf6ff; --muted: #a6bbcf; }");
        Sb.AppendLine("html, body { margin: 0; padding: 0; background: var(--ink-0); color: var(--text); font-family: system-ui, -apple-system, sans-serif; }");
        Sb.AppendLine(".layout-frame { max-width: 72rem; margin: 0 auto; padding: 1.5rem; min-height: 100vh; }");
        Sb.AppendLine("h1, h2, h3 { color: var(--mint); }");
        Sb.AppendLine(".panel-card { background: var(--ink-1); border: 1px solid var(--ink-2); border-radius: 12px; padding: 1.25rem; margin-bottom: 1rem; }");
        Sb.AppendLine(".hero-card { background: linear-gradient(160deg, rgba(140,255,215,0.08), rgba(255,143,176,0.06)); border: 1px solid var(--ink-2); border-radius: 16px; padding: 1.5rem; margin-bottom: 1.5rem; }");
        Sb.AppendLine(".badge-row { display: flex; flex-wrap: wrap; gap: 0.5rem; }");
        Sb.AppendLine(".badge { background: var(--ink-2); color: var(--muted); padding: 0.25rem 0.75rem; border-radius: 999px; font-size: 0.8rem; }");
        Sb.AppendLine(".badge.on { background: rgba(140,255,215,0.15); color: var(--mint); }");
        Sb.AppendLine(".action { display: inline-flex; align-items: center; gap: 0.4rem; padding: 0.5rem 1.25rem; border: none; border-radius: 8px; cursor: pointer; font-weight: 600; font-size: 0.9rem; background: var(--ink-2); color: var(--text); }");
        Sb.AppendLine(".action.primary { background: linear-gradient(135deg, var(--mint), #5ce0b0); color: var(--ink-0); }");
        Sb.AppendLine(".action:hover { filter: brightness(1.15); }");
        Sb.AppendLine(".status-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(16rem, 1fr)); gap: 0.75rem; }");
        Sb.AppendLine(".form-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 0.75rem; }");
        Sb.AppendLine("@media (max-width: 640px) { .form-grid { grid-template-columns: 1fr; } }");
        Sb.AppendLine("input, select, textarea { background: var(--ink-0); color: var(--text); border: 1px solid var(--ink-2); border-radius: 6px; padding: 0.5rem 0.75rem; font-size: 0.9rem; }");
        Sb.AppendLine("pre, code { font-family: Consolas, 'Courier New', monospace; background: var(--ink-0); padding: 0.75rem; border-radius: 6px; overflow-x: auto; font-size: 0.85rem; color: var(--muted); }");
        Sb.AppendLine(".detail-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(18rem, 1fr)); gap: 0.75rem; }");
        Sb.AppendLine("#blazor-error-ui { background: #5a1a1a; color: #fca; padding: 0.5rem 1rem; position: fixed; bottom: 0; width: 100%; z-index: 9999; display: none; }");
        Sb.AppendLine("#blazor-error-ui .reload { color: var(--mint); }");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.CssDirectory, ApkConstants.AppCssFileName), Sb.ToString());
    }

    private void WriteServiceStubs(Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        foreach (var Kvp in TypeMap)
        {
            foreach (var T in Kvp.Value.Types)
            {
                if (!T.IsInterface)
                {
                    continue;
                }

                if (!T.TypeName.StartsWith("I", StringComparison.Ordinal) || T.TypeName.Length < 2 || !char.IsUpper(T.TypeName[1]))
                {
                    continue;
                }

                WriteInterfaceFile(T);
                WriteStubFile(T);
            }
        }
    }

    private void WriteInterfaceFile(DiscoveredType T)
    {
        var Sb = new StringBuilder();
        Sb.Append("namespace ").Append(Namespace).Append('.').Append(ApkConstants.ServicesDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("public interface ").AppendLine(T.TypeName);
        Sb.AppendLine("{");

        foreach (var Prop in T.Properties)
        {
            Sb.Append("    string ").Append(Prop).AppendLine(" { get; }");
        }

        if (T.Properties.Count > 0 && T.Methods.Count > 0)
        {
            Sb.AppendLine();
        }

        foreach (var Method in T.Methods)
        {
            if (Method.EndsWith("Async", StringComparison.Ordinal))
            {
                Sb.Append("    Task ").Append(Method).AppendLine("();");
            }
            else
            {
                Sb.Append("    void ").Append(Method).AppendLine("();");
            }
        }

        Sb.AppendLine("}");

        var FileName = T.TypeName + ApkConstants.CsExtension;
        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.ServicesDirectory, FileName), Sb.ToString());
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ServiceStubGeneratedFormat, FileName));
    }

    private void WriteStubFile(DiscoveredType T)
    {
        var ImplName = T.TypeName[1..] + "Stub";
        var Sb = new StringBuilder();
        Sb.Append("namespace ").Append(Namespace).Append('.').Append(ApkConstants.ServicesDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.Append("public sealed class ").Append(ImplName).Append(" : ").AppendLine(T.TypeName);
        Sb.AppendLine("{");
        Sb.AppendLine("    public event Action? Changed;");
        Sb.AppendLine();

        foreach (var Prop in T.Properties)
        {
            Sb.Append("    public string ").Append(Prop).AppendLine(" { get; private set; } = string.Empty;");
        }

        if (T.Properties.Count > 0 && T.Methods.Count > 0)
        {
            Sb.AppendLine();
        }

        foreach (var Method in T.Methods)
        {
            if (Method.EndsWith("Async", StringComparison.Ordinal))
            {
                Sb.Append("    public Task ").Append(Method).AppendLine("() => Task.CompletedTask;");
            }
            else
            {
                Sb.Append("    public void ").Append(Method).AppendLine("() { }");
            }
        }

        Sb.AppendLine("}");

        var FileName = ImplName + ApkConstants.CsExtension;
        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.ServicesDirectory, FileName), Sb.ToString());
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ServiceStubGeneratedFormat, FileName));
    }

    private void WriteModelFiles(Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        foreach (var Kvp in TypeMap)
        {
            foreach (var T in Kvp.Value.Types)
            {
                if (T.IsInterface || T.Properties.Count == 0)
                {
                    continue;
                }

                if (T.TypeNamespace.Contains("Services", StringComparison.Ordinal) ||
                    T.TypeNamespace.Contains("Platforms", StringComparison.Ordinal))
                {
                    continue;
                }

                var Sb = new StringBuilder();
                Sb.Append("namespace ").Append(Namespace).Append('.').Append(ApkConstants.ModelsDirectory).AppendLine(";");
                Sb.AppendLine();
                Sb.Append("public sealed record ").Append(T.TypeName).AppendLine("(");

                for (var I = 0; I < T.Properties.Count; I++)
                {
                    Sb.Append("    string ").Append(T.Properties[I]);
                    if (I < T.Properties.Count - 1)
                    {
                        Sb.AppendLine(",");
                    }
                    else
                    {
                        Sb.AppendLine(");");
                    }
                }

                var FileName = T.TypeName + ApkConstants.CsExtension;
                File.WriteAllText(Path.Combine(OutputDir, ApkConstants.ModelsDirectory, FileName), Sb.ToString());
            }
        }
    }

    private void WriteHomePage(Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        var ServiceInterface = FindPrimaryServiceInterface(TypeMap);

        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");

        if (ServiceInterface is not null)
        {
            Sb.Append("@inject ").Append(ServiceInterface.TypeName).AppendLine(" Workbench");
            Sb.AppendLine("@implements IDisposable");
        }

        Sb.AppendLine();
        Sb.Append("<h1>").Append(AppTitle).AppendLine("</h1>");
        Sb.AppendLine();

        if (ServiceInterface is not null)
        {
            Sb.AppendLine("<div class=\"hero-card\">");
            Sb.AppendLine("    <h2>Status</h2>");
            Sb.AppendLine("    <div class=\"badge-row\">");

            foreach (var Prop in ServiceInterface.Properties)
            {
                if (Prop.StartsWith("Is", StringComparison.Ordinal) || Prop.StartsWith("Supports", StringComparison.Ordinal))
                {
                    Sb.Append("        <span class=\"badge\">").Append(Prop).AppendLine("</span>");
                }
            }

            Sb.AppendLine("    </div>");
            Sb.AppendLine("</div>");
            Sb.AppendLine();

            Sb.AppendLine("<div class=\"panel-card\">");
            Sb.AppendLine("    <h2>Controls</h2>");
            Sb.AppendLine("    <div class=\"badge-row\">");

            foreach (var Method in ServiceInterface.Methods)
            {
                Sb.Append("        <button class=\"action\" @onclick=\"() => Invoke(nameof(Workbench.").Append(Method).Append("))\">").Append(Method).AppendLine("</button>");
            }

            Sb.AppendLine("    </div>");
            Sb.AppendLine("</div>");
            Sb.AppendLine();

            var TextProps = new List<string>();
            foreach (var Prop in ServiceInterface.Properties)
            {
                if (!Prop.StartsWith("Is", StringComparison.Ordinal) && !Prop.StartsWith("Supports", StringComparison.Ordinal))
                {
                    TextProps.Add(Prop);
                }
            }

            if (TextProps.Count > 0)
            {
                Sb.AppendLine("<div class=\"panel-card\">");
                Sb.AppendLine("    <h2>Details</h2>");
                Sb.AppendLine("    <div class=\"detail-grid\">");

                foreach (var Prop in TextProps)
                {
                    Sb.Append("        <div><strong>").Append(Prop).Append("</strong><br /><code>@Workbench.").Append(Prop).AppendLine("</code></div>");
                }

                Sb.AppendLine("    </div>");
                Sb.AppendLine("</div>");
            }

            Sb.AppendLine();
            Sb.AppendLine("<div class=\"panel-card\">");
            Sb.AppendLine("    <h2>Log</h2>");
            Sb.AppendLine("    <pre>@Log</pre>");
            Sb.AppendLine("</div>");
        }
        else
        {
            Sb.AppendLine("<div class=\"hero-card\">");
            Sb.AppendLine("    <h2>Ready</h2>");
            Sb.Append("    <p>").Append(AppTitle).AppendLine(" is running in the browser via WebAssembly.</p>");
            Sb.AppendLine("</div>");
        }

        Sb.AppendLine();
        Sb.AppendLine("@code {");

        if (ServiceInterface is not null)
        {
            Sb.AppendLine("    private string Log = string.Empty;");
            Sb.AppendLine();
            Sb.AppendLine("    protected override void OnInitialized()");
            Sb.AppendLine("    {");
            Sb.AppendLine("        if (Workbench is Services.NfcWorkbenchServiceStub Stub)");
            Sb.AppendLine("        {");
            Sb.AppendLine("            Stub.Changed += OnChanged;");
            Sb.AppendLine("        }");
            Sb.AppendLine("    }");
            Sb.AppendLine();
            Sb.AppendLine("    private void OnChanged() => InvokeAsync(StateHasChanged);");
            Sb.AppendLine();
            Sb.AppendLine("    private void Invoke(string MethodName)");
            Sb.AppendLine("    {");
            Sb.AppendLine("        Log = string.Concat(DateTime.UtcNow.ToString(\"HH:mm:ss\"), \" Invoked: \", MethodName, \"\\n\", Log);");
            Sb.AppendLine("        StateHasChanged();");
            Sb.AppendLine("    }");
            Sb.AppendLine();
            Sb.AppendLine("    public void Dispose()");
            Sb.AppendLine("    {");
            Sb.AppendLine("        if (Workbench is Services.NfcWorkbenchServiceStub Stub)");
            Sb.AppendLine("        {");
            Sb.AppendLine("            Stub.Changed -= OnChanged;");
            Sb.AppendLine("        }");
            Sb.AppendLine("    }");
        }

        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(OutputDir, ApkConstants.PagesDirectory, ApkConstants.IndexRazorFileName), Sb.ToString());
    }

    private static DiscoveredType? FindPrimaryServiceInterface(Dictionary<string, AssemblyTypeInfo> TypeMap)
    {
        DiscoveredType? Best = null;
        var BestScore = 0;

        foreach (var Kvp in TypeMap)
        {
            foreach (var T in Kvp.Value.Types)
            {
                if (!T.IsInterface)
                {
                    continue;
                }

                var Score = T.Methods.Count + T.Properties.Count;
                if (Score > BestScore)
                {
                    BestScore = Score;
                    Best = T;
                }
            }
        }

        return Best;
    }

    private static string ReadNullTerminatedString(byte[] Data, int Offset, int MaxOffset)
    {
        var Sb = new StringBuilder();
        for (var I = Offset; I < MaxOffset && I < Data.Length; I++)
        {
            if (Data[I] == 0)
            {
                break;
            }

            Sb.Append((char)Data[I]);
        }

        return Sb.ToString();
    }

    private static byte[] ReadEntryBytes(ZipArchiveEntry Entry)
    {
        using var Stream = Entry.Open();
        using var Ms = new MemoryStream();
        Stream.CopyTo(Ms);
        return Ms.ToArray();
    }
}

public sealed class ApkConversionResult
{
    public bool Success { get; set; }
    public int WwwrootAssetCount { get; set; }
    public int AssemblyCount { get; set; }
    public int AppAssemblyCount { get; set; }
    public int TypeCount { get; set; }
}

public sealed record ExtractedAssembly(string FileName, string FilePath, int Size);

public sealed class AssemblyTypeInfo
{
    public string AssemblyName { get; }
    public List<DiscoveredType> Types { get; } = [];

    public AssemblyTypeInfo(string AssemblyName)
    {
        this.AssemblyName = AssemblyName;
    }
}

public sealed record DiscoveredType(
    string FullName,
    string TypeName,
    string TypeNamespace,
    bool IsInterface,
    List<string> Methods,
    List<string> Properties);
