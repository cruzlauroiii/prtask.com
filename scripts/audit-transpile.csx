using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var WasmDir = @"C:\work\prtask.com\src\PocketPay.Wasm\Decompiled";

var Zip = ZipFile.OpenRead(ApkPath);

// Count DEX classes
var TotalDexClasses = 0;
var TotalDexMethods = 0;
var DexFiles = 0;
foreach (var Entry in Zip.Entries)
{
    if (!Entry.Name.EndsWith(".dex")) continue;
    DexFiles++;
    var Stream = Entry.Open();
    var Ms = new MemoryStream();
    Stream.CopyTo(Ms);
    var Dex = Ms.ToArray();
    Stream.Dispose();
    if (Dex.Length < 112) continue;
    var ClassCount = BitConverter.ToInt32(Dex, 96);
    var MethodCount = BitConverter.ToInt32(Dex, 88);
    TotalDexClasses += ClassCount;
    TotalDexMethods += MethodCount;
    Console.WriteLine($"  {Entry.FullName}: {ClassCount} classes, {MethodCount} method IDs");
}

// Count decompiled files
var DecompiledFiles = Directory.GetFiles(WasmDir, "*.cs", SearchOption.AllDirectories);
var TypesCount = Directory.GetFiles(Path.Combine(WasmDir, "Types"), "*.cs", SearchOption.TopDirectoryOnly).Length;
var ContractsCount = Directory.GetFiles(Path.Combine(WasmDir, "Contracts"), "*.cs", SearchOption.TopDirectoryOnly).Length;
var EnumsCount = Directory.GetFiles(Path.Combine(WasmDir, "Enums"), "*.cs", SearchOption.TopDirectoryOnly).Length;

// Count methods with bodies vs stubs
var MethodsWithBodies = 0;
var StubMethods = 0;
var EmptyBodies = 0;
foreach (var F in DecompiledFiles)
{
    var Lines = File.ReadAllLines(F);
    for (var I = 0; I < Lines.Length; I++)
    {
        var Line = Lines[I].Trim();
        if (Line.StartsWith("public ") && Line.Contains("(") && Line.EndsWith(")"))
        {
            if (I + 2 < Lines.Length && Lines[I+1].Trim() == "{")
            {
                var Body = Lines[I+2].Trim();
                if (Body == "}" || Body == "")
                    EmptyBodies++;
                else if (Body.StartsWith("return default") || Body.StartsWith("return 0") || Body.StartsWith("return false") || Body.StartsWith("return string.Empty"))
                    StubMethods++;
                else
                    MethodsWithBodies++;
            }
        }
    }
}

// Count assets
var AssetCount = 0;
var AssetBytes = 0L;
foreach (var Entry in Zip.Entries)
{
    if (Entry.FullName.StartsWith("assets/") && !Entry.FullName.EndsWith("/"))
    {
        AssetCount++;
        AssetBytes += Entry.Length;
    }
}

// Count native libs
var NativeLibs = 0;
foreach (var Entry in Zip.Entries)
{
    if (Entry.FullName.StartsWith("lib/") && Entry.Name.EndsWith(".so"))
        NativeLibs++;
}

Console.WriteLine();
Console.WriteLine("=== APK CONTENT ===");
Console.WriteLine($"DEX files:          {DexFiles}");
Console.WriteLine($"Total classes:      {TotalDexClasses}");
Console.WriteLine($"Total method IDs:   {TotalDexMethods}");
Console.WriteLine($"Assets:             {AssetCount} ({AssetBytes / 1024} KB)");
Console.WriteLine($"Native .so libs:    {NativeLibs}");
Console.WriteLine();
Console.WriteLine("=== TRANSPILED OUTPUT ===");
Console.WriteLine($"Decompiled files:   {DecompiledFiles.Length}");
Console.WriteLine($"  Types:            {TypesCount}");
Console.WriteLine($"  Contracts:        {ContractsCount}");
Console.WriteLine($"  Enums:            {EnumsCount}");
Console.WriteLine();
Console.WriteLine("=== METHOD COVERAGE ===");
Console.WriteLine($"Methods with real bodies:   {MethodsWithBodies}");
Console.WriteLine($"Stub methods (return default): {StubMethods}");
Console.WriteLine($"Empty void methods:         {EmptyBodies}");
Console.WriteLine();
Console.WriteLine("=== GAPS ===");
Console.WriteLine($"Classes in APK:     {TotalDexClasses}");
Console.WriteLine($"Classes decompiled: {DecompiledFiles.Length}");
Console.WriteLine($"Missing classes:    {TotalDexClasses - DecompiledFiles.Length}");
Console.WriteLine($"Coverage:           {(DecompiledFiles.Length * 100.0 / TotalDexClasses):F1}%");
Console.WriteLine();

// Check for unmapped Java types
var UnmappedTypes = new HashSet<string>();
foreach (var F in DecompiledFiles)
{
    foreach (var Line in File.ReadAllLines(F))
    {
        var Trimmed = Line.Trim();
        foreach (var Token in new[] { "HashMap", "ArrayMap", "Context", "IsoDep", "Iterator", "Scheduler", "Single", "URL", "BigInteger", "SimpleDateFormat", "KProperty" })
        {
            if (Trimmed.Contains(Token))
                UnmappedTypes.Add(Token);
        }
    }
}
Console.WriteLine($"Unmapped Java types found: {string.Join(", ", UnmappedTypes.OrderBy(T => T))}");

// Check duplicate method signatures
var DuplicateCount = 0;
foreach (var F in DecompiledFiles)
{
    var Sigs = new List<string>();
    foreach (var Line in File.ReadAllLines(F))
    {
        var Trimmed = Line.Trim();
        if (Trimmed.StartsWith("public ") && Trimmed.Contains("(") && Trimmed.EndsWith(")"))
        {
            if (Sigs.Contains(Trimmed))
                DuplicateCount++;
            Sigs.Add(Trimmed);
        }
    }
}
Console.WriteLine($"Duplicate method signatures: {DuplicateCount}");

Zip.Dispose();
