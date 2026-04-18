using System.Diagnostics;
using System.Text;

var JadxOutput = @"C:\work\pocketpay-apk-v2\jadx-merged\sources";
var ApkPath = @"C:\work\pocketpay-apk-v2\base.apk";
var JavaHome = @"C:\Program Files\Eclipse Adoptium\jdk-21.0.10.7-hotspot";
var CfrJar = @"C:\work\cfr.jar";
var VineflowerJar = @"C:\work\vineflower.jar";
var OutputDir = @"C:\work\pocketpay-apk-v2\jadx-fixed-merged";

var FailedFiles = new List<string>();
foreach (var File in Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories))
{
    var Content = System.IO.File.ReadAllText(File);
    if (Content.Contains("Code decompiled incorrectly"))
    {
        FailedFiles.Add(File);
    }
}

Console.WriteLine($"Found {FailedFiles.Count} files with decompilation errors");
Console.WriteLine($"Total files: {Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories).Length}");
Console.WriteLine($"Success rate: {(1.0 - (double)FailedFiles.Count / Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories).Length) * 100:F1}%");

var Fixed = 0;
foreach (var F in FailedFiles.Take(5))
{
    var Relative = F.Replace(JadxOutput + "\\", "").Replace("\\", "/");
    Console.WriteLine($"\nFailed: {Relative}");

    var Lines = System.IO.File.ReadAllLines(F);
    var BadMethods = Lines.Where(L => L.Contains("Code decompiled incorrectly")).Count();
    var TotalMethods = Lines.Where(L => L.TrimStart().StartsWith("public ") || L.TrimStart().StartsWith("private ") || L.TrimStart().StartsWith("protected ")).Count();
    Console.WriteLine($"  Bad methods: {BadMethods}, Total methods: ~{TotalMethods}");
}
