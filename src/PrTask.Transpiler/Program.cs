using System.Globalization;
using PrTask.Domain.Constants;
using PrTask.Git;
using PrTask.Transpiler;

var Command = args.Length > 0 ? args[0] : string.Empty;

if (string.Equals(Command, ApkConstants.CommandName, StringComparison.OrdinalIgnoreCase))
{
    var ApkPath = args.Length > 1 ? args[1] : string.Empty;
    if (ApkPath.Length == 0 || !File.Exists(ApkPath))
    {
        Console.Error.WriteLine(ApkPath.Length == 0
            ? ApkConstants.UsageMessage
            : string.Format(CultureInfo.InvariantCulture, ApkConstants.ApkNotFoundFormat, ApkPath));
        return 1;
    }

    var ApkFileName = Path.GetFileNameWithoutExtension(ApkPath);
    var ApkOutputDir = args.Length > 2 ? args[2] : Path.Combine(Path.GetDirectoryName(ApkPath) ?? ".", ApkFileName + ".Wasm");
    var ApkNamespace = args.Length > 3 ? args[3] : ApkConstants.DefaultNamespace;

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ExtractingFormat, ApkPath));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.OutputDirectoryFormat, ApkOutputDir));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.NamespaceFormat, ApkNamespace));

    var ApkTitle = ApkNamespace.Replace(".Wasm", string.Empty).Replace(".", " ");
    var ApkConverter = new ApkToBlazorConverter(ApkPath, ApkOutputDir, ApkNamespace, ApkTitle);
    var ApkResult = ApkConverter.Convert();

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.WwwrootCopiedFormat, ApkResult.WwwrootAssetCount));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.TotalAssembliesFormat, ApkResult.AssemblyCount));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, ApkConstants.ConversionCompleteFormat, ApkOutputDir));

    return ApkResult.Success ? 0 : 1;
}

if (string.Equals(Command, BunConstants.ExtractCommandName, StringComparison.OrdinalIgnoreCase))
{
    var ExePath = args.Length > 1 ? args[1] : string.Empty;
    if (ExePath.Length == 0 || !File.Exists(ExePath))
    {
        Console.Error.WriteLine(BunConstants.ExePathRequiredMessage);
        return 1;
    }

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ExtractingFormat, ExePath));

    var Extractor = new BunExtractor();
    var Bundle = Extractor.ExtractBundle(ExePath);

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ModuleCountFormat, Bundle.Modules.Count));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.TotalBundleSizeFormat, Bundle.TotalSize));

    if (Bundle.EntryPointId >= 0 && Bundle.EntryPointId < Bundle.Modules.Count)
    {
        var EntryModule = Bundle.Modules[Bundle.EntryPointId];
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.EntryPointFormat, EntryModule.Name, Bundle.EntryPointId));
    }

    for (var I = 0; I < Bundle.Modules.Count; I++)
    {
        var Mod = Bundle.Modules[I];
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ModuleNameFormat, I, Mod.Name, Mod.SourceLength));
    }

    var OutputPath = Path.Combine(Path.GetDirectoryName(ExePath) ?? ".", BunConstants.ExtractedEntryPointFileName);
    if (Bundle.EntryPointId >= 0 && Bundle.EntryPointId < Bundle.Modules.Count)
    {
        File.WriteAllText(OutputPath, Bundle.Modules[Bundle.EntryPointId].Source);
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ExtractedToFormat, OutputPath));
    }

    var ReferencePath = BunConstants.DefaultReferenceSourcePath;
    if (File.Exists(ReferencePath))
    {
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ComparisonHeaderFormat, ReferencePath));
        var ComparisonResult = Extractor.CompareWithSource(Bundle, ReferencePath);

        if (ComparisonResult.IsMatch)
        {
            Console.WriteLine(BunConstants.ComparisonMatchMessage);
        }
        else
        {
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ComparisonSizeMismatchFormat, ComparisonResult.ExtractedSize, ComparisonResult.ReferenceSize));
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ComparisonContentMismatchFormat, ComparisonResult.FirstDifferenceOffset));
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ComparisonContextFormat, ComparisonResult.ExtractedContext));
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.ComparisonReferenceContextFormat, ComparisonResult.ReferenceContext));
        }
    }

    return 0;
}

