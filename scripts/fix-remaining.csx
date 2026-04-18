var JadxOutput = @"C:\work\pocketpay-apk-v2\jadx-merged\sources";
var SimpleOutput = @"C:\tmp\jadx-simple\sources";

var StillBad = new List<string>();
foreach (var File in Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories))
{
    var Content = System.IO.File.ReadAllText(File);
    if (Content.Contains("Code decompiled incorrectly"))
    {
        var Relative = File.Replace(JadxOutput + "\\", "");
        StillBad.Add(Relative);
    }
}

Console.WriteLine($"Still bad: {StillBad.Count} files");

foreach (var Rel in StillBad.Take(10))
{
    Console.WriteLine($"  {Rel}");
    var SimpleFile = Path.Combine(SimpleOutput, Rel);
    var SimpleExists = System.IO.File.Exists(SimpleFile);
    if (!SimpleExists)
    {
        var BaseName = Path.GetFileNameWithoutExtension(Rel);
        var Dir = Path.GetDirectoryName(Rel) ?? "";
        var Candidates = Directory.Exists(Path.Combine(SimpleOutput, Dir))
            ? Directory.GetFiles(Path.Combine(SimpleOutput, Dir), BaseName + "*.java")
            : Array.Empty<string>();
        Console.WriteLine($"    Simple not found. Candidates in dir: {Candidates.Length}");
        foreach (var C in Candidates.Take(3))
        {
            Console.WriteLine($"      {Path.GetFileName(C)}");
        }
    }
    else
    {
        var SimpleContent = System.IO.File.ReadAllText(SimpleFile);
        Console.WriteLine($"    Simple exists, has error: {SimpleContent.Contains("Code decompiled incorrectly")}");
    }
}
