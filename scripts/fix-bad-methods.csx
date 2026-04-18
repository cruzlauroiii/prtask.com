using System.Text.RegularExpressions;

var JadxOutput = @"C:\work\pocketpay-apk-v2\jadx-merged\sources";
var SimpleOutput = @"C:\tmp\jadx-simple\sources";
var FixedCount = 0;
var StillBad = 0;

if (!Directory.Exists(SimpleOutput))
{
    Console.WriteLine("Simple mode output not ready yet, waiting...");
    return;
}

foreach (var File in Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories))
{
    var Content = System.IO.File.ReadAllText(File);
    if (!Content.Contains("Code decompiled incorrectly"))
    {
        continue;
    }

    var Relative = File.Replace(JadxOutput + "\\", "");
    var SimpleFile = Path.Combine(SimpleOutput, Relative);

    if (System.IO.File.Exists(SimpleFile))
    {
        var SimpleContent = System.IO.File.ReadAllText(SimpleFile);
        if (!SimpleContent.Contains("Code decompiled incorrectly"))
        {
            System.IO.File.Copy(SimpleFile, File, true);
            FixedCount++;
            continue;
        }
    }
    StillBad++;
}

Console.WriteLine($"Fixed {FixedCount} files from simple mode output");
Console.WriteLine($"Still bad: {StillBad} files");
Console.WriteLine($"New success rate: {(1.0 - (double)StillBad / Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories).Length) * 100:F1}%");
