namespace PrTask.Domain.Constants;
public static class ApkConstants
{
    public const string CommandName = "apk-to-blazor";
    public const string UsageMessage = "Usage: apk-to-blazor <path-to-apk> [output-dir] [namespace]";
    public const string ApkNotFoundFormat = "APK not found: {0}";
    public const string ExtractingFormat = "Extracting APK: {0}";
    public const string OutputDirectoryFormat = "Output directory: {0}";
    public const string NamespaceFormat = "Namespace: {0}";
    public const string AssemblyStoreFoundFormat = "Assembly store found: {0} ({1} bytes)";
    public const string AssemblyExtractedFormat = "  Extracted: {0} ({1} bytes)";
    public const string AssemblyDecompressedFormat = "  Decompressed: {0} ({1} -> {2} bytes)";
    public const string WwwrootCopiedFormat = "Copied {0} wwwroot assets";
    public const string ProjectGeneratedFormat = "Blazor WASM project generated at: {0}";
    public const string TotalAssembliesFormat = "Total assemblies extracted: {0}";
    public const string NoAssemblyStoreMessage = "No assembly store found in APK";
    public const string InvalidApkMessage = "File is not a valid APK/ZIP archive";
    public const string ConversionCompleteFormat = "APK to Blazor WASM conversion complete: {0}";
    public const string ServiceStubGeneratedFormat = "Generated service stub: {0}";
    public const string SkippedSystemAssemblyFormat = "  Skipped system assembly: {0}";
    public const string ElfPayloadNotFoundFormat = "ELF payload section not found in: {0}";
    public const string XabaInvalidMagicFormat = "Invalid XABA magic: 0x{0:X8} (expected 0x{1:X8})";
    public const string CssExtractedFormat = "Extracted CSS: {0}";

    public const string ApkExtension = ".apk";
    public const string DllExtension = ".dll";
    public const string PdbExtension = ".pdb";
    public const string SoExtension = ".so";
    public const string RazorExtension = ".razor";
    public const string CsExtension = ".cs";
    public const string CsprojExtension = ".csproj";
    public const string CssExtension = ".css";

    public const string AssetsWwwrootPrefix = "assets/wwwroot/";
    public const string LibPrefix = "lib/";
    public const string AssemblyStoreFileName = "libassembly-store.so";
    public const string AssembliesBlobPrefix = "libassemblies.";
    public const string AssembliesBlobSuffix = ".blob.so";
    public const string AssembliesDirectoryPrefix = "assemblies/";
    public const string AssembliesBlobName = "assemblies.blob";
    public const string IndividualDllSoPrefix = "lib_";
    public const string IndividualDllSoSuffix = ".dll.so";
    public const string IndividualPdbSoSuffix = ".pdb.so";
    public const string Arm64Directory = "arm64-v8a";
    public const string X8664Directory = "x86_64";

    public const uint XabaMagic = 0x41424158;
    public const uint XalzMagic = 0x5A4C4158;
    public const int XabaHeaderSize = 20;
    public const int XabaDescriptorSize = 28;
    public const int XalzHeaderSize = 12;

    public const byte ElfMagic0 = 0x7F;
    public const byte ElfMagic1 = 0x45;
    public const byte ElfMagic2 = 0x4C;
    public const byte ElfMagic3 = 0x46;
    public const byte ElfClass64 = 2;
    public const int Elf64HeaderSize = 64;
    public const int Elf64SectionHeaderSize = 64;
    public const int Elf64ShOffsetPosition = 40;
    public const int Elf64ShEntSizePosition = 58;
    public const int Elf64ShNumPosition = 60;
    public const int Elf64ShStrNdxPosition = 62;
    public const int Elf64ShNamePosition = 0;
    public const int Elf64ShOffsetFieldPosition = 24;
    public const int Elf64ShSizeFieldPosition = 32;
    public const string ElfPayloadSectionName = "payload";

    public const string BlazorProjectSdk = "Microsoft.NET.Sdk.BlazorWebAssembly";
    public const string BlazorTargetFramework = "net11.0";
    public const string BlazorWasmPackageId = "Microsoft.AspNetCore.Components.WebAssembly";
    public const string BlazorWasmPackageVersion = "11.0.0-preview.2.26159.112";
    public const string BlazorDevServerPackageId = "Microsoft.AspNetCore.Components.WebAssembly.DevServer";
    public const string BlazorDevServerPackageVersion = "11.0.0-preview.2.26159.112";
    public const string BlazorRootSelector = "#app";

    public const string ProgramFileName = "Program.cs";
    public const string AppRazorFileName = "App.razor";
    public const string ImportsRazorFileName = "_Imports.razor";
    public const string IndexRazorFileName = "Index.razor";
    public const string IndexHtmlFileName = "index.html";
    public const string AppCssFileName = "app.css";
    public const string MainLayoutFileName = "MainLayout.razor";
    public const string NotFoundRazorFileName = "NotFound.razor";

    public const string PagesDirectory = "Pages";
    public const string LayoutDirectory = "Layout";
    public const string ServicesDirectory = "Services";
    public const string ModelsDirectory = "Models";
    public const string WwwrootDirectory = "wwwroot";
    public const string CssDirectory = "css";
    public const string ExtractedDirectory = "Extracted";

    public const string SystemAssemblyPrefix = "System.";
    public const string MicrosoftAssemblyPrefix = "Microsoft.";
    public const string MonoAssemblyPrefix = "Mono.";
    public const string JavaInteropAssemblyPrefix = "Java.Interop";
    public const string XamarinAssemblyPrefix = "Xamarin.";
    public const string NetstandardAssembly = "netstandard";
    public const string MscorlibAssembly = "mscorlib";
    public const string AndroidAssemblyPrefix = "Mono.Android";

    public const ushort PeMagicMz = 0x5A4D;

    public const string DefaultAppTitle = "Willow Maze";
    public const string DefaultNamespace = "WillowMaze.Wasm";

    public const string NoWarnList = "$(NoWarn);SYSLIB0057;SA0001;SA1122;SA1134;SA1402;SA1407;SA1503;SA1520;SA1633;CS1591;PT003;PT004;PT005;PT006;PT007;CA1002;CA1416;CA1422;CA1834;CA1865;CA2016;CA2227;CA5359;CA5394;IDE0007;IDE0011;IDE0017;IDE0021;IDE0022;IDE0023;IDE0024;IDE0025;IDE0026;IDE0027;IDE0028;IDE0031;IDE0032;IDE0046;IDE0047;IDE0048;IDE0059;IDE0072;IDE0078;IDE0130;IDE0200;IDE0270;IDE0290;IDE0300;IDE0301;IDE0305;IDE0330;IDE1006;MA0016;MA0028;MA0075;MA0099;MA0101;MA0132;MA0140;MA0158;MA0159;RCS1003;CA1859;RCS1036;RCS1075;RCS1077;RCS1085;RCS1118;RCS1123;RCS1136;RCS1161;RCS1170;RCS1179;RCS1181;RCS1192;RCS1197;RCS1201;RCS1214;RCS1235;RCS1239;RCS1266;RCS1267;S108;S127;S1075;S1144;S1186;S1481;S1854;S1871;S1905;S2486;S2681;S3063;S3358;S3457;S3459;S3626;S4830;IL2026;IL2046;IL2050;IL2055;IL2057;IL2060;IL2072;IL2075;IL2077;IL2091;IL3050";
}
