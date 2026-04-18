#load "DexParser_NoNs.csx"

using System.IO.Compression;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var OutputPath = @"C:\work\prtask.com\docs\pocketpay-request-models.md";

var TargetClasses = new[] { "pd239a801", "p1f723f91", "p3d06c92c" };
var DeviceStrings = new[] { "device_id", "deviceId", "androidId", "android_id" };

var Sb = new StringBuilder();
Sb.AppendLine("# PocketPay Request Models (Decompiled from DEX)");
Sb.AppendLine();

var FoundClasses = new List<(string DexName, DexClassDef Cls)>();
var DeviceClasses = new List<(string DexName, DexClassDef Cls)>();

var Zip = ZipFile.OpenRead(ApkPath);
var DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();
Console.WriteLine($"Found {DexEntries.Count} DEX files");

foreach (var Entry in DexEntries)
{
    Console.WriteLine($"Parsing {Entry.Name} ({Entry.Length} bytes)...");
    byte[] Data;
    using (var S = Entry.Open())
    using (var Ms = new MemoryStream())
    {
        S.CopyTo(Ms);
        Data = Ms.ToArray();
    }

    var Parser = new DexParser(Data);
    if (!Parser.Parse())
    {
        Console.WriteLine($"  FAILED to parse {Entry.Name}");
        continue;
    }

    Console.WriteLine($"  Classes: {Parser.ClassDefs.Count}, Strings: {Parser.StringIdsSize}, Fields: {Parser.FieldIdsSize}");

    foreach (var Cls in Parser.ClassDefs)
    {
        var NameLower = Cls.FullName.ToLowerInvariant();
        foreach (var Target in TargetClasses)
        {
            if (NameLower.Contains(Target.ToLowerInvariant()))
            {
                Console.WriteLine($"  FOUND TARGET: {Cls.FullName} in {Entry.Name}");
                FoundClasses.Add((Entry.Name, Cls));
            }
        }

        // Search for device-related data classes
        var HasDeviceField = false;
        foreach (var F in Cls.Fields)
        {
            foreach (var Ds in DeviceStrings)
            {
                if (F.Name.Equals(Ds, StringComparison.OrdinalIgnoreCase))
                {
                    HasDeviceField = true;
                    break;
                }
            }
            if (HasDeviceField) break;
        }

        // Also check if any method body references device strings
        if (!HasDeviceField)
        {
            foreach (var M in Cls.Methods)
            {
                if (string.IsNullOrEmpty(M.DecompiledBody)) continue;
                foreach (var Ds in DeviceStrings)
                {
                    if (M.DecompiledBody.Contains(Ds, StringComparison.OrdinalIgnoreCase))
                    {
                        HasDeviceField = true;
                        break;
                    }
                }
                if (HasDeviceField) break;
            }
        }

        if (HasDeviceField && !Cls.IsSystem && Cls.Fields.Count >= 2)
        {
            DeviceClasses.Add((Entry.Name, Cls));
        }
    }

    // Also search string table for @SerializedName patterns near target class names
    foreach (var Target in TargetClasses)
    {
        for (int I = 0; I < Parser.Strings.Length; I++)
        {
            if (Parser.Strings[I].Contains(Target, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"  String match for '{Target}' at index {I}: \"{Parser.Strings[I]}\"");
            }
        }
    }
}

void WriteClassDef(StringBuilder S, string DexName, DexClassDef Cls)
{
    S.AppendLine($"### `{Cls.FullName}`");
    S.AppendLine($"- **DEX**: {DexName}");
    S.AppendLine($"- **Super**: {Cls.SuperClass}");
    if (Cls.Interfaces.Count > 0)
        S.AppendLine($"- **Interfaces**: {string.Join(", ", Cls.Interfaces)}");
    S.AppendLine($"- **Flags**: Public={Cls.IsPublic}, Final={Cls.IsFinal}, Abstract={Cls.IsAbstract}");
    S.AppendLine();

    if (Cls.Fields.Count > 0)
    {
        S.AppendLine("#### Fields");
        S.AppendLine("| Name | Type | Static | Final | Public | Private |");
        S.AppendLine("|------|------|--------|-------|--------|---------|");
        foreach (var F in Cls.Fields)
        {
            S.AppendLine($"| `{F.Name}` | `{F.TypeName}` | {F.IsStatic} | {F.IsFinal} | {F.IsPublic} | {F.IsPrivate} |");
        }
        S.AppendLine();
    }

    if (Cls.Methods.Count > 0)
    {
        S.AppendLine("#### Methods");
        foreach (var M in Cls.Methods)
        {
            var Params = string.Join(", ", M.Proto.ParamTypes);
            S.AppendLine($"- `{M.Proto.ReturnType} {M.Name}({Params})` [static={M.IsStatic}, public={M.IsPublic}]");
            if (!string.IsNullOrEmpty(M.DecompiledBody))
            {
                S.AppendLine("  ```");
                foreach (var Line in M.DecompiledBody.Split('\n').Take(30))
                {
                    S.AppendLine($"  {Line.TrimEnd()}");
                }
                S.AppendLine("  ```");
            }
        }
        S.AppendLine();
    }
}

Sb.AppendLine("## Target Request Model Classes");
Sb.AppendLine();

if (FoundClasses.Count == 0)
{
    Sb.AppendLine("*No exact matches found for pd239a801, p1f723f91, p3d06c92c*");
    Sb.AppendLine();
}

foreach (var (DexName, Cls) in FoundClasses)
{
    WriteClassDef(Sb, DexName, Cls);
}

Sb.AppendLine("---");
Sb.AppendLine();
Sb.AppendLine("## Classes Referencing device_id / deviceId / androidId");
Sb.AppendLine();

Console.WriteLine($"\nDevice-related classes found: {DeviceClasses.Count}");
foreach (var (DexName, Cls) in DeviceClasses.Take(30))
{
    Console.WriteLine($"  {Cls.FullName} ({Cls.Fields.Count} fields) in {DexName}");
    WriteClassDef(Sb, DexName, Cls);
}

Directory.CreateDirectory(Path.GetDirectoryName(OutputPath)!);
File.WriteAllText(OutputPath, Sb.ToString());
Console.WriteLine($"\nOutput saved to {OutputPath}");