if (string.Equals(Command, JsTranspilerConstants.JsTranspileCommandName, StringComparison.OrdinalIgnoreCase))
{
    var JsPath = args.Length > 1 ? args[1] : string.Empty;
    if (JsPath.Length == 0 || !File.Exists(JsPath))
    {
        Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.InputFileNotFoundFormat, JsPath));
        return 1;
    }

    var JsOutDir = args.Length > 2 ? args[2] : Path.Combine(Path.GetDirectoryName(JsPath) ?? ".", "Transpiled");
    var JsNamespace = args.Length > 3 ? args[3] : JsTranspilerConstants.DefaultNamespace;

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.ConvertingFormat, JsPath));

    var JsConverter = new JsToCSharpConverter();
    var JsResult = JsConverter.TranspileFile(JsPath, JsOutDir, JsNamespace);

    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.ConvertedCountFormat,
        JsResult.ClassCount, JsResult.FunctionCount, JsResult.ComponentCount));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.TranspileCompleteFormat,
        JsResult.FileCount, JsResult.LineCount));

    foreach (var Error in JsResult.Errors)
    {
        Console.Error.WriteLine(Error);
    }

    var ComponentOutDir = Path.Combine(JsOutDir, JsTranspilerConstants.ComponentsSubNamespace);
    var JsSource = File.ReadAllText(JsPath);
    var BlazorResults = JsConverter.GenerateBlazorComponents(JsSource, ComponentOutDir, JsNamespace);
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.GeneratedComponentsFormat,
        BlazorResults.Count, ComponentOutDir));

    var ProjectGenerator = new BlazorProjectGenerator(JsOutDir, JsNamespace, AnthropicConstants.GeneratedAppTitle, Path.GetDirectoryName(JsPath) ?? ".");
    ProjectGenerator.Generate();
    ProjectGenerator.GenerateClaudeCodeProject();
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, JsTranspilerConstants.BlazorProjectGeneratedFormat, JsOutDir));

    return JsResult.Success ? 0 : 1;
}

if (string.Equals(Command, "wss", StringComparison.OrdinalIgnoreCase))
{
    var EndpointsDir = args.Length > 1 ? args[1] : @"C:\work\prtask.com\src\PrTask.Server\Endpoints";
    var WssOutputDir = args.Length > 2 ? args[2] : @"C:\work\prtask.com\infra\cloudflare-worker\src";

    Console.WriteLine("Transpiling Server endpoints to Cloudflare WSS...");
    Console.WriteLine($"  Endpoints: {EndpointsDir}");
    Console.WriteLine($"  Output: {WssOutputDir}");

    var WssTranspiler = new ServerToWssTranspiler(EndpointsDir, WssOutputDir);
    WssTranspiler.Transpile();

    Console.WriteLine("Server-to-WSS transpilation complete.");
    return 0;
}

var SourcePath = Command.Length > 0 ? Command : @"C:\work\git";
var OutputDir = args.Length > 1 ? args[1] : string.Empty;
var Namespace = args.Length > 2 ? args[2] : string.Empty;
var SkipFile = args.Length > 3 ? args[3] : string.Empty;

if (File.Exists(SourcePath))
{
    var FileName = Path.GetFileNameWithoutExtension(SourcePath);
    if (OutputDir.Length == 0)
    {
        OutputDir = Path.Combine(Path.GetDirectoryName(SourcePath) ?? ".", FileName + ".Transpiled");
    }

    if (Namespace.Length == 0)
    {
        Namespace = FileName.Replace("-", string.Empty).Replace(".", string.Empty);
    }

    Directory.CreateDirectory(OutputDir);
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Transpiling binary: {0}", SourcePath));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Output directory: {0}", OutputDir));
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Namespace: {0}", Namespace));

    var BinaryConverter = new BinaryToSharpConverter(Namespace);
    var Success = BinaryConverter.ConvertFile(SourcePath, OutputDir);

    if (Success)
    {
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Successfully transpiled {0} to C# in {1}", SourcePath, OutputDir));
        return 0;
    }

    Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, "Failed to transpile binary: {0}", SourcePath));
    return 1;
}

// Otherwise treat source as a directory of C source files
var SourceDir = SourcePath;
if (OutputDir.Length == 0)
{
    OutputDir = @"C:\work\prtask.com\src\PrTask.Git\Generated";
}

if (Namespace.Length == 0)
{
    Namespace = "PrTask.Git.Generated";
}

if (!Directory.Exists(SourceDir))
{
    Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, "Source not found: {0}", SourceDir));
    return 1;
}

var GitDir = Path.Combine(SourceDir, ".git");
if (Directory.Exists(GitDir))
{
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Pulling latest from {0}...", SourceDir));
    try
    {
        var Repo = GitRepository.Open(SourceDir);
        var Remote = new GitRemote(Repo);
        await Remote.FetchAsync("origin");
        var CurrentBranch = Repo.GetCurrentBranch();
        if (CurrentBranch is not null)
        {
            var RemoteRef = Repo.ResolveRef(string.Concat("refs/remotes/origin/", CurrentBranch));
            if (RemoteRef is not null)
            {
                Repo.SetHead(RemoteRef);
            }
        }

        var CommitHash = Repo.GetHead();
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Source at commit: {0}", CommitHash ?? "unknown"));
    }
    catch (Exception Ex)
    {
        Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, "Pull failed (continuing with existing source): {0}", Ex.Message));
    }
}

Directory.CreateDirectory(OutputDir);

var SkipSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
if (SkipFile.Length > 0 && File.Exists(SkipFile))
{
    foreach (var Line in File.ReadAllLines(SkipFile))
    {
        var Trimmed = Line.Trim();
        if (Trimmed.Length > 0 && !Trimmed.StartsWith('#'))
        {
            SkipSet.Add(Trimmed);
        }
    }
}

var Converter = new CToSharpConverter(SourceDir, OutputDir, Namespace, SkipSet);
var ConvertedCount = Converter.ConvertAll();

Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Transpiled {0} files to C# in {1} (namespace: {2})", ConvertedCount, OutputDir, Namespace));
return 0;
