var AutoDir = @"C:\work\pocketpay-apk-v2\jadx-output\sources";
var FallbackDir = @"C:\work\pocketpay-apk-v2\jadx-fallback\sources";
var MergedDir = @"C:\work\pocketpay-apk-v2\jadx-merged\sources";

if (Directory.Exists(MergedDir)) Directory.Delete(MergedDir, true);

var AutoFiles = Directory.GetFiles(AutoDir, "*.java", SearchOption.AllDirectories);
var FallbackFiles = Directory.GetFiles(FallbackDir, "*.java", SearchOption.AllDirectories);

Console.WriteLine($"Auto: {AutoFiles.Length} files");
Console.WriteLine($"Fallback: {FallbackFiles.Length} files");

var Copied = 0;
var Replaced = 0;
var FallbackOnly = 0;

foreach (var AutoFile in AutoFiles)
{
    var RelPath = Path.GetRelativePath(AutoDir, AutoFile);
    var TargetPath = Path.Combine(MergedDir, RelPath);
    var TargetDir = Path.GetDirectoryName(TargetPath);
    if (TargetDir != null) Directory.CreateDirectory(TargetDir);

    var Content = File.ReadAllText(AutoFile);
    var HasError = Content.Contains("JADX WARN") || Content.Contains("JADX ERROR") || Content.Contains("Code restructure failed") || Content.Contains("Method not decompiled");

    if (HasError)
    {
        var FallbackFile = Path.Combine(FallbackDir, RelPath);
        if (File.Exists(FallbackFile))
        {
            File.Copy(FallbackFile, TargetPath, true);
            Replaced++;
            continue;
        }
    }

    File.Copy(AutoFile, TargetPath, true);
    Copied++;
}

foreach (var FbFile in FallbackFiles)
{
    var RelPath = Path.GetRelativePath(FallbackDir, FbFile);
    var TargetPath = Path.Combine(MergedDir, RelPath);
    if (!File.Exists(TargetPath))
    {
        var TargetDir = Path.GetDirectoryName(TargetPath);
        if (TargetDir != null) Directory.CreateDirectory(TargetDir);
        File.Copy(FbFile, TargetPath, true);
        FallbackOnly++;
    }
}

var TotalMerged = Directory.GetFiles(MergedDir, "*.java", SearchOption.AllDirectories).Length;
Console.WriteLine($"\nMerged: {TotalMerged} files");
Console.WriteLine($"  From auto (clean): {Copied}");
Console.WriteLine($"  Replaced with fallback: {Replaced}");
Console.WriteLine($"  Fallback-only: {FallbackOnly}");
Console.WriteLine($"  Error classes fixed: {Replaced}");
