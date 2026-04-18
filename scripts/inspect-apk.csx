using System.IO.Compression;

var ApkPath = Args.Count > 0 ? Args[0] : @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

var Count = 0;
foreach (var Entry in Zip.Entries)
{
    if (Count >= 80) break;
    if (Entry.FullName.StartsWith("classes") ||
        Entry.FullName.StartsWith("lib/") ||
        Entry.FullName.StartsWith("assets/") ||
        Entry.FullName == "AndroidManifest.xml")
    {
        Console.WriteLine($"{Entry.FullName}  ({Entry.Length} bytes)");
        Count++;
    }
}

Console.WriteLine($"\nTotal entries: {Zip.Entries.Count}");
