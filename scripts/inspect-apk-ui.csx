using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

Console.WriteLine("=== LAYOUTS ===");
var Layouts = 0;
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/layout") && E.Name.EndsWith(".xml") && E.Length > 0)
    {
        Console.WriteLine($"  {E.FullName} ({E.Length} bytes)");
        Layouts++;
    }
}
Console.WriteLine($"Total layouts: {Layouts}");

Console.WriteLine("\n=== DRAWABLES ===");
var Drawables = 0;
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/drawable") && E.Length > 0)
    {
        Drawables++;
    }
}
Console.WriteLine($"Total drawables: {Drawables}");

Console.WriteLine("\n=== MENU ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/menu") && E.Length > 0)
        Console.WriteLine($"  {E.FullName}");
}

Console.WriteLine("\n=== VALUES ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/values/") && E.Length > 0)
        Console.WriteLine($"  {E.FullName} ({E.Length} bytes)");
}

Console.WriteLine("\n=== NAVIGATION ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/navigation") && E.Length > 0)
        Console.WriteLine($"  {E.FullName}");
}

Console.WriteLine("\n=== XML ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/xml") && E.Length > 0)
        Console.WriteLine($"  {E.FullName}");
}

Console.WriteLine("\n=== MIPMAP (app icons) ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/mipmap") && E.Length > 0)
        Console.WriteLine($"  {E.FullName}");
}

Console.WriteLine("\n=== RAW ===");
foreach (var E in Zip.Entries)
{
    if (E.FullName.StartsWith("res/raw") && E.Length > 0)
        Console.WriteLine($"  {E.FullName} ({E.Length} bytes)");
}

Zip.Dispose();
