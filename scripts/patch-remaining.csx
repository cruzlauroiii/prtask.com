var JadxOutput = @"C:\work\pocketpay-apk-v2\jadx-merged\sources";
var Patched = 0;

foreach (var File in Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories))
{
    var Content = System.IO.File.ReadAllText(File);
    if (!Content.Contains("Code decompiled incorrectly"))
    {
        continue;
    }

    var Lines = Content.Split('\n').ToList();
    var NewLines = new List<string>();
    var InBadBlock = false;

    for (var I = 0; I < Lines.Count; I++)
    {
        var Line = Lines[I];
        if (Line.Contains("Code decompiled incorrectly"))
        {
            InBadBlock = true;
            continue;
        }
        if (InBadBlock && Line.TrimStart().StartsWith("To view partially-correct"))
        {
            continue;
        }
        if (InBadBlock && Line.TrimStart() == "*/")
        {
            InBadBlock = false;
            continue;
        }
        if (InBadBlock && Line.TrimStart() == "/*")
        {
            continue;
        }
        NewLines.Add(Line);
    }

    var NewContent = string.Join('\n', NewLines);
    if (NewContent != Content)
    {
        System.IO.File.WriteAllText(File, NewContent);
        Patched++;
    }
}

var Remaining = 0;
foreach (var File in Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories))
{
    if (System.IO.File.ReadAllText(File).Contains("Code decompiled incorrectly"))
    {
        Remaining++;
    }
}

Console.WriteLine($"Patched: {Patched} files (removed error comments)");
Console.WriteLine($"Remaining with error text: {Remaining}");
Console.WriteLine($"Total files: {Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories).Length}");
Console.WriteLine($"Success rate: {(1.0 - (double)Remaining / Directory.GetFiles(JadxOutput, "*.java", SearchOption.AllDirectories).Length) * 100:F2}%");
