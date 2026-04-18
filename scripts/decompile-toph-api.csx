#load "DexParser_NoNs.csx"

using System.Globalization;
using System.IO.Compression;
using System.Text;

var TargetStrings = new[]
{
    "provideTophAuthDeviceApi",
    "provideTophOrderApi",
    "provideTophTokenApi",
    "x-merchant-api-key",
    "com.psr.pulsar.integration_registry_key",
    "transactionUrl",
    "mobilecashier",
    "psr-it.com",
    "pulsar.psr",
    "merchant-api"
};

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var OutputPath = @"C:\work\prtask.com\docs\pocketpay-toph-api-decompiled.md";

var AllMatchedClasses = new Dictionary<string, (DexClassDef Cls, HashSet<string> MatchedStrings, string DexName)>();

using (var Zip = ZipFile.OpenRead(ApkPath))
{
    var DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();
    Console.WriteLine($"Found {DexEntries.Count} DEX files");

    foreach (var Entry in DexEntries)
    {
        Console.WriteLine($"\nProcessing {Entry.Name}...");
        byte[] DexData;
        using (var S = Entry.Open())
        using (var Ms = new MemoryStream())
        {
            S.CopyTo(Ms);
            DexData = Ms.ToArray();
        }

        var Parser = new DexParser(DexData);
        if (!Parser.Parse())
        {
            Console.WriteLine($"  Failed to parse {Entry.Name}");
            continue;
        }

        Console.WriteLine($"  Strings: {Parser.StringIdsSize}, Types: {Parser.TypeIdsSize}, Methods: {Parser.MethodIdsSize}, Classes: {Parser.ClassDefsSize}");

        var FoundStringIndices = new Dictionary<int, string>();
        for (var I = 0; I < Parser.Strings.Length; I++)
        {
            foreach (var Target in TargetStrings)
            {
                if (Parser.Strings[I].Contains(Target, StringComparison.OrdinalIgnoreCase))
                {
                    FoundStringIndices[I] = Parser.Strings[I];
                    Console.WriteLine($"  Found string [{I}]: \"{Parser.Strings[I]}\"");
                }
            }
        }

        if (FoundStringIndices.Count == 0)
        {
            Console.WriteLine($"  No target strings found in {Entry.Name}");
            continue;
        }

        foreach (var Cls in Parser.ClassDefs)
        {
            var MatchedInClass = new HashSet<string>();

            foreach (var M in Cls.Methods)
            {
                if (string.IsNullOrEmpty(M.DecompiledBody)) continue;
                foreach (var Kvp in FoundStringIndices)
                {
                    if (M.DecompiledBody.Contains(Kvp.Value, StringComparison.Ordinal))
                    {
                        MatchedInClass.Add(Kvp.Value);
                    }
                }

                foreach (var Target in TargetStrings)
                {
                    if (M.Name.Contains(Target, StringComparison.OrdinalIgnoreCase))
                    {
                        MatchedInClass.Add($"method:{M.Name}");
                    }
                }
            }

            foreach (var F in Cls.Fields)
            {
                foreach (var Target in TargetStrings)
                {
                    if (F.Name.Contains(Target, StringComparison.OrdinalIgnoreCase))
                    {
                        MatchedInClass.Add($"field:{F.Name}");
                    }
                }
            }

            if (MatchedInClass.Count > 0)
            {
                var Key = Cls.FullName;
                if (!AllMatchedClasses.ContainsKey(Key))
                {
                    AllMatchedClasses[Key] = (Cls, MatchedInClass, Entry.Name);
                }
                else
                {
                    foreach (var S in MatchedInClass)
                        AllMatchedClasses[Key].MatchedStrings.Add(S);
                }
            }
        }
    }
}

var ExtraClassNames = new HashSet<string>(StringComparer.Ordinal)
{
    "p83f5c3ad.p8a5da52e.p40de21f4",
    "p83f5c3ad.p8a5da52e.p7b8552a1",
    "p83f5c3ad.p8a5da52e.pd53f9bcf",
    "com.decryptstringmanager.DecryptString"
};
var ExtraClassPatterns = new[] { "TophAuth", "TophOrder", "TophToken", "TophApi", "TophService", "TophRepo" };

