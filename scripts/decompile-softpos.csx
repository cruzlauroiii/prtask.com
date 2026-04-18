#load "DexParser_NoNs.csx"

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var OutputPath = @"C:\work\prtask.com\docs\pocketpay-softpos-decompiled.md";

var AllClasses = new List<DexClassDef>();

using (var Zip = ZipFile.OpenRead(ApkPath))
{
    var DexEntries = Zip.Entries.Where(E => E.FullName.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).ToList();
    Console.WriteLine($"Found {DexEntries.Count} DEX files in APK");

    foreach (var Entry in DexEntries)
    {
        Console.WriteLine($"Parsing {Entry.FullName} ({Entry.Length:N0} bytes)...");
        using var Ms = new MemoryStream();
        using (var S = Entry.Open()) S.CopyTo(Ms);
        var DexData = Ms.ToArray();

        var Parser = new DexParser(DexData);
        if (Parser.Parse())
        {
            Console.WriteLine($"  {Parser.ClassDefs.Count} classes, {Parser.StringIdsSize} strings, {Parser.MethodIdsSize} methods");
            AllClasses.AddRange(Parser.ClassDefs);
        }
        else
        {
            Console.WriteLine($"  FAILED to parse {Entry.FullName}");
        }
    }
}

Console.WriteLine($"\nTotal classes across all DEX files: {AllClasses.Count}");

bool MatchesFilter(string FullName)
{
    var Lower = FullName.ToLowerInvariant();

    if (Lower.Contains("com.d.c.") || Lower.Contains("com/d/c/")) return true;
    if (Lower.Contains("contactlesskernel") || Lower.Contains("contactlessconfiguration")) return true;
    if (Lower.Contains("decryptstring") || Lower.Contains("decryptasset")) return true;
    if (Lower.Contains("softpos")) return true;
    if (Lower.Contains("emv")) return true;
    if (Lower.Contains("visa.vac") || Lower.Contains("visa/vac")) return true;
    if (Lower.Contains("acquir")) return true;
    if (Lower.Contains("gateway")) return true;
    if (Lower.Contains("toph")) return true;

    if (Lower.Contains("payment")) return true;
    if (Lower.Contains("terminal")) return true;
    if (Lower.Contains("kernel")) return true;
    if (Lower.Contains("transaction")) return true;

    if (Lower.Contains("nfc") && !Lower.Contains("nfcadapter$")) return true;

    if (Lower.Contains("cipher") || Lower.Contains("encrypt") || Lower.Contains("crypto"))
    {
        if (!Lower.StartsWith("javax.crypto.") && !Lower.StartsWith("org.bouncycastle.")) return true;
    }

    if (Lower.Contains("tap") && !Lower.Contains("adapter") && !Lower.Contains("getap")) return true;

    if (Lower.Contains("card") && !Lower.Contains("cardview") && !Lower.Contains("card_container")) return true;

    if (Lower.Contains("auth") && !Lower.Contains("authority") && !Lower.Contains("authorization")) return true;

    return false;
}

var Matched = AllClasses.Where(C => !C.IsSystem && MatchesFilter(C.FullName)).OrderBy(C => C.FullName).ToList();
Console.WriteLine($"Matched {Matched.Count} classes after filtering");

Directory.CreateDirectory(Path.GetDirectoryName(OutputPath));

var Sb = new StringBuilder();
Sb.AppendLine("# PocketPay SoftPOS Decompiled Classes");
Sb.AppendLine();
Sb.AppendLine($"Generated: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC");
Sb.AppendLine($"Source: {ApkPath}");
Sb.AppendLine($"Total classes in APK: {AllClasses.Count}");
Sb.AppendLine($"Matched classes: {Matched.Count}");
Sb.AppendLine();
Sb.AppendLine("## Table of Contents");
Sb.AppendLine();

foreach (var C in Matched)
{
    Sb.AppendLine($"- `{C.FullName}`");
}

Sb.AppendLine();

foreach (var C in Matched)
{
    Sb.AppendLine($"---");
    Sb.AppendLine();
    Sb.AppendLine($"## {C.FullName}");
    Sb.AppendLine();

    var Kind = C.IsInterface ? "interface" : C.IsEnum ? "enum" : C.IsAbstract ? "abstract class" : "class";
    var Mods = new List<string>();
    if (C.IsPublic) Mods.Add("public");
    if (C.IsStatic) Mods.Add("static");
    if (C.IsFinal) Mods.Add("sealed");
    Mods.Add(Kind);
    Mods.Add(C.ClassName);

    var Decl = string.Join(" ", Mods);
    if (!string.IsNullOrEmpty(C.SuperClass) && C.SuperClass != "object" && C.SuperClass != "java.lang.Object")
        Decl += $" : {C.SuperClass}";
    if (C.Interfaces.Count > 0)
        Decl += (C.SuperClass != "object" && C.SuperClass != "java.lang.Object" ? ", " : " : ") + string.Join(", ", C.Interfaces);

    Sb.AppendLine($"```csharp");
    Sb.AppendLine($"// Package: {C.Package}");
    Sb.AppendLine(Decl);
    Sb.AppendLine("{");

    foreach (var F in C.Fields)
    {
        var FMods = new List<string>();
        if (F.IsPublic) FMods.Add("public");
        else if (F.IsPrivate) FMods.Add("private");
        if (F.IsStatic) FMods.Add("static");
        if (F.IsFinal) FMods.Add("readonly");
        FMods.Add(F.TypeName);
        FMods.Add(F.Name + ";");
        Sb.AppendLine($"    {string.Join(" ", FMods)}");
    }

    if (C.Fields.Count > 0 && C.Methods.Count > 0) Sb.AppendLine();

    foreach (var M in C.Methods)
    {
        var MMods = new List<string>();
        if (M.IsPublic) MMods.Add("public");
        else if (M.IsPrivate) MMods.Add("private");
        if (M.IsStatic) MMods.Add("static");
        if (M.IsAbstract) MMods.Add("abstract");
        MMods.Add(M.Proto.ReturnType);
        var Params = string.Join(", ", M.Proto.ParamTypes.Select((T, I) => $"{T} p{I}"));
        MMods.Add($"{M.Name}({Params})");

        if (M.IsAbstract || !M.HasCode)
        {
            Sb.AppendLine($"    {string.Join(" ", MMods)};");
        }
        else
        {
            Sb.AppendLine($"    {string.Join(" ", MMods)}");
            Sb.AppendLine("    {");
            if (!string.IsNullOrWhiteSpace(M.DecompiledBody))
            {
                foreach (var Line in M.DecompiledBody.Split('\n', StringSplitOptions.RemoveEmptyEntries))
                {
                    Sb.AppendLine($"        {Line}");
                }
            }
            Sb.AppendLine("    }");
        }

        Sb.AppendLine();
    }

    Sb.AppendLine("}");
    Sb.AppendLine("```");
    Sb.AppendLine();
}

File.WriteAllText(OutputPath, Sb.ToString(), Encoding.UTF8);
Console.WriteLine($"\nOutput written to {OutputPath} ({new FileInfo(OutputPath).Length:N0} bytes)");