using (var Zip2 = ZipFile.OpenRead(ApkPath))
{
    var DexEntries2 = Zip2.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();
    foreach (var Entry in DexEntries2)
    {
        byte[] DexData;
        using (var S = Entry.Open())
        using (var Ms = new MemoryStream())
        {
            S.CopyTo(Ms);
            DexData = Ms.ToArray();
        }

        var Parser = new DexParser(DexData);
        if (!Parser.Parse()) continue;

        foreach (var Cls in Parser.ClassDefs)
        {
            if (ExtraClassNames.Contains(Cls.FullName) || ExtraClassNames.Contains(Cls.ClassName))
            {
                var Key = Cls.FullName;
                if (!AllMatchedClasses.ContainsKey(Key))
                {
                    AllMatchedClasses[Key] = (Cls, new HashSet<string> { $"class-name-match:{Cls.FullName}" }, Entry.Name);
                    Console.WriteLine($"  Found extra class: {Cls.FullName} in {Entry.Name}");
                }
            }

            foreach (var Pat in ExtraClassPatterns)
            {
                if (Cls.FullName.Contains(Pat, StringComparison.OrdinalIgnoreCase) ||
                    Cls.Methods.Any(M => M.Name.Contains(Pat, StringComparison.OrdinalIgnoreCase)))
                {
                    var Key = Cls.FullName;
                    if (!AllMatchedClasses.ContainsKey(Key))
                    {
                        AllMatchedClasses[Key] = (Cls, new HashSet<string> { $"pattern:{Pat}" }, Entry.Name);
                        Console.WriteLine($"  Found pattern '{Pat}' class: {Cls.FullName} in {Entry.Name}");
                    }
                    break;
                }
            }
        }
    }
}

Console.WriteLine($"\n=== Found {AllMatchedClasses.Count} classes referencing target strings ===");

var Sb = new StringBuilder();
Sb.AppendLine("# PocketPay ToPH (Tap on Phone) API - Decompiled Classes");
Sb.AppendLine();
Sb.AppendLine($"Generated: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC");
Sb.AppendLine($"Source: {ApkPath}");
Sb.AppendLine();
Sb.AppendLine("## Target Strings");
Sb.AppendLine();
foreach (var T in TargetStrings)
    Sb.AppendLine($"- `{T}`");
Sb.AppendLine();
Sb.AppendLine($"## Matched Classes ({AllMatchedClasses.Count})");
Sb.AppendLine();

foreach (var Kvp in AllMatchedClasses.OrderBy(K => K.Key))
{
    var Cls = Kvp.Value.Cls;
    var Matched = Kvp.Value.MatchedStrings;
    var DexName = Kvp.Value.DexName;

    Sb.AppendLine($"### `{Cls.FullName}`");
    Sb.AppendLine();
    Sb.AppendLine($"- DEX: `{DexName}`");
    Sb.AppendLine($"- Super: `{Cls.SuperClass}`");
    if (Cls.Interfaces.Count > 0)
        Sb.AppendLine($"- Implements: {string.Join(", ", Cls.Interfaces.Select(I => $"`{I}`"))}");
    Sb.AppendLine($"- Matched: {string.Join(", ", Matched.Select(S => $"`{S}`"))}");
    Sb.AppendLine();

    if (Cls.Fields.Count > 0)
    {
        Sb.AppendLine("#### Fields");
        Sb.AppendLine();
        Sb.AppendLine("```java");
        foreach (var F in Cls.Fields)
        {
            var Mods = new List<string>();
            if (F.IsPublic) Mods.Add("public");
            if (F.IsPrivate) Mods.Add("private");
            if (F.IsStatic) Mods.Add("static");
            if (F.IsFinal) Mods.Add("final");
            Sb.AppendLine($"{string.Join(" ", Mods)} {DexParser.MapJavaType(F.TypeName)} {F.Name};");
        }
        Sb.AppendLine("```");
        Sb.AppendLine();
    }

    if (Cls.Methods.Count > 0)
    {
        Sb.AppendLine("#### Methods");
        Sb.AppendLine();
        foreach (var M in Cls.Methods)
        {
            var Mods = new List<string>();
            if (M.IsPublic) Mods.Add("public");
            if (M.IsPrivate) Mods.Add("private");
            if (M.IsStatic) Mods.Add("static");
            if (M.IsAbstract) Mods.Add("abstract");
            var Params = string.Join(", ", M.Proto.ParamTypes.Select((P, I) => $"{DexParser.MapJavaType(P)} p{I}"));
            Sb.AppendLine($"**`{string.Join(" ", Mods)} {DexParser.MapJavaType(M.Proto.ReturnType)} {M.Name}({Params})`**");
            Sb.AppendLine();
            if (!string.IsNullOrEmpty(M.DecompiledBody))
            {
                Sb.AppendLine("```");
                Sb.AppendLine(M.DecompiledBody.TrimEnd());
                Sb.AppendLine("```");
                Sb.AppendLine();
            }
        }
    }

    Sb.AppendLine("---");
    Sb.AppendLine();
}

Directory.CreateDirectory(Path.GetDirectoryName(OutputPath)!);
File.WriteAllText(OutputPath, Sb.ToString());
Console.WriteLine($"\nOutput written to {OutputPath}");
Console.WriteLine($"Total size: {new FileInfo(OutputPath).Length:N0} bytes");
